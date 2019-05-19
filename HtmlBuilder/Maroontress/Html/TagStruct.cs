namespace Maroontress.Html
{
    using System.Collections.Immutable;

    /// <summary>
    /// The data that the <see cref="Tag"/> object contains.
    /// </summary>
    public struct TagStruct
    {
        /// <summary>
        /// Gets or sets the name of the tag.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the child nodes that the tag contains.
        /// </summary>
        public ImmutableList<Node> Children { get; set; }

        /// <summary>
        /// Gets or sets the attributes of the tag (except <c>class</c> and
        /// <c>id</c> attribute).
        /// </summary>
        public ImmutableDictionary<string, string> Attributes
        { get; set; }

        /// <summary>
        /// Gets or sets the values of the <c>class</c> attribute.
        /// </summary>
        public ImmutableList<string> Classes { get; set; }

        /// <summary>
        /// Gets or sets the value of the <c>id</c> attribute.
        /// </summary>
        public string? Id { get; set; }
    }
}
