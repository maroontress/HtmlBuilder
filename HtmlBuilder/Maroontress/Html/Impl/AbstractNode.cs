namespace Maroontress.Html.Impl
{
    using System.IO;

    /// <summary>
    /// Provides common implementation of the Node instances.
    /// </summary>
    public abstract class AbstractNode : Node
    {
        /// <inheritdoc/>
        public NodeKind Kind => GetKind();

        /// <inheritdoc/>
        public abstract void Accept(NodeVisitor visitor);

        /// <inheritdoc/>
        public override sealed string ToString()
        {
            var writer = new StringWriter();
            Accept(new DefaultTextWriterVisitor(writer));
            writer.Close();
            return writer.ToString();
        }

        /// <inheritdoc/>
        public string ToString(FormatOptions options)
        {
            var writer = new StringWriter();
            Accept(new IndentTextWriterVisitor(writer, options));
            writer.Close();
            return writer.ToString();
        }

        /// <summary>
        /// Gets the kind of this node.
        /// </summary>
        /// <returns>
        /// The kind of this node.
        /// </returns>
        protected abstract NodeKind GetKind();
    }
}
