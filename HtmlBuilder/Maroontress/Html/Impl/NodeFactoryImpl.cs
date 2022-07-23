namespace Maroontress.Html.Impl;

using Maroontress.Html;

/// <summary>
/// The default implementation of <see cref="NodeFactory"/>.
/// </summary>
public sealed class NodeFactoryImpl : NodeFactory
{
    /// <inheritdoc/>
    public Tag A { get; } = new TagImpl(nameof(A));

    /// <inheritdoc/>
    public Tag Abbr { get; } = new TagImpl(nameof(Abbr));

    /// <inheritdoc/>
    public Tag Address { get; } = new TagImpl(nameof(Address));

    /// <inheritdoc/>
    public EmptyTag Area { get; } = new EmptyTagImpl(nameof(Area));

    /// <inheritdoc/>
    public Tag Article { get; } = new TagImpl(nameof(Article));

    /// <inheritdoc/>
    public Tag Aside { get; } = new TagImpl(nameof(Aside));

    /// <inheritdoc/>
    public Tag Audio { get; } = new TagImpl(nameof(Audio));

    /// <inheritdoc/>
    public Tag B { get; } = new TagImpl(nameof(B));

    /// <inheritdoc/>
    public EmptyTag Base { get; } = new EmptyTagImpl(nameof(Base));

    /// <inheritdoc/>
    public Tag Bdi { get; } = new TagImpl(nameof(Bdi));

    /// <inheritdoc/>
    public Tag Bdo { get; } = new TagImpl(nameof(Bdo));

    /// <inheritdoc/>
    public Tag Blockquote { get; } = new TagImpl(nameof(Blockquote));

    /// <inheritdoc/>
    public Tag Body { get; } = new TagImpl(nameof(Body));

    /// <inheritdoc/>
    public EmptyTag Br { get; } = new EmptyTagImpl(nameof(Br));

    /// <inheritdoc/>
    public Tag Button { get; } = new TagImpl(nameof(Button));

    /// <inheritdoc/>
    public Tag Canvas { get; } = new TagImpl(nameof(Canvas));

    /// <inheritdoc/>
    public Tag Caption { get; } = new TagImpl(nameof(Caption));

    /// <inheritdoc/>
    public Tag Cite { get; } = new TagImpl(nameof(Cite));

    /// <inheritdoc/>
    public Tag Code { get; } = new TagImpl(nameof(Code));

    /// <inheritdoc/>
    public EmptyTag Col { get; } = new EmptyTagImpl(nameof(Col));

    /// <inheritdoc/>
    public Tag Colgroup { get; } = new TagImpl(nameof(Colgroup));

    /// <inheritdoc/>
    public Tag Data { get; } = new TagImpl(nameof(Data));

    /// <inheritdoc/>
    public Tag Datalist { get; } = new TagImpl(nameof(Datalist));

    /// <inheritdoc/>
    public Tag Dd { get; } = new TagImpl(nameof(Dd));

    /// <inheritdoc/>
    public Tag Del { get; } = new TagImpl(nameof(Del));

    /// <inheritdoc/>
    public Tag Details { get; } = new TagImpl(nameof(Details));

    /// <inheritdoc/>
    public Tag Dfn { get; } = new TagImpl(nameof(Dfn));

    /// <inheritdoc/>
    public Tag Dialog { get; } = new TagImpl(nameof(Dialog));

    /// <inheritdoc/>
    public Tag Div { get; } = new TagImpl(nameof(Div));

    /// <inheritdoc/>
    public Tag Dl { get; } = new TagImpl(nameof(Dl));

    /// <inheritdoc/>
    public Tag Dt { get; } = new TagImpl(nameof(Dt));

    /// <inheritdoc/>
    public Tag Em { get; } = new TagImpl(nameof(Em));

    /// <inheritdoc/>
    public EmptyTag Embed { get; } = new EmptyTagImpl(nameof(Embed));

    /// <inheritdoc/>
    public Tag Fieldset { get; } = new TagImpl(nameof(Fieldset));

    /// <inheritdoc/>
    public Tag Figcaption { get; } = new TagImpl(nameof(Figcaption));

    /// <inheritdoc/>
    public Tag Figure { get; } = new TagImpl(nameof(Figure));

    /// <inheritdoc/>
    public Tag Footer { get; } = new TagImpl(nameof(Footer));

    /// <inheritdoc/>
    public Tag Form { get; } = new TagImpl(nameof(Form));

    /// <inheritdoc/>
    public Tag H1 { get; } = new TagImpl(nameof(H1));

    /// <inheritdoc/>
    public Tag H2 { get; } = new TagImpl(nameof(H2));

    /// <inheritdoc/>
    public Tag H3 { get; } = new TagImpl(nameof(H3));

    /// <inheritdoc/>
    public Tag H4 { get; } = new TagImpl(nameof(H4));

    /// <inheritdoc/>
    public Tag H5 { get; } = new TagImpl(nameof(H5));

    /// <inheritdoc/>
    public Tag H6 { get; } = new TagImpl(nameof(H6));

    /// <inheritdoc/>
    public Tag Head { get; } = new TagImpl(nameof(Head));

    /// <inheritdoc/>
    public Tag Header { get; } = new TagImpl(nameof(Header));

    /// <inheritdoc/>
    public EmptyTag Hr { get; } = new EmptyTagImpl(nameof(Hr));

    /// <inheritdoc/>
    public Tag Html { get; } = new TagImpl(nameof(Html));

    /// <inheritdoc/>
    public Tag I { get; } = new TagImpl(nameof(I));

    /// <inheritdoc/>
    public Tag Iframe { get; } = new TagImpl(nameof(Iframe));

    /// <inheritdoc/>
    public EmptyTag Img { get; } = new EmptyTagImpl(nameof(Img));

    /// <inheritdoc/>
    public EmptyTag Input { get; } = new EmptyTagImpl(nameof(Input));

    /// <inheritdoc/>
    public Tag Ins { get; } = new TagImpl(nameof(Ins));

    /// <inheritdoc/>
    public Tag Kbd { get; } = new TagImpl(nameof(Kbd));

    /// <inheritdoc/>
    public Tag Label { get; } = new TagImpl(nameof(Label));

    /// <inheritdoc/>
    public Tag Legend { get; } = new TagImpl(nameof(Legend));

    /// <inheritdoc/>
    public Tag Li { get; } = new TagImpl(nameof(Li));

    /// <inheritdoc/>
    public EmptyTag Link { get; } = new EmptyTagImpl(nameof(Link));

    /// <inheritdoc/>
    public Tag Main { get; } = new TagImpl(nameof(Main));

    /// <inheritdoc/>
    public Tag Map { get; } = new TagImpl(nameof(Map));

    /// <inheritdoc/>
    public Tag Mark { get; } = new TagImpl(nameof(Mark));

    /// <inheritdoc/>
    public EmptyTag Meta { get; } = new EmptyTagImpl(nameof(Meta));

    /// <inheritdoc/>
    public Tag Meter { get; } = new TagImpl(nameof(Meter));

    /// <inheritdoc/>
    public Tag Nav { get; } = new TagImpl(nameof(Nav));

    /// <inheritdoc/>
    public Tag Noscript { get; } = new TagImpl(nameof(Noscript));

    /// <inheritdoc/>
    public Tag Object { get; } = new TagImpl(nameof(Object));

    /// <inheritdoc/>
    public Tag Ol { get; } = new TagImpl(nameof(Ol));

    /// <inheritdoc/>
    public Tag Optgroup { get; } = new TagImpl(nameof(Optgroup));

    /// <inheritdoc/>
    public Tag Option { get; } = new TagImpl(nameof(Option));

    /// <inheritdoc/>
    public Tag Output { get; } = new TagImpl(nameof(Output));

    /// <inheritdoc/>
    public Tag P { get; } = new TagImpl(nameof(P));

    /// <inheritdoc/>
    public EmptyTag Param { get; } = new EmptyTagImpl(nameof(Param));

    /// <inheritdoc/>
    public Tag Picture { get; } = new TagImpl(nameof(Picture));

    /// <inheritdoc/>
    public Tag Pre { get; } = new TagImpl(nameof(Pre));

    /// <inheritdoc/>
    public Tag Progress { get; } = new TagImpl(nameof(Progress));

    /// <inheritdoc/>
    public Tag Q { get; } = new TagImpl(nameof(Q));

    /// <inheritdoc/>
    public Tag Rb { get; } = new TagImpl(nameof(Rb));

    /// <inheritdoc/>
    public Tag Rp { get; } = new TagImpl(nameof(Rp));

    /// <inheritdoc/>
    public Tag Rt { get; } = new TagImpl(nameof(Rt));

    /// <inheritdoc/>
    public Tag Rtc { get; } = new TagImpl(nameof(Rtc));

    /// <inheritdoc/>
    public Tag Ruby { get; } = new TagImpl(nameof(Ruby));

    /// <inheritdoc/>
    public Tag S { get; } = new TagImpl(nameof(S));

    /// <inheritdoc/>
    public Tag Samp { get; } = new TagImpl(nameof(Samp));

    /// <inheritdoc/>
    public Tag Script { get; } = new TagImpl(nameof(Script));

    /// <inheritdoc/>
    public Tag Section { get; } = new TagImpl(nameof(Section));

    /// <inheritdoc/>
    public Tag Select { get; } = new TagImpl(nameof(Select));

    /// <inheritdoc/>
    public Tag Small { get; } = new TagImpl(nameof(Small));

    /// <inheritdoc/>
    public EmptyTag Source { get; } = new EmptyTagImpl(nameof(Source));

    /// <inheritdoc/>
    public Tag Span { get; } = new TagImpl(nameof(Span));

    /// <inheritdoc/>
    public Tag Strong { get; } = new TagImpl(nameof(Strong));

    /// <inheritdoc/>
    public Tag Style { get; } = new TagImpl(nameof(Style));

    /// <inheritdoc/>
    public Tag Sub { get; } = new TagImpl(nameof(Sub));

    /// <inheritdoc/>
    public Tag Summary { get; } = new TagImpl(nameof(Summary));

    /// <inheritdoc/>
    public Tag Sup { get; } = new TagImpl(nameof(Sup));

    /// <inheritdoc/>
    public Tag Table { get; } = new TagImpl(nameof(Table));

    /// <inheritdoc/>
    public Tag Tbody { get; } = new TagImpl(nameof(Tbody));

    /// <inheritdoc/>
    public Tag Td { get; } = new TagImpl(nameof(Td));

    /// <inheritdoc/>
    public Tag Template { get; } = new TagImpl(nameof(Template));

    /// <inheritdoc/>
    public Tag Textarea { get; } = new TagImpl(nameof(Textarea));

    /// <inheritdoc/>
    public Tag Tfoot { get; } = new TagImpl(nameof(Tfoot));

    /// <inheritdoc/>
    public Tag Th { get; } = new TagImpl(nameof(Th));

    /// <inheritdoc/>
    public Tag Thead { get; } = new TagImpl(nameof(Thead));

    /// <inheritdoc/>
    public Tag Time { get; } = new TagImpl(nameof(Time));

    /// <inheritdoc/>
    public Tag Title { get; } = new TagImpl(nameof(Title));

    /// <inheritdoc/>
    public Tag Tr { get; } = new TagImpl(nameof(Tr));

    /// <inheritdoc/>
    public EmptyTag Track { get; } = new EmptyTagImpl(nameof(Track));

    /// <inheritdoc/>
    public Tag U { get; } = new TagImpl(nameof(U));

    /// <inheritdoc/>
    public Tag Ul { get; } = new TagImpl(nameof(Ul));

    /// <inheritdoc/>
    public Tag Var { get; } = new TagImpl(nameof(Var));

    /// <inheritdoc/>
    public Tag Video { get; } = new TagImpl(nameof(Video));

    /// <inheritdoc/>
    public EmptyTag Wbr { get; } = new EmptyTagImpl(nameof(Wbr));

    /// <inheritdoc/>
    public Entity Entity { get; } = new EntityImpl();

    /// <inheritdoc/>
    public Tag Tag(string name) => new TagImpl(name);

    /// <inheritdoc/>
    public EmptyTag EmptyTag(string name) => new EmptyTagImpl(name);

    /// <inheritdoc/>
    public Node Text(string text) => new TextImpl(text);

    /// <inheritdoc/>
    public Node CharacterReference(int codePoint)
        => new CharacterReferenceImpl(codePoint);
}
