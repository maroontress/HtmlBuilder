namespace Maroontress.Html.Impl
{
    /// <summary>
    /// The default implementation of an <see cref="AttributeData"/>.
    /// </summary>
    public sealed class AttributeDataImpl : AttributeData
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AttributeDataImpl"/>
        /// class.
        /// </summary>
        /// <param name="order">
        /// The occurrence order.
        /// </param>
        /// <param name="attribute">
        /// The tuple containing the name and value of the attribute. If the
        /// value is <c>null</c>, this represents the empty attribute.
        /// </param>
        public AttributeDataImpl(
            int order, (string name, string? value) attribute)
        {
            Order = order;
            Name = attribute.name;
            Value = attribute.value;
        }

        /// <inheritdoc/>
        public int Order { get; }

        /// <inheritdoc/>
        public string Name { get; }

        /// <inheritdoc/>
        public string? Value { get; }
    }
}
