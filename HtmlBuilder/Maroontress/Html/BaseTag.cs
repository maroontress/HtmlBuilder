namespace Maroontress.Html
{
    using StyleChecker.Annotations;

    /// <summary>
    /// Represents basic features of an HTML element.
    /// </summary>
    /// <typeparam name="T">
    /// The type of an HTML element.
    /// </typeparam>
    public interface BaseTag<out T>
        where T : BaseTag<T>
    {
        /// <summary>
        /// Gets the name of this tag in lowercase letters.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Gets a new <see cref="BaseTag{T}"/> object with the <c>id</c>
        /// attribute that has the specified value.
        /// </summary>
        /// <param name="id">
        /// The value of the <c>id</c> attribute.
        /// </param>
        /// <returns>
        /// The new <see cref="BaseTag{T}"/> object.
        /// </returns>
        [return: DoNotIgnore]
        T WithId(string id);

        /// <summary>
        /// Gets a new <see cref="BaseTag{T}"/> object with the <c>class</c>
        /// attribute that has the specified values.
        /// </summary>
        /// <param name="values">
        /// The values of the <c>class</c> attribute.
        /// </param>
        /// <returns>
        /// The new <see cref="BaseTag{T}"/> object.
        /// </returns>
        [return: DoNotIgnore]
        T WithClass(params string[] values);

        /// <summary>
        /// Gets a new <see cref="BaseTag{T}"/> object with the <c>class</c>
        /// attribute that has both the values of this object and the specified
        /// values.
        /// </summary>
        /// <param name="values">
        /// The adding values of the <c>class</c> attribute.
        /// </param>
        /// <returns>
        /// The new <see cref="BaseTag{T}"/> object.
        /// </returns>
        [return: DoNotIgnore]
        T AddClass(params string[] values);

        /// <summary>
        /// Gets a new <see cref="BaseTag{T}"/> object with the specified
        /// attribute that has the specified value.
        /// </summary>
        /// <param name="attributes">
        /// Tuples of the name and value representing an attribute.
        /// </param>
        /// <returns>
        /// The new <see cref="BaseTag{T}"/> object.
        /// </returns>
        [return: DoNotIgnore]
        T AddAttributes(params (string name, string value)[] attributes);
    }
}
