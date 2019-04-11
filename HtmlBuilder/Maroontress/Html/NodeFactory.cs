namespace Maroontress.Html
{
    using StyleChecker.Annotations;

    /// <summary>
    /// The factory of the <see cref="Node"/> and <see cref="Tag"/> objects.
    /// </summary>
    /// <remarks>
    /// See
    /// <a href="https://www.w3.org/TR/html52/fullindex.html#index-elements">
    /// HTML5 specifications</a>.
    /// </remarks>
    public interface NodeFactory
    {
        /* A */

        /// <summary>
        /// Gets <c>a</c> element representing hyperlink.
        /// </summary>
        Tag A { get; }

        /// <summary>
        /// Gets <c>abbr</c> element representing abbreviation.
        /// </summary>
        Tag Abbr { get; }

        /// <summary>
        /// Gets <c>address</c> element representing contact information.
        /// </summary>
        Tag Address { get; }

        /// <summary>
        /// Gets <c>area</c> element representing hyperlink or dead area on an
        /// image map.
        /// </summary>
        EmptyTag Area { get; }

        /// <summary>
        /// Gets <c>article</c> element representing self-contained
        /// syndicatable or reusable composition.
        /// </summary>
        Tag Article { get; }

        /// <summary>
        /// Gets <c>aside</c> element representing sidebar for tangentially
        /// related content.
        /// </summary>
        Tag Aside { get; }

        /// <summary>
        /// Gets <c>audio</c> element representing audio player.
        /// </summary>
        Tag Audio { get; }

        /* B */

        /// <summary>
        /// Gets <c>b</c> element representing keywords.
        /// </summary>
        Tag B { get; }

        /// <summary>
        /// Gets <c>base</c> element representing base URL and default target
        /// browsing context for hyperlinks and forms.
        /// </summary>
        EmptyTag Base { get; }

        /// <summary>
        /// Gets <c>bdi</c> element representing text directionality isolation.
        /// </summary>
        Tag Bdi { get; }

        /// <summary>
        /// Gets <c>bdo</c> element representing text directionality
        /// formatting.
        /// </summary>
        Tag Bdo { get; }

        /// <summary>
        /// Gets <c>blockquote</c> element representing a section quoted from
        /// another source.
        /// </summary>
        Tag Blockquote { get; }

        /// <summary>
        /// Gets <c>body</c> element representing document body.
        /// </summary>
        Tag Body { get; }

        /// <summary>
        /// Gets <c>br</c> element representing line break, e.g., in poem or
        /// postal address.
        /// </summary>
        EmptyTag Br { get; }

        /// <summary>
        /// Gets <c>button</c> element representing button control.
        /// </summary>
        Tag Button { get; }

        /* C */

        /// <summary>
        /// Gets <c>canvas</c> element representing scriptable bitmap canvas.
        /// </summary>
        Tag Canvas { get; }

        /// <summary>
        /// Gets <c>caption</c> element representing table caption.
        /// </summary>
        Tag Caption { get; }

        /// <summary>
        /// Gets <c>cite</c> element representing title of a work.
        /// </summary>
        Tag Cite { get; }

        /// <summary>
        /// Gets <c>code</c> element representing computer code.
        /// </summary>
        Tag Code { get; }

        /// <summary>
        /// Gets <c>col</c> element representing table column.
        /// </summary>
        EmptyTag Col { get; }

        /// <summary>
        /// Gets <c>colgroup</c> element representing group of columns in a
        /// table.
        /// </summary>
        Tag Colgroup { get; }

        /* D */

        /// <summary>
        /// Gets <c>data</c> element representing machine-readable equivalent.
        /// </summary>
        Tag Data { get; }

        /// <summary>
        /// Gets <c>datalist</c> element representing container for options for
        /// combo box control.
        /// </summary>
        Tag Datalist { get; }

        /// <summary>
        /// Gets <c>dd</c> element representing content for corresponding
        /// <c>dt</c> element(s).
        /// </summary>
        Tag Dd { get; }

        /// <summary>
        /// Gets <c>del</c> element representing a removal from the document.
        /// </summary>
        Tag Del { get; }

        /// <summary>
        /// Gets <c>details</c> element representing disclosure control for
        /// hiding details.
        /// </summary>
        Tag Details { get; }

        /// <summary>
        /// Gets <c>dfn</c> element representing defining instance.
        /// </summary>
        Tag Dfn { get; }

        /// <summary>
        /// Gets <c>dialog</c> element representing dialog box or window.
        /// </summary>
        Tag Dialog { get; }

        /// <summary>
        /// Gets <c>div</c> element representing generic flow container.
        /// </summary>
        Tag Div { get; }

        /// <summary>
        /// Gets <c>dl</c> element representing association list consisting of
        /// zero or more name-value groups.
        /// </summary>
        Tag Dl { get; }

        /// <summary>
        /// Gets <c>dt</c> element representing legend for corresponding
        /// <c>dd</c> element(s).
        /// </summary>
        Tag Dt { get; }

        /* E */

        /// <summary>
        /// Gets <c>em</c> element representing stress emphasis.
        /// </summary>
        Tag Em { get; }

        /// <summary>
        /// Gets <c>embed</c> element representing plugin.
        /// </summary>
        EmptyTag Embed { get; }

        /* F */

        /// <summary>
        /// Gets <c>fieldset</c> element representing group of form controls.
        /// </summary>
        Tag Fieldset { get; }

        /// <summary>
        /// Gets <c>figcaption</c> element representing caption for figure.
        /// </summary>
        Tag Figcaption { get; }

        /// <summary>
        /// Gets <c>figure</c> element representing figure with optional
        /// caption.
        /// </summary>
        Tag Figure { get; }

        /// <summary>
        /// Gets <c>footer</c> element representing footer for a page or
        /// section.
        /// </summary>
        Tag Footer { get; }

        /// <summary>
        /// Gets <c>form</c> element representing user-submittable form.
        /// </summary>
        Tag Form { get; }

        /* H */

        /// <summary>
        /// Gets <c>h1</c> element representing section heading.
        /// </summary>
        Tag H1 { get; }

        /// <summary>
        /// Gets <c>h2</c> element representing section heading.
        /// </summary>
        Tag H2 { get; }

        /// <summary>
        /// Gets <c>h3</c> element representing section heading.
        /// </summary>
        Tag H3 { get; }

        /// <summary>
        /// Gets <c>h4</c> element representing section heading.
        /// </summary>
        Tag H4 { get; }

        /// <summary>
        /// Gets <c>h5</c> element representing section heading.
        /// </summary>
        Tag H5 { get; }

        /// <summary>
        /// Gets <c>h6</c> element representing section heading.
        /// </summary>
        Tag H6 { get; }

        /// <summary>
        /// Gets <c>head</c> element representing container for document
        /// metadata.
        /// </summary>
        Tag Head { get; }

        /// <summary>
        /// Gets <c>header</c> element representing introductory or
        /// navigational aids for a page or section.
        /// </summary>
        Tag Header { get; }

        /// <summary>
        /// Gets <c>hr</c> element representing thematic break.
        /// </summary>
        EmptyTag Hr { get; }

        /// <summary>
        /// Gets <c>html</c> element representing root element.
        /// </summary>
        Tag Html { get; }

        /* I */

        /// <summary>
        /// Gets <c>i</c> element representing alternate voice.
        /// </summary>
        Tag I { get; }

        /// <summary>
        /// Gets <c>iframe</c> element representing nested browsing context.
        /// </summary>
        Tag Iframe { get; }

        /// <summary>
        /// Gets <c>img</c> element representing image.
        /// </summary>
        EmptyTag Img { get; }

        /// <summary>
        /// Gets <c>input</c> element representing form control.
        /// </summary>
        EmptyTag Input { get; }

        /// <summary>
        /// Gets <c>ins</c> element representing an addition to the document.
        /// </summary>
        Tag Ins { get; }

        /* K */

        /// <summary>
        /// Gets <c>kbd</c> element representing user input.
        /// </summary>
        Tag Kbd { get; }

        /* L */

        /// <summary>
        /// Gets <c>label</c> element representing caption for a form control.
        /// </summary>
        Tag Label { get; }

        /// <summary>
        /// Gets <c>legend</c> element representing caption for
        /// <c>fieldset</c>.
        /// </summary>
        Tag Legend { get; }

        /// <summary>
        /// Gets <c>li</c> element representing list item.
        /// </summary>
        Tag Li { get; }

        /// <summary>
        /// Gets <c>link</c> element representing link metadata.
        /// </summary>
        EmptyTag Link { get; }

        /* M */

        /// <summary>
        /// Gets <c>main</c> element representing main content of a document.
        /// </summary>
        Tag Main { get; }

        /// <summary>
        /// Gets <c>map</c> element representing image map.
        /// </summary>
        Tag Map { get; }

        /// <summary>
        /// Gets <c>mark</c> element representing highlight.
        /// </summary>
        Tag Mark { get; }

        /// <summary>
        /// Gets <c>meta</c> element representing text metadata.
        /// </summary>
        EmptyTag Meta { get; }

        /// <summary>
        /// Gets <c>meter</c> element representing gauge.
        /// </summary>
        Tag Meter { get; }

        /* N */

        /// <summary>
        /// Gets <c>nav</c> element representing section with navigational
        /// links.
        /// </summary>
        Tag Nav { get; }

        /// <summary>
        /// Gets <c>noscript</c> element representing fallback content for
        /// script.
        /// </summary>
        Tag Noscript { get; }

        /* O */

        /// <summary>
        /// Gets <c>object</c> element representing image, nested browsing
        /// context, or plugin.
        /// </summary>
        Tag Object { get; }

        /// <summary>
        /// Gets <c>ol</c> element representing ordered list.
        /// </summary>
        Tag Ol { get; }

        /// <summary>
        /// Gets <c>optgroup</c> element representing group of options in a
        /// list box.
        /// </summary>
        Tag Optgroup { get; }

        /// <summary>
        /// Gets <c>option</c> element representing option in a list box or
        /// combo box control.
        /// </summary>
        Tag Option { get; }

        /// <summary>
        /// Gets <c>output</c> element representing calculated output value.
        /// </summary>
        Tag Output { get; }

        /* P */

        /// <summary>
        /// Gets <c>p</c> element representing paragraph.
        /// </summary>
        Tag P { get; }

        /// <summary>
        /// Gets <c>param</c> element representing parameter for object.
        /// </summary>
        EmptyTag Param { get; }

        /// <summary>
        /// Gets <c>picture</c> element representing image.
        /// </summary>
        Tag Picture { get; }

        /// <summary>
        /// Gets <c>pre</c> element representing block of preformatted text.
        /// </summary>
        Tag Pre { get; }

        /// <summary>
        /// Gets <c>progress</c> element representing progress bar.
        /// </summary>
        Tag Progress { get; }

        /* Q */

        /// <summary>
        /// Gets <c>q</c> element representing quotation.
        /// </summary>
        Tag Q { get; }

        /* R */

        /// <summary>
        /// Gets <c>rb</c> element representing ruby base.
        /// </summary>
        Tag Rb { get; }

        /// <summary>
        /// Gets <c>rp</c> element representing parenthesis for ruby annotation
        /// text.
        /// </summary>
        Tag Rp { get; }

        /// <summary>
        /// Gets <c>rt</c> element representing ruby annotation text.
        /// </summary>
        Tag Rt { get; }

        /// <summary>
        /// Gets <c>rtc</c> element representing ruby annotation text
        /// container.
        /// </summary>
        Tag Rtc { get; }

        /// <summary>
        /// Gets <c>ruby</c> element representing ruby annotation(s).
        /// </summary>
        Tag Ruby { get; }

        /* S */

        /// <summary>
        /// Gets <c>s</c> element representing inaccurate text.
        /// </summary>
        Tag S { get; }

        /// <summary>
        /// Gets <c>samp</c> element representing computer output.
        /// </summary>
        Tag Samp { get; }

        /// <summary>
        /// Gets <c>script</c> element representing embedded script.
        /// </summary>
        Tag Script { get; }

        /// <summary>
        /// Gets <c>section</c> element representing generic document or
        /// application section.
        /// </summary>
        Tag Section { get; }

        /// <summary>
        /// Gets <c>select</c> element representing list box control.
        /// </summary>
        Tag Select { get; }

        /// <summary>
        /// Gets <c>small</c> element representing side comment.
        /// </summary>
        Tag Small { get; }

        /// <summary>
        /// Gets <c>source</c> element representing media source for video or
        /// audio or as image source for picture.
        /// </summary>
        EmptyTag Source { get; }

        /// <summary>
        /// Gets <c>span</c> element representing generic phrasing container.
        /// </summary>
        Tag Span { get; }

        /// <summary>
        /// Gets <c>strong</c> element representing importance.
        /// </summary>
        Tag Strong { get; }

        /// <summary>
        /// Gets <c>style</c> element representing embedded styling
        /// information.
        /// </summary>
        Tag Style { get; }

        /// <summary>
        /// Gets <c>sub</c> element representing subscript.
        /// </summary>
        Tag Sub { get; }

        /// <summary>
        /// Gets <c>summary</c> element representing caption for details.
        /// </summary>
        Tag Summary { get; }

        /// <summary>
        /// Gets <c>sup</c> element representing superscript.
        /// </summary>
        Tag Sup { get; }

        /* T */

        /// <summary>
        /// Gets <c>table</c> element representing table.
        /// </summary>
        Tag Table { get; }

        /// <summary>
        /// Gets <c>tbody</c> element representing group of rows in a table.
        /// </summary>
        Tag Tbody { get; }

        /// <summary>
        /// Gets <c>td</c> element representing table cell.
        /// </summary>
        Tag Td { get; }

        /// <summary>
        /// Gets <c>template</c> element representing template.
        /// </summary>
        Tag Template { get; }

        /// <summary>
        /// Gets <c>textarea</c> element representing multiline text field.
        /// </summary>
        Tag Textarea { get; }

        /// <summary>
        /// Gets <c>tfoot</c> element representing group of footer rows in a
        /// table.
        /// </summary>
        Tag Tfoot { get; }

        /// <summary>
        /// Gets <c>th</c> element representing table header cell.
        /// </summary>
        Tag Th { get; }

        /// <summary>
        /// Gets <c>thead</c> element representing group of heading rows in a
        /// table.
        /// </summary>
        Tag Thead { get; }

        /// <summary>
        /// Gets <c>time</c> element representing machine-readable equivalent
        /// of date- or time-related data.
        /// </summary>
        Tag Time { get; }

        /// <summary>
        /// Gets <c>title</c> element representing document title.
        /// </summary>
        Tag Title { get; }

        /// <summary>
        /// Gets <c>tr</c> element representing table row.
        /// </summary>
        Tag Tr { get; }

        /// <summary>
        /// Gets <c>track</c> element representing timed text track.
        /// </summary>
        EmptyTag Track { get; }

        /* U */

        /// <summary>
        /// Gets <c>u</c> element representing keywords.
        /// </summary>
        Tag U { get; }

        /// <summary>
        /// Gets <c>ul</c> element representing list.
        /// </summary>
        Tag Ul { get; }

        /* V */

        /// <summary>
        /// Gets <c>var</c> element representing variable.
        /// </summary>
        Tag Var { get; }

        /// <summary>
        /// Gets <c>video</c> element representing video player.
        /// </summary>
        Tag Video { get; }

        /* W */

        /// <summary>
        /// Gets <c>wbr</c> element representing line breaking opportunity.
        /// </summary>
        EmptyTag Wbr { get; }

        /* others */

        /// <summary>
        /// Gets an <c>Entity</c> object.
        /// </summary>
        /// <returns>
        /// The <c>Entity</c> object.
        /// </returns>
        Entity Entity { get; }

        /// <summary>
        /// Gets a new element that has the specified name.
        /// </summary>
        /// <param name="name">
        /// The name of the element.
        /// </param>
        /// <returns>
        /// The new element.
        /// </returns>
        [return: DoNotIgnore]
        Tag Tag(string name);

        /// <summary>
        /// Gets a new void element that has the specified name.
        /// </summary>
        /// <param name="name">
        /// The name of the element.
        /// </param>
        /// <returns>
        /// The new element.
        /// </returns>
        [return: DoNotIgnore]
        EmptyTag EmptyTag(string name);

        /// <summary>
        /// Gets a new text node containing the specified text.
        /// </summary>
        /// <param name="text">
        /// The text to be contained in the node.
        /// </param>
        /// <returns>
        /// The new text node.
        /// </returns>
        [return: DoNotIgnore]
        Node Text(string text);

        /// <summary>
        /// Gets a hexadecimal numeric character reference.
        /// </summary>
        /// <param name="codePoint">
        /// Unicode code point.
        /// </param>
        /// <returns>
        /// The node corresponding to the character reference in the form
        /// "<c>&amp;#x</c>", that is followed by one or more ASCII hex digits
        /// representing the specified code point, that is followed by
        /// "<c>;</c>".
        /// </returns>
        [return: DoNotIgnore]
        Node CharacterReference(int codePoint);
    }
}
