#pragma warning disable SA1114 // Parameter list should follow declaration
#pragma warning disable SA1115 // Parameter should follow comma
#pragma warning disable SA1515 // Single-line comment should be preceded by blank line

namespace Maroontress.Html.Impl;

using System;
using System.Collections.Immutable;
using System.IO;
using System.Linq;

/// <summary>
/// The visitor implementaion to write the HTML document into text with
/// indentation.
/// </summary>
public sealed class IndentTextWriterVisitor : AbstractTextWriterVisitor
{
    /*
        <flow>
          (text|<phrase>...</phrase>|<empty/>)*
        </flow>
    */
    private static readonly ImmutableHashSet<string> ChildrenArePhrasingSet
        = ImmutableHashSet.Create(
            // children: phrasing
            "h1",
            "h2",
            "h3",
            "h4",
            "h5",
            "h6",
            "legend",
            "p",
            "pre",
            "rb",
            "rp",
            "rt",
            "rtc",
            "summary",

            // children: text
            "option",
            "textarea",
            "title");

    private static readonly ImmutableHashSet<string> ParentIsPhrasingSet
        = ImmutableHashSet.Create(
            "a",
            "abbr",
            "b",
            "bdi",
            "bdo",
            "button",
            "cite",
            "code",
            "data",
            "datalist",
            "del",
            "dfn",
            "em",
            "i",
            "ins",
            "kbd",
            "label",
            "mark",
            "meter",
            "output",
            "progress",
            "q",
            "ruby",
            "s",
            "samp",
            "small",
            "span",
            "strong",
            "sub",
            "sup",
            "time",
            "u",
            "var");

    private readonly int indentWidth;
    private readonly string newLine;
    private int indent;
    private string spaces;
    private int phraseNest;
    private bool needsLineFeed;

    /// <summary>
    /// Initializes a new instance of the <see cref="IndentTextWriterVisitor"/>
    /// class.
    /// </summary>
    /// <param name="writer">
    /// The text writer object for this visitor to output.
    /// </param>
    /// <param name="options">
    /// The format options.
    /// </param>
    public IndentTextWriterVisitor(TextWriter writer, FormatOptions options)
        : base(writer)
    {
        indentWidth = options.IndentWidth;
        newLine = options.NewLine;
        indent = 0;
        spaces = string.Empty;
        phraseNest = 0;
        needsLineFeed = false;
    }

    /// <inheritdoc/>
    protected override void WriteStartTagHook(in TagStruct tag)
    {
        var name = tag.Name;
        if (ParentIsPhrasingSet.Contains(name))
        {
            BeforeEmptyOrText();
            WriteStartTag(tag);
            return;
        }
        if (ChildrenArePhrasingSet.Contains(name))
        {
            if (phraseNest is 0)
            {
                WriteIndent();
            }
            ++phraseNest;
            WriteStartTag(tag);
            return;
        }
        if (phraseNest > 0)
        {
            WriteStartTag(tag);
            return;
        }
        WriteIndent();
        indent += indentWidth;
        WriteStartTag(tag);
        ForceLineFeed();
    }

    /// <inheritdoc/>
    protected override void WriteEndTagHook(in TagStruct tag)
    {
        var name = tag.Name;
        if (ParentIsPhrasingSet.Contains(name))
        {
            WriteEndTag(tag);
            return;
        }
        if (ChildrenArePhrasingSet.Contains(name))
        {
            WriteEndTag(tag);
            --phraseNest;
            if (phraseNest is 0)
            {
                ForceLineFeed();
            }
            return;
        }
        if (phraseNest > 0)
        {
            WriteEndTag(tag);
            return;
        }
        indent -= indentWidth;
        WriteIndent();
        WriteEndTag(tag);
        ForceLineFeed();
    }

    /// <inheritdoc/>
    protected override void BeforeEmptyOrText()
    {
        if (!needsLineFeed && phraseNest is 0)
        {
            WriteIndent();
        }
        needsLineFeed = true;
    }

    private static string NewSpaces(int length)
    {
        return string.Concat(Enumerable.Repeat(" ", length));
    }

    private void LineFeed()
    {
        if (!needsLineFeed)
        {
            return;
        }
        ForceLineFeed();
    }

    private void ForceLineFeed()
    {
        Write(newLine);
        needsLineFeed = false;
    }

    private void WriteIndent()
    {
        LineFeed();
        if (indent is 0)
        {
            return;
        }
        if (spaces.Length < indent)
        {
            spaces = NewSpaces(indent);
        }
        Write(spaces.AsSpan(0, indent));
    }
}
