namespace Maroontress.Html
{
    using System.Collections.Generic;
    using StyleChecker.Annotations;

    /// <summary>
    /// Represents an HTML element.
    /// </summary>
    /// <remarks>
    /// This object is immutable.
    /// </remarks>
    public interface Tag : Node
    {
        /// <summary>
        /// Gets a new <see cref="Tag"/> object with the <c>id</c> attribute
        /// that has the specified value.
        /// </summary>
        /// <param name="id">
        /// The value of the <c>id</c> attribute.
        /// </param>
        /// <returns>
        /// The new <see cref="Tag"/> object.
        /// </returns>
        [return: DoNotIgnore]
        Tag WithId(string id);

        /// <summary>
        /// Gets a new <see cref="Tag"/> object with the <c>class</c> attribute
        /// that has the specified values.
        /// </summary>
        /// <param name="values">
        /// The values of the <c>class</c> attribute.
        /// </param>
        /// <returns>
        /// The new <see cref="Tag"/> object.
        /// </returns>
        [return: DoNotIgnore]
        Tag WithClass(params string[] values);

        /// <summary>
        /// Gets a new <see cref="Tag"/> object with the <c>class</c> attribute
        /// that has both the values of this object and the specified values.
        /// </summary>
        /// <param name="values">
        /// The adding values of the <c>class</c> attribute.
        /// </param>
        /// <returns>
        /// The new <see cref="Tag"/> object.
        /// </returns>
        [return: DoNotIgnore]
        Tag AddClass(params string[] values);

        /// <summary>
        /// Gets a new <see cref="Tag"/> object with the specified attribute
        /// that has the specified value.
        /// </summary>
        /// <param name="attributes">
        /// Tuples of the name and value representing an attribute.
        /// </param>
        /// <returns>
        /// The new <see cref="Tag"/> object.
        /// </returns>
        [return: DoNotIgnore]
        Tag AddAttributes(params (string name, string value)[] attributes);

        /// <summary>
        /// Gets a new <see cref="Tag"/> object with the child <see
        /// cref="Node"/>s that represent both the children of this object and
        /// the specified nodes.
        /// </summary>
        /// <remarks>
        /// The node that this method returns has the same attributes of this
        /// object.
        /// </remarks>
        /// <param name="children">
        /// The adding <see cref="Node"/>s as children.
        /// </param>
        /// <returns>
        /// The new <see cref="Tag"/> object.
        /// </returns>
        [return: DoNotIgnore]
        Tag Add(params Node[] children);

        /// <summary>
        /// Gets a new <see cref="Tag"/> object with the child <see
        /// cref="Node"/>s that represent both the children of this object and
        /// the specified nodes.
        /// </summary>
        /// <remarks>
        /// The node that this method returns has the same attributes of this
        /// object.
        /// </remarks>
        /// <param name="children">
        /// The adding <see cref="Node"/>s as children.
        /// </param>
        /// <returns>
        /// The new <see cref="Tag"/> object.
        /// </returns>
        [return: DoNotIgnore]
        Tag Add(IEnumerable<Node> children);

        /// <summary>
        /// Gets a new <see cref="Tag"/> object with the child <see
        /// cref="Node"/>s that represent both the children of this object and
        /// the new text node containing the specified string.
        /// </summary>
        /// <remarks>
        /// The node that this method returns has the same attributes of this
        /// object.
        /// </remarks>
        /// <param name="text">
        /// The text that the adding node contains.
        /// </param>
        /// <returns>
        /// The new <see cref="Tag"/> object.
        /// </returns>
        [return: DoNotIgnore]
        Tag Add(string text);
    }
}
