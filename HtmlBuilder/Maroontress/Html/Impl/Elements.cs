/*
    https://www.w3.org/TR/html5/syntax.html#writing-html-documents-elements
*/
namespace Maroontress.Html.Impl;

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using Maroontress.Collection;

/// <summary>
/// Provides the utilities for the HTML elements.
/// </summary>
public static class Elements
{
    private static readonly IImmutableSet<char> ValidCharSet
        = NewValidCharSet();

    /// <summary>
    /// Gets a new <see cref="TagStruct"/> object that has the specified name.
    /// </summary>
    /// <param name="name">
    /// The tag name.
    /// </param>
    /// <returns>
    /// The new <see cref="TagStruct"/> object.
    /// </returns>
    public static TagStruct NewTagStruct(string name)
    {
        if (!IsValid(name))
        {
            throw new ArgumentException(
                $"'{name}' is invalid for the tag name.");
        }
        return new TagStruct
        {
            Name = string.Intern(name.ToLowerInvariant()),
            Children = ImmutableList<Node>.Empty,
            Attributes = ImmutableLinkedHashMap<string, string?>.Empty,
            Classes = ImmutableList<string>.Empty,
            Id = null,
        };
    }

    /// <summary>
    /// Gets the whether the spcified name is valid for HTML elements.
    /// </summary>
    /// <param name="name">
    /// The name of the tag.
    /// </param>
    /// <returns>
    /// <c>true</c> if the name is valid.
    /// </returns>
    private static bool IsValid(string name)
    {
        if (name.Length is 0)
        {
            return false;
        }
        var validSet = ValidCharSet;
        foreach (var c in name)
        {
            if (!validSet.Contains(c))
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
    private static IImmutableSet<char> NewValidCharSet()
    {
        var set = new HashSet<char>();
        void AddRange(char start, char end)
        {
            for (var c = start; c <= end; ++c)
            {
                set.Add(c);
            }
        }
        var all = new[]
        {
            ('a', 'z'),
            ('A', 'Z'),
            ('0', '9'),
        };
        foreach (var (s, e) in all)
        {
            AddRange(s, e);
        }
        return set.ToImmutableHashSet();
    }
}
