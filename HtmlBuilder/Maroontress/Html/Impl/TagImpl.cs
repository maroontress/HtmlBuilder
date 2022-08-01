namespace Maroontress.Html.Impl;

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

/// <summary>
/// The default implementation of <see cref="Tag"/>s other than void elements.
/// </summary>
public sealed class TagImpl : BaseTagImpl<Tag>, Tag
{
    private readonly TagStruct data;

    /// <summary>
    /// Initializes a new instance of the <see cref="TagImpl"/> class.
    /// </summary>
    /// <param name="name">
    /// The name of this tag.
    /// </param>
    public TagImpl(string name)
    {
        data = Elements.NewTagStruct(name);
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="TagImpl"/> class.
    /// </summary>
    /// <param name="another">
    /// Another <see cref="TagImpl"/> object that has the original data.
    /// </param>
    /// <param name="modify">
    /// The function that takes the data and returns the modified data.
    /// </param>
    private TagImpl(TagImpl another, Func<TagStruct, TagStruct> modify)
    {
        data = modify(another.data);
    }

    /// <inheritdoc/>
    public override string Name => data.Name;

    /// <inheritdoc/>
    public Tag Add(IEnumerable<Node> children)
            => new TagImpl(this, d =>
        {
            d.Children = d.Children.Concat(children)
                .ToImmutableList();
            return d;
        });

    /// <inheritdoc/>
    public Tag Add(params Node[] children)
        => Add(children.AsEnumerable());

    /// <inheritdoc/>
    public Tag Add(string text)
        => Add(new TextImpl(text));

    /// <inheritdoc/>
    public override void Accept(NodeVisitor visitor)
        => visitor.VisitTag(in data);

    /// <inheritdoc/>
    protected override NodeKind GetKind() => NodeKind.Tag;

    /// <inheritdoc/>
    protected override Tag Create(Func<TagStruct, TagStruct> modify)
    {
        return new TagImpl(this, modify);
    }

    /// <inheritdoc/>
    protected override Tag CreateAddingAttributes(
        IEnumerable<(string Name, string? Value)> attributes)
    {
        return Create(Attributes.GetAddingModifier(
            data.Attributes.ContainsKey, attributes));
    }
}
