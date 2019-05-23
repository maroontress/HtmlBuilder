namespace Maroontress.Util
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;

    /// <summary>
    /// An <see cref="ImmutableDictionary{TKey, TValue}"/> and linked list
    /// implementation of the <see cref="IImmutableDictionary{TKey, TValue}"/>
    /// interface, with predictable iteration order.
    /// </summary>
    /// <remarks>
    /// <para>This implementation differs from <see
    /// cref="ImmutableDictionary{TKey, TValue}"/> in that it maintains a
    /// linked list running through all of its entries. This linked list
    /// defines the iteration ordering, which is normally the order in which
    /// keys were inserted into the dictionary (<i>insertion-order</i>).</para>
    ///
    /// <para>Note that insertion order is not affected if a key is
    /// <i>re-inserted</i> into the dictionary. (A key <c>k</c> is reinserted
    /// into a dictionary <c>m</c> if <c>m[k] = v</c> is invoked when
    /// <c>m.ContainsKey(k)</c> would return <c>true</c> immediately prior to
    /// the invocation.)</para>
    /// </remarks>
    /// <typeparam name="K">
    /// The type of keys maintained by this dictionary.
    /// </typeparam>
    /// <typeparam name="V">
    /// The type of mapped values.
    /// </typeparam>
    public sealed class ImmutableLinkedHashMap<K, V>
        : IImmutableDictionary<K, V>
        where K : IComparable<K>
    {
        /// <summary>
        /// Gets an empty <see cref="ImmutableLinkedHashMap{K, V}"/>.
        /// </summary>
        public static readonly ImmutableLinkedHashMap<K, V> Empty
            = new ImmutableLinkedHashMap<K, V>();

        private readonly IEnumerable<KeyValuePair<K, V>> list;
        private readonly ImmutableDictionary<K, V> map;

        private ImmutableLinkedHashMap()
        {
            list = Enumerable.Empty<KeyValuePair<K, V>>();
            map = ImmutableDictionary<K, V>.Empty;
        }

        private ImmutableLinkedHashMap(
            IEnumerable<KeyValuePair<K, V>> newList,
            ImmutableDictionary<K, V> newMap)
        {
            list = newList;
            map = newMap;
        }

        /// <inheritdoc/>
        public IEnumerable<K> Keys => list.Select(p => p.Key);

        /// <inheritdoc/>
        public IEnumerable<V> Values => list.Select(p => p.Value);

        /// <inheritdoc/>
        public int Count => map.Count;

        /// <inheritdoc/>
        public V this[K key] => map[key];

        /// <inheritdoc/>
        public IImmutableDictionary<K, V> Add(K key, V value)
        {
            var pair = new KeyValuePair<K, V>(key, value);
            var newList = list.Append(pair);
            var newMap = map.Add(key, value);
            return new ImmutableLinkedHashMap<K, V>(newList, newMap);
        }

        /// <inheritdoc/>
        public IImmutableDictionary<K, V> AddRange(
            IEnumerable<KeyValuePair<K, V>> pairs)
        {
            if (!pairs.Any())
            {
                return this;
            }
            var newList = list.Concat(pairs.ToImmutableArray());
            var newMap = map.AddRange(pairs);
            return new ImmutableLinkedHashMap<K, V>(newList, newMap);
        }

        /// <inheritdoc/>
        public IImmutableDictionary<K, V> Clear()
            => Empty;

        /// <inheritdoc/>
        public bool Contains(KeyValuePair<K, V> pair)
        {
            return map.TryGetValue(pair.Key, out var value)
                && Equals(value, pair.Value);
        }

        /// <inheritdoc/>
        public bool ContainsKey(K key) => map.ContainsKey(key);

        /// <inheritdoc/>
        public IEnumerator<KeyValuePair<K, V>> GetEnumerator()
            => list.GetEnumerator();

        /// <inheritdoc/>
        public IImmutableDictionary<K, V> Remove(K key)
        {
            if (!map.ContainsKey(key))
            {
                return this;
            }

            bool NotMatches(KeyValuePair<K, V> p)
                => !p.Key.Equals(key);

            var newMap = map.Remove(key);
            var newList = list.Where(NotMatches);
            return new ImmutableLinkedHashMap<K, V>(newList, newMap);
        }

        /// <inheritdoc/>
        public IImmutableDictionary<K, V> RemoveRange(IEnumerable<K> keys)
        {
            var all = map.Keys.Intersect(keys).ToImmutableHashSet();
            if (!all.Any())
            {
                return this;
            }

            bool NotMatches(KeyValuePair<K, V> p)
                => !all.Contains(p.Key);

            var newMap = map.RemoveRange(all);
            var newList = list.Where(NotMatches);
            return new ImmutableLinkedHashMap<K, V>(newList, newMap);
        }

        /// <inheritdoc/>
        public IImmutableDictionary<K, V> SetItem(K key, V value)
        {
            if (!map.TryGetValue(key, out var oldValue))
            {
                return Add(key, value);
            }
            if (Equals(oldValue, value))
            {
                return this;
            }

            var newPair = new KeyValuePair<K, V>(key, value);
            var newMap = map.SetItem(key, value);
            var newList = list.Select(p => p.Key.Equals(key) ? newPair : p);
            return new ImmutableLinkedHashMap<K, V>(newList, newMap);
        }

        /// <inheritdoc/>
        public IImmutableDictionary<K, V> SetItems(
            IEnumerable<KeyValuePair<K, V>> items)
        {
            var appendingList = new List<KeyValuePair<K, V>>();
            var replacingMap = new Dictionary<K, KeyValuePair<K, V>>();
            foreach (var i in items)
            {
                if (!map.TryGetValue(i.Key, out var oldValue))
                {
                    appendingList.Add(i);
                    continue;
                }
                if (Equals(oldValue, i.Value))
                {
                    continue;
                }
                replacingMap.Add(i.Key, i);
            }
            if (!replacingMap.Any())
            {
                return AddRange(appendingList);
            }

            var newMap = map.SetItems(
                replacingMap.Values.AsEnumerable());
            var newList = list.Select(
                p => replacingMap.TryGetValue(p.Key, out var newValue)
                    ? newValue : p);
            return new ImmutableLinkedHashMap<K, V>(newList, newMap)
                .AddRange(appendingList);
        }

        /// <inheritdoc/>
        public bool TryGetKey(K equalKey, out K actualKey)
            => map.TryGetKey(equalKey, out actualKey);

        /// <inheritdoc/>
        public bool TryGetValue(K key, out V value)
            => map.TryGetValue(key, out value);

        /// <inheritdoc/>
        IEnumerator IEnumerable.GetEnumerator()
            => GetEnumerator();
    }
}
