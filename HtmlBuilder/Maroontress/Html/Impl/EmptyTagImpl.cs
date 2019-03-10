namespace Maroontress.Html.Impl
{
    using System;
    using System.Collections.Generic;
    using StyleChecker.Annotations;

    /// <summary>
    /// The default implementation of empty <see cref="Tag"/>s.
    /// </summary>
    public sealed class EmptyTagImpl : AbstractNode, Tag
    {
        private readonly TagStruct data;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmptyTagImpl"/> class.
        /// </summary>
        /// <param name="name">
        /// The name of this tag.
        /// </param>
        public EmptyTagImpl(string name)
        {
            data = Elements.NewTagStruct(name);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmptyTagImpl"/> class.
        /// </summary>
        /// <param name="another">
        /// Another <see cref="TagImpl"/> object that has the original data.
        /// </param>
        /// <param name="modify">
        /// The function that takes the data and returns the modified data.
        /// </param>
        private EmptyTagImpl(
            EmptyTagImpl another, Func<TagStruct, TagStruct> modify)
        {
            data = modify(another.data);
        }

        /// <inheritdoc/>
        public string Name => data.Name;

        /// <inheritdoc/>
        public Tag Add([Unused] IEnumerable<Node> children)
            => throw new InvalidOperationException();

        /// <inheritdoc/>
        public Tag Add([Unused] params Node[] children)
            => throw new InvalidOperationException();

        /// <inheritdoc/>
        public Tag Add([Unused] string text)
            => throw new InvalidOperationException();

        /// <inheritdoc/>
        public Tag AddAttributes(
            params (string name, string value)[] attributes)
            => new EmptyTagImpl(
                this,
                Attributes.GetAddingModifier(
                    data.Attributes.ContainsKey, attributes));

        /// <inheritdoc/>
        public Tag AddClass(params string[] values)
            => new EmptyTagImpl(
                this, Attributes.GetAddingClassModifier(values));

        /// <inheritdoc/>
        public Tag WithClass(params string[] values)
            => new EmptyTagImpl(
                this, Attributes.GetReplacingClassModifier(values));

        /// <inheritdoc/>
        public Tag WithId(string id)
            => new EmptyTagImpl(this, Attributes.GetReplacingIdModifier(id));

        /// <inheritdoc/>
        public override void Accept(NodeVisitor visitor)
            => visitor.VisitEmptyTag(in data);
    }
}
