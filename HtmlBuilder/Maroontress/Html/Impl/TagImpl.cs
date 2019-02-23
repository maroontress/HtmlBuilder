namespace Maroontress.Html.Impl
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;

    /// <summary>
    /// The default implementation of <see cref="Tag"/>s other than void
    /// elements.
    /// </summary>
    public sealed class TagImpl : AbstractNode, Tag
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
        public Tag AddAttributes(
            params (string name, string value)[] attributes)
            => new TagImpl(
                this,
                Attributes.GetAddingModifier(
                    data.Attributes.ContainsKey, attributes));

        /// <inheritdoc/>
        public Tag AddClass(params string[] values)
            => new TagImpl(this, Attributes.GetAddingClassModifier(values));

        /// <inheritdoc/>
        public Tag WithClass(params string[] values)
            => new TagImpl(this, Attributes.GetReplacingClassModifier(values));

        /// <inheritdoc/>
        public Tag WithId(string id)
            => new TagImpl(this, Attributes.GetReplacingIdModifier(id));

        /// <inheritdoc/>
        public override void Accept(NodeVisitor visitor)
            => visitor.VisitTag(in data);
    }
}
