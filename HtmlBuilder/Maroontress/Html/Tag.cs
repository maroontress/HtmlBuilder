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
    public interface Tag : Node, BaseTag<Tag>
    {
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
