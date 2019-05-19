namespace Maroontress.Html
{
    /// <summary>
    /// The attribute data.
    /// </summary>
    public interface AttributeData
    {
        /// <summary>
        /// Gets the occurrence order. Zero means the first attribute of the
        /// element.
        /// </summary>
        int Order { get; }

        /// <summary>
        /// Gets the attribute's name.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Gets the attribute's value. If the value is <c>null</c>, this
        /// represents the empty attribute.
        /// </summary>
        string? Value { get; }
    }
}
