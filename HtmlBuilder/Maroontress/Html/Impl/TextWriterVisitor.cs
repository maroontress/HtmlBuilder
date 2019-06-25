namespace Maroontress.Html.Impl
{
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.IO;
    using System.Linq;

    /// <summary>
    /// The default visitor implementaion.
    /// </summary>
    public sealed class TextWriterVisitor : NodeVisitor
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
        /// Initializes a new instance of the <see cref="TextWriterVisitor"/>
        /// class.
        /// </summary>
        /// <param name="writer">
        /// The text writer object for this visitor to output.
        /// </param>
        public TextWriterVisitor(TextWriter writer)
        {
            this.writer = writer;
        }

        /// <inheritdoc/>
        public void VisitEmptyTag(in TagStruct tag)
        {
            Write("<");
            Write(tag.Name);
            if (!(tag.Id is null))
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

        /// <inheritdoc/>
        public void VisitEntity(string text)
        {
            Write("&");
            Write(text);
            Write(";");
        }

        /// <inheritdoc/>
        public void VisitTag(in TagStruct tag)
        {
            VisitEmptyTag(tag);
            foreach (var c in tag.Children)
            {
                c.Accept(this);
            }
            Write("</");
            Write(tag.Name);
            Write(">");
        }

        /// <inheritdoc/>
        public void VisitText(string text)
        {
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

        private void Write(string text)
        {
            writer.Write(text);
        }

        private void Write(char c)
        {
            writer.Write(c);
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
}
