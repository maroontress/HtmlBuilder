namespace Maroontress.Html.Impl
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The default implementation of empty <see cref="EmptyTag"/>s.
    /// </summary>
    public sealed class EmptyTagImpl : BaseTagImpl<EmptyTag>, EmptyTag
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
        public override string Name => data.Name;

        /// <inheritdoc/>
        public override void Accept(NodeVisitor visitor)
            => visitor.VisitEmptyTag(in data);

        /// <inheritdoc/>
        protected override NodeKind GetKind() => NodeKind.EmptyTag;

        /// <inheritdoc/>
        protected override EmptyTag Create(Func<TagStruct, TagStruct> modify)
        {
            return new EmptyTagImpl(this, modify);
        }

        /// <inheritdoc/>
        protected override EmptyTag CreateAddingAttributes(
            IEnumerable<(string name, string? value)> attributes)
        {
            return Create(Attributes.GetAddingModifier(
                data.Attributes.ContainsKey, attributes));
        }
    }
}
