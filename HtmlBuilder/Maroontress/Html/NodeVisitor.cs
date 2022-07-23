namespace Maroontress.Html;

/// <summary>
/// Provides operations to be performed on nodes of an HTML document
/// structure.
/// </summary>
/// <remarks>
/// This interface is a part of the visitor pattern.
/// </remarks>
/// <seealso cref="Node.Accept(NodeVisitor)"/>
public interface NodeVisitor
{
    /// <summary>
    /// Performs the operation on the <see cref="Tag"/>.
    /// </summary>
    /// <param name="tag">
    /// The <see cref="TagStruct"/> object that the tag object contains.
    /// </param>
    void VisitTag(in TagStruct tag);

    /// <summary>
    /// Performs the operation on the entity node.
    /// </summary>
    /// <param name="text">
    /// The string representing a character reference of the entity.
    /// </param>
    void VisitEntity(string text);

    /// <summary>
    /// Performs the operation on the empty <see cref="Tag"/>
    /// representing a void element.
    /// </summary>
    /// <param name="tag">
    /// The <see cref="TagStruct"/> object that the tag object contains.
    /// </param>
    void VisitEmptyTag(in TagStruct tag);

    /// <summary>
    /// Performs the operation on the text node.
    /// </summary>
    /// <param name="text">
    /// The string that the text node contains.
    /// </param>
    void VisitText(string text);
}
