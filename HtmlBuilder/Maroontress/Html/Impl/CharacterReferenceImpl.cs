namespace Maroontress.Html.Impl
{
    /// <summary>
    /// The default implementation of a character reference <see cref="Node"/>.
    /// </summary>
    public sealed class CharacterReferenceImpl : AbstractNode, Node
    {
        /// <summary>
        /// Initializes a new instance of the <see
        /// cref="CharacterReferenceImpl"/> class.
        /// </summary>
        /// <param name="text">
        /// The text representings the character reference of this node.
        /// </param>
        public CharacterReferenceImpl(string text)
        {
            Text = text;
        }

        /// <summary>
        /// Initializes a new instance of the <see
        /// cref="CharacterReferenceImpl"/> class.
        /// </summary>
        /// <param name="codePoint">
        /// The code point.
        /// </param>
        public CharacterReferenceImpl(int codePoint)
        {
            var hex = codePoint.ToString("X");
            Text = $"#x{hex}";
        }

        /// <summary>
        /// Gets the text representings the character reference of this node.
        /// </summary>
        private string Text { get; }

        /// <inheritdoc/>
        public override void Accept(NodeVisitor visitor)
            => visitor.VisitEntity(Text);

        /// <inheritdoc/>
        protected override NodeKind GetKind() => NodeKind.CharacterReference;
    }
}
