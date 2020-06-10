/*
    References:

    2.4.1. Common parser idioms, HTML 5.2:
    https://www.w3.org/TR/html52/infrastructure.html#common-parser-idioms

    2.4.7. Space-separated tokens, HTML 5.2:
    https://www.w3.org/TR/html52/infrastructure.html#space-separated-tokens

    3.2.5. Global attributes, HTML 5.2:
    https://www.w3.org/TR/html52/dom.html#global-attributes

    8.1.2.3. Attributes, HTML 5.2:
    https://www.w3.org/TR/html52/syntax.html#elements-attributes

    8.2.4.33. Attribute name state, HTML 5.2:
    https://www.w3.org/TR/html52/syntax.html#attribute-name-state
*/
namespace Maroontress.Html.Impl
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;

    /// <summary>
    /// Provides the utilities for the HTML attributes.
    /// </summary>
    public static class Attributes
    {
        private static readonly IImmutableSet<char> InvalidCharSet
            = NewInvalidCharSet();

        private static readonly IImmutableSet<string> SpecialNameSet
            = ImmutableHashSet.Create("id", "class");

        /// <summary>
        /// Represents the space characters.
        /// </summary>
        /// <remarks>
        /// Refer sections "2.4.1. Common parser idioms" of the
        /// <a href="https://www.w3.org/TR/html52/">HTML 5.2</a>.
        /// <blockquote>
        /// The space characters, for the purposes of this specification, are
        /// U+0020 SPACE, "tab" (U+0009), "LF" (U+000A), "FF" (U+000C), and
        /// "CR" (U+000D).
        /// </blockquote>
        /// </remarks>
        private static readonly IImmutableSet<char> SpaceCharSet
            = ImmutableHashSet.Create(' ', '\x09', '\x0a', '\x0c', '\x0d');

        /// <summary>
        /// Gets the function that returns the modified <c>TagStruct</c>
        /// object.
        /// </summary>
        /// <param name="values">
        /// The values of the <c>class</c> attribute to be added.
        /// </param>
        /// <returns>
        /// The function that takes the original <c>TagStruct</c> and returns
        /// the modified <c>TagStruct</c>.
        /// </returns>
        public static Func<TagStruct, TagStruct> GetAddingClassModifier(
            IEnumerable<string> values)
            => GetClassModifier(values, d =>
            {
                d.Classes = d.Classes.Concat(values)
                    .ToImmutableList();
                return d;
            });

        /// <summary>
        /// Gets the function that returns the modified <c>TagStruct</c>
        /// object.
        /// </summary>
        /// <param name="values">
        /// The values of the <c>class</c> attribute to be replaced.
        /// </param>
        /// <returns>
        /// The function that takes the original <c>TagStruct</c> and returns
        /// the modified <c>TagStruct</c>.
        /// </returns>
        public static Func<TagStruct, TagStruct> GetReplacingClassModifier(
            IEnumerable<string> values)
            => GetClassModifier(values, d =>
            {
                d.Classes = values.ToImmutableList();
                return d;
            });

        /// <summary>
        /// Gets the function that returns the modified <c>TagStruct</c>
        /// object.
        /// </summary>
        /// <param name="value">
        /// The value of the <c>id</c> attribute to be replaced.
        /// </param>
        /// <returns>
        /// The function that takes the original <c>TagStruct</c> and returns
        /// the modified <c>TagStruct</c>.
        /// </returns>
        public static Func<TagStruct, TagStruct> GetReplacingIdModifier(
            string value)
        {
            if (!IsNonEmptyAndContainsNoSpaces(value))
            {
                throw new ArgumentException(
                    $"'{value}' is not valid for the id attribute value");
            }
            return d =>
            {
                d.Id = value;
                return d;
            };
        }

        /// <summary>
        /// Gets the function that returns the modified <c>TagStruct</c>
        /// object.
        /// </summary>
        /// <param name="isDuplicated">
        /// The function that takes the attribute name and returns whether the
        /// name is duplicated.
        /// </param>
        /// <param name="attributes">
        /// The attributes to be added.
        /// </param>
        /// <returns>
        /// The function that takes the original <c>TagStruct</c> and returns
        /// the modified <c>TagStruct</c>.
        /// </returns>
        public static Func<TagStruct, TagStruct> GetAddingModifier(
            Func<string, bool> isDuplicated,
            IEnumerable<(string Name, string? Value)> attributes)
        {
            static string ToName(string s)
                => string.Intern(s.ToLowerInvariant());

            static KeyValuePair<string, string?>
                    ToPair((string Name, string? Value) p)
                => new KeyValuePair<string, string?>(ToName(p.Name), p.Value);

            var invalid = attributes.Select(a => a.Name)
                .FirstOrDefault(n => !IsValid(n));
            if (!(invalid is null))
            {
                throw new ArgumentException(
                    $"'{invalid}' is not valid for the attribute name");
            }
            var delta = attributes.Select(ToPair);
            var keys = delta.Select(p => p.Key);
            var specialName = keys.FirstOrDefault(SpecialNameSet.Contains);
            if (!(specialName is null))
            {
                throw new ArgumentException(
                    $"attribute name '{specialName}' is not allowed.");
            }
            var selfDuplicatedKey = keys.GroupBy(k => k)
                .Where(g => g.Count() > 1)
                .Select(g => g.Key)
                .FirstOrDefault();
            if (!(selfDuplicatedKey is null))
            {
                throw new ArgumentException(
                    $"attribute name '{selfDuplicatedKey}' is duplicated");
            }
            var duplicated = keys.FirstOrDefault(isDuplicated);
            if (!(duplicated is null))
            {
                throw new ArgumentException(
                    $"attribute name '{duplicated}' has already been added");
            }
            return d =>
            {
                d.Attributes = d.Attributes.AddRange(delta);
                return d;
            };
        }

        private static Func<TagStruct, TagStruct> GetClassModifier(
            IEnumerable<string> values, Func<TagStruct, TagStruct> function)
        {
            var invalid = values
                .FirstOrDefault(n => !IsNonEmptyAndContainsNoSpaces(n));
            if (!(invalid is null))
            {
                throw new ArgumentException(
                    $"'{invalid}' is not valid for the class attribute value");
            }
            return function;
        }

        /// <summary>
        /// Gets the whether the spcified name is valid for HTML attribute
        /// names.
        /// </summary>
        /// <param name="name">
        /// The name of the attribute.
        /// </param>
        /// <returns>
        /// <c>true</c> if the name is valid.
        /// </returns>
        private static bool IsValid(string name)
        {
            if (name.Length == 0)
            {
                return false;
            }
            var invalidSet = InvalidCharSet;
            foreach (var c in name)
            {
                if (invalidSet.Contains(c))
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Gets the whether the spcified value is not empty and contains
        /// no space characters.
        /// </summary>
        /// <param name="value">
        /// The value that must not be empty and contain space characters.
        /// </param>
        /// <returns>
        /// <c>true</c> if the value is valid.
        /// </returns>
        private static bool IsNonEmptyAndContainsNoSpaces(string value)
        {
            if (value.Length == 0)
            {
                return false;
            }
            var invalidSet = SpaceCharSet;
            foreach (var c in value)
            {
                if (invalidSet.Contains(c))
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Gets a new valid character set of the tag name.
        /// </summary>
        /// <returns>
        /// The new valid character set of the tag name.
        /// </returns>
        /// <remarks>
        /// Refer sections "8.1.2.3. Attributes" and "8.2.4.33. Attribute name
        /// state" of the <a href="https://www.w3.org/TR/html52/">HTML 5.2</a>.
        /// The former describes that the attribute name can consist of
        /// U+003C LESS-THAN SIGN (&lt;) as follows:
        /// <blockquote>
        /// Attribute names must consist of one or more characters other than
        /// the space characters, U+0000 NULL, U+0022 QUOTATION MARK ("),
        /// U+0027 APOSTROPHE ('), U+003E GREATER-THAN SIGN (&gt;), U+002F
        /// SOLIDUS (/), and U+003D EQUALS SIGN (=) characters, the control
        /// characters, and any characters that are not defined by Unicode.
        /// In the HTML syntax, attribute names, even those for foreign
        /// elements, may be written with any mix of lower- and uppercase
        /// letters that are an ASCII case-insensitive match for the
        /// attribute's name.
        /// </blockquote>
        /// However, the latter forbids it. So the former is just a bug.
        /// </remarks>
        private static IImmutableSet<char> NewInvalidCharSet()
        {
            var set = new HashSet<char>()
            {
                ' ',
                '"',
                '\'',
                '>',
                '<',
                '/',
                '=',
            };
            for (var c = '\0'; c < ' '; ++c)
            {
                set.Add(c);
            }
            return set.ToImmutableHashSet();
        }
    }
}
