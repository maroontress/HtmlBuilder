namespace Maroontress.Html.Impl;

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Linq;

/// <summary>
/// The abstract visitor implementaion to write the HTML document into text.
/// </summary>
public abstract class AbstractTextWriterVisitor : NodeVisitor
{
    private const string Lt = "&lt;";
    private const string Gt = "&gt;";
    private const string Amp = "&amp;";
    private const string Quot = "&quot;";

    private static readonly ImmutableDictionary<char, string>
        TextEscapeMap = new Dictionary<char, string>()
        {
            ['<'] = Lt,
            ['>'] = Gt,
            ['&'] = Amp,
        }.ToImmutableDictionary();

    private static readonly ImmutableDictionary<char, string>
        AttributeEscapeMap = new Dictionary<char, string>(TextEscapeMap)
        {
            ['"'] = Quot,
        }.ToImmutableDictionary();

    private readonly TextWriter writer;

    /// <summary>
    /// Initializes a new instance of the <see
    /// cref="AbstractTextWriterVisitor"/> class.
    /// </summary>
    /// <param name="writer">
    /// The text writer object for this visitor to output.
    /// </param>
    public AbstractTextWriterVisitor(TextWriter writer)
    {
        this.writer = writer;
    }

    /// <inheritdoc/>
    public void VisitEmptyTag(in TagStruct tag)
    {
        BeforeEmptyOrText();
        WriteTag(tag);
    }

    /// <inheritdoc/>
    public void VisitEntity(string text)
    {
        BeforeEmptyOrText();
        Write("&");
        Write(text);
        Write(";");
    }

    /// <inheritdoc/>
    public void VisitTag(in TagStruct tag)
    {
        WriteStartTagHook(tag);
        foreach (var c in tag.Children)
        {
            c.Accept(this);
        }
        WriteEndTagHook(tag);
    }

    /// <inheritdoc/>
    public void VisitText(string text)
    {
        BeforeEmptyOrText();
        foreach (var c in text)
        {
            if (TextEscapeMap.TryGetValue(c, out var s))
            {
                Write(s);
                continue;
            }
            Write(c);
        }
    }

    /// <summary>
    /// Writes a start tag.
    /// </summary>
    /// <param name="tag">
    /// The tag.
    /// </param>
    protected void WriteStartTag(in TagStruct tag)
    {
        WriteTag(tag);
    }

    /// <summary>
    /// Writes an end tag.
    /// </summary>
    /// <param name="tag">
    /// The tag.
    /// </param>
    protected void WriteEndTag(in TagStruct tag)
    {
        Write("</");
        Write(tag.Name);
        Write(">");
    }

    /// <summary>
    /// The hook to write the start tag, which is invoked just before the tag
    /// starts. The method overriding this method must invoke <see
    /// cref="WriteStartTag(in TagStruct)"/> with the specified tag.
    /// </summary>
    /// <param name="tag">
    /// The tag.
    /// </param>
    protected abstract void WriteStartTagHook(in TagStruct tag);

    /// <summary>
    /// The hook to write the end tag, which is invoked just before the tag
    /// ends. The method overriding this method must invoke <see
    /// cref="WriteEndTag(in TagStruct)"/> with the specified tag.
    /// </summary>
    /// <param name="tag">
    /// The tag.
    /// </param>
    protected abstract void WriteEndTagHook(in TagStruct tag);

    /// <summary>
    /// The hook called before the empty tag or the text node.
    /// </summary>
    protected virtual void BeforeEmptyOrText()
    {
    }

    /// <summary>
    /// Writes characters into the text stream.
    /// </summary>
    /// <param name="text">
    /// A span.
    /// </param>
    protected void Write(ReadOnlySpan<char> text)
    {
        writer.Write(text);
    }

    /// <summary>
    /// Writes a string into the text stream.
    /// </summary>
    /// <param name="text">
    /// A string.
    /// </param>
    protected void Write(string text)
    {
        writer.Write(text);
    }

    private void Write(char c)
    {
        writer.Write(c);
    }

    private void WriteTag(in TagStruct tag)
    {
        Write("<");
        Write(tag.Name);
        if (tag.Id is not null)
        {
            Write(" id=\"");
            WriteAttribute(tag.Id);
            Write("\"");
        }
        if (tag.Classes.Any())
        {
            var all = tag.Classes;
            Write(" class=\"");
            WriteAttribute(all[0]);
            foreach (var c in all.Skip(1))
            {
                writer.Write(" ");
                WriteAttribute(c);
            }
            Write("\"");
        }

        void WriteAttributePair(KeyValuePair<string, string?> pair)
        {
            Write(" ");
            Write(pair.Key);

            var v = pair.Value;
            if (v is null)
            {
                return;
            }
            Write("=\"");
            WriteAttribute(v);
            Write("\"");
        }

        foreach (var pair in tag.Attributes)
        {
            WriteAttributePair(pair);
        }
        Write(">");
    }

    private void WriteAttribute(string text)
    {
        foreach (var c in text)
        {
            if (AttributeEscapeMap.TryGetValue(c, out var s))
            {
                writer.Write(s);
                continue;
            }
            writer.Write(c);
        }
    }
}
