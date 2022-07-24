namespace Maroontress.Html.Impl;

using System.IO;

/// <summary>
/// The default visitor implementaion to write the HTML document into
/// text.
/// </summary>
public sealed class DefaultTextWriterVisitor : AbstractTextWriterVisitor
{
    /// <summary>
    /// Initializes a new instance of the <see
    /// cref="DefaultTextWriterVisitor"/> class.
    /// </summary>
    /// <param name="writer">
    /// The text writer object for this visitor to output.
    /// </param>
    public DefaultTextWriterVisitor(TextWriter writer)
        : base(writer)
    {
    }

    /// <inheritdoc/>
    protected override void WriteStartTagHook(in TagStruct tag)
    {
        WriteStartTag(tag);
    }

    /// <inheritdoc/>
    protected override void WriteEndTagHook(in TagStruct tag)
    {
        WriteEndTag(tag);
    }
}
