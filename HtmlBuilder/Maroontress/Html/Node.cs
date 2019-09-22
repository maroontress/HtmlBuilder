namespace Maroontress.Html
{
    /// <summary>
    /// Represents the document node.
    /// </summary>
    /// <remarks>
    /// <para>This object is immutable.</para>
    /// <para>This interface is a part of the visitor pattern.</para>
    /// </remarks>
    public interface Node
    {
        /// <summary>
        /// Gets the kind of this node.
        /// </summary>
        NodeKind Kind { get; }

        /// <summary>
        /// Returns the object associated this node that is created with the
        /// specified visitor.
        /// </summary>
        /// <param name="visitor">
        /// The visitor.
        /// </param>
        /// <seealso cref="NodeVisitor"/>
        void Accept(NodeVisitor visitor);

        /// <summary>
        /// Returns the string representing the current object, formatting it
        /// with the spcified <see cref="FormatOptions"/>.
        /// </summary>
        /// <param name="options">
        /// The format options.
        /// </param>
        /// <returns>
        /// The string representing the current object.
        /// </returns>
        string ToString(FormatOptions options);
    }
}
