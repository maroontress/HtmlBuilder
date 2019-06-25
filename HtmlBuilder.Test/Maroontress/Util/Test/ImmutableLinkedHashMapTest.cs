namespace Maroontress.Util.Test
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public sealed class ImmutableLinkedHashMapTest
    {
        [TestMethod]
        public void Keys()
        {
            var map = FooBarBaz();
            var actual = map.Keys;
            CheckFooBarBaz(actual);
        }

        [TestMethod]
        public void Values()
        {
            var map = FooBarBaz();
            var actual = map.Values;
            Check123(actual);
        }

        [TestMethod]
        public void Count()
        {
            var map = FooBarBaz();
            Assert.AreEqual(3, map.Count);
        }

        [TestMethod]
        public void Indexer()
        {
            var map = FooBarBaz();
            Assert.AreEqual("2", map["bar"]);
        }

        [TestMethod]
        public void AddRange()
        {
            var pairs = new (string key, string value)[]
            {
                ("foo", "1"),
                ("bar", "2"),
                ("baz", "3"),
            };
            var map = ImmutableLinkedHashMap<string, string>.Empty
                .AddRange(pairs.Select(p => ToPair(p.key, p.value)));
            Assert.AreEqual("2", map["bar"]);
        }

        [TestMethod]
        public void AddRangeWithEmpty()
        {
            var empty = ImmutableLinkedHashMap<string, string>.Empty;
            var map = FooBarBaz();
            var addedMap = map.AddRange(empty.AsEnumerable());
            Assert.AreSame(map, addedMap);
        }

        [TestMethod]
        public void Clear()
        {
            var map = FooBarBaz();
            var expected = ImmutableLinkedHashMap<string, string>.Empty;
            Assert.AreSame(expected, map.Clear());
        }

        [TestMethod]
        public void Contains()
        {
            var map = FooBarBaz();
            Assert.IsTrue(map.Contains(ToPair("foo", "1")));
            Assert.IsTrue(map.Contains(ToPair("bar", "2")));
            Assert.IsTrue(map.Contains(ToPair("baz", "3")));

            Assert.IsFalse(map.Contains(ToPair("foo", "2")));
            Assert.IsFalse(map.Contains(ToPair("2", "bar")));
        }

        [TestMethod]
        public void ContainsKey()
        {
            var map = FooBarBaz();
            Assert.IsTrue(map.ContainsKey("foo"));
            Assert.IsTrue(map.ContainsKey("bar"));
            Assert.IsTrue(map.ContainsKey("baz"));

            Assert.IsFalse(map.ContainsKey("1"));
        }

        [TestMethod]
        public void GetEnumerator()
        {
            var actual = FooBarBaz().AsEnumerable();
            CheckFooBarBaz(actual.Select(p => p.Key));
            Check123(actual.Select(p => p.Value));
        }

        [TestMethod]
        public void Remove()
        {
            var map = FooBarBaz().Remove("bar");
            Assert.AreEqual(2, map.Count);
            Assert.IsTrue(map.Contains(ToPair("foo", "1")));
            Assert.IsFalse(map.Contains(ToPair("bar", "2")));
            Assert.IsTrue(map.Contains(ToPair("baz", "3")));
            var actual = map.AsEnumerable();
            Assert.IsTrue(Enumerable.SequenceEqual(
                actual.Select(p => p.Key),
                new[] { "foo", "baz" }));
            Assert.IsTrue(Enumerable.SequenceEqual(
                actual.Select(p => p.Value),
                new[] { "1", "3" }));
        }

        [TestMethod]
        public void RemoveNothing()
        {
            var map = FooBarBaz();
            var removedMap = map.Remove("2");
            Assert.AreSame(map, removedMap);
        }

        [TestMethod]
        public void RemoveRange()
        {
            var map = FooBarBaz().Add("qux", "4");
            var removedMap = map.RemoveRange(new[] { "bar", "baz" });
            Assert.AreEqual(2, removedMap.Count);
            Assert.IsTrue(removedMap.Contains(ToPair("foo", "1")));
            Assert.IsFalse(removedMap.Contains(ToPair("bar", "2")));
            Assert.IsFalse(removedMap.Contains(ToPair("baz", "3")));
            Assert.IsTrue(removedMap.Contains(ToPair("qux", "4")));
            var actual = removedMap.AsEnumerable();
            Assert.IsTrue(Enumerable.SequenceEqual(
                actual.Select(p => p.Key),
                new[] { "foo", "qux" }));
            Assert.IsTrue(Enumerable.SequenceEqual(
                actual.Select(p => p.Value),
                new[] { "1", "4" }));
        }

        [TestMethod]
        public void RemoveRangeNothing()
        {
            var map = FooBarBaz();
            var removedMap = map.RemoveRange(Array.Empty<string>());
            Assert.AreSame(map, removedMap);
        }

        [TestMethod]
        public void SetItemWithNew()
        {
            var map = FooBarBaz().SetItem("qux", "4");
            Assert.AreEqual(4, map.Count);
            Assert.IsTrue(map.Contains(ToPair("foo", "1")));
            Assert.IsTrue(map.Contains(ToPair("bar", "2")));
            Assert.IsTrue(map.Contains(ToPair("baz", "3")));
            Assert.IsTrue(map.Contains(ToPair("qux", "4")));
            var actual = map.AsEnumerable();
            Assert.IsTrue(Enumerable.SequenceEqual(
                actual.Select(p => p.Key),
                new[] { "foo", "bar", "baz", "qux" }));
            Assert.IsTrue(Enumerable.SequenceEqual(
                actual.Select(p => p.Value),
                new[] { "1", "2", "3", "4" }));
        }

        [TestMethod]
        public void SetItemWithOverwriting()
        {
            var map = FooBarBaz().SetItem("bar", "4");
            Assert.AreEqual(3, map.Count);
            Assert.IsTrue(map.Contains(ToPair("foo", "1")));
            Assert.IsTrue(map.Contains(ToPair("bar", "4")));
            Assert.IsTrue(map.Contains(ToPair("baz", "3")));
            var actual = map.AsEnumerable();
            Assert.IsTrue(Enumerable.SequenceEqual(
                actual.Select(p => p.Key),
                new[] { "foo", "bar", "baz" }));
            Assert.IsTrue(Enumerable.SequenceEqual(
                actual.Select(p => p.Value),
                new[] { "1", "4", "3" }));
        }

        [TestMethod]
        public void SetItemWithContaining()
        {
            var map = FooBarBaz();
            var setMap = map.SetItem("bar", "2");
            Assert.AreSame(map, setMap);
        }

        [TestMethod]
        public void SetItemsWithAllNew()
        {
            var pairs = new (string key, string value)[]
            {
                ("qux", "4"),
                ("quux", "5"),
            };
            var map = FooBarBaz().SetItems(
                pairs.Select(p => ToPair(p.key, p.value)));

            Assert.AreEqual(5, map.Count);
            Assert.IsTrue(map.Contains(ToPair("foo", "1")));
            Assert.IsTrue(map.Contains(ToPair("bar", "2")));
            Assert.IsTrue(map.Contains(ToPair("baz", "3")));
            Assert.IsTrue(map.Contains(ToPair("qux", "4")));
            Assert.IsTrue(map.Contains(ToPair("quux", "5")));
            var actual = map.AsEnumerable();
            Assert.IsTrue(Enumerable.SequenceEqual(
                actual.Select(p => p.Key),
                new[] { "foo", "bar", "baz", "qux", "quux" }));
            Assert.IsTrue(Enumerable.SequenceEqual(
                actual.Select(p => p.Value),
                new[] { "1", "2", "3", "4", "5" }));
        }

        [TestMethod]
        public void SetItems()
        {
            var pairs = new (string key, string value)[]
            {
                ("qux", "4"),
                ("bar", "2"),
                ("foo", "5"),
            };
            var map = FooBarBaz().SetItems(
                pairs.Select(p => ToPair(p.key, p.value)));

            Assert.AreEqual(4, map.Count);
            Assert.IsTrue(map.Contains(ToPair("foo", "5")));
            Assert.IsTrue(map.Contains(ToPair("bar", "2")));
            Assert.IsTrue(map.Contains(ToPair("baz", "3")));
            Assert.IsTrue(map.Contains(ToPair("qux", "4")));
            var actual = map.AsEnumerable();
            Assert.IsTrue(Enumerable.SequenceEqual(
                actual.Select(p => p.Key),
                new[] { "foo", "bar", "baz", "qux" }));
            Assert.IsTrue(Enumerable.SequenceEqual(
                actual.Select(p => p.Value),
                new[] { "5", "2", "3", "4" }));
        }

        [TestMethod]
        public void TryGetKey()
        {
            var map = FooBarBaz();
            Assert.IsTrue(map.TryGetKey("foo", out var fooKey));
            Assert.AreEqual("foo", fooKey);
            Assert.IsFalse(map.TryGetKey("1", out _));
        }

        [TestMethod]
        public void TryGetValue()
        {
            var map = FooBarBaz();
            Assert.IsTrue(map.TryGetValue("foo", out var fooValue));
            Assert.AreEqual("1", fooValue);
            Assert.IsFalse(map.TryGetValue("1", out _));
        }

        [TestMethod]
        public void IEnumeratorGetEnumerator()
        {
            var map = FooBarBaz();
            IEnumerable all = map;
            var e = all.GetEnumerator();
            var pairs = new List<KeyValuePair<string, string>>();
            while (e.MoveNext())
            {
                pairs.Add((KeyValuePair<string, string>)e.Current);
            }
            Assert.AreEqual(3, pairs.Count);
            CheckFooBarBaz(pairs.Select(p => p.Key));
            Check123(pairs.Select(p => p.Value));
        }

        private KeyValuePair<string, string> ToPair(string key, string value)
        {
            return new KeyValuePair<string, string>(key, value);
        }

        private IImmutableDictionary<string, string> FooBarBaz()
        {
            return ImmutableLinkedHashMap<string, string>.Empty
                .Add("foo", "1")
                .Add("bar", "2")
                .Add("baz", "3");
        }

        private void CheckFooBarBaz(IEnumerable<string> actual)
        {
            var expected = new[] { "foo", "bar", "baz" };
            Assert.IsTrue(Enumerable.SequenceEqual(expected, actual));
        }

        private void Check123(IEnumerable<string> actual)
        {
            var expected = new[] { "1", "2", "3" };
            Assert.IsTrue(Enumerable.SequenceEqual(expected, actual));
        }
    }
}
