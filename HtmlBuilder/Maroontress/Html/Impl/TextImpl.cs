namespace Maroontress.Html.Impl;

/// <summary>
/// The default implementation of a text <see cref="Node"/>.
/// </summary>
public sealed class TextImpl : AbstractNode, Node
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TextImpl"/> class.
    /// </summary>
    /// <param name="text">
    /// The text of this node.
    /// </param>
    public TextImpl(string text)
    {
        Text = text;
    }

    /// <summary>
    /// Gets the text of this node.
    /// </summary>
    private string Text { get; }

    /// <inheritdoc/>
    public override void Accept(NodeVisitor visitor)
        => visitor.VisitText(Text);

    /// <inheritdoc/>
    protected override NodeKind GetKind() => NodeKind.Text;
}
