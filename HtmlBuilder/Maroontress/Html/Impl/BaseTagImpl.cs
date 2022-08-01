namespace Maroontress.Html.Impl;

using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Abstraction of Tag and EmptyTag.
/// </summary>
/// <typeparam name="T">
/// The type of an HTML element.
/// </typeparam>
public abstract class BaseTagImpl<T> : AbstractNode, BaseTag<T>
    where T : BaseTag<T>
{
    /// <inheritdoc/>
    public abstract string Name { get; }

    /// <inheritdoc/>
    public T AddAttributes(
        params (string Name, string? Value)[] attributes)
        => CreateAddingAttributes(attributes);

    /// <inheritdoc/>
    public T AddClass(params string[] values)
        => Create(Attributes.GetAddingClassModifier(values));

    /// <inheritdoc/>
    public T AddEmptyAttributes(params string[] attributeNames)
    {
        static (string Name, string? Value) ToTuples(string name)
            => (name, null);

        return CreateAddingAttributes(attributeNames.Select(ToTuples));
    }

    /// <inheritdoc/>
    public T WithClass(params string[] values)
        => Create(Attributes.GetReplacingClassModifier(values));

    /// <inheritdoc/>
    public T WithId(string id)
        => Create(Attributes.GetReplacingIdModifier(id));

    /// <summary>
    /// Gets a new element with the modifying function.
    /// </summary>
    /// <param name="modify">
    /// The function that takes the data and returns the modified data.
    /// </param>
    /// <returns>
    /// A new element.
    /// </returns>
    protected abstract T Create(Func<TagStruct, TagStruct> modify);

    /// <summary>
    /// Gets a new element with adding the specified attributes.
    /// </summary>
    /// <param name="attributes">
    /// Tuples of the name and value representing an attribute. If the value of
    /// the tuple is <c>null</c>, it represents the empty attribute.
    /// </param>
    /// <returns>
    /// A new element.
    /// </returns>
    protected abstract T CreateAddingAttributes(
        IEnumerable<(string Name, string? Value)> attributes);
}
