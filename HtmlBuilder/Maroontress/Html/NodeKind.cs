namespace Maroontress.Html
{
    /// <summary>
    /// Provides constants representing the kind of Node.
    /// </summary>
    public enum NodeKind
    {
        /// <summary>
        /// Represents a text node.
        /// </summary>
        Text,

        /// <summary>
        /// Represents an empty tag that cannot have child nodes.
        /// </summary>
        EmptyTag,

        /// <summary>
        /// Represents a tag that can have child nodes.
        /// </summary>
        Tag,
    }
}
