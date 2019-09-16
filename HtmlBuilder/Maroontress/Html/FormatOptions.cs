namespace Maroontress.Html
{
    using System;

    /// <summary>
    /// Provides the text format options.
    /// </summary>
    public sealed class FormatOptions
    {
        /// <summary>
        /// Represents the default indentation, where the indent width is two
        /// and the new line is platform-dependent.
        /// </summary>
        public static readonly FormatOptions DefaultIndent
            = new FormatOptions();

        /// <summary>
        /// Initializes a new instance of the <see cref="FormatOptions"/>
        /// class.
        /// </summary>
        /// <param name="indentWidth">
        /// The indent width, which must be greater than or equal to 0, and
        /// must not be greater than 8.
        /// </param>
        /// <param name="newLine">
        /// The string representing a new line. <c>null</c> means <see
        /// cref="Environment.NewLine"/>.
        /// </param>
        public FormatOptions(int indentWidth = 2, string? newLine = null)
        {
            if (indentWidth < 0
                || indentWidth > 8)
            {
                throw new ArgumentException(
                    $"{nameof(indentWidth)} is out of range.");
            }
            IndentWidth = indentWidth;
            NewLine = newLine ?? Environment.NewLine;
        }

        /// <summary>
        /// Gets the indent width.
        /// </summary>
        public int IndentWidth { get; }

        /// <summary>
        /// Gets the string representing a new line.
        /// </summary>
        public string NewLine { get; }
    }
}
