namespace Maroontress.Html;

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
    /// Gets a new <see cref="BaseTag{T}"/> object with the <c>id</c> attribute
    /// that has the specified value.
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
    /// Gets a new <see cref="BaseTag{T}"/> object with the specified attribute
    /// that has the specified value.
    /// </summary>
    /// <param name="attributes">
    /// Tuples of the name and value representing an attribute. If the value of
    /// the tuple is <c>null</c>, it represents the empty attribute.
    /// </param>
    /// <returns>
    /// The new <see cref="BaseTag{T}"/> object.
    /// </returns>
    [return: DoNotIgnore]
    T AddAttributes(params (string Name, string? Value)[] attributes);

    /// <summary>
    /// Gets a new <see cref="BaseTag{T}"/> object with the specified empty
    /// attribute.
    /// </summary>
    /// <param name="attributeNames">
    /// The name of the empty attribute.
    /// </param>
    /// <returns>
    /// The new <see cref="BaseTag{T}"/> object.
    /// </returns>
    /// <remarks>
    /// <para>An invocation of this method of the form
    /// <c>tag.AddEmptyAttributes(n1, n2)</c> behaves in exactly the same way
    /// as the invocation <c>tag.AddAttributes((n1, null), (n2,
    /// null))</c>.</para>
    ///
    /// <para>The web browser interprets the value of the empty attribute as
    /// the empty string implicitly. So, for example, <c>&lt;input
    /// disabled&gt;</c> is equivalent to <c>&lt;input disabled=""&gt;</c>. The
    /// former can be generated with <c>AddEmptyAttributes("disabled")</c> or
    /// <c>AddAttributes(("disabled", null))</c>, and the latter with
    /// <c>AddAttributes(("disabled", ""))</c>.</para>
    /// </remarks>
    [return: DoNotIgnore]
    T AddEmptyAttributes(params string[] attributeNames);
}
