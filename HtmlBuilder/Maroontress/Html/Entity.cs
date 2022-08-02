#pragma warning disable IDE1006, SA1300

namespace Maroontress.Html;

/// <summary>
/// The factory of <see cref="Node"/> objects representing a character
/// reference.
/// </summary>
/// <remarks>
/// <para>
/// Some names of the properties that this class contains violate the naming
/// convention so as to enhance convenience. The property name represents the
/// character reference name itself, which is case sensitive.
/// </para>
/// <para>
/// See <a
/// href="https://www.w3.org/TR/html52/syntax.html#named-character-references">
/// HTML5 specifications</a>.
/// </para>
/// </remarks>
public interface Entity
{
    /// <summary>
    /// Gets character reference <c>&amp;Aacute;</c>
    /// representing U+000C1.
    /// </summary>
    Node Aacute { get; }

    /// <summary>
    /// Gets character reference <c>&amp;aacute;</c>
    /// representing U+000E1.
    /// </summary>
    Node aacute { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Abreve;</c>
    /// representing U+00102.
    /// </summary>
    Node Abreve { get; }

    /// <summary>
    /// Gets character reference <c>&amp;abreve;</c>
    /// representing U+00103.
    /// </summary>
    Node abreve { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ac;</c>
    /// representing U+0223E.
    /// </summary>
    Node ac { get; }

    /// <summary>
    /// Gets character reference <c>&amp;acd;</c>
    /// representing U+0223F.
    /// </summary>
    Node acd { get; }

    /// <summary>
    /// Gets character reference <c>&amp;acE;</c>
    /// representing U+0223E U+00333.
    /// </summary>
    Node acE { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Acirc;</c>
    /// representing U+000C2.
    /// </summary>
    Node Acirc { get; }

    /// <summary>
    /// Gets character reference <c>&amp;acirc;</c>
    /// representing U+000E2.
    /// </summary>
    Node acirc { get; }

    /// <summary>
    /// Gets character reference <c>&amp;acute;</c>
    /// representing U+000B4.
    /// </summary>
    Node acute { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Acy;</c>
    /// representing U+00410.
    /// </summary>
    Node Acy { get; }

    /// <summary>
    /// Gets character reference <c>&amp;acy;</c>
    /// representing U+00430.
    /// </summary>
    Node acy { get; }

    /// <summary>
    /// Gets character reference <c>&amp;AElig;</c>
    /// representing U+000C6.
    /// </summary>
    Node AElig { get; }

    /// <summary>
    /// Gets character reference <c>&amp;aelig;</c>
    /// representing U+000E6.
    /// </summary>
    Node aelig { get; }

    /// <summary>
    /// Gets character reference <c>&amp;af;</c>
    /// representing U+02061.
    /// </summary>
    Node af { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Afr;</c>
    /// representing U+1D504.
    /// </summary>
    Node Afr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;afr;</c>
    /// representing U+1D51E.
    /// </summary>
    Node afr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Agrave;</c>
    /// representing U+000C0.
    /// </summary>
    Node Agrave { get; }

    /// <summary>
    /// Gets character reference <c>&amp;agrave;</c>
    /// representing U+000E0.
    /// </summary>
    Node agrave { get; }

    /// <summary>
    /// Gets character reference <c>&amp;alefsym;</c>
    /// representing U+02135.
    /// </summary>
    Node alefsym { get; }

    /// <summary>
    /// Gets character reference <c>&amp;aleph;</c>
    /// representing U+02135.
    /// </summary>
    Node aleph { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Alpha;</c>
    /// representing U+00391.
    /// </summary>
    Node Alpha { get; }

    /// <summary>
    /// Gets character reference <c>&amp;alpha;</c>
    /// representing U+003B1.
    /// </summary>
    Node alpha { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Amacr;</c>
    /// representing U+00100.
    /// </summary>
    Node Amacr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;amacr;</c>
    /// representing U+00101.
    /// </summary>
    Node amacr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;amalg;</c>
    /// representing U+02A3F.
    /// </summary>
    Node amalg { get; }

    /// <summary>
    /// Gets character reference <c>&amp;AMP;</c>
    /// representing U+00026.
    /// </summary>
    Node AMP { get; }

    /// <summary>
    /// Gets character reference <c>&amp;amp;</c>
    /// representing U+00026.
    /// </summary>
    Node amp { get; }

    /// <summary>
    /// Gets character reference <c>&amp;And;</c>
    /// representing U+02A53.
    /// </summary>
    Node And { get; }

    /// <summary>
    /// Gets character reference <c>&amp;and;</c>
    /// representing U+02227.
    /// </summary>
    Node and { get; }

    /// <summary>
    /// Gets character reference <c>&amp;andand;</c>
    /// representing U+02A55.
    /// </summary>
    Node andand { get; }

    /// <summary>
    /// Gets character reference <c>&amp;andd;</c>
    /// representing U+02A5C.
    /// </summary>
    Node andd { get; }

    /// <summary>
    /// Gets character reference <c>&amp;andslope;</c>
    /// representing U+02A58.
    /// </summary>
    Node andslope { get; }

    /// <summary>
    /// Gets character reference <c>&amp;andv;</c>
    /// representing U+02A5A.
    /// </summary>
    Node andv { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ang;</c>
    /// representing U+02220.
    /// </summary>
    Node ang { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ange;</c>
    /// representing U+029A4.
    /// </summary>
    Node ange { get; }

    /// <summary>
    /// Gets character reference <c>&amp;angle;</c>
    /// representing U+02220.
    /// </summary>
    Node angle { get; }

    /// <summary>
    /// Gets character reference <c>&amp;angmsd;</c>
    /// representing U+02221.
    /// </summary>
    Node angmsd { get; }

    /// <summary>
    /// Gets character reference <c>&amp;angmsdaa;</c>
    /// representing U+029A8.
    /// </summary>
    Node angmsdaa { get; }

    /// <summary>
    /// Gets character reference <c>&amp;angmsdab;</c>
    /// representing U+029A9.
    /// </summary>
    Node angmsdab { get; }

    /// <summary>
    /// Gets character reference <c>&amp;angmsdac;</c>
    /// representing U+029AA.
    /// </summary>
    Node angmsdac { get; }

    /// <summary>
    /// Gets character reference <c>&amp;angmsdad;</c>
    /// representing U+029AB.
    /// </summary>
    Node angmsdad { get; }

    /// <summary>
    /// Gets character reference <c>&amp;angmsdae;</c>
    /// representing U+029AC.
    /// </summary>
    Node angmsdae { get; }

    /// <summary>
    /// Gets character reference <c>&amp;angmsdaf;</c>
    /// representing U+029AD.
    /// </summary>
    Node angmsdaf { get; }

    /// <summary>
    /// Gets character reference <c>&amp;angmsdag;</c>
    /// representing U+029AE.
    /// </summary>
    Node angmsdag { get; }

    /// <summary>
    /// Gets character reference <c>&amp;angmsdah;</c>
    /// representing U+029AF.
    /// </summary>
    Node angmsdah { get; }

    /// <summary>
    /// Gets character reference <c>&amp;angrt;</c>
    /// representing U+0221F.
    /// </summary>
    Node angrt { get; }

    /// <summary>
    /// Gets character reference <c>&amp;angrtvb;</c>
    /// representing U+022BE.
    /// </summary>
    Node angrtvb { get; }

    /// <summary>
    /// Gets character reference <c>&amp;angrtvbd;</c>
    /// representing U+0299D.
    /// </summary>
    Node angrtvbd { get; }

    /// <summary>
    /// Gets character reference <c>&amp;angsph;</c>
    /// representing U+02222.
    /// </summary>
    Node angsph { get; }

    /// <summary>
    /// Gets character reference <c>&amp;angst;</c>
    /// representing U+000C5.
    /// </summary>
    Node angst { get; }

    /// <summary>
    /// Gets character reference <c>&amp;angzarr;</c>
    /// representing U+0237C.
    /// </summary>
    Node angzarr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Aogon;</c>
    /// representing U+00104.
    /// </summary>
    Node Aogon { get; }

    /// <summary>
    /// Gets character reference <c>&amp;aogon;</c>
    /// representing U+00105.
    /// </summary>
    Node aogon { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Aopf;</c>
    /// representing U+1D538.
    /// </summary>
    Node Aopf { get; }

    /// <summary>
    /// Gets character reference <c>&amp;aopf;</c>
    /// representing U+1D552.
    /// </summary>
    Node aopf { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ap;</c>
    /// representing U+02248.
    /// </summary>
    Node ap { get; }

    /// <summary>
    /// Gets character reference <c>&amp;apacir;</c>
    /// representing U+02A6F.
    /// </summary>
    Node apacir { get; }

    /// <summary>
    /// Gets character reference <c>&amp;apE;</c>
    /// representing U+02A70.
    /// </summary>
    Node apE { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ape;</c>
    /// representing U+0224A.
    /// </summary>
    Node ape { get; }

    /// <summary>
    /// Gets character reference <c>&amp;apid;</c>
    /// representing U+0224B.
    /// </summary>
    Node apid { get; }

    /// <summary>
    /// Gets character reference <c>&amp;apos;</c>
    /// representing U+00027.
    /// </summary>
    Node apos { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ApplyFunction;</c>
    /// representing U+02061.
    /// </summary>
    Node ApplyFunction { get; }

    /// <summary>
    /// Gets character reference <c>&amp;approx;</c>
    /// representing U+02248.
    /// </summary>
    Node approx { get; }

    /// <summary>
    /// Gets character reference <c>&amp;approxeq;</c>
    /// representing U+0224A.
    /// </summary>
    Node approxeq { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Aring;</c>
    /// representing U+000C5.
    /// </summary>
    Node Aring { get; }

    /// <summary>
    /// Gets character reference <c>&amp;aring;</c>
    /// representing U+000E5.
    /// </summary>
    Node aring { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Ascr;</c>
    /// representing U+1D49C.
    /// </summary>
    Node Ascr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ascr;</c>
    /// representing U+1D4B6.
    /// </summary>
    Node ascr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Assign;</c>
    /// representing U+02254.
    /// </summary>
    Node Assign { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ast;</c>
    /// representing U+0002A.
    /// </summary>
    Node ast { get; }

    /// <summary>
    /// Gets character reference <c>&amp;asymp;</c>
    /// representing U+02248.
    /// </summary>
    Node asymp { get; }

    /// <summary>
    /// Gets character reference <c>&amp;asympeq;</c>
    /// representing U+0224D.
    /// </summary>
    Node asympeq { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Atilde;</c>
    /// representing U+000C3.
    /// </summary>
    Node Atilde { get; }

    /// <summary>
    /// Gets character reference <c>&amp;atilde;</c>
    /// representing U+000E3.
    /// </summary>
    Node atilde { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Auml;</c>
    /// representing U+000C4.
    /// </summary>
    Node Auml { get; }

    /// <summary>
    /// Gets character reference <c>&amp;auml;</c>
    /// representing U+000E4.
    /// </summary>
    Node auml { get; }

    /// <summary>
    /// Gets character reference <c>&amp;awconint;</c>
    /// representing U+02233.
    /// </summary>
    Node awconint { get; }

    /// <summary>
    /// Gets character reference <c>&amp;awint;</c>
    /// representing U+02A11.
    /// </summary>
    Node awint { get; }

    /// <summary>
    /// Gets character reference <c>&amp;backcong;</c>
    /// representing U+0224C.
    /// </summary>
    Node backcong { get; }

    /// <summary>
    /// Gets character reference <c>&amp;backepsilon;</c>
    /// representing U+003F6.
    /// </summary>
    Node backepsilon { get; }

    /// <summary>
    /// Gets character reference <c>&amp;backprime;</c>
    /// representing U+02035.
    /// </summary>
    Node backprime { get; }

    /// <summary>
    /// Gets character reference <c>&amp;backsim;</c>
    /// representing U+0223D.
    /// </summary>
    Node backsim { get; }

    /// <summary>
    /// Gets character reference <c>&amp;backsimeq;</c>
    /// representing U+022CD.
    /// </summary>
    Node backsimeq { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Backslash;</c>
    /// representing U+02216.
    /// </summary>
    Node Backslash { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Barv;</c>
    /// representing U+02AE7.
    /// </summary>
    Node Barv { get; }

    /// <summary>
    /// Gets character reference <c>&amp;barvee;</c>
    /// representing U+022BD.
    /// </summary>
    Node barvee { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Barwed;</c>
    /// representing U+02306.
    /// </summary>
    Node Barwed { get; }

    /// <summary>
    /// Gets character reference <c>&amp;barwed;</c>
    /// representing U+02305.
    /// </summary>
    Node barwed { get; }

    /// <summary>
    /// Gets character reference <c>&amp;barwedge;</c>
    /// representing U+02305.
    /// </summary>
    Node barwedge { get; }

    /// <summary>
    /// Gets character reference <c>&amp;bbrk;</c>
    /// representing U+023B5.
    /// </summary>
    Node bbrk { get; }

    /// <summary>
    /// Gets character reference <c>&amp;bbrktbrk;</c>
    /// representing U+023B6.
    /// </summary>
    Node bbrktbrk { get; }

    /// <summary>
    /// Gets character reference <c>&amp;bcong;</c>
    /// representing U+0224C.
    /// </summary>
    Node bcong { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Bcy;</c>
    /// representing U+00411.
    /// </summary>
    Node Bcy { get; }

    /// <summary>
    /// Gets character reference <c>&amp;bcy;</c>
    /// representing U+00431.
    /// </summary>
    Node bcy { get; }

    /// <summary>
    /// Gets character reference <c>&amp;bdquo;</c>
    /// representing U+0201E.
    /// </summary>
    Node bdquo { get; }

    /// <summary>
    /// Gets character reference <c>&amp;becaus;</c>
    /// representing U+02235.
    /// </summary>
    Node becaus { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Because;</c>
    /// representing U+02235.
    /// </summary>
    Node Because { get; }

    /// <summary>
    /// Gets character reference <c>&amp;because;</c>
    /// representing U+02235.
    /// </summary>
    Node because { get; }

    /// <summary>
    /// Gets character reference <c>&amp;bemptyv;</c>
    /// representing U+029B0.
    /// </summary>
    Node bemptyv { get; }

    /// <summary>
    /// Gets character reference <c>&amp;bepsi;</c>
    /// representing U+003F6.
    /// </summary>
    Node bepsi { get; }

    /// <summary>
    /// Gets character reference <c>&amp;bernou;</c>
    /// representing U+0212C.
    /// </summary>
    Node bernou { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Bernoullis;</c>
    /// representing U+0212C.
    /// </summary>
    Node Bernoullis { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Beta;</c>
    /// representing U+00392.
    /// </summary>
    Node Beta { get; }

    /// <summary>
    /// Gets character reference <c>&amp;beta;</c>
    /// representing U+003B2.
    /// </summary>
    Node beta { get; }

    /// <summary>
    /// Gets character reference <c>&amp;beth;</c>
    /// representing U+02136.
    /// </summary>
    Node beth { get; }

    /// <summary>
    /// Gets character reference <c>&amp;between;</c>
    /// representing U+0226C.
    /// </summary>
    Node between { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Bfr;</c>
    /// representing U+1D505.
    /// </summary>
    Node Bfr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;bfr;</c>
    /// representing U+1D51F.
    /// </summary>
    Node bfr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;bigcap;</c>
    /// representing U+022C2.
    /// </summary>
    Node bigcap { get; }

    /// <summary>
    /// Gets character reference <c>&amp;bigcirc;</c>
    /// representing U+025EF.
    /// </summary>
    Node bigcirc { get; }

    /// <summary>
    /// Gets character reference <c>&amp;bigcup;</c>
    /// representing U+022C3.
    /// </summary>
    Node bigcup { get; }

    /// <summary>
    /// Gets character reference <c>&amp;bigodot;</c>
    /// representing U+02A00.
    /// </summary>
    Node bigodot { get; }

    /// <summary>
    /// Gets character reference <c>&amp;bigoplus;</c>
    /// representing U+02A01.
    /// </summary>
    Node bigoplus { get; }

    /// <summary>
    /// Gets character reference <c>&amp;bigotimes;</c>
    /// representing U+02A02.
    /// </summary>
    Node bigotimes { get; }

    /// <summary>
    /// Gets character reference <c>&amp;bigsqcup;</c>
    /// representing U+02A06.
    /// </summary>
    Node bigsqcup { get; }

    /// <summary>
    /// Gets character reference <c>&amp;bigstar;</c>
    /// representing U+02605.
    /// </summary>
    Node bigstar { get; }

    /// <summary>
    /// Gets character reference <c>&amp;bigtriangledown;</c>
    /// representing U+025BD.
    /// </summary>
    Node bigtriangledown { get; }

    /// <summary>
    /// Gets character reference <c>&amp;bigtriangleup;</c>
    /// representing U+025B3.
    /// </summary>
    Node bigtriangleup { get; }

    /// <summary>
    /// Gets character reference <c>&amp;biguplus;</c>
    /// representing U+02A04.
    /// </summary>
    Node biguplus { get; }

    /// <summary>
    /// Gets character reference <c>&amp;bigvee;</c>
    /// representing U+022C1.
    /// </summary>
    Node bigvee { get; }

    /// <summary>
    /// Gets character reference <c>&amp;bigwedge;</c>
    /// representing U+022C0.
    /// </summary>
    Node bigwedge { get; }

    /// <summary>
    /// Gets character reference <c>&amp;bkarow;</c>
    /// representing U+0290D.
    /// </summary>
    Node bkarow { get; }

    /// <summary>
    /// Gets character reference <c>&amp;blacklozenge;</c>
    /// representing U+029EB.
    /// </summary>
    Node blacklozenge { get; }

    /// <summary>
    /// Gets character reference <c>&amp;blacksquare;</c>
    /// representing U+025AA.
    /// </summary>
    Node blacksquare { get; }

    /// <summary>
    /// Gets character reference <c>&amp;blacktriangle;</c>
    /// representing U+025B4.
    /// </summary>
    Node blacktriangle { get; }

    /// <summary>
    /// Gets character reference <c>&amp;blacktriangledown;</c>
    /// representing U+025BE.
    /// </summary>
    Node blacktriangledown { get; }

    /// <summary>
    /// Gets character reference <c>&amp;blacktriangleleft;</c>
    /// representing U+025C2.
    /// </summary>
    Node blacktriangleleft { get; }

    /// <summary>
    /// Gets character reference <c>&amp;blacktriangleright;</c>
    /// representing U+025B8.
    /// </summary>
    Node blacktriangleright { get; }

    /// <summary>
    /// Gets character reference <c>&amp;blank;</c>
    /// representing U+02423.
    /// </summary>
    Node blank { get; }

    /// <summary>
    /// Gets character reference <c>&amp;blk12;</c>
    /// representing U+02592.
    /// </summary>
    Node blk12 { get; }

    /// <summary>
    /// Gets character reference <c>&amp;blk14;</c>
    /// representing U+02591.
    /// </summary>
    Node blk14 { get; }

    /// <summary>
    /// Gets character reference <c>&amp;blk34;</c>
    /// representing U+02593.
    /// </summary>
    Node blk34 { get; }

    /// <summary>
    /// Gets character reference <c>&amp;block;</c>
    /// representing U+02588.
    /// </summary>
    Node block { get; }

    /// <summary>
    /// Gets character reference <c>&amp;bne;</c>
    /// representing U+0003D U+020E5.
    /// </summary>
    Node bne { get; }

    /// <summary>
    /// Gets character reference <c>&amp;bnequiv;</c>
    /// representing U+02261 U+020E5.
    /// </summary>
    Node bnequiv { get; }

    /// <summary>
    /// Gets character reference <c>&amp;bNot;</c>
    /// representing U+02AED.
    /// </summary>
    Node bNot { get; }

    /// <summary>
    /// Gets character reference <c>&amp;bnot;</c>
    /// representing U+02310.
    /// </summary>
    Node bnot { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Bopf;</c>
    /// representing U+1D539.
    /// </summary>
    Node Bopf { get; }

    /// <summary>
    /// Gets character reference <c>&amp;bopf;</c>
    /// representing U+1D553.
    /// </summary>
    Node bopf { get; }

    /// <summary>
    /// Gets character reference <c>&amp;bot;</c>
    /// representing U+022A5.
    /// </summary>
    Node bot { get; }

    /// <summary>
    /// Gets character reference <c>&amp;bottom;</c>
    /// representing U+022A5.
    /// </summary>
    Node bottom { get; }

    /// <summary>
    /// Gets character reference <c>&amp;bowtie;</c>
    /// representing U+022C8.
    /// </summary>
    Node bowtie { get; }

    /// <summary>
    /// Gets character reference <c>&amp;boxbox;</c>
    /// representing U+029C9.
    /// </summary>
    Node boxbox { get; }

    /// <summary>
    /// Gets character reference <c>&amp;boxDL;</c>
    /// representing U+02557.
    /// </summary>
    Node boxDL { get; }

    /// <summary>
    /// Gets character reference <c>&amp;boxDl;</c>
    /// representing U+02556.
    /// </summary>
    Node boxDl { get; }

    /// <summary>
    /// Gets character reference <c>&amp;boxdL;</c>
    /// representing U+02555.
    /// </summary>
    Node boxdL { get; }

    /// <summary>
    /// Gets character reference <c>&amp;boxdl;</c>
    /// representing U+02510.
    /// </summary>
    Node boxdl { get; }

    /// <summary>
    /// Gets character reference <c>&amp;boxDR;</c>
    /// representing U+02554.
    /// </summary>
    Node boxDR { get; }

    /// <summary>
    /// Gets character reference <c>&amp;boxDr;</c>
    /// representing U+02553.
    /// </summary>
    Node boxDr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;boxdR;</c>
    /// representing U+02552.
    /// </summary>
    Node boxdR { get; }

    /// <summary>
    /// Gets character reference <c>&amp;boxdr;</c>
    /// representing U+0250C.
    /// </summary>
    Node boxdr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;boxH;</c>
    /// representing U+02550.
    /// </summary>
    Node boxH { get; }

    /// <summary>
    /// Gets character reference <c>&amp;boxh;</c>
    /// representing U+02500.
    /// </summary>
    Node boxh { get; }

    /// <summary>
    /// Gets character reference <c>&amp;boxHD;</c>
    /// representing U+02566.
    /// </summary>
    Node boxHD { get; }

    /// <summary>
    /// Gets character reference <c>&amp;boxHd;</c>
    /// representing U+02564.
    /// </summary>
    Node boxHd { get; }

    /// <summary>
    /// Gets character reference <c>&amp;boxhD;</c>
    /// representing U+02565.
    /// </summary>
    Node boxhD { get; }

    /// <summary>
    /// Gets character reference <c>&amp;boxhd;</c>
    /// representing U+0252C.
    /// </summary>
    Node boxhd { get; }

    /// <summary>
    /// Gets character reference <c>&amp;boxHU;</c>
    /// representing U+02569.
    /// </summary>
    Node boxHU { get; }

    /// <summary>
    /// Gets character reference <c>&amp;boxHu;</c>
    /// representing U+02567.
    /// </summary>
    Node boxHu { get; }

    /// <summary>
    /// Gets character reference <c>&amp;boxhU;</c>
    /// representing U+02568.
    /// </summary>
    Node boxhU { get; }

    /// <summary>
    /// Gets character reference <c>&amp;boxhu;</c>
    /// representing U+02534.
    /// </summary>
    Node boxhu { get; }

    /// <summary>
    /// Gets character reference <c>&amp;boxminus;</c>
    /// representing U+0229F.
    /// </summary>
    Node boxminus { get; }

    /// <summary>
    /// Gets character reference <c>&amp;boxplus;</c>
    /// representing U+0229E.
    /// </summary>
    Node boxplus { get; }

    /// <summary>
    /// Gets character reference <c>&amp;boxtimes;</c>
    /// representing U+022A0.
    /// </summary>
    Node boxtimes { get; }

    /// <summary>
    /// Gets character reference <c>&amp;boxUL;</c>
    /// representing U+0255D.
    /// </summary>
    Node boxUL { get; }

    /// <summary>
    /// Gets character reference <c>&amp;boxUl;</c>
    /// representing U+0255C.
    /// </summary>
    Node boxUl { get; }

    /// <summary>
    /// Gets character reference <c>&amp;boxuL;</c>
    /// representing U+0255B.
    /// </summary>
    Node boxuL { get; }

    /// <summary>
    /// Gets character reference <c>&amp;boxul;</c>
    /// representing U+02518.
    /// </summary>
    Node boxul { get; }

    /// <summary>
    /// Gets character reference <c>&amp;boxUR;</c>
    /// representing U+0255A.
    /// </summary>
    Node boxUR { get; }

    /// <summary>
    /// Gets character reference <c>&amp;boxUr;</c>
    /// representing U+02559.
    /// </summary>
    Node boxUr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;boxuR;</c>
    /// representing U+02558.
    /// </summary>
    Node boxuR { get; }

    /// <summary>
    /// Gets character reference <c>&amp;boxur;</c>
    /// representing U+02514.
    /// </summary>
    Node boxur { get; }

    /// <summary>
    /// Gets character reference <c>&amp;boxV;</c>
    /// representing U+02551.
    /// </summary>
    Node boxV { get; }

    /// <summary>
    /// Gets character reference <c>&amp;boxv;</c>
    /// representing U+02502.
    /// </summary>
    Node boxv { get; }

    /// <summary>
    /// Gets character reference <c>&amp;boxVH;</c>
    /// representing U+0256C.
    /// </summary>
    Node boxVH { get; }

    /// <summary>
    /// Gets character reference <c>&amp;boxVh;</c>
    /// representing U+0256B.
    /// </summary>
    Node boxVh { get; }

    /// <summary>
    /// Gets character reference <c>&amp;boxvH;</c>
    /// representing U+0256A.
    /// </summary>
    Node boxvH { get; }

    /// <summary>
    /// Gets character reference <c>&amp;boxvh;</c>
    /// representing U+0253C.
    /// </summary>
    Node boxvh { get; }

    /// <summary>
    /// Gets character reference <c>&amp;boxVL;</c>
    /// representing U+02563.
    /// </summary>
    Node boxVL { get; }

    /// <summary>
    /// Gets character reference <c>&amp;boxVl;</c>
    /// representing U+02562.
    /// </summary>
    Node boxVl { get; }

    /// <summary>
    /// Gets character reference <c>&amp;boxvL;</c>
    /// representing U+02561.
    /// </summary>
    Node boxvL { get; }

    /// <summary>
    /// Gets character reference <c>&amp;boxvl;</c>
    /// representing U+02524.
    /// </summary>
    Node boxvl { get; }

    /// <summary>
    /// Gets character reference <c>&amp;boxVR;</c>
    /// representing U+02560.
    /// </summary>
    Node boxVR { get; }

    /// <summary>
    /// Gets character reference <c>&amp;boxVr;</c>
    /// representing U+0255F.
    /// </summary>
    Node boxVr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;boxvR;</c>
    /// representing U+0255E.
    /// </summary>
    Node boxvR { get; }

    /// <summary>
    /// Gets character reference <c>&amp;boxvr;</c>
    /// representing U+0251C.
    /// </summary>
    Node boxvr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;bprime;</c>
    /// representing U+02035.
    /// </summary>
    Node bprime { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Breve;</c>
    /// representing U+002D8.
    /// </summary>
    Node Breve { get; }

    /// <summary>
    /// Gets character reference <c>&amp;breve;</c>
    /// representing U+002D8.
    /// </summary>
    Node breve { get; }

    /// <summary>
    /// Gets character reference <c>&amp;brvbar;</c>
    /// representing U+000A6.
    /// </summary>
    Node brvbar { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Bscr;</c>
    /// representing U+0212C.
    /// </summary>
    Node Bscr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;bscr;</c>
    /// representing U+1D4B7.
    /// </summary>
    Node bscr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;bsemi;</c>
    /// representing U+0204F.
    /// </summary>
    Node bsemi { get; }

    /// <summary>
    /// Gets character reference <c>&amp;bsim;</c>
    /// representing U+0223D.
    /// </summary>
    Node bsim { get; }

    /// <summary>
    /// Gets character reference <c>&amp;bsime;</c>
    /// representing U+022CD.
    /// </summary>
    Node bsime { get; }

    /// <summary>
    /// Gets character reference <c>&amp;bsol;</c>
    /// representing U+0005C.
    /// </summary>
    Node bsol { get; }

    /// <summary>
    /// Gets character reference <c>&amp;bsolb;</c>
    /// representing U+029C5.
    /// </summary>
    Node bsolb { get; }

    /// <summary>
    /// Gets character reference <c>&amp;bsolhsub;</c>
    /// representing U+027C8.
    /// </summary>
    Node bsolhsub { get; }

    /// <summary>
    /// Gets character reference <c>&amp;bull;</c>
    /// representing U+02022.
    /// </summary>
    Node bull { get; }

    /// <summary>
    /// Gets character reference <c>&amp;bullet;</c>
    /// representing U+02022.
    /// </summary>
    Node bullet { get; }

    /// <summary>
    /// Gets character reference <c>&amp;bump;</c>
    /// representing U+0224E.
    /// </summary>
    Node bump { get; }

    /// <summary>
    /// Gets character reference <c>&amp;bumpE;</c>
    /// representing U+02AAE.
    /// </summary>
    Node bumpE { get; }

    /// <summary>
    /// Gets character reference <c>&amp;bumpe;</c>
    /// representing U+0224F.
    /// </summary>
    Node bumpe { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Bumpeq;</c>
    /// representing U+0224E.
    /// </summary>
    Node Bumpeq { get; }

    /// <summary>
    /// Gets character reference <c>&amp;bumpeq;</c>
    /// representing U+0224F.
    /// </summary>
    Node bumpeq { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Cacute;</c>
    /// representing U+00106.
    /// </summary>
    Node Cacute { get; }

    /// <summary>
    /// Gets character reference <c>&amp;cacute;</c>
    /// representing U+00107.
    /// </summary>
    Node cacute { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Cap;</c>
    /// representing U+022D2.
    /// </summary>
    Node Cap { get; }

    /// <summary>
    /// Gets character reference <c>&amp;cap;</c>
    /// representing U+02229.
    /// </summary>
    Node cap { get; }

    /// <summary>
    /// Gets character reference <c>&amp;capand;</c>
    /// representing U+02A44.
    /// </summary>
    Node capand { get; }

    /// <summary>
    /// Gets character reference <c>&amp;capbrcup;</c>
    /// representing U+02A49.
    /// </summary>
    Node capbrcup { get; }

    /// <summary>
    /// Gets character reference <c>&amp;capcap;</c>
    /// representing U+02A4B.
    /// </summary>
    Node capcap { get; }

    /// <summary>
    /// Gets character reference <c>&amp;capcup;</c>
    /// representing U+02A47.
    /// </summary>
    Node capcup { get; }

    /// <summary>
    /// Gets character reference <c>&amp;capdot;</c>
    /// representing U+02A40.
    /// </summary>
    Node capdot { get; }

    /// <summary>
    /// Gets character reference <c>&amp;CapitalDifferentialD;</c>
    /// representing U+02145.
    /// </summary>
    Node CapitalDifferentialD { get; }

    /// <summary>
    /// Gets character reference <c>&amp;caps;</c>
    /// representing U+02229 U+0FE00.
    /// </summary>
    Node caps { get; }

    /// <summary>
    /// Gets character reference <c>&amp;caret;</c>
    /// representing U+02041.
    /// </summary>
    Node caret { get; }

    /// <summary>
    /// Gets character reference <c>&amp;caron;</c>
    /// representing U+002C7.
    /// </summary>
    Node caron { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Cayleys;</c>
    /// representing U+0212D.
    /// </summary>
    Node Cayleys { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ccaps;</c>
    /// representing U+02A4D.
    /// </summary>
    Node ccaps { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Ccaron;</c>
    /// representing U+0010C.
    /// </summary>
    Node Ccaron { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ccaron;</c>
    /// representing U+0010D.
    /// </summary>
    Node ccaron { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Ccedil;</c>
    /// representing U+000C7.
    /// </summary>
    Node Ccedil { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ccedil;</c>
    /// representing U+000E7.
    /// </summary>
    Node ccedil { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Ccirc;</c>
    /// representing U+00108.
    /// </summary>
    Node Ccirc { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ccirc;</c>
    /// representing U+00109.
    /// </summary>
    Node ccirc { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Cconint;</c>
    /// representing U+02230.
    /// </summary>
    Node Cconint { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ccups;</c>
    /// representing U+02A4C.
    /// </summary>
    Node ccups { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ccupssm;</c>
    /// representing U+02A50.
    /// </summary>
    Node ccupssm { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Cdot;</c>
    /// representing U+0010A.
    /// </summary>
    Node Cdot { get; }

    /// <summary>
    /// Gets character reference <c>&amp;cdot;</c>
    /// representing U+0010B.
    /// </summary>
    Node cdot { get; }

    /// <summary>
    /// Gets character reference <c>&amp;cedil;</c>
    /// representing U+000B8.
    /// </summary>
    Node cedil { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Cedilla;</c>
    /// representing U+000B8.
    /// </summary>
    Node Cedilla { get; }

    /// <summary>
    /// Gets character reference <c>&amp;cemptyv;</c>
    /// representing U+029B2.
    /// </summary>
    Node cemptyv { get; }

    /// <summary>
    /// Gets character reference <c>&amp;cent;</c>
    /// representing U+000A2.
    /// </summary>
    Node cent { get; }

    /// <summary>
    /// Gets character reference <c>&amp;CenterDot;</c>
    /// representing U+000B7.
    /// </summary>
    Node CenterDot { get; }

    /// <summary>
    /// Gets character reference <c>&amp;centerdot;</c>
    /// representing U+000B7.
    /// </summary>
    Node centerdot { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Cfr;</c>
    /// representing U+0212D.
    /// </summary>
    Node Cfr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;cfr;</c>
    /// representing U+1D520.
    /// </summary>
    Node cfr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;CHcy;</c>
    /// representing U+00427.
    /// </summary>
    Node CHcy { get; }

    /// <summary>
    /// Gets character reference <c>&amp;chcy;</c>
    /// representing U+00447.
    /// </summary>
    Node chcy { get; }

    /// <summary>
    /// Gets character reference <c>&amp;check;</c>
    /// representing U+02713.
    /// </summary>
    Node check { get; }

    /// <summary>
    /// Gets character reference <c>&amp;checkmark;</c>
    /// representing U+02713.
    /// </summary>
    Node checkmark { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Chi;</c>
    /// representing U+003A7.
    /// </summary>
    Node Chi { get; }

    /// <summary>
    /// Gets character reference <c>&amp;chi;</c>
    /// representing U+003C7.
    /// </summary>
    Node chi { get; }

    /// <summary>
    /// Gets character reference <c>&amp;cir;</c>
    /// representing U+025CB.
    /// </summary>
    Node cir { get; }

    /// <summary>
    /// Gets character reference <c>&amp;circ;</c>
    /// representing U+002C6.
    /// </summary>
    Node circ { get; }

    /// <summary>
    /// Gets character reference <c>&amp;circeq;</c>
    /// representing U+02257.
    /// </summary>
    Node circeq { get; }

    /// <summary>
    /// Gets character reference <c>&amp;circlearrowleft;</c>
    /// representing U+021BA.
    /// </summary>
    Node circlearrowleft { get; }

    /// <summary>
    /// Gets character reference <c>&amp;circlearrowright;</c>
    /// representing U+021BB.
    /// </summary>
    Node circlearrowright { get; }

    /// <summary>
    /// Gets character reference <c>&amp;circledast;</c>
    /// representing U+0229B.
    /// </summary>
    Node circledast { get; }

    /// <summary>
    /// Gets character reference <c>&amp;circledcirc;</c>
    /// representing U+0229A.
    /// </summary>
    Node circledcirc { get; }

    /// <summary>
    /// Gets character reference <c>&amp;circleddash;</c>
    /// representing U+0229D.
    /// </summary>
    Node circleddash { get; }

    /// <summary>
    /// Gets character reference <c>&amp;CircleDot;</c>
    /// representing U+02299.
    /// </summary>
    Node CircleDot { get; }

    /// <summary>
    /// Gets character reference <c>&amp;circledR;</c>
    /// representing U+000AE.
    /// </summary>
    Node circledR { get; }

    /// <summary>
    /// Gets character reference <c>&amp;circledS;</c>
    /// representing U+024C8.
    /// </summary>
    Node circledS { get; }

    /// <summary>
    /// Gets character reference <c>&amp;CircleMinus;</c>
    /// representing U+02296.
    /// </summary>
    Node CircleMinus { get; }

    /// <summary>
    /// Gets character reference <c>&amp;CirclePlus;</c>
    /// representing U+02295.
    /// </summary>
    Node CirclePlus { get; }

    /// <summary>
    /// Gets character reference <c>&amp;CircleTimes;</c>
    /// representing U+02297.
    /// </summary>
    Node CircleTimes { get; }

    /// <summary>
    /// Gets character reference <c>&amp;cirE;</c>
    /// representing U+029C3.
    /// </summary>
    Node cirE { get; }

    /// <summary>
    /// Gets character reference <c>&amp;cire;</c>
    /// representing U+02257.
    /// </summary>
    Node cire { get; }

    /// <summary>
    /// Gets character reference <c>&amp;cirfnint;</c>
    /// representing U+02A10.
    /// </summary>
    Node cirfnint { get; }

    /// <summary>
    /// Gets character reference <c>&amp;cirmid;</c>
    /// representing U+02AEF.
    /// </summary>
    Node cirmid { get; }

    /// <summary>
    /// Gets character reference <c>&amp;cirscir;</c>
    /// representing U+029C2.
    /// </summary>
    Node cirscir { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ClockwiseContourIntegral;</c>
    /// representing U+02232.
    /// </summary>
    Node ClockwiseContourIntegral { get; }

    /// <summary>
    /// Gets character reference <c>&amp;CloseCurlyDoubleQuote;</c>
    /// representing U+0201D.
    /// </summary>
    Node CloseCurlyDoubleQuote { get; }

    /// <summary>
    /// Gets character reference <c>&amp;CloseCurlyQuote;</c>
    /// representing U+02019.
    /// </summary>
    Node CloseCurlyQuote { get; }

    /// <summary>
    /// Gets character reference <c>&amp;clubs;</c>
    /// representing U+02663.
    /// </summary>
    Node clubs { get; }

    /// <summary>
    /// Gets character reference <c>&amp;clubsuit;</c>
    /// representing U+02663.
    /// </summary>
    Node clubsuit { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Colon;</c>
    /// representing U+02237.
    /// </summary>
    Node Colon { get; }

    /// <summary>
    /// Gets character reference <c>&amp;colon;</c>
    /// representing U+0003A.
    /// </summary>
    Node colon { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Colone;</c>
    /// representing U+02A74.
    /// </summary>
    Node Colone { get; }

    /// <summary>
    /// Gets character reference <c>&amp;colone;</c>
    /// representing U+02254.
    /// </summary>
    Node colone { get; }

    /// <summary>
    /// Gets character reference <c>&amp;coloneq;</c>
    /// representing U+02254.
    /// </summary>
    Node coloneq { get; }

    /// <summary>
    /// Gets character reference <c>&amp;comma;</c>
    /// representing U+0002C.
    /// </summary>
    Node comma { get; }

    /// <summary>
    /// Gets character reference <c>&amp;commat;</c>
    /// representing U+00040.
    /// </summary>
    Node commat { get; }

    /// <summary>
    /// Gets character reference <c>&amp;comp;</c>
    /// representing U+02201.
    /// </summary>
    Node comp { get; }

    /// <summary>
    /// Gets character reference <c>&amp;compfn;</c>
    /// representing U+02218.
    /// </summary>
    Node compfn { get; }

    /// <summary>
    /// Gets character reference <c>&amp;complement;</c>
    /// representing U+02201.
    /// </summary>
    Node complement { get; }

    /// <summary>
    /// Gets character reference <c>&amp;complexes;</c>
    /// representing U+02102.
    /// </summary>
    Node complexes { get; }

    /// <summary>
    /// Gets character reference <c>&amp;cong;</c>
    /// representing U+02245.
    /// </summary>
    Node cong { get; }

    /// <summary>
    /// Gets character reference <c>&amp;congdot;</c>
    /// representing U+02A6D.
    /// </summary>
    Node congdot { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Congruent;</c>
    /// representing U+02261.
    /// </summary>
    Node Congruent { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Conint;</c>
    /// representing U+0222F.
    /// </summary>
    Node Conint { get; }

    /// <summary>
    /// Gets character reference <c>&amp;conint;</c>
    /// representing U+0222E.
    /// </summary>
    Node conint { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ContourIntegral;</c>
    /// representing U+0222E.
    /// </summary>
    Node ContourIntegral { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Copf;</c>
    /// representing U+02102.
    /// </summary>
    Node Copf { get; }

    /// <summary>
    /// Gets character reference <c>&amp;copf;</c>
    /// representing U+1D554.
    /// </summary>
    Node copf { get; }

    /// <summary>
    /// Gets character reference <c>&amp;coprod;</c>
    /// representing U+02210.
    /// </summary>
    Node coprod { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Coproduct;</c>
    /// representing U+02210.
    /// </summary>
    Node Coproduct { get; }

    /// <summary>
    /// Gets character reference <c>&amp;COPY;</c>
    /// representing U+000A9.
    /// </summary>
    Node COPY { get; }

    /// <summary>
    /// Gets character reference <c>&amp;copy;</c>
    /// representing U+000A9.
    /// </summary>
    Node copy { get; }

    /// <summary>
    /// Gets character reference <c>&amp;copysr;</c>
    /// representing U+02117.
    /// </summary>
    Node copysr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;CounterClockwiseContourIntegral;</c>
    /// representing U+02233.
    /// </summary>
    Node CounterClockwiseContourIntegral { get; }

    /// <summary>
    /// Gets character reference <c>&amp;crarr;</c>
    /// representing U+021B5.
    /// </summary>
    Node crarr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Cross;</c>
    /// representing U+02A2F.
    /// </summary>
    Node Cross { get; }

    /// <summary>
    /// Gets character reference <c>&amp;cross;</c>
    /// representing U+02717.
    /// </summary>
    Node cross { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Cscr;</c>
    /// representing U+1D49E.
    /// </summary>
    Node Cscr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;cscr;</c>
    /// representing U+1D4B8.
    /// </summary>
    Node cscr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;csub;</c>
    /// representing U+02ACF.
    /// </summary>
    Node csub { get; }

    /// <summary>
    /// Gets character reference <c>&amp;csube;</c>
    /// representing U+02AD1.
    /// </summary>
    Node csube { get; }

    /// <summary>
    /// Gets character reference <c>&amp;csup;</c>
    /// representing U+02AD0.
    /// </summary>
    Node csup { get; }

    /// <summary>
    /// Gets character reference <c>&amp;csupe;</c>
    /// representing U+02AD2.
    /// </summary>
    Node csupe { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ctdot;</c>
    /// representing U+022EF.
    /// </summary>
    Node ctdot { get; }

    /// <summary>
    /// Gets character reference <c>&amp;cudarrl;</c>
    /// representing U+02938.
    /// </summary>
    Node cudarrl { get; }

    /// <summary>
    /// Gets character reference <c>&amp;cudarrr;</c>
    /// representing U+02935.
    /// </summary>
    Node cudarrr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;cuepr;</c>
    /// representing U+022DE.
    /// </summary>
    Node cuepr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;cuesc;</c>
    /// representing U+022DF.
    /// </summary>
    Node cuesc { get; }

    /// <summary>
    /// Gets character reference <c>&amp;cularr;</c>
    /// representing U+021B6.
    /// </summary>
    Node cularr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;cularrp;</c>
    /// representing U+0293D.
    /// </summary>
    Node cularrp { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Cup;</c>
    /// representing U+022D3.
    /// </summary>
    Node Cup { get; }

    /// <summary>
    /// Gets character reference <c>&amp;cup;</c>
    /// representing U+0222A.
    /// </summary>
    Node cup { get; }

    /// <summary>
    /// Gets character reference <c>&amp;cupbrcap;</c>
    /// representing U+02A48.
    /// </summary>
    Node cupbrcap { get; }

    /// <summary>
    /// Gets character reference <c>&amp;CupCap;</c>
    /// representing U+0224D.
    /// </summary>
    Node CupCap { get; }

    /// <summary>
    /// Gets character reference <c>&amp;cupcap;</c>
    /// representing U+02A46.
    /// </summary>
    Node cupcap { get; }

    /// <summary>
    /// Gets character reference <c>&amp;cupcup;</c>
    /// representing U+02A4A.
    /// </summary>
    Node cupcup { get; }

    /// <summary>
    /// Gets character reference <c>&amp;cupdot;</c>
    /// representing U+0228D.
    /// </summary>
    Node cupdot { get; }

    /// <summary>
    /// Gets character reference <c>&amp;cupor;</c>
    /// representing U+02A45.
    /// </summary>
    Node cupor { get; }

    /// <summary>
    /// Gets character reference <c>&amp;cups;</c>
    /// representing U+0222A U+0FE00.
    /// </summary>
    Node cups { get; }

    /// <summary>
    /// Gets character reference <c>&amp;curarr;</c>
    /// representing U+021B7.
    /// </summary>
    Node curarr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;curarrm;</c>
    /// representing U+0293C.
    /// </summary>
    Node curarrm { get; }

    /// <summary>
    /// Gets character reference <c>&amp;curlyeqprec;</c>
    /// representing U+022DE.
    /// </summary>
    Node curlyeqprec { get; }

    /// <summary>
    /// Gets character reference <c>&amp;curlyeqsucc;</c>
    /// representing U+022DF.
    /// </summary>
    Node curlyeqsucc { get; }

    /// <summary>
    /// Gets character reference <c>&amp;curlyvee;</c>
    /// representing U+022CE.
    /// </summary>
    Node curlyvee { get; }

    /// <summary>
    /// Gets character reference <c>&amp;curlywedge;</c>
    /// representing U+022CF.
    /// </summary>
    Node curlywedge { get; }

    /// <summary>
    /// Gets character reference <c>&amp;curren;</c>
    /// representing U+000A4.
    /// </summary>
    Node curren { get; }

    /// <summary>
    /// Gets character reference <c>&amp;curvearrowleft;</c>
    /// representing U+021B6.
    /// </summary>
    Node curvearrowleft { get; }

    /// <summary>
    /// Gets character reference <c>&amp;curvearrowright;</c>
    /// representing U+021B7.
    /// </summary>
    Node curvearrowright { get; }

    /// <summary>
    /// Gets character reference <c>&amp;cuvee;</c>
    /// representing U+022CE.
    /// </summary>
    Node cuvee { get; }

    /// <summary>
    /// Gets character reference <c>&amp;cuwed;</c>
    /// representing U+022CF.
    /// </summary>
    Node cuwed { get; }

    /// <summary>
    /// Gets character reference <c>&amp;cwconint;</c>
    /// representing U+02232.
    /// </summary>
    Node cwconint { get; }

    /// <summary>
    /// Gets character reference <c>&amp;cwint;</c>
    /// representing U+02231.
    /// </summary>
    Node cwint { get; }

    /// <summary>
    /// Gets character reference <c>&amp;cylcty;</c>
    /// representing U+0232D.
    /// </summary>
    Node cylcty { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Dagger;</c>
    /// representing U+02021.
    /// </summary>
    Node Dagger { get; }

    /// <summary>
    /// Gets character reference <c>&amp;dagger;</c>
    /// representing U+02020.
    /// </summary>
    Node dagger { get; }

    /// <summary>
    /// Gets character reference <c>&amp;daleth;</c>
    /// representing U+02138.
    /// </summary>
    Node daleth { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Darr;</c>
    /// representing U+021A1.
    /// </summary>
    Node Darr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;dArr;</c>
    /// representing U+021D3.
    /// </summary>
    Node dArr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;darr;</c>
    /// representing U+02193.
    /// </summary>
    Node darr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;dash;</c>
    /// representing U+02010.
    /// </summary>
    Node dash { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Dashv;</c>
    /// representing U+02AE4.
    /// </summary>
    Node Dashv { get; }

    /// <summary>
    /// Gets character reference <c>&amp;dashv;</c>
    /// representing U+022A3.
    /// </summary>
    Node dashv { get; }

    /// <summary>
    /// Gets character reference <c>&amp;dbkarow;</c>
    /// representing U+0290F.
    /// </summary>
    Node dbkarow { get; }

    /// <summary>
    /// Gets character reference <c>&amp;dblac;</c>
    /// representing U+002DD.
    /// </summary>
    Node dblac { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Dcaron;</c>
    /// representing U+0010E.
    /// </summary>
    Node Dcaron { get; }

    /// <summary>
    /// Gets character reference <c>&amp;dcaron;</c>
    /// representing U+0010F.
    /// </summary>
    Node dcaron { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Dcy;</c>
    /// representing U+00414.
    /// </summary>
    Node Dcy { get; }

    /// <summary>
    /// Gets character reference <c>&amp;dcy;</c>
    /// representing U+00434.
    /// </summary>
    Node dcy { get; }

    /// <summary>
    /// Gets character reference <c>&amp;DD;</c>
    /// representing U+02145.
    /// </summary>
    Node DD { get; }

    /// <summary>
    /// Gets character reference <c>&amp;dd;</c>
    /// representing U+02146.
    /// </summary>
    Node dd { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ddagger;</c>
    /// representing U+02021.
    /// </summary>
    Node ddagger { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ddarr;</c>
    /// representing U+021CA.
    /// </summary>
    Node ddarr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;DDotrahd;</c>
    /// representing U+02911.
    /// </summary>
    Node DDotrahd { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ddotseq;</c>
    /// representing U+02A77.
    /// </summary>
    Node ddotseq { get; }

    /// <summary>
    /// Gets character reference <c>&amp;deg;</c>
    /// representing U+000B0.
    /// </summary>
    Node deg { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Del;</c>
    /// representing U+02207.
    /// </summary>
    Node Del { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Delta;</c>
    /// representing U+00394.
    /// </summary>
    Node Delta { get; }

    /// <summary>
    /// Gets character reference <c>&amp;delta;</c>
    /// representing U+003B4.
    /// </summary>
    Node delta { get; }

    /// <summary>
    /// Gets character reference <c>&amp;demptyv;</c>
    /// representing U+029B1.
    /// </summary>
    Node demptyv { get; }

    /// <summary>
    /// Gets character reference <c>&amp;dfisht;</c>
    /// representing U+0297F.
    /// </summary>
    Node dfisht { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Dfr;</c>
    /// representing U+1D507.
    /// </summary>
    Node Dfr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;dfr;</c>
    /// representing U+1D521.
    /// </summary>
    Node dfr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;dHar;</c>
    /// representing U+02965.
    /// </summary>
    Node dHar { get; }

    /// <summary>
    /// Gets character reference <c>&amp;dharl;</c>
    /// representing U+021C3.
    /// </summary>
    Node dharl { get; }

    /// <summary>
    /// Gets character reference <c>&amp;dharr;</c>
    /// representing U+021C2.
    /// </summary>
    Node dharr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;DiacriticalAcute;</c>
    /// representing U+000B4.
    /// </summary>
    Node DiacriticalAcute { get; }

    /// <summary>
    /// Gets character reference <c>&amp;DiacriticalDot;</c>
    /// representing U+002D9.
    /// </summary>
    Node DiacriticalDot { get; }

    /// <summary>
    /// Gets character reference <c>&amp;DiacriticalDoubleAcute;</c>
    /// representing U+002DD.
    /// </summary>
    Node DiacriticalDoubleAcute { get; }

    /// <summary>
    /// Gets character reference <c>&amp;DiacriticalGrave;</c>
    /// representing U+00060.
    /// </summary>
    Node DiacriticalGrave { get; }

    /// <summary>
    /// Gets character reference <c>&amp;DiacriticalTilde;</c>
    /// representing U+002DC.
    /// </summary>
    Node DiacriticalTilde { get; }

    /// <summary>
    /// Gets character reference <c>&amp;diam;</c>
    /// representing U+022C4.
    /// </summary>
    Node diam { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Diamond;</c>
    /// representing U+022C4.
    /// </summary>
    Node Diamond { get; }

    /// <summary>
    /// Gets character reference <c>&amp;diamond;</c>
    /// representing U+022C4.
    /// </summary>
    Node diamond { get; }

    /// <summary>
    /// Gets character reference <c>&amp;diamondsuit;</c>
    /// representing U+02666.
    /// </summary>
    Node diamondsuit { get; }

    /// <summary>
    /// Gets character reference <c>&amp;diams;</c>
    /// representing U+02666.
    /// </summary>
    Node diams { get; }

    /// <summary>
    /// Gets character reference <c>&amp;die;</c>
    /// representing U+000A8.
    /// </summary>
    Node die { get; }

    /// <summary>
    /// Gets character reference <c>&amp;DifferentialD;</c>
    /// representing U+02146.
    /// </summary>
    Node DifferentialD { get; }

    /// <summary>
    /// Gets character reference <c>&amp;digamma;</c>
    /// representing U+003DD.
    /// </summary>
    Node digamma { get; }

    /// <summary>
    /// Gets character reference <c>&amp;disin;</c>
    /// representing U+022F2.
    /// </summary>
    Node disin { get; }

    /// <summary>
    /// Gets character reference <c>&amp;div;</c>
    /// representing U+000F7.
    /// </summary>
    Node div { get; }

    /// <summary>
    /// Gets character reference <c>&amp;divide;</c>
    /// representing U+000F7.
    /// </summary>
    Node divide { get; }

    /// <summary>
    /// Gets character reference <c>&amp;divideontimes;</c>
    /// representing U+022C7.
    /// </summary>
    Node divideontimes { get; }

    /// <summary>
    /// Gets character reference <c>&amp;divonx;</c>
    /// representing U+022C7.
    /// </summary>
    Node divonx { get; }

    /// <summary>
    /// Gets character reference <c>&amp;DJcy;</c>
    /// representing U+00402.
    /// </summary>
    Node DJcy { get; }

    /// <summary>
    /// Gets character reference <c>&amp;djcy;</c>
    /// representing U+00452.
    /// </summary>
    Node djcy { get; }

    /// <summary>
    /// Gets character reference <c>&amp;dlcorn;</c>
    /// representing U+0231E.
    /// </summary>
    Node dlcorn { get; }

    /// <summary>
    /// Gets character reference <c>&amp;dlcrop;</c>
    /// representing U+0230D.
    /// </summary>
    Node dlcrop { get; }

    /// <summary>
    /// Gets character reference <c>&amp;dollar;</c>
    /// representing U+00024.
    /// </summary>
    Node dollar { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Dopf;</c>
    /// representing U+1D53B.
    /// </summary>
    Node Dopf { get; }

    /// <summary>
    /// Gets character reference <c>&amp;dopf;</c>
    /// representing U+1D555.
    /// </summary>
    Node dopf { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Dot;</c>
    /// representing U+000A8.
    /// </summary>
    Node Dot { get; }

    /// <summary>
    /// Gets character reference <c>&amp;dot;</c>
    /// representing U+002D9.
    /// </summary>
    Node dot { get; }

    /// <summary>
    /// Gets character reference <c>&amp;DotDot;</c>
    /// representing U+020DC.
    /// </summary>
    Node DotDot { get; }

    /// <summary>
    /// Gets character reference <c>&amp;doteq;</c>
    /// representing U+02250.
    /// </summary>
    Node doteq { get; }

    /// <summary>
    /// Gets character reference <c>&amp;doteqdot;</c>
    /// representing U+02251.
    /// </summary>
    Node doteqdot { get; }

    /// <summary>
    /// Gets character reference <c>&amp;DotEqual;</c>
    /// representing U+02250.
    /// </summary>
    Node DotEqual { get; }

    /// <summary>
    /// Gets character reference <c>&amp;dotminus;</c>
    /// representing U+02238.
    /// </summary>
    Node dotminus { get; }

    /// <summary>
    /// Gets character reference <c>&amp;dotplus;</c>
    /// representing U+02214.
    /// </summary>
    Node dotplus { get; }

    /// <summary>
    /// Gets character reference <c>&amp;dotsquare;</c>
    /// representing U+022A1.
    /// </summary>
    Node dotsquare { get; }

    /// <summary>
    /// Gets character reference <c>&amp;doublebarwedge;</c>
    /// representing U+02306.
    /// </summary>
    Node doublebarwedge { get; }

    /// <summary>
    /// Gets character reference <c>&amp;DoubleContourIntegral;</c>
    /// representing U+0222F.
    /// </summary>
    Node DoubleContourIntegral { get; }

    /// <summary>
    /// Gets character reference <c>&amp;DoubleDot;</c>
    /// representing U+000A8.
    /// </summary>
    Node DoubleDot { get; }

    /// <summary>
    /// Gets character reference <c>&amp;DoubleDownArrow;</c>
    /// representing U+021D3.
    /// </summary>
    Node DoubleDownArrow { get; }

    /// <summary>
    /// Gets character reference <c>&amp;DoubleLeftArrow;</c>
    /// representing U+021D0.
    /// </summary>
    Node DoubleLeftArrow { get; }

    /// <summary>
    /// Gets character reference <c>&amp;DoubleLeftRightArrow;</c>
    /// representing U+021D4.
    /// </summary>
    Node DoubleLeftRightArrow { get; }

    /// <summary>
    /// Gets character reference <c>&amp;DoubleLeftTee;</c>
    /// representing U+02AE4.
    /// </summary>
    Node DoubleLeftTee { get; }

    /// <summary>
    /// Gets character reference <c>&amp;DoubleLongLeftArrow;</c>
    /// representing U+027F8.
    /// </summary>
    Node DoubleLongLeftArrow { get; }

    /// <summary>
    /// Gets character reference <c>&amp;DoubleLongLeftRightArrow;</c>
    /// representing U+027FA.
    /// </summary>
    Node DoubleLongLeftRightArrow { get; }

    /// <summary>
    /// Gets character reference <c>&amp;DoubleLongRightArrow;</c>
    /// representing U+027F9.
    /// </summary>
    Node DoubleLongRightArrow { get; }

    /// <summary>
    /// Gets character reference <c>&amp;DoubleRightArrow;</c>
    /// representing U+021D2.
    /// </summary>
    Node DoubleRightArrow { get; }

    /// <summary>
    /// Gets character reference <c>&amp;DoubleRightTee;</c>
    /// representing U+022A8.
    /// </summary>
    Node DoubleRightTee { get; }

    /// <summary>
    /// Gets character reference <c>&amp;DoubleUpArrow;</c>
    /// representing U+021D1.
    /// </summary>
    Node DoubleUpArrow { get; }

    /// <summary>
    /// Gets character reference <c>&amp;DoubleUpDownArrow;</c>
    /// representing U+021D5.
    /// </summary>
    Node DoubleUpDownArrow { get; }

    /// <summary>
    /// Gets character reference <c>&amp;DoubleVerticalBar;</c>
    /// representing U+02225.
    /// </summary>
    Node DoubleVerticalBar { get; }

    /// <summary>
    /// Gets character reference <c>&amp;DownArrow;</c>
    /// representing U+02193.
    /// </summary>
    Node DownArrow { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Downarrow;</c>
    /// representing U+021D3.
    /// </summary>
    Node Downarrow { get; }

    /// <summary>
    /// Gets character reference <c>&amp;downarrow;</c>
    /// representing U+02193.
    /// </summary>
    Node downarrow { get; }

    /// <summary>
    /// Gets character reference <c>&amp;DownArrowBar;</c>
    /// representing U+02913.
    /// </summary>
    Node DownArrowBar { get; }

    /// <summary>
    /// Gets character reference <c>&amp;DownArrowUpArrow;</c>
    /// representing U+021F5.
    /// </summary>
    Node DownArrowUpArrow { get; }

    /// <summary>
    /// Gets character reference <c>&amp;DownBreve;</c>
    /// representing U+00311.
    /// </summary>
    Node DownBreve { get; }

    /// <summary>
    /// Gets character reference <c>&amp;downdownarrows;</c>
    /// representing U+021CA.
    /// </summary>
    Node downdownarrows { get; }

    /// <summary>
    /// Gets character reference <c>&amp;downharpoonleft;</c>
    /// representing U+021C3.
    /// </summary>
    Node downharpoonleft { get; }

    /// <summary>
    /// Gets character reference <c>&amp;downharpoonright;</c>
    /// representing U+021C2.
    /// </summary>
    Node downharpoonright { get; }

    /// <summary>
    /// Gets character reference <c>&amp;DownLeftRightVector;</c>
    /// representing U+02950.
    /// </summary>
    Node DownLeftRightVector { get; }

    /// <summary>
    /// Gets character reference <c>&amp;DownLeftTeeVector;</c>
    /// representing U+0295E.
    /// </summary>
    Node DownLeftTeeVector { get; }

    /// <summary>
    /// Gets character reference <c>&amp;DownLeftVector;</c>
    /// representing U+021BD.
    /// </summary>
    Node DownLeftVector { get; }

    /// <summary>
    /// Gets character reference <c>&amp;DownLeftVectorBar;</c>
    /// representing U+02956.
    /// </summary>
    Node DownLeftVectorBar { get; }

    /// <summary>
    /// Gets character reference <c>&amp;DownRightTeeVector;</c>
    /// representing U+0295F.
    /// </summary>
    Node DownRightTeeVector { get; }

    /// <summary>
    /// Gets character reference <c>&amp;DownRightVector;</c>
    /// representing U+021C1.
    /// </summary>
    Node DownRightVector { get; }

    /// <summary>
    /// Gets character reference <c>&amp;DownRightVectorBar;</c>
    /// representing U+02957.
    /// </summary>
    Node DownRightVectorBar { get; }

    /// <summary>
    /// Gets character reference <c>&amp;DownTee;</c>
    /// representing U+022A4.
    /// </summary>
    Node DownTee { get; }

    /// <summary>
    /// Gets character reference <c>&amp;DownTeeArrow;</c>
    /// representing U+021A7.
    /// </summary>
    Node DownTeeArrow { get; }

    /// <summary>
    /// Gets character reference <c>&amp;drbkarow;</c>
    /// representing U+02910.
    /// </summary>
    Node drbkarow { get; }

    /// <summary>
    /// Gets character reference <c>&amp;drcorn;</c>
    /// representing U+0231F.
    /// </summary>
    Node drcorn { get; }

    /// <summary>
    /// Gets character reference <c>&amp;drcrop;</c>
    /// representing U+0230C.
    /// </summary>
    Node drcrop { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Dscr;</c>
    /// representing U+1D49F.
    /// </summary>
    Node Dscr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;dscr;</c>
    /// representing U+1D4B9.
    /// </summary>
    Node dscr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;DScy;</c>
    /// representing U+00405.
    /// </summary>
    Node DScy { get; }

    /// <summary>
    /// Gets character reference <c>&amp;dscy;</c>
    /// representing U+00455.
    /// </summary>
    Node dscy { get; }

    /// <summary>
    /// Gets character reference <c>&amp;dsol;</c>
    /// representing U+029F6.
    /// </summary>
    Node dsol { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Dstrok;</c>
    /// representing U+00110.
    /// </summary>
    Node Dstrok { get; }

    /// <summary>
    /// Gets character reference <c>&amp;dstrok;</c>
    /// representing U+00111.
    /// </summary>
    Node dstrok { get; }

    /// <summary>
    /// Gets character reference <c>&amp;dtdot;</c>
    /// representing U+022F1.
    /// </summary>
    Node dtdot { get; }

    /// <summary>
    /// Gets character reference <c>&amp;dtri;</c>
    /// representing U+025BF.
    /// </summary>
    Node dtri { get; }

    /// <summary>
    /// Gets character reference <c>&amp;dtrif;</c>
    /// representing U+025BE.
    /// </summary>
    Node dtrif { get; }

    /// <summary>
    /// Gets character reference <c>&amp;duarr;</c>
    /// representing U+021F5.
    /// </summary>
    Node duarr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;duhar;</c>
    /// representing U+0296F.
    /// </summary>
    Node duhar { get; }

    /// <summary>
    /// Gets character reference <c>&amp;dwangle;</c>
    /// representing U+029A6.
    /// </summary>
    Node dwangle { get; }

    /// <summary>
    /// Gets character reference <c>&amp;DZcy;</c>
    /// representing U+0040F.
    /// </summary>
    Node DZcy { get; }

    /// <summary>
    /// Gets character reference <c>&amp;dzcy;</c>
    /// representing U+0045F.
    /// </summary>
    Node dzcy { get; }

    /// <summary>
    /// Gets character reference <c>&amp;dzigrarr;</c>
    /// representing U+027FF.
    /// </summary>
    Node dzigrarr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Eacute;</c>
    /// representing U+000C9.
    /// </summary>
    Node Eacute { get; }

    /// <summary>
    /// Gets character reference <c>&amp;eacute;</c>
    /// representing U+000E9.
    /// </summary>
    Node eacute { get; }

    /// <summary>
    /// Gets character reference <c>&amp;easter;</c>
    /// representing U+02A6E.
    /// </summary>
    Node easter { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Ecaron;</c>
    /// representing U+0011A.
    /// </summary>
    Node Ecaron { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ecaron;</c>
    /// representing U+0011B.
    /// </summary>
    Node ecaron { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ecir;</c>
    /// representing U+02256.
    /// </summary>
    Node ecir { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Ecirc;</c>
    /// representing U+000CA.
    /// </summary>
    Node Ecirc { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ecirc;</c>
    /// representing U+000EA.
    /// </summary>
    Node ecirc { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ecolon;</c>
    /// representing U+02255.
    /// </summary>
    Node ecolon { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Ecy;</c>
    /// representing U+0042D.
    /// </summary>
    Node Ecy { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ecy;</c>
    /// representing U+0044D.
    /// </summary>
    Node ecy { get; }

    /// <summary>
    /// Gets character reference <c>&amp;eDDot;</c>
    /// representing U+02A77.
    /// </summary>
    Node eDDot { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Edot;</c>
    /// representing U+00116.
    /// </summary>
    Node Edot { get; }

    /// <summary>
    /// Gets character reference <c>&amp;eDot;</c>
    /// representing U+02251.
    /// </summary>
    Node eDot { get; }

    /// <summary>
    /// Gets character reference <c>&amp;edot;</c>
    /// representing U+00117.
    /// </summary>
    Node edot { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ee;</c>
    /// representing U+02147.
    /// </summary>
    Node ee { get; }

    /// <summary>
    /// Gets character reference <c>&amp;efDot;</c>
    /// representing U+02252.
    /// </summary>
    Node efDot { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Efr;</c>
    /// representing U+1D508.
    /// </summary>
    Node Efr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;efr;</c>
    /// representing U+1D522.
    /// </summary>
    Node efr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;eg;</c>
    /// representing U+02A9A.
    /// </summary>
    Node eg { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Egrave;</c>
    /// representing U+000C8.
    /// </summary>
    Node Egrave { get; }

    /// <summary>
    /// Gets character reference <c>&amp;egrave;</c>
    /// representing U+000E8.
    /// </summary>
    Node egrave { get; }

    /// <summary>
    /// Gets character reference <c>&amp;egs;</c>
    /// representing U+02A96.
    /// </summary>
    Node egs { get; }

    /// <summary>
    /// Gets character reference <c>&amp;egsdot;</c>
    /// representing U+02A98.
    /// </summary>
    Node egsdot { get; }

    /// <summary>
    /// Gets character reference <c>&amp;el;</c>
    /// representing U+02A99.
    /// </summary>
    Node el { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Element;</c>
    /// representing U+02208.
    /// </summary>
    Node Element { get; }

    /// <summary>
    /// Gets character reference <c>&amp;elinters;</c>
    /// representing U+023E7.
    /// </summary>
    Node elinters { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ell;</c>
    /// representing U+02113.
    /// </summary>
    Node ell { get; }

    /// <summary>
    /// Gets character reference <c>&amp;els;</c>
    /// representing U+02A95.
    /// </summary>
    Node els { get; }

    /// <summary>
    /// Gets character reference <c>&amp;elsdot;</c>
    /// representing U+02A97.
    /// </summary>
    Node elsdot { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Emacr;</c>
    /// representing U+00112.
    /// </summary>
    Node Emacr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;emacr;</c>
    /// representing U+00113.
    /// </summary>
    Node emacr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;empty;</c>
    /// representing U+02205.
    /// </summary>
    Node empty { get; }

    /// <summary>
    /// Gets character reference <c>&amp;emptyset;</c>
    /// representing U+02205.
    /// </summary>
    Node emptyset { get; }

    /// <summary>
    /// Gets character reference <c>&amp;EmptySmallSquare;</c>
    /// representing U+025FB.
    /// </summary>
    Node EmptySmallSquare { get; }

    /// <summary>
    /// Gets character reference <c>&amp;emptyv;</c>
    /// representing U+02205.
    /// </summary>
    Node emptyv { get; }

    /// <summary>
    /// Gets character reference <c>&amp;EmptyVerySmallSquare;</c>
    /// representing U+025AB.
    /// </summary>
    Node EmptyVerySmallSquare { get; }

    /// <summary>
    /// Gets character reference <c>&amp;emsp;</c>
    /// representing U+02003.
    /// </summary>
    Node emsp { get; }

    /// <summary>
    /// Gets character reference <c>&amp;emsp13;</c>
    /// representing U+02004.
    /// </summary>
    Node emsp13 { get; }

    /// <summary>
    /// Gets character reference <c>&amp;emsp14;</c>
    /// representing U+02005.
    /// </summary>
    Node emsp14 { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ENG;</c>
    /// representing U+0014A.
    /// </summary>
    Node ENG { get; }

    /// <summary>
    /// Gets character reference <c>&amp;eng;</c>
    /// representing U+0014B.
    /// </summary>
    Node eng { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ensp;</c>
    /// representing U+02002.
    /// </summary>
    Node ensp { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Eogon;</c>
    /// representing U+00118.
    /// </summary>
    Node Eogon { get; }

    /// <summary>
    /// Gets character reference <c>&amp;eogon;</c>
    /// representing U+00119.
    /// </summary>
    Node eogon { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Eopf;</c>
    /// representing U+1D53C.
    /// </summary>
    Node Eopf { get; }

    /// <summary>
    /// Gets character reference <c>&amp;eopf;</c>
    /// representing U+1D556.
    /// </summary>
    Node eopf { get; }

    /// <summary>
    /// Gets character reference <c>&amp;epar;</c>
    /// representing U+022D5.
    /// </summary>
    Node epar { get; }

    /// <summary>
    /// Gets character reference <c>&amp;eparsl;</c>
    /// representing U+029E3.
    /// </summary>
    Node eparsl { get; }

    /// <summary>
    /// Gets character reference <c>&amp;eplus;</c>
    /// representing U+02A71.
    /// </summary>
    Node eplus { get; }

    /// <summary>
    /// Gets character reference <c>&amp;epsi;</c>
    /// representing U+003B5.
    /// </summary>
    Node epsi { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Epsilon;</c>
    /// representing U+00395.
    /// </summary>
    Node Epsilon { get; }

    /// <summary>
    /// Gets character reference <c>&amp;epsilon;</c>
    /// representing U+003B5.
    /// </summary>
    Node epsilon { get; }

    /// <summary>
    /// Gets character reference <c>&amp;epsiv;</c>
    /// representing U+003F5.
    /// </summary>
    Node epsiv { get; }

    /// <summary>
    /// Gets character reference <c>&amp;eqcirc;</c>
    /// representing U+02256.
    /// </summary>
    Node eqcirc { get; }

    /// <summary>
    /// Gets character reference <c>&amp;eqcolon;</c>
    /// representing U+02255.
    /// </summary>
    Node eqcolon { get; }

    /// <summary>
    /// Gets character reference <c>&amp;eqsim;</c>
    /// representing U+02242.
    /// </summary>
    Node eqsim { get; }

    /// <summary>
    /// Gets character reference <c>&amp;eqslantgtr;</c>
    /// representing U+02A96.
    /// </summary>
    Node eqslantgtr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;eqslantless;</c>
    /// representing U+02A95.
    /// </summary>
    Node eqslantless { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Equal;</c>
    /// representing U+02A75.
    /// </summary>
    Node Equal { get; }

    /// <summary>
    /// Gets character reference <c>&amp;equals;</c>
    /// representing U+0003D.
    /// </summary>
    Node equals { get; }

    /// <summary>
    /// Gets character reference <c>&amp;EqualTilde;</c>
    /// representing U+02242.
    /// </summary>
    Node EqualTilde { get; }

    /// <summary>
    /// Gets character reference <c>&amp;equest;</c>
    /// representing U+0225F.
    /// </summary>
    Node equest { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Equilibrium;</c>
    /// representing U+021CC.
    /// </summary>
    Node Equilibrium { get; }

    /// <summary>
    /// Gets character reference <c>&amp;equiv;</c>
    /// representing U+02261.
    /// </summary>
    Node equiv { get; }

    /// <summary>
    /// Gets character reference <c>&amp;equivDD;</c>
    /// representing U+02A78.
    /// </summary>
    Node equivDD { get; }

    /// <summary>
    /// Gets character reference <c>&amp;eqvparsl;</c>
    /// representing U+029E5.
    /// </summary>
    Node eqvparsl { get; }

    /// <summary>
    /// Gets character reference <c>&amp;erarr;</c>
    /// representing U+02971.
    /// </summary>
    Node erarr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;erDot;</c>
    /// representing U+02253.
    /// </summary>
    Node erDot { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Escr;</c>
    /// representing U+02130.
    /// </summary>
    Node Escr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;escr;</c>
    /// representing U+0212F.
    /// </summary>
    Node escr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;esdot;</c>
    /// representing U+02250.
    /// </summary>
    Node esdot { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Esim;</c>
    /// representing U+02A73.
    /// </summary>
    Node Esim { get; }

    /// <summary>
    /// Gets character reference <c>&amp;esim;</c>
    /// representing U+02242.
    /// </summary>
    Node esim { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Eta;</c>
    /// representing U+00397.
    /// </summary>
    Node Eta { get; }

    /// <summary>
    /// Gets character reference <c>&amp;eta;</c>
    /// representing U+003B7.
    /// </summary>
    Node eta { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ETH;</c>
    /// representing U+000D0.
    /// </summary>
    Node ETH { get; }

    /// <summary>
    /// Gets character reference <c>&amp;eth;</c>
    /// representing U+000F0.
    /// </summary>
    Node eth { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Euml;</c>
    /// representing U+000CB.
    /// </summary>
    Node Euml { get; }

    /// <summary>
    /// Gets character reference <c>&amp;euml;</c>
    /// representing U+000EB.
    /// </summary>
    Node euml { get; }

    /// <summary>
    /// Gets character reference <c>&amp;euro;</c>
    /// representing U+020AC.
    /// </summary>
    Node euro { get; }

    /// <summary>
    /// Gets character reference <c>&amp;excl;</c>
    /// representing U+00021.
    /// </summary>
    Node excl { get; }

    /// <summary>
    /// Gets character reference <c>&amp;exist;</c>
    /// representing U+02203.
    /// </summary>
    Node exist { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Exists;</c>
    /// representing U+02203.
    /// </summary>
    Node Exists { get; }

    /// <summary>
    /// Gets character reference <c>&amp;expectation;</c>
    /// representing U+02130.
    /// </summary>
    Node expectation { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ExponentialE;</c>
    /// representing U+02147.
    /// </summary>
    Node ExponentialE { get; }

    /// <summary>
    /// Gets character reference <c>&amp;exponentiale;</c>
    /// representing U+02147.
    /// </summary>
    Node exponentiale { get; }

    /// <summary>
    /// Gets character reference <c>&amp;fallingdotseq;</c>
    /// representing U+02252.
    /// </summary>
    Node fallingdotseq { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Fcy;</c>
    /// representing U+00424.
    /// </summary>
    Node Fcy { get; }

    /// <summary>
    /// Gets character reference <c>&amp;fcy;</c>
    /// representing U+00444.
    /// </summary>
    Node fcy { get; }

    /// <summary>
    /// Gets character reference <c>&amp;female;</c>
    /// representing U+02640.
    /// </summary>
    Node female { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ffilig;</c>
    /// representing U+0FB03.
    /// </summary>
    Node ffilig { get; }

    /// <summary>
    /// Gets character reference <c>&amp;fflig;</c>
    /// representing U+0FB00.
    /// </summary>
    Node fflig { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ffllig;</c>
    /// representing U+0FB04.
    /// </summary>
    Node ffllig { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Ffr;</c>
    /// representing U+1D509.
    /// </summary>
    Node Ffr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ffr;</c>
    /// representing U+1D523.
    /// </summary>
    Node ffr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;filig;</c>
    /// representing U+0FB01.
    /// </summary>
    Node filig { get; }

    /// <summary>
    /// Gets character reference <c>&amp;FilledSmallSquare;</c>
    /// representing U+025FC.
    /// </summary>
    Node FilledSmallSquare { get; }

    /// <summary>
    /// Gets character reference <c>&amp;FilledVerySmallSquare;</c>
    /// representing U+025AA.
    /// </summary>
    Node FilledVerySmallSquare { get; }

    /// <summary>
    /// Gets character reference <c>&amp;fjlig;</c>
    /// representing U+00066 U+0006A.
    /// </summary>
    Node fjlig { get; }

    /// <summary>
    /// Gets character reference <c>&amp;flat;</c>
    /// representing U+0266D.
    /// </summary>
    Node flat { get; }

    /// <summary>
    /// Gets character reference <c>&amp;fllig;</c>
    /// representing U+0FB02.
    /// </summary>
    Node fllig { get; }

    /// <summary>
    /// Gets character reference <c>&amp;fltns;</c>
    /// representing U+025B1.
    /// </summary>
    Node fltns { get; }

    /// <summary>
    /// Gets character reference <c>&amp;fnof;</c>
    /// representing U+00192.
    /// </summary>
    Node fnof { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Fopf;</c>
    /// representing U+1D53D.
    /// </summary>
    Node Fopf { get; }

    /// <summary>
    /// Gets character reference <c>&amp;fopf;</c>
    /// representing U+1D557.
    /// </summary>
    Node fopf { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ForAll;</c>
    /// representing U+02200.
    /// </summary>
    Node ForAll { get; }

    /// <summary>
    /// Gets character reference <c>&amp;forall;</c>
    /// representing U+02200.
    /// </summary>
    Node forall { get; }

    /// <summary>
    /// Gets character reference <c>&amp;fork;</c>
    /// representing U+022D4.
    /// </summary>
    Node fork { get; }

    /// <summary>
    /// Gets character reference <c>&amp;forkv;</c>
    /// representing U+02AD9.
    /// </summary>
    Node forkv { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Fouriertrf;</c>
    /// representing U+02131.
    /// </summary>
    Node Fouriertrf { get; }

    /// <summary>
    /// Gets character reference <c>&amp;fpartint;</c>
    /// representing U+02A0D.
    /// </summary>
    Node fpartint { get; }

    /// <summary>
    /// Gets character reference <c>&amp;frac12;</c>
    /// representing U+000BD.
    /// </summary>
    Node frac12 { get; }

    /// <summary>
    /// Gets character reference <c>&amp;frac13;</c>
    /// representing U+02153.
    /// </summary>
    Node frac13 { get; }

    /// <summary>
    /// Gets character reference <c>&amp;frac14;</c>
    /// representing U+000BC.
    /// </summary>
    Node frac14 { get; }

    /// <summary>
    /// Gets character reference <c>&amp;frac15;</c>
    /// representing U+02155.
    /// </summary>
    Node frac15 { get; }

    /// <summary>
    /// Gets character reference <c>&amp;frac16;</c>
    /// representing U+02159.
    /// </summary>
    Node frac16 { get; }

    /// <summary>
    /// Gets character reference <c>&amp;frac18;</c>
    /// representing U+0215B.
    /// </summary>
    Node frac18 { get; }

    /// <summary>
    /// Gets character reference <c>&amp;frac23;</c>
    /// representing U+02154.
    /// </summary>
    Node frac23 { get; }

    /// <summary>
    /// Gets character reference <c>&amp;frac25;</c>
    /// representing U+02156.
    /// </summary>
    Node frac25 { get; }

    /// <summary>
    /// Gets character reference <c>&amp;frac34;</c>
    /// representing U+000BE.
    /// </summary>
    Node frac34 { get; }

    /// <summary>
    /// Gets character reference <c>&amp;frac35;</c>
    /// representing U+02157.
    /// </summary>
    Node frac35 { get; }

    /// <summary>
    /// Gets character reference <c>&amp;frac38;</c>
    /// representing U+0215C.
    /// </summary>
    Node frac38 { get; }

    /// <summary>
    /// Gets character reference <c>&amp;frac45;</c>
    /// representing U+02158.
    /// </summary>
    Node frac45 { get; }

    /// <summary>
    /// Gets character reference <c>&amp;frac56;</c>
    /// representing U+0215A.
    /// </summary>
    Node frac56 { get; }

    /// <summary>
    /// Gets character reference <c>&amp;frac58;</c>
    /// representing U+0215D.
    /// </summary>
    Node frac58 { get; }

    /// <summary>
    /// Gets character reference <c>&amp;frac78;</c>
    /// representing U+0215E.
    /// </summary>
    Node frac78 { get; }

    /// <summary>
    /// Gets character reference <c>&amp;frasl;</c>
    /// representing U+02044.
    /// </summary>
    Node frasl { get; }

    /// <summary>
    /// Gets character reference <c>&amp;frown;</c>
    /// representing U+02322.
    /// </summary>
    Node frown { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Fscr;</c>
    /// representing U+02131.
    /// </summary>
    Node Fscr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;fscr;</c>
    /// representing U+1D4BB.
    /// </summary>
    Node fscr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;gacute;</c>
    /// representing U+001F5.
    /// </summary>
    Node gacute { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Gamma;</c>
    /// representing U+00393.
    /// </summary>
    Node Gamma { get; }

    /// <summary>
    /// Gets character reference <c>&amp;gamma;</c>
    /// representing U+003B3.
    /// </summary>
    Node gamma { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Gammad;</c>
    /// representing U+003DC.
    /// </summary>
    Node Gammad { get; }

    /// <summary>
    /// Gets character reference <c>&amp;gammad;</c>
    /// representing U+003DD.
    /// </summary>
    Node gammad { get; }

    /// <summary>
    /// Gets character reference <c>&amp;gap;</c>
    /// representing U+02A86.
    /// </summary>
    Node gap { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Gbreve;</c>
    /// representing U+0011E.
    /// </summary>
    Node Gbreve { get; }

    /// <summary>
    /// Gets character reference <c>&amp;gbreve;</c>
    /// representing U+0011F.
    /// </summary>
    Node gbreve { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Gcedil;</c>
    /// representing U+00122.
    /// </summary>
    Node Gcedil { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Gcirc;</c>
    /// representing U+0011C.
    /// </summary>
    Node Gcirc { get; }

    /// <summary>
    /// Gets character reference <c>&amp;gcirc;</c>
    /// representing U+0011D.
    /// </summary>
    Node gcirc { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Gcy;</c>
    /// representing U+00413.
    /// </summary>
    Node Gcy { get; }

    /// <summary>
    /// Gets character reference <c>&amp;gcy;</c>
    /// representing U+00433.
    /// </summary>
    Node gcy { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Gdot;</c>
    /// representing U+00120.
    /// </summary>
    Node Gdot { get; }

    /// <summary>
    /// Gets character reference <c>&amp;gdot;</c>
    /// representing U+00121.
    /// </summary>
    Node gdot { get; }

    /// <summary>
    /// Gets character reference <c>&amp;gE;</c>
    /// representing U+02267.
    /// </summary>
    Node gE { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ge;</c>
    /// representing U+02265.
    /// </summary>
    Node ge { get; }

    /// <summary>
    /// Gets character reference <c>&amp;gEl;</c>
    /// representing U+02A8C.
    /// </summary>
    Node gEl { get; }

    /// <summary>
    /// Gets character reference <c>&amp;gel;</c>
    /// representing U+022DB.
    /// </summary>
    Node gel { get; }

    /// <summary>
    /// Gets character reference <c>&amp;geq;</c>
    /// representing U+02265.
    /// </summary>
    Node geq { get; }

    /// <summary>
    /// Gets character reference <c>&amp;geqq;</c>
    /// representing U+02267.
    /// </summary>
    Node geqq { get; }

    /// <summary>
    /// Gets character reference <c>&amp;geqslant;</c>
    /// representing U+02A7E.
    /// </summary>
    Node geqslant { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ges;</c>
    /// representing U+02A7E.
    /// </summary>
    Node ges { get; }

    /// <summary>
    /// Gets character reference <c>&amp;gescc;</c>
    /// representing U+02AA9.
    /// </summary>
    Node gescc { get; }

    /// <summary>
    /// Gets character reference <c>&amp;gesdot;</c>
    /// representing U+02A80.
    /// </summary>
    Node gesdot { get; }

    /// <summary>
    /// Gets character reference <c>&amp;gesdoto;</c>
    /// representing U+02A82.
    /// </summary>
    Node gesdoto { get; }

    /// <summary>
    /// Gets character reference <c>&amp;gesdotol;</c>
    /// representing U+02A84.
    /// </summary>
    Node gesdotol { get; }

    /// <summary>
    /// Gets character reference <c>&amp;gesl;</c>
    /// representing U+022DB U+0FE00.
    /// </summary>
    Node gesl { get; }

    /// <summary>
    /// Gets character reference <c>&amp;gesles;</c>
    /// representing U+02A94.
    /// </summary>
    Node gesles { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Gfr;</c>
    /// representing U+1D50A.
    /// </summary>
    Node Gfr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;gfr;</c>
    /// representing U+1D524.
    /// </summary>
    Node gfr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Gg;</c>
    /// representing U+022D9.
    /// </summary>
    Node Gg { get; }

    /// <summary>
    /// Gets character reference <c>&amp;gg;</c>
    /// representing U+0226B.
    /// </summary>
    Node gg { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ggg;</c>
    /// representing U+022D9.
    /// </summary>
    Node ggg { get; }

    /// <summary>
    /// Gets character reference <c>&amp;gimel;</c>
    /// representing U+02137.
    /// </summary>
    Node gimel { get; }

    /// <summary>
    /// Gets character reference <c>&amp;GJcy;</c>
    /// representing U+00403.
    /// </summary>
    Node GJcy { get; }

    /// <summary>
    /// Gets character reference <c>&amp;gjcy;</c>
    /// representing U+00453.
    /// </summary>
    Node gjcy { get; }

    /// <summary>
    /// Gets character reference <c>&amp;gl;</c>
    /// representing U+02277.
    /// </summary>
    Node gl { get; }

    /// <summary>
    /// Gets character reference <c>&amp;gla;</c>
    /// representing U+02AA5.
    /// </summary>
    Node gla { get; }

    /// <summary>
    /// Gets character reference <c>&amp;glE;</c>
    /// representing U+02A92.
    /// </summary>
    Node glE { get; }

    /// <summary>
    /// Gets character reference <c>&amp;glj;</c>
    /// representing U+02AA4.
    /// </summary>
    Node glj { get; }

    /// <summary>
    /// Gets character reference <c>&amp;gnap;</c>
    /// representing U+02A8A.
    /// </summary>
    Node gnap { get; }

    /// <summary>
    /// Gets character reference <c>&amp;gnapprox;</c>
    /// representing U+02A8A.
    /// </summary>
    Node gnapprox { get; }

    /// <summary>
    /// Gets character reference <c>&amp;gnE;</c>
    /// representing U+02269.
    /// </summary>
    Node gnE { get; }

    /// <summary>
    /// Gets character reference <c>&amp;gne;</c>
    /// representing U+02A88.
    /// </summary>
    Node gne { get; }

    /// <summary>
    /// Gets character reference <c>&amp;gneq;</c>
    /// representing U+02A88.
    /// </summary>
    Node gneq { get; }

    /// <summary>
    /// Gets character reference <c>&amp;gneqq;</c>
    /// representing U+02269.
    /// </summary>
    Node gneqq { get; }

    /// <summary>
    /// Gets character reference <c>&amp;gnsim;</c>
    /// representing U+022E7.
    /// </summary>
    Node gnsim { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Gopf;</c>
    /// representing U+1D53E.
    /// </summary>
    Node Gopf { get; }

    /// <summary>
    /// Gets character reference <c>&amp;gopf;</c>
    /// representing U+1D558.
    /// </summary>
    Node gopf { get; }

    /// <summary>
    /// Gets character reference <c>&amp;grave;</c>
    /// representing U+00060.
    /// </summary>
    Node grave { get; }

    /// <summary>
    /// Gets character reference <c>&amp;GreaterEqual;</c>
    /// representing U+02265.
    /// </summary>
    Node GreaterEqual { get; }

    /// <summary>
    /// Gets character reference <c>&amp;GreaterEqualLess;</c>
    /// representing U+022DB.
    /// </summary>
    Node GreaterEqualLess { get; }

    /// <summary>
    /// Gets character reference <c>&amp;GreaterFullEqual;</c>
    /// representing U+02267.
    /// </summary>
    Node GreaterFullEqual { get; }

    /// <summary>
    /// Gets character reference <c>&amp;GreaterGreater;</c>
    /// representing U+02AA2.
    /// </summary>
    Node GreaterGreater { get; }

    /// <summary>
    /// Gets character reference <c>&amp;GreaterLess;</c>
    /// representing U+02277.
    /// </summary>
    Node GreaterLess { get; }

    /// <summary>
    /// Gets character reference <c>&amp;GreaterSlantEqual;</c>
    /// representing U+02A7E.
    /// </summary>
    Node GreaterSlantEqual { get; }

    /// <summary>
    /// Gets character reference <c>&amp;GreaterTilde;</c>
    /// representing U+02273.
    /// </summary>
    Node GreaterTilde { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Gscr;</c>
    /// representing U+1D4A2.
    /// </summary>
    Node Gscr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;gscr;</c>
    /// representing U+0210A.
    /// </summary>
    Node gscr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;gsim;</c>
    /// representing U+02273.
    /// </summary>
    Node gsim { get; }

    /// <summary>
    /// Gets character reference <c>&amp;gsime;</c>
    /// representing U+02A8E.
    /// </summary>
    Node gsime { get; }

    /// <summary>
    /// Gets character reference <c>&amp;gsiml;</c>
    /// representing U+02A90.
    /// </summary>
    Node gsiml { get; }

    /// <summary>
    /// Gets character reference <c>&amp;GT;</c>
    /// representing U+0003E.
    /// </summary>
    Node GT { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Gt;</c>
    /// representing U+0226B.
    /// </summary>
    Node Gt { get; }

    /// <summary>
    /// Gets character reference <c>&amp;gt;</c>
    /// representing U+0003E.
    /// </summary>
    Node gt { get; }

    /// <summary>
    /// Gets character reference <c>&amp;gtcc;</c>
    /// representing U+02AA7.
    /// </summary>
    Node gtcc { get; }

    /// <summary>
    /// Gets character reference <c>&amp;gtcir;</c>
    /// representing U+02A7A.
    /// </summary>
    Node gtcir { get; }

    /// <summary>
    /// Gets character reference <c>&amp;gtdot;</c>
    /// representing U+022D7.
    /// </summary>
    Node gtdot { get; }

    /// <summary>
    /// Gets character reference <c>&amp;gtlPar;</c>
    /// representing U+02995.
    /// </summary>
    Node gtlPar { get; }

    /// <summary>
    /// Gets character reference <c>&amp;gtquest;</c>
    /// representing U+02A7C.
    /// </summary>
    Node gtquest { get; }

    /// <summary>
    /// Gets character reference <c>&amp;gtrapprox;</c>
    /// representing U+02A86.
    /// </summary>
    Node gtrapprox { get; }

    /// <summary>
    /// Gets character reference <c>&amp;gtrarr;</c>
    /// representing U+02978.
    /// </summary>
    Node gtrarr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;gtrdot;</c>
    /// representing U+022D7.
    /// </summary>
    Node gtrdot { get; }

    /// <summary>
    /// Gets character reference <c>&amp;gtreqless;</c>
    /// representing U+022DB.
    /// </summary>
    Node gtreqless { get; }

    /// <summary>
    /// Gets character reference <c>&amp;gtreqqless;</c>
    /// representing U+02A8C.
    /// </summary>
    Node gtreqqless { get; }

    /// <summary>
    /// Gets character reference <c>&amp;gtrless;</c>
    /// representing U+02277.
    /// </summary>
    Node gtrless { get; }

    /// <summary>
    /// Gets character reference <c>&amp;gtrsim;</c>
    /// representing U+02273.
    /// </summary>
    Node gtrsim { get; }

    /// <summary>
    /// Gets character reference <c>&amp;gvertneqq;</c>
    /// representing U+02269 U+0FE00.
    /// </summary>
    Node gvertneqq { get; }

    /// <summary>
    /// Gets character reference <c>&amp;gvnE;</c>
    /// representing U+02269 U+0FE00.
    /// </summary>
    Node gvnE { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Hacek;</c>
    /// representing U+002C7.
    /// </summary>
    Node Hacek { get; }

    /// <summary>
    /// Gets character reference <c>&amp;hairsp;</c>
    /// representing U+0200A.
    /// </summary>
    Node hairsp { get; }

    /// <summary>
    /// Gets character reference <c>&amp;half;</c>
    /// representing U+000BD.
    /// </summary>
    Node half { get; }

    /// <summary>
    /// Gets character reference <c>&amp;hamilt;</c>
    /// representing U+0210B.
    /// </summary>
    Node hamilt { get; }

    /// <summary>
    /// Gets character reference <c>&amp;HARDcy;</c>
    /// representing U+0042A.
    /// </summary>
    Node HARDcy { get; }

    /// <summary>
    /// Gets character reference <c>&amp;hardcy;</c>
    /// representing U+0044A.
    /// </summary>
    Node hardcy { get; }

    /// <summary>
    /// Gets character reference <c>&amp;hArr;</c>
    /// representing U+021D4.
    /// </summary>
    Node hArr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;harr;</c>
    /// representing U+02194.
    /// </summary>
    Node harr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;harrcir;</c>
    /// representing U+02948.
    /// </summary>
    Node harrcir { get; }

    /// <summary>
    /// Gets character reference <c>&amp;harrw;</c>
    /// representing U+021AD.
    /// </summary>
    Node harrw { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Hat;</c>
    /// representing U+0005E.
    /// </summary>
    Node Hat { get; }

    /// <summary>
    /// Gets character reference <c>&amp;hbar;</c>
    /// representing U+0210F.
    /// </summary>
    Node hbar { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Hcirc;</c>
    /// representing U+00124.
    /// </summary>
    Node Hcirc { get; }

    /// <summary>
    /// Gets character reference <c>&amp;hcirc;</c>
    /// representing U+00125.
    /// </summary>
    Node hcirc { get; }

    /// <summary>
    /// Gets character reference <c>&amp;hearts;</c>
    /// representing U+02665.
    /// </summary>
    Node hearts { get; }

    /// <summary>
    /// Gets character reference <c>&amp;heartsuit;</c>
    /// representing U+02665.
    /// </summary>
    Node heartsuit { get; }

    /// <summary>
    /// Gets character reference <c>&amp;hellip;</c>
    /// representing U+02026.
    /// </summary>
    Node hellip { get; }

    /// <summary>
    /// Gets character reference <c>&amp;hercon;</c>
    /// representing U+022B9.
    /// </summary>
    Node hercon { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Hfr;</c>
    /// representing U+0210C.
    /// </summary>
    Node Hfr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;hfr;</c>
    /// representing U+1D525.
    /// </summary>
    Node hfr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;HilbertSpace;</c>
    /// representing U+0210B.
    /// </summary>
    Node HilbertSpace { get; }

    /// <summary>
    /// Gets character reference <c>&amp;hksearow;</c>
    /// representing U+02925.
    /// </summary>
    Node hksearow { get; }

    /// <summary>
    /// Gets character reference <c>&amp;hkswarow;</c>
    /// representing U+02926.
    /// </summary>
    Node hkswarow { get; }

    /// <summary>
    /// Gets character reference <c>&amp;hoarr;</c>
    /// representing U+021FF.
    /// </summary>
    Node hoarr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;homtht;</c>
    /// representing U+0223B.
    /// </summary>
    Node homtht { get; }

    /// <summary>
    /// Gets character reference <c>&amp;hookleftarrow;</c>
    /// representing U+021A9.
    /// </summary>
    Node hookleftarrow { get; }

    /// <summary>
    /// Gets character reference <c>&amp;hookrightarrow;</c>
    /// representing U+021AA.
    /// </summary>
    Node hookrightarrow { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Hopf;</c>
    /// representing U+0210D.
    /// </summary>
    Node Hopf { get; }

    /// <summary>
    /// Gets character reference <c>&amp;hopf;</c>
    /// representing U+1D559.
    /// </summary>
    Node hopf { get; }

    /// <summary>
    /// Gets character reference <c>&amp;horbar;</c>
    /// representing U+02015.
    /// </summary>
    Node horbar { get; }

    /// <summary>
    /// Gets character reference <c>&amp;HorizontalLine;</c>
    /// representing U+02500.
    /// </summary>
    Node HorizontalLine { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Hscr;</c>
    /// representing U+0210B.
    /// </summary>
    Node Hscr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;hscr;</c>
    /// representing U+1D4BD.
    /// </summary>
    Node hscr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;hslash;</c>
    /// representing U+0210F.
    /// </summary>
    Node hslash { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Hstrok;</c>
    /// representing U+00126.
    /// </summary>
    Node Hstrok { get; }

    /// <summary>
    /// Gets character reference <c>&amp;hstrok;</c>
    /// representing U+00127.
    /// </summary>
    Node hstrok { get; }

    /// <summary>
    /// Gets character reference <c>&amp;HumpDownHump;</c>
    /// representing U+0224E.
    /// </summary>
    Node HumpDownHump { get; }

    /// <summary>
    /// Gets character reference <c>&amp;HumpEqual;</c>
    /// representing U+0224F.
    /// </summary>
    Node HumpEqual { get; }

    /// <summary>
    /// Gets character reference <c>&amp;hybull;</c>
    /// representing U+02043.
    /// </summary>
    Node hybull { get; }

    /// <summary>
    /// Gets character reference <c>&amp;hyphen;</c>
    /// representing U+02010.
    /// </summary>
    Node hyphen { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Iacute;</c>
    /// representing U+000CD.
    /// </summary>
    Node Iacute { get; }

    /// <summary>
    /// Gets character reference <c>&amp;iacute;</c>
    /// representing U+000ED.
    /// </summary>
    Node iacute { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ic;</c>
    /// representing U+02063.
    /// </summary>
    Node ic { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Icirc;</c>
    /// representing U+000CE.
    /// </summary>
    Node Icirc { get; }

    /// <summary>
    /// Gets character reference <c>&amp;icirc;</c>
    /// representing U+000EE.
    /// </summary>
    Node icirc { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Icy;</c>
    /// representing U+00418.
    /// </summary>
    Node Icy { get; }

    /// <summary>
    /// Gets character reference <c>&amp;icy;</c>
    /// representing U+00438.
    /// </summary>
    Node icy { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Idot;</c>
    /// representing U+00130.
    /// </summary>
    Node Idot { get; }

    /// <summary>
    /// Gets character reference <c>&amp;IEcy;</c>
    /// representing U+00415.
    /// </summary>
    Node IEcy { get; }

    /// <summary>
    /// Gets character reference <c>&amp;iecy;</c>
    /// representing U+00435.
    /// </summary>
    Node iecy { get; }

    /// <summary>
    /// Gets character reference <c>&amp;iexcl;</c>
    /// representing U+000A1.
    /// </summary>
    Node iexcl { get; }

    /// <summary>
    /// Gets character reference <c>&amp;iff;</c>
    /// representing U+021D4.
    /// </summary>
    Node iff { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Ifr;</c>
    /// representing U+02111.
    /// </summary>
    Node Ifr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ifr;</c>
    /// representing U+1D526.
    /// </summary>
    Node ifr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Igrave;</c>
    /// representing U+000CC.
    /// </summary>
    Node Igrave { get; }

    /// <summary>
    /// Gets character reference <c>&amp;igrave;</c>
    /// representing U+000EC.
    /// </summary>
    Node igrave { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ii;</c>
    /// representing U+02148.
    /// </summary>
    Node ii { get; }

    /// <summary>
    /// Gets character reference <c>&amp;iiiint;</c>
    /// representing U+02A0C.
    /// </summary>
    Node iiiint { get; }

    /// <summary>
    /// Gets character reference <c>&amp;iiint;</c>
    /// representing U+0222D.
    /// </summary>
    Node iiint { get; }

    /// <summary>
    /// Gets character reference <c>&amp;iinfin;</c>
    /// representing U+029DC.
    /// </summary>
    Node iinfin { get; }

    /// <summary>
    /// Gets character reference <c>&amp;iiota;</c>
    /// representing U+02129.
    /// </summary>
    Node iiota { get; }

    /// <summary>
    /// Gets character reference <c>&amp;IJlig;</c>
    /// representing U+00132.
    /// </summary>
    Node IJlig { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ijlig;</c>
    /// representing U+00133.
    /// </summary>
    Node ijlig { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Im;</c>
    /// representing U+02111.
    /// </summary>
    Node Im { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Imacr;</c>
    /// representing U+0012A.
    /// </summary>
    Node Imacr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;imacr;</c>
    /// representing U+0012B.
    /// </summary>
    Node imacr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;image;</c>
    /// representing U+02111.
    /// </summary>
    Node image { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ImaginaryI;</c>
    /// representing U+02148.
    /// </summary>
    Node ImaginaryI { get; }

    /// <summary>
    /// Gets character reference <c>&amp;imagline;</c>
    /// representing U+02110.
    /// </summary>
    Node imagline { get; }

    /// <summary>
    /// Gets character reference <c>&amp;imagpart;</c>
    /// representing U+02111.
    /// </summary>
    Node imagpart { get; }

    /// <summary>
    /// Gets character reference <c>&amp;imath;</c>
    /// representing U+00131.
    /// </summary>
    Node imath { get; }

    /// <summary>
    /// Gets character reference <c>&amp;imof;</c>
    /// representing U+022B7.
    /// </summary>
    Node imof { get; }

    /// <summary>
    /// Gets character reference <c>&amp;imped;</c>
    /// representing U+001B5.
    /// </summary>
    Node imped { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Implies;</c>
    /// representing U+021D2.
    /// </summary>
    Node Implies { get; }

    /// <summary>
    /// Gets character reference <c>&amp;@in;</c>
    /// representing U+02208.
    /// </summary>
    Node @in { get; }

    /// <summary>
    /// Gets character reference <c>&amp;incare;</c>
    /// representing U+02105.
    /// </summary>
    Node incare { get; }

    /// <summary>
    /// Gets character reference <c>&amp;infin;</c>
    /// representing U+0221E.
    /// </summary>
    Node infin { get; }

    /// <summary>
    /// Gets character reference <c>&amp;infintie;</c>
    /// representing U+029DD.
    /// </summary>
    Node infintie { get; }

    /// <summary>
    /// Gets character reference <c>&amp;inodot;</c>
    /// representing U+00131.
    /// </summary>
    Node inodot { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Int;</c>
    /// representing U+0222C.
    /// </summary>
    Node Int { get; }

    /// <summary>
    /// Gets character reference <c>&amp;@int;</c>
    /// representing U+0222B.
    /// </summary>
    Node @int { get; }

    /// <summary>
    /// Gets character reference <c>&amp;intcal;</c>
    /// representing U+022BA.
    /// </summary>
    Node intcal { get; }

    /// <summary>
    /// Gets character reference <c>&amp;integers;</c>
    /// representing U+02124.
    /// </summary>
    Node integers { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Integral;</c>
    /// representing U+0222B.
    /// </summary>
    Node Integral { get; }

    /// <summary>
    /// Gets character reference <c>&amp;intercal;</c>
    /// representing U+022BA.
    /// </summary>
    Node intercal { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Intersection;</c>
    /// representing U+022C2.
    /// </summary>
    Node Intersection { get; }

    /// <summary>
    /// Gets character reference <c>&amp;intlarhk;</c>
    /// representing U+02A17.
    /// </summary>
    Node intlarhk { get; }

    /// <summary>
    /// Gets character reference <c>&amp;intprod;</c>
    /// representing U+02A3C.
    /// </summary>
    Node intprod { get; }

    /// <summary>
    /// Gets character reference <c>&amp;InvisibleComma;</c>
    /// representing U+02063.
    /// </summary>
    Node InvisibleComma { get; }

    /// <summary>
    /// Gets character reference <c>&amp;InvisibleTimes;</c>
    /// representing U+02062.
    /// </summary>
    Node InvisibleTimes { get; }

    /// <summary>
    /// Gets character reference <c>&amp;IOcy;</c>
    /// representing U+00401.
    /// </summary>
    Node IOcy { get; }

    /// <summary>
    /// Gets character reference <c>&amp;iocy;</c>
    /// representing U+00451.
    /// </summary>
    Node iocy { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Iogon;</c>
    /// representing U+0012E.
    /// </summary>
    Node Iogon { get; }

    /// <summary>
    /// Gets character reference <c>&amp;iogon;</c>
    /// representing U+0012F.
    /// </summary>
    Node iogon { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Iopf;</c>
    /// representing U+1D540.
    /// </summary>
    Node Iopf { get; }

    /// <summary>
    /// Gets character reference <c>&amp;iopf;</c>
    /// representing U+1D55A.
    /// </summary>
    Node iopf { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Iota;</c>
    /// representing U+00399.
    /// </summary>
    Node Iota { get; }

    /// <summary>
    /// Gets character reference <c>&amp;iota;</c>
    /// representing U+003B9.
    /// </summary>
    Node iota { get; }

    /// <summary>
    /// Gets character reference <c>&amp;iprod;</c>
    /// representing U+02A3C.
    /// </summary>
    Node iprod { get; }

    /// <summary>
    /// Gets character reference <c>&amp;iquest;</c>
    /// representing U+000BF.
    /// </summary>
    Node iquest { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Iscr;</c>
    /// representing U+02110.
    /// </summary>
    Node Iscr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;iscr;</c>
    /// representing U+1D4BE.
    /// </summary>
    Node iscr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;isin;</c>
    /// representing U+02208.
    /// </summary>
    Node isin { get; }

    /// <summary>
    /// Gets character reference <c>&amp;isindot;</c>
    /// representing U+022F5.
    /// </summary>
    Node isindot { get; }

    /// <summary>
    /// Gets character reference <c>&amp;isinE;</c>
    /// representing U+022F9.
    /// </summary>
    Node isinE { get; }

    /// <summary>
    /// Gets character reference <c>&amp;isins;</c>
    /// representing U+022F4.
    /// </summary>
    Node isins { get; }

    /// <summary>
    /// Gets character reference <c>&amp;isinsv;</c>
    /// representing U+022F3.
    /// </summary>
    Node isinsv { get; }

    /// <summary>
    /// Gets character reference <c>&amp;isinv;</c>
    /// representing U+02208.
    /// </summary>
    Node isinv { get; }

    /// <summary>
    /// Gets character reference <c>&amp;it;</c>
    /// representing U+02062.
    /// </summary>
    Node it { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Itilde;</c>
    /// representing U+00128.
    /// </summary>
    Node Itilde { get; }

    /// <summary>
    /// Gets character reference <c>&amp;itilde;</c>
    /// representing U+00129.
    /// </summary>
    Node itilde { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Iukcy;</c>
    /// representing U+00406.
    /// </summary>
    Node Iukcy { get; }

    /// <summary>
    /// Gets character reference <c>&amp;iukcy;</c>
    /// representing U+00456.
    /// </summary>
    Node iukcy { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Iuml;</c>
    /// representing U+000CF.
    /// </summary>
    Node Iuml { get; }

    /// <summary>
    /// Gets character reference <c>&amp;iuml;</c>
    /// representing U+000EF.
    /// </summary>
    Node iuml { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Jcirc;</c>
    /// representing U+00134.
    /// </summary>
    Node Jcirc { get; }

    /// <summary>
    /// Gets character reference <c>&amp;jcirc;</c>
    /// representing U+00135.
    /// </summary>
    Node jcirc { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Jcy;</c>
    /// representing U+00419.
    /// </summary>
    Node Jcy { get; }

    /// <summary>
    /// Gets character reference <c>&amp;jcy;</c>
    /// representing U+00439.
    /// </summary>
    Node jcy { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Jfr;</c>
    /// representing U+1D50D.
    /// </summary>
    Node Jfr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;jfr;</c>
    /// representing U+1D527.
    /// </summary>
    Node jfr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;jmath;</c>
    /// representing U+00237.
    /// </summary>
    Node jmath { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Jopf;</c>
    /// representing U+1D541.
    /// </summary>
    Node Jopf { get; }

    /// <summary>
    /// Gets character reference <c>&amp;jopf;</c>
    /// representing U+1D55B.
    /// </summary>
    Node jopf { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Jscr;</c>
    /// representing U+1D4A5.
    /// </summary>
    Node Jscr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;jscr;</c>
    /// representing U+1D4BF.
    /// </summary>
    Node jscr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Jsercy;</c>
    /// representing U+00408.
    /// </summary>
    Node Jsercy { get; }

    /// <summary>
    /// Gets character reference <c>&amp;jsercy;</c>
    /// representing U+00458.
    /// </summary>
    Node jsercy { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Jukcy;</c>
    /// representing U+00404.
    /// </summary>
    Node Jukcy { get; }

    /// <summary>
    /// Gets character reference <c>&amp;jukcy;</c>
    /// representing U+00454.
    /// </summary>
    Node jukcy { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Kappa;</c>
    /// representing U+0039A.
    /// </summary>
    Node Kappa { get; }

    /// <summary>
    /// Gets character reference <c>&amp;kappa;</c>
    /// representing U+003BA.
    /// </summary>
    Node kappa { get; }

    /// <summary>
    /// Gets character reference <c>&amp;kappav;</c>
    /// representing U+003F0.
    /// </summary>
    Node kappav { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Kcedil;</c>
    /// representing U+00136.
    /// </summary>
    Node Kcedil { get; }

    /// <summary>
    /// Gets character reference <c>&amp;kcedil;</c>
    /// representing U+00137.
    /// </summary>
    Node kcedil { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Kcy;</c>
    /// representing U+0041A.
    /// </summary>
    Node Kcy { get; }

    /// <summary>
    /// Gets character reference <c>&amp;kcy;</c>
    /// representing U+0043A.
    /// </summary>
    Node kcy { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Kfr;</c>
    /// representing U+1D50E.
    /// </summary>
    Node Kfr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;kfr;</c>
    /// representing U+1D528.
    /// </summary>
    Node kfr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;kgreen;</c>
    /// representing U+00138.
    /// </summary>
    Node kgreen { get; }

    /// <summary>
    /// Gets character reference <c>&amp;KHcy;</c>
    /// representing U+00425.
    /// </summary>
    Node KHcy { get; }

    /// <summary>
    /// Gets character reference <c>&amp;khcy;</c>
    /// representing U+00445.
    /// </summary>
    Node khcy { get; }

    /// <summary>
    /// Gets character reference <c>&amp;KJcy;</c>
    /// representing U+0040C.
    /// </summary>
    Node KJcy { get; }

    /// <summary>
    /// Gets character reference <c>&amp;kjcy;</c>
    /// representing U+0045C.
    /// </summary>
    Node kjcy { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Kopf;</c>
    /// representing U+1D542.
    /// </summary>
    Node Kopf { get; }

    /// <summary>
    /// Gets character reference <c>&amp;kopf;</c>
    /// representing U+1D55C.
    /// </summary>
    Node kopf { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Kscr;</c>
    /// representing U+1D4A6.
    /// </summary>
    Node Kscr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;kscr;</c>
    /// representing U+1D4C0.
    /// </summary>
    Node kscr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;lAarr;</c>
    /// representing U+021DA.
    /// </summary>
    Node lAarr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Lacute;</c>
    /// representing U+00139.
    /// </summary>
    Node Lacute { get; }

    /// <summary>
    /// Gets character reference <c>&amp;lacute;</c>
    /// representing U+0013A.
    /// </summary>
    Node lacute { get; }

    /// <summary>
    /// Gets character reference <c>&amp;laemptyv;</c>
    /// representing U+029B4.
    /// </summary>
    Node laemptyv { get; }

    /// <summary>
    /// Gets character reference <c>&amp;lagran;</c>
    /// representing U+02112.
    /// </summary>
    Node lagran { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Lambda;</c>
    /// representing U+0039B.
    /// </summary>
    Node Lambda { get; }

    /// <summary>
    /// Gets character reference <c>&amp;lambda;</c>
    /// representing U+003BB.
    /// </summary>
    Node lambda { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Lang;</c>
    /// representing U+027EA.
    /// </summary>
    Node Lang { get; }

    /// <summary>
    /// Gets character reference <c>&amp;lang;</c>
    /// representing U+027E8.
    /// </summary>
    Node lang { get; }

    /// <summary>
    /// Gets character reference <c>&amp;langd;</c>
    /// representing U+02991.
    /// </summary>
    Node langd { get; }

    /// <summary>
    /// Gets character reference <c>&amp;langle;</c>
    /// representing U+027E8.
    /// </summary>
    Node langle { get; }

    /// <summary>
    /// Gets character reference <c>&amp;lap;</c>
    /// representing U+02A85.
    /// </summary>
    Node lap { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Laplacetrf;</c>
    /// representing U+02112.
    /// </summary>
    Node Laplacetrf { get; }

    /// <summary>
    /// Gets character reference <c>&amp;laquo;</c>
    /// representing U+000AB.
    /// </summary>
    Node laquo { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Larr;</c>
    /// representing U+0219E.
    /// </summary>
    Node Larr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;lArr;</c>
    /// representing U+021D0.
    /// </summary>
    Node lArr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;larr;</c>
    /// representing U+02190.
    /// </summary>
    Node larr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;larrb;</c>
    /// representing U+021E4.
    /// </summary>
    Node larrb { get; }

    /// <summary>
    /// Gets character reference <c>&amp;larrbfs;</c>
    /// representing U+0291F.
    /// </summary>
    Node larrbfs { get; }

    /// <summary>
    /// Gets character reference <c>&amp;larrfs;</c>
    /// representing U+0291D.
    /// </summary>
    Node larrfs { get; }

    /// <summary>
    /// Gets character reference <c>&amp;larrhk;</c>
    /// representing U+021A9.
    /// </summary>
    Node larrhk { get; }

    /// <summary>
    /// Gets character reference <c>&amp;larrlp;</c>
    /// representing U+021AB.
    /// </summary>
    Node larrlp { get; }

    /// <summary>
    /// Gets character reference <c>&amp;larrpl;</c>
    /// representing U+02939.
    /// </summary>
    Node larrpl { get; }

    /// <summary>
    /// Gets character reference <c>&amp;larrsim;</c>
    /// representing U+02973.
    /// </summary>
    Node larrsim { get; }

    /// <summary>
    /// Gets character reference <c>&amp;larrtl;</c>
    /// representing U+021A2.
    /// </summary>
    Node larrtl { get; }

    /// <summary>
    /// Gets character reference <c>&amp;lat;</c>
    /// representing U+02AAB.
    /// </summary>
    Node lat { get; }

    /// <summary>
    /// Gets character reference <c>&amp;lAtail;</c>
    /// representing U+0291B.
    /// </summary>
    Node lAtail { get; }

    /// <summary>
    /// Gets character reference <c>&amp;latail;</c>
    /// representing U+02919.
    /// </summary>
    Node latail { get; }

    /// <summary>
    /// Gets character reference <c>&amp;late;</c>
    /// representing U+02AAD.
    /// </summary>
    Node late { get; }

    /// <summary>
    /// Gets character reference <c>&amp;lates;</c>
    /// representing U+02AAD U+0FE00.
    /// </summary>
    Node lates { get; }

    /// <summary>
    /// Gets character reference <c>&amp;lBarr;</c>
    /// representing U+0290E.
    /// </summary>
    Node lBarr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;lbarr;</c>
    /// representing U+0290C.
    /// </summary>
    Node lbarr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;lbbrk;</c>
    /// representing U+02772.
    /// </summary>
    Node lbbrk { get; }

    /// <summary>
    /// Gets character reference <c>&amp;lbrace;</c>
    /// representing U+0007B.
    /// </summary>
    Node lbrace { get; }

    /// <summary>
    /// Gets character reference <c>&amp;lbrack;</c>
    /// representing U+0005B.
    /// </summary>
    Node lbrack { get; }

    /// <summary>
    /// Gets character reference <c>&amp;lbrke;</c>
    /// representing U+0298B.
    /// </summary>
    Node lbrke { get; }

    /// <summary>
    /// Gets character reference <c>&amp;lbrksld;</c>
    /// representing U+0298F.
    /// </summary>
    Node lbrksld { get; }

    /// <summary>
    /// Gets character reference <c>&amp;lbrkslu;</c>
    /// representing U+0298D.
    /// </summary>
    Node lbrkslu { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Lcaron;</c>
    /// representing U+0013D.
    /// </summary>
    Node Lcaron { get; }

    /// <summary>
    /// Gets character reference <c>&amp;lcaron;</c>
    /// representing U+0013E.
    /// </summary>
    Node lcaron { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Lcedil;</c>
    /// representing U+0013B.
    /// </summary>
    Node Lcedil { get; }

    /// <summary>
    /// Gets character reference <c>&amp;lcedil;</c>
    /// representing U+0013C.
    /// </summary>
    Node lcedil { get; }

    /// <summary>
    /// Gets character reference <c>&amp;lceil;</c>
    /// representing U+02308.
    /// </summary>
    Node lceil { get; }

    /// <summary>
    /// Gets character reference <c>&amp;lcub;</c>
    /// representing U+0007B.
    /// </summary>
    Node lcub { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Lcy;</c>
    /// representing U+0041B.
    /// </summary>
    Node Lcy { get; }

    /// <summary>
    /// Gets character reference <c>&amp;lcy;</c>
    /// representing U+0043B.
    /// </summary>
    Node lcy { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ldca;</c>
    /// representing U+02936.
    /// </summary>
    Node ldca { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ldquo;</c>
    /// representing U+0201C.
    /// </summary>
    Node ldquo { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ldquor;</c>
    /// representing U+0201E.
    /// </summary>
    Node ldquor { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ldrdhar;</c>
    /// representing U+02967.
    /// </summary>
    Node ldrdhar { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ldrushar;</c>
    /// representing U+0294B.
    /// </summary>
    Node ldrushar { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ldsh;</c>
    /// representing U+021B2.
    /// </summary>
    Node ldsh { get; }

    /// <summary>
    /// Gets character reference <c>&amp;lE;</c>
    /// representing U+02266.
    /// </summary>
    Node lE { get; }

    /// <summary>
    /// Gets character reference <c>&amp;le;</c>
    /// representing U+02264.
    /// </summary>
    Node le { get; }

    /// <summary>
    /// Gets character reference <c>&amp;LeftAngleBracket;</c>
    /// representing U+027E8.
    /// </summary>
    Node LeftAngleBracket { get; }

    /// <summary>
    /// Gets character reference <c>&amp;LeftArrow;</c>
    /// representing U+02190.
    /// </summary>
    Node LeftArrow { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Leftarrow;</c>
    /// representing U+021D0.
    /// </summary>
    Node Leftarrow { get; }

    /// <summary>
    /// Gets character reference <c>&amp;leftarrow;</c>
    /// representing U+02190.
    /// </summary>
    Node leftarrow { get; }

    /// <summary>
    /// Gets character reference <c>&amp;LeftArrowBar;</c>
    /// representing U+021E4.
    /// </summary>
    Node LeftArrowBar { get; }

    /// <summary>
    /// Gets character reference <c>&amp;LeftArrowRightArrow;</c>
    /// representing U+021C6.
    /// </summary>
    Node LeftArrowRightArrow { get; }

    /// <summary>
    /// Gets character reference <c>&amp;leftarrowtail;</c>
    /// representing U+021A2.
    /// </summary>
    Node leftarrowtail { get; }

    /// <summary>
    /// Gets character reference <c>&amp;LeftCeiling;</c>
    /// representing U+02308.
    /// </summary>
    Node LeftCeiling { get; }

    /// <summary>
    /// Gets character reference <c>&amp;LeftDoubleBracket;</c>
    /// representing U+027E6.
    /// </summary>
    Node LeftDoubleBracket { get; }

    /// <summary>
    /// Gets character reference <c>&amp;LeftDownTeeVector;</c>
    /// representing U+02961.
    /// </summary>
    Node LeftDownTeeVector { get; }

    /// <summary>
    /// Gets character reference <c>&amp;LeftDownVector;</c>
    /// representing U+021C3.
    /// </summary>
    Node LeftDownVector { get; }

    /// <summary>
    /// Gets character reference <c>&amp;LeftDownVectorBar;</c>
    /// representing U+02959.
    /// </summary>
    Node LeftDownVectorBar { get; }

    /// <summary>
    /// Gets character reference <c>&amp;LeftFloor;</c>
    /// representing U+0230A.
    /// </summary>
    Node LeftFloor { get; }

    /// <summary>
    /// Gets character reference <c>&amp;leftharpoondown;</c>
    /// representing U+021BD.
    /// </summary>
    Node leftharpoondown { get; }

    /// <summary>
    /// Gets character reference <c>&amp;leftharpoonup;</c>
    /// representing U+021BC.
    /// </summary>
    Node leftharpoonup { get; }

    /// <summary>
    /// Gets character reference <c>&amp;leftleftarrows;</c>
    /// representing U+021C7.
    /// </summary>
    Node leftleftarrows { get; }

    /// <summary>
    /// Gets character reference <c>&amp;LeftRightArrow;</c>
    /// representing U+02194.
    /// </summary>
    Node LeftRightArrow { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Leftrightarrow;</c>
    /// representing U+021D4.
    /// </summary>
    Node Leftrightarrow { get; }

    /// <summary>
    /// Gets character reference <c>&amp;leftrightarrow;</c>
    /// representing U+02194.
    /// </summary>
    Node leftrightarrow { get; }

    /// <summary>
    /// Gets character reference <c>&amp;leftrightarrows;</c>
    /// representing U+021C6.
    /// </summary>
    Node leftrightarrows { get; }

    /// <summary>
    /// Gets character reference <c>&amp;leftrightharpoons;</c>
    /// representing U+021CB.
    /// </summary>
    Node leftrightharpoons { get; }

    /// <summary>
    /// Gets character reference <c>&amp;leftrightsquigarrow;</c>
    /// representing U+021AD.
    /// </summary>
    Node leftrightsquigarrow { get; }

    /// <summary>
    /// Gets character reference <c>&amp;LeftRightVector;</c>
    /// representing U+0294E.
    /// </summary>
    Node LeftRightVector { get; }

    /// <summary>
    /// Gets character reference <c>&amp;LeftTee;</c>
    /// representing U+022A3.
    /// </summary>
    Node LeftTee { get; }

    /// <summary>
    /// Gets character reference <c>&amp;LeftTeeArrow;</c>
    /// representing U+021A4.
    /// </summary>
    Node LeftTeeArrow { get; }

    /// <summary>
    /// Gets character reference <c>&amp;LeftTeeVector;</c>
    /// representing U+0295A.
    /// </summary>
    Node LeftTeeVector { get; }

    /// <summary>
    /// Gets character reference <c>&amp;leftthreetimes;</c>
    /// representing U+022CB.
    /// </summary>
    Node leftthreetimes { get; }

    /// <summary>
    /// Gets character reference <c>&amp;LeftTriangle;</c>
    /// representing U+022B2.
    /// </summary>
    Node LeftTriangle { get; }

    /// <summary>
    /// Gets character reference <c>&amp;LeftTriangleBar;</c>
    /// representing U+029CF.
    /// </summary>
    Node LeftTriangleBar { get; }

    /// <summary>
    /// Gets character reference <c>&amp;LeftTriangleEqual;</c>
    /// representing U+022B4.
    /// </summary>
    Node LeftTriangleEqual { get; }

    /// <summary>
    /// Gets character reference <c>&amp;LeftUpDownVector;</c>
    /// representing U+02951.
    /// </summary>
    Node LeftUpDownVector { get; }

    /// <summary>
    /// Gets character reference <c>&amp;LeftUpTeeVector;</c>
    /// representing U+02960.
    /// </summary>
    Node LeftUpTeeVector { get; }

    /// <summary>
    /// Gets character reference <c>&amp;LeftUpVector;</c>
    /// representing U+021BF.
    /// </summary>
    Node LeftUpVector { get; }

    /// <summary>
    /// Gets character reference <c>&amp;LeftUpVectorBar;</c>
    /// representing U+02958.
    /// </summary>
    Node LeftUpVectorBar { get; }

    /// <summary>
    /// Gets character reference <c>&amp;LeftVector;</c>
    /// representing U+021BC.
    /// </summary>
    Node LeftVector { get; }

    /// <summary>
    /// Gets character reference <c>&amp;LeftVectorBar;</c>
    /// representing U+02952.
    /// </summary>
    Node LeftVectorBar { get; }

    /// <summary>
    /// Gets character reference <c>&amp;lEg;</c>
    /// representing U+02A8B.
    /// </summary>
    Node lEg { get; }

    /// <summary>
    /// Gets character reference <c>&amp;leg;</c>
    /// representing U+022DA.
    /// </summary>
    Node leg { get; }

    /// <summary>
    /// Gets character reference <c>&amp;leq;</c>
    /// representing U+02264.
    /// </summary>
    Node leq { get; }

    /// <summary>
    /// Gets character reference <c>&amp;leqq;</c>
    /// representing U+02266.
    /// </summary>
    Node leqq { get; }

    /// <summary>
    /// Gets character reference <c>&amp;leqslant;</c>
    /// representing U+02A7D.
    /// </summary>
    Node leqslant { get; }

    /// <summary>
    /// Gets character reference <c>&amp;les;</c>
    /// representing U+02A7D.
    /// </summary>
    Node les { get; }

    /// <summary>
    /// Gets character reference <c>&amp;lescc;</c>
    /// representing U+02AA8.
    /// </summary>
    Node lescc { get; }

    /// <summary>
    /// Gets character reference <c>&amp;lesdot;</c>
    /// representing U+02A7F.
    /// </summary>
    Node lesdot { get; }

    /// <summary>
    /// Gets character reference <c>&amp;lesdoto;</c>
    /// representing U+02A81.
    /// </summary>
    Node lesdoto { get; }

    /// <summary>
    /// Gets character reference <c>&amp;lesdotor;</c>
    /// representing U+02A83.
    /// </summary>
    Node lesdotor { get; }

    /// <summary>
    /// Gets character reference <c>&amp;lesg;</c>
    /// representing U+022DA U+0FE00.
    /// </summary>
    Node lesg { get; }

    /// <summary>
    /// Gets character reference <c>&amp;lesges;</c>
    /// representing U+02A93.
    /// </summary>
    Node lesges { get; }

    /// <summary>
    /// Gets character reference <c>&amp;lessapprox;</c>
    /// representing U+02A85.
    /// </summary>
    Node lessapprox { get; }

    /// <summary>
    /// Gets character reference <c>&amp;lessdot;</c>
    /// representing U+022D6.
    /// </summary>
    Node lessdot { get; }

    /// <summary>
    /// Gets character reference <c>&amp;lesseqgtr;</c>
    /// representing U+022DA.
    /// </summary>
    Node lesseqgtr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;lesseqqgtr;</c>
    /// representing U+02A8B.
    /// </summary>
    Node lesseqqgtr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;LessEqualGreater;</c>
    /// representing U+022DA.
    /// </summary>
    Node LessEqualGreater { get; }

    /// <summary>
    /// Gets character reference <c>&amp;LessFullEqual;</c>
    /// representing U+02266.
    /// </summary>
    Node LessFullEqual { get; }

    /// <summary>
    /// Gets character reference <c>&amp;LessGreater;</c>
    /// representing U+02276.
    /// </summary>
    Node LessGreater { get; }

    /// <summary>
    /// Gets character reference <c>&amp;lessgtr;</c>
    /// representing U+02276.
    /// </summary>
    Node lessgtr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;LessLess;</c>
    /// representing U+02AA1.
    /// </summary>
    Node LessLess { get; }

    /// <summary>
    /// Gets character reference <c>&amp;lesssim;</c>
    /// representing U+02272.
    /// </summary>
    Node lesssim { get; }

    /// <summary>
    /// Gets character reference <c>&amp;LessSlantEqual;</c>
    /// representing U+02A7D.
    /// </summary>
    Node LessSlantEqual { get; }

    /// <summary>
    /// Gets character reference <c>&amp;LessTilde;</c>
    /// representing U+02272.
    /// </summary>
    Node LessTilde { get; }

    /// <summary>
    /// Gets character reference <c>&amp;lfisht;</c>
    /// representing U+0297C.
    /// </summary>
    Node lfisht { get; }

    /// <summary>
    /// Gets character reference <c>&amp;lfloor;</c>
    /// representing U+0230A.
    /// </summary>
    Node lfloor { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Lfr;</c>
    /// representing U+1D50F.
    /// </summary>
    Node Lfr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;lfr;</c>
    /// representing U+1D529.
    /// </summary>
    Node lfr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;lg;</c>
    /// representing U+02276.
    /// </summary>
    Node lg { get; }

    /// <summary>
    /// Gets character reference <c>&amp;lgE;</c>
    /// representing U+02A91.
    /// </summary>
    Node lgE { get; }

    /// <summary>
    /// Gets character reference <c>&amp;lHar;</c>
    /// representing U+02962.
    /// </summary>
    Node lHar { get; }

    /// <summary>
    /// Gets character reference <c>&amp;lhard;</c>
    /// representing U+021BD.
    /// </summary>
    Node lhard { get; }

    /// <summary>
    /// Gets character reference <c>&amp;lharu;</c>
    /// representing U+021BC.
    /// </summary>
    Node lharu { get; }

    /// <summary>
    /// Gets character reference <c>&amp;lharul;</c>
    /// representing U+0296A.
    /// </summary>
    Node lharul { get; }

    /// <summary>
    /// Gets character reference <c>&amp;lhblk;</c>
    /// representing U+02584.
    /// </summary>
    Node lhblk { get; }

    /// <summary>
    /// Gets character reference <c>&amp;LJcy;</c>
    /// representing U+00409.
    /// </summary>
    Node LJcy { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ljcy;</c>
    /// representing U+00459.
    /// </summary>
    Node ljcy { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Ll;</c>
    /// representing U+022D8.
    /// </summary>
    Node Ll { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ll;</c>
    /// representing U+0226A.
    /// </summary>
    Node ll { get; }

    /// <summary>
    /// Gets character reference <c>&amp;llarr;</c>
    /// representing U+021C7.
    /// </summary>
    Node llarr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;llcorner;</c>
    /// representing U+0231E.
    /// </summary>
    Node llcorner { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Lleftarrow;</c>
    /// representing U+021DA.
    /// </summary>
    Node Lleftarrow { get; }

    /// <summary>
    /// Gets character reference <c>&amp;llhard;</c>
    /// representing U+0296B.
    /// </summary>
    Node llhard { get; }

    /// <summary>
    /// Gets character reference <c>&amp;lltri;</c>
    /// representing U+025FA.
    /// </summary>
    Node lltri { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Lmidot;</c>
    /// representing U+0013F.
    /// </summary>
    Node Lmidot { get; }

    /// <summary>
    /// Gets character reference <c>&amp;lmidot;</c>
    /// representing U+00140.
    /// </summary>
    Node lmidot { get; }

    /// <summary>
    /// Gets character reference <c>&amp;lmoust;</c>
    /// representing U+023B0.
    /// </summary>
    Node lmoust { get; }

    /// <summary>
    /// Gets character reference <c>&amp;lmoustache;</c>
    /// representing U+023B0.
    /// </summary>
    Node lmoustache { get; }

    /// <summary>
    /// Gets character reference <c>&amp;lnap;</c>
    /// representing U+02A89.
    /// </summary>
    Node lnap { get; }

    /// <summary>
    /// Gets character reference <c>&amp;lnapprox;</c>
    /// representing U+02A89.
    /// </summary>
    Node lnapprox { get; }

    /// <summary>
    /// Gets character reference <c>&amp;lnE;</c>
    /// representing U+02268.
    /// </summary>
    Node lnE { get; }

    /// <summary>
    /// Gets character reference <c>&amp;lne;</c>
    /// representing U+02A87.
    /// </summary>
    Node lne { get; }

    /// <summary>
    /// Gets character reference <c>&amp;lneq;</c>
    /// representing U+02A87.
    /// </summary>
    Node lneq { get; }

    /// <summary>
    /// Gets character reference <c>&amp;lneqq;</c>
    /// representing U+02268.
    /// </summary>
    Node lneqq { get; }

    /// <summary>
    /// Gets character reference <c>&amp;lnsim;</c>
    /// representing U+022E6.
    /// </summary>
    Node lnsim { get; }

    /// <summary>
    /// Gets character reference <c>&amp;loang;</c>
    /// representing U+027EC.
    /// </summary>
    Node loang { get; }

    /// <summary>
    /// Gets character reference <c>&amp;loarr;</c>
    /// representing U+021FD.
    /// </summary>
    Node loarr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;lobrk;</c>
    /// representing U+027E6.
    /// </summary>
    Node lobrk { get; }

    /// <summary>
    /// Gets character reference <c>&amp;LongLeftArrow;</c>
    /// representing U+027F5.
    /// </summary>
    Node LongLeftArrow { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Longleftarrow;</c>
    /// representing U+027F8.
    /// </summary>
    Node Longleftarrow { get; }

    /// <summary>
    /// Gets character reference <c>&amp;longleftarrow;</c>
    /// representing U+027F5.
    /// </summary>
    Node longleftarrow { get; }

    /// <summary>
    /// Gets character reference <c>&amp;LongLeftRightArrow;</c>
    /// representing U+027F7.
    /// </summary>
    Node LongLeftRightArrow { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Longleftrightarrow;</c>
    /// representing U+027FA.
    /// </summary>
    Node Longleftrightarrow { get; }

    /// <summary>
    /// Gets character reference <c>&amp;longleftrightarrow;</c>
    /// representing U+027F7.
    /// </summary>
    Node longleftrightarrow { get; }

    /// <summary>
    /// Gets character reference <c>&amp;longmapsto;</c>
    /// representing U+027FC.
    /// </summary>
    Node longmapsto { get; }

    /// <summary>
    /// Gets character reference <c>&amp;LongRightArrow;</c>
    /// representing U+027F6.
    /// </summary>
    Node LongRightArrow { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Longrightarrow;</c>
    /// representing U+027F9.
    /// </summary>
    Node Longrightarrow { get; }

    /// <summary>
    /// Gets character reference <c>&amp;longrightarrow;</c>
    /// representing U+027F6.
    /// </summary>
    Node longrightarrow { get; }

    /// <summary>
    /// Gets character reference <c>&amp;looparrowleft;</c>
    /// representing U+021AB.
    /// </summary>
    Node looparrowleft { get; }

    /// <summary>
    /// Gets character reference <c>&amp;looparrowright;</c>
    /// representing U+021AC.
    /// </summary>
    Node looparrowright { get; }

    /// <summary>
    /// Gets character reference <c>&amp;lopar;</c>
    /// representing U+02985.
    /// </summary>
    Node lopar { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Lopf;</c>
    /// representing U+1D543.
    /// </summary>
    Node Lopf { get; }

    /// <summary>
    /// Gets character reference <c>&amp;lopf;</c>
    /// representing U+1D55D.
    /// </summary>
    Node lopf { get; }

    /// <summary>
    /// Gets character reference <c>&amp;loplus;</c>
    /// representing U+02A2D.
    /// </summary>
    Node loplus { get; }

    /// <summary>
    /// Gets character reference <c>&amp;lotimes;</c>
    /// representing U+02A34.
    /// </summary>
    Node lotimes { get; }

    /// <summary>
    /// Gets character reference <c>&amp;lowast;</c>
    /// representing U+02217.
    /// </summary>
    Node lowast { get; }

    /// <summary>
    /// Gets character reference <c>&amp;lowbar;</c>
    /// representing U+0005F.
    /// </summary>
    Node lowbar { get; }

    /// <summary>
    /// Gets character reference <c>&amp;LowerLeftArrow;</c>
    /// representing U+02199.
    /// </summary>
    Node LowerLeftArrow { get; }

    /// <summary>
    /// Gets character reference <c>&amp;LowerRightArrow;</c>
    /// representing U+02198.
    /// </summary>
    Node LowerRightArrow { get; }

    /// <summary>
    /// Gets character reference <c>&amp;loz;</c>
    /// representing U+025CA.
    /// </summary>
    Node loz { get; }

    /// <summary>
    /// Gets character reference <c>&amp;lozenge;</c>
    /// representing U+025CA.
    /// </summary>
    Node lozenge { get; }

    /// <summary>
    /// Gets character reference <c>&amp;lozf;</c>
    /// representing U+029EB.
    /// </summary>
    Node lozf { get; }

    /// <summary>
    /// Gets character reference <c>&amp;lpar;</c>
    /// representing U+00028.
    /// </summary>
    Node lpar { get; }

    /// <summary>
    /// Gets character reference <c>&amp;lparlt;</c>
    /// representing U+02993.
    /// </summary>
    Node lparlt { get; }

    /// <summary>
    /// Gets character reference <c>&amp;lrarr;</c>
    /// representing U+021C6.
    /// </summary>
    Node lrarr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;lrcorner;</c>
    /// representing U+0231F.
    /// </summary>
    Node lrcorner { get; }

    /// <summary>
    /// Gets character reference <c>&amp;lrhar;</c>
    /// representing U+021CB.
    /// </summary>
    Node lrhar { get; }

    /// <summary>
    /// Gets character reference <c>&amp;lrhard;</c>
    /// representing U+0296D.
    /// </summary>
    Node lrhard { get; }

    /// <summary>
    /// Gets character reference <c>&amp;lrm;</c>
    /// representing U+0200E.
    /// </summary>
    Node lrm { get; }

    /// <summary>
    /// Gets character reference <c>&amp;lrtri;</c>
    /// representing U+022BF.
    /// </summary>
    Node lrtri { get; }

    /// <summary>
    /// Gets character reference <c>&amp;lsaquo;</c>
    /// representing U+02039.
    /// </summary>
    Node lsaquo { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Lscr;</c>
    /// representing U+02112.
    /// </summary>
    Node Lscr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;lscr;</c>
    /// representing U+1D4C1.
    /// </summary>
    Node lscr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Lsh;</c>
    /// representing U+021B0.
    /// </summary>
    Node Lsh { get; }

    /// <summary>
    /// Gets character reference <c>&amp;lsh;</c>
    /// representing U+021B0.
    /// </summary>
    Node lsh { get; }

    /// <summary>
    /// Gets character reference <c>&amp;lsim;</c>
    /// representing U+02272.
    /// </summary>
    Node lsim { get; }

    /// <summary>
    /// Gets character reference <c>&amp;lsime;</c>
    /// representing U+02A8D.
    /// </summary>
    Node lsime { get; }

    /// <summary>
    /// Gets character reference <c>&amp;lsimg;</c>
    /// representing U+02A8F.
    /// </summary>
    Node lsimg { get; }

    /// <summary>
    /// Gets character reference <c>&amp;lsqb;</c>
    /// representing U+0005B.
    /// </summary>
    Node lsqb { get; }

    /// <summary>
    /// Gets character reference <c>&amp;lsquo;</c>
    /// representing U+02018.
    /// </summary>
    Node lsquo { get; }

    /// <summary>
    /// Gets character reference <c>&amp;lsquor;</c>
    /// representing U+0201A.
    /// </summary>
    Node lsquor { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Lstrok;</c>
    /// representing U+00141.
    /// </summary>
    Node Lstrok { get; }

    /// <summary>
    /// Gets character reference <c>&amp;lstrok;</c>
    /// representing U+00142.
    /// </summary>
    Node lstrok { get; }

    /// <summary>
    /// Gets character reference <c>&amp;LT;</c>
    /// representing U+0003C.
    /// </summary>
    Node LT { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Lt;</c>
    /// representing U+0226A.
    /// </summary>
    Node Lt { get; }

    /// <summary>
    /// Gets character reference <c>&amp;lt;</c>
    /// representing U+0003C.
    /// </summary>
    Node lt { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ltcc;</c>
    /// representing U+02AA6.
    /// </summary>
    Node ltcc { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ltcir;</c>
    /// representing U+02A79.
    /// </summary>
    Node ltcir { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ltdot;</c>
    /// representing U+022D6.
    /// </summary>
    Node ltdot { get; }

    /// <summary>
    /// Gets character reference <c>&amp;lthree;</c>
    /// representing U+022CB.
    /// </summary>
    Node lthree { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ltimes;</c>
    /// representing U+022C9.
    /// </summary>
    Node ltimes { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ltlarr;</c>
    /// representing U+02976.
    /// </summary>
    Node ltlarr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ltquest;</c>
    /// representing U+02A7B.
    /// </summary>
    Node ltquest { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ltri;</c>
    /// representing U+025C3.
    /// </summary>
    Node ltri { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ltrie;</c>
    /// representing U+022B4.
    /// </summary>
    Node ltrie { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ltrif;</c>
    /// representing U+025C2.
    /// </summary>
    Node ltrif { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ltrPar;</c>
    /// representing U+02996.
    /// </summary>
    Node ltrPar { get; }

    /// <summary>
    /// Gets character reference <c>&amp;lurdshar;</c>
    /// representing U+0294A.
    /// </summary>
    Node lurdshar { get; }

    /// <summary>
    /// Gets character reference <c>&amp;luruhar;</c>
    /// representing U+02966.
    /// </summary>
    Node luruhar { get; }

    /// <summary>
    /// Gets character reference <c>&amp;lvertneqq;</c>
    /// representing U+02268 U+0FE00.
    /// </summary>
    Node lvertneqq { get; }

    /// <summary>
    /// Gets character reference <c>&amp;lvnE;</c>
    /// representing U+02268 U+0FE00.
    /// </summary>
    Node lvnE { get; }

    /// <summary>
    /// Gets character reference <c>&amp;macr;</c>
    /// representing U+000AF.
    /// </summary>
    Node macr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;male;</c>
    /// representing U+02642.
    /// </summary>
    Node male { get; }

    /// <summary>
    /// Gets character reference <c>&amp;malt;</c>
    /// representing U+02720.
    /// </summary>
    Node malt { get; }

    /// <summary>
    /// Gets character reference <c>&amp;maltese;</c>
    /// representing U+02720.
    /// </summary>
    Node maltese { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Map;</c>
    /// representing U+02905.
    /// </summary>
    Node Map { get; }

    /// <summary>
    /// Gets character reference <c>&amp;map;</c>
    /// representing U+021A6.
    /// </summary>
    Node map { get; }

    /// <summary>
    /// Gets character reference <c>&amp;mapsto;</c>
    /// representing U+021A6.
    /// </summary>
    Node mapsto { get; }

    /// <summary>
    /// Gets character reference <c>&amp;mapstodown;</c>
    /// representing U+021A7.
    /// </summary>
    Node mapstodown { get; }

    /// <summary>
    /// Gets character reference <c>&amp;mapstoleft;</c>
    /// representing U+021A4.
    /// </summary>
    Node mapstoleft { get; }

    /// <summary>
    /// Gets character reference <c>&amp;mapstoup;</c>
    /// representing U+021A5.
    /// </summary>
    Node mapstoup { get; }

    /// <summary>
    /// Gets character reference <c>&amp;marker;</c>
    /// representing U+025AE.
    /// </summary>
    Node marker { get; }

    /// <summary>
    /// Gets character reference <c>&amp;mcomma;</c>
    /// representing U+02A29.
    /// </summary>
    Node mcomma { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Mcy;</c>
    /// representing U+0041C.
    /// </summary>
    Node Mcy { get; }

    /// <summary>
    /// Gets character reference <c>&amp;mcy;</c>
    /// representing U+0043C.
    /// </summary>
    Node mcy { get; }

    /// <summary>
    /// Gets character reference <c>&amp;mdash;</c>
    /// representing U+02014.
    /// </summary>
    Node mdash { get; }

    /// <summary>
    /// Gets character reference <c>&amp;mDDot;</c>
    /// representing U+0223A.
    /// </summary>
    Node mDDot { get; }

    /// <summary>
    /// Gets character reference <c>&amp;measuredangle;</c>
    /// representing U+02221.
    /// </summary>
    Node measuredangle { get; }

    /// <summary>
    /// Gets character reference <c>&amp;MediumSpace;</c>
    /// representing U+0205F.
    /// </summary>
    Node MediumSpace { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Mellintrf;</c>
    /// representing U+02133.
    /// </summary>
    Node Mellintrf { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Mfr;</c>
    /// representing U+1D510.
    /// </summary>
    Node Mfr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;mfr;</c>
    /// representing U+1D52A.
    /// </summary>
    Node mfr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;mho;</c>
    /// representing U+02127.
    /// </summary>
    Node mho { get; }

    /// <summary>
    /// Gets character reference <c>&amp;micro;</c>
    /// representing U+000B5.
    /// </summary>
    Node micro { get; }

    /// <summary>
    /// Gets character reference <c>&amp;mid;</c>
    /// representing U+02223.
    /// </summary>
    Node mid { get; }

    /// <summary>
    /// Gets character reference <c>&amp;midast;</c>
    /// representing U+0002A.
    /// </summary>
    Node midast { get; }

    /// <summary>
    /// Gets character reference <c>&amp;midcir;</c>
    /// representing U+02AF0.
    /// </summary>
    Node midcir { get; }

    /// <summary>
    /// Gets character reference <c>&amp;middot;</c>
    /// representing U+000B7.
    /// </summary>
    Node middot { get; }

    /// <summary>
    /// Gets character reference <c>&amp;minus;</c>
    /// representing U+02212.
    /// </summary>
    Node minus { get; }

    /// <summary>
    /// Gets character reference <c>&amp;minusb;</c>
    /// representing U+0229F.
    /// </summary>
    Node minusb { get; }

    /// <summary>
    /// Gets character reference <c>&amp;minusd;</c>
    /// representing U+02238.
    /// </summary>
    Node minusd { get; }

    /// <summary>
    /// Gets character reference <c>&amp;minusdu;</c>
    /// representing U+02A2A.
    /// </summary>
    Node minusdu { get; }

    /// <summary>
    /// Gets character reference <c>&amp;MinusPlus;</c>
    /// representing U+02213.
    /// </summary>
    Node MinusPlus { get; }

    /// <summary>
    /// Gets character reference <c>&amp;mlcp;</c>
    /// representing U+02ADB.
    /// </summary>
    Node mlcp { get; }

    /// <summary>
    /// Gets character reference <c>&amp;mldr;</c>
    /// representing U+02026.
    /// </summary>
    Node mldr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;mnplus;</c>
    /// representing U+02213.
    /// </summary>
    Node mnplus { get; }

    /// <summary>
    /// Gets character reference <c>&amp;models;</c>
    /// representing U+022A7.
    /// </summary>
    Node models { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Mopf;</c>
    /// representing U+1D544.
    /// </summary>
    Node Mopf { get; }

    /// <summary>
    /// Gets character reference <c>&amp;mopf;</c>
    /// representing U+1D55E.
    /// </summary>
    Node mopf { get; }

    /// <summary>
    /// Gets character reference <c>&amp;mp;</c>
    /// representing U+02213.
    /// </summary>
    Node mp { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Mscr;</c>
    /// representing U+02133.
    /// </summary>
    Node Mscr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;mscr;</c>
    /// representing U+1D4C2.
    /// </summary>
    Node mscr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;mstpos;</c>
    /// representing U+0223E.
    /// </summary>
    Node mstpos { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Mu;</c>
    /// representing U+0039C.
    /// </summary>
    Node Mu { get; }

    /// <summary>
    /// Gets character reference <c>&amp;mu;</c>
    /// representing U+003BC.
    /// </summary>
    Node mu { get; }

    /// <summary>
    /// Gets character reference <c>&amp;multimap;</c>
    /// representing U+022B8.
    /// </summary>
    Node multimap { get; }

    /// <summary>
    /// Gets character reference <c>&amp;mumap;</c>
    /// representing U+022B8.
    /// </summary>
    Node mumap { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nabla;</c>
    /// representing U+02207.
    /// </summary>
    Node nabla { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Nacute;</c>
    /// representing U+00143.
    /// </summary>
    Node Nacute { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nacute;</c>
    /// representing U+00144.
    /// </summary>
    Node nacute { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nang;</c>
    /// representing U+02220 U+020D2.
    /// </summary>
    Node nang { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nap;</c>
    /// representing U+02249.
    /// </summary>
    Node nap { get; }

    /// <summary>
    /// Gets character reference <c>&amp;napE;</c>
    /// representing U+02A70 U+00338.
    /// </summary>
    Node napE { get; }

    /// <summary>
    /// Gets character reference <c>&amp;napid;</c>
    /// representing U+0224B U+00338.
    /// </summary>
    Node napid { get; }

    /// <summary>
    /// Gets character reference <c>&amp;napos;</c>
    /// representing U+00149.
    /// </summary>
    Node napos { get; }

    /// <summary>
    /// Gets character reference <c>&amp;napprox;</c>
    /// representing U+02249.
    /// </summary>
    Node napprox { get; }

    /// <summary>
    /// Gets character reference <c>&amp;natur;</c>
    /// representing U+0266E.
    /// </summary>
    Node natur { get; }

    /// <summary>
    /// Gets character reference <c>&amp;natural;</c>
    /// representing U+0266E.
    /// </summary>
    Node natural { get; }

    /// <summary>
    /// Gets character reference <c>&amp;naturals;</c>
    /// representing U+02115.
    /// </summary>
    Node naturals { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nbsp;</c>
    /// representing U+000A0.
    /// </summary>
    Node nbsp { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nbump;</c>
    /// representing U+0224E U+00338.
    /// </summary>
    Node nbump { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nbumpe;</c>
    /// representing U+0224F U+00338.
    /// </summary>
    Node nbumpe { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ncap;</c>
    /// representing U+02A43.
    /// </summary>
    Node ncap { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Ncaron;</c>
    /// representing U+00147.
    /// </summary>
    Node Ncaron { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ncaron;</c>
    /// representing U+00148.
    /// </summary>
    Node ncaron { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Ncedil;</c>
    /// representing U+00145.
    /// </summary>
    Node Ncedil { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ncedil;</c>
    /// representing U+00146.
    /// </summary>
    Node ncedil { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ncong;</c>
    /// representing U+02247.
    /// </summary>
    Node ncong { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ncongdot;</c>
    /// representing U+02A6D U+00338.
    /// </summary>
    Node ncongdot { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ncup;</c>
    /// representing U+02A42.
    /// </summary>
    Node ncup { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Ncy;</c>
    /// representing U+0041D.
    /// </summary>
    Node Ncy { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ncy;</c>
    /// representing U+0043D.
    /// </summary>
    Node ncy { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ndash;</c>
    /// representing U+02013.
    /// </summary>
    Node ndash { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ne;</c>
    /// representing U+02260.
    /// </summary>
    Node ne { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nearhk;</c>
    /// representing U+02924.
    /// </summary>
    Node nearhk { get; }

    /// <summary>
    /// Gets character reference <c>&amp;neArr;</c>
    /// representing U+021D7.
    /// </summary>
    Node neArr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nearr;</c>
    /// representing U+02197.
    /// </summary>
    Node nearr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nearrow;</c>
    /// representing U+02197.
    /// </summary>
    Node nearrow { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nedot;</c>
    /// representing U+02250 U+00338.
    /// </summary>
    Node nedot { get; }

    /// <summary>
    /// Gets character reference <c>&amp;NegativeMediumSpace;</c>
    /// representing U+0200B.
    /// </summary>
    Node NegativeMediumSpace { get; }

    /// <summary>
    /// Gets character reference <c>&amp;NegativeThickSpace;</c>
    /// representing U+0200B.
    /// </summary>
    Node NegativeThickSpace { get; }

    /// <summary>
    /// Gets character reference <c>&amp;NegativeThinSpace;</c>
    /// representing U+0200B.
    /// </summary>
    Node NegativeThinSpace { get; }

    /// <summary>
    /// Gets character reference <c>&amp;NegativeVeryThinSpace;</c>
    /// representing U+0200B.
    /// </summary>
    Node NegativeVeryThinSpace { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nequiv;</c>
    /// representing U+02262.
    /// </summary>
    Node nequiv { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nesear;</c>
    /// representing U+02928.
    /// </summary>
    Node nesear { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nesim;</c>
    /// representing U+02242 U+00338.
    /// </summary>
    Node nesim { get; }

    /// <summary>
    /// Gets character reference <c>&amp;NestedGreaterGreater;</c>
    /// representing U+0226B.
    /// </summary>
    Node NestedGreaterGreater { get; }

    /// <summary>
    /// Gets character reference <c>&amp;NestedLessLess;</c>
    /// representing U+0226A.
    /// </summary>
    Node NestedLessLess { get; }

    /// <summary>
    /// Gets character reference <c>&amp;NewLine;</c>
    /// representing U+0000A.
    /// </summary>
    Node NewLine { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nexist;</c>
    /// representing U+02204.
    /// </summary>
    Node nexist { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nexists;</c>
    /// representing U+02204.
    /// </summary>
    Node nexists { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Nfr;</c>
    /// representing U+1D511.
    /// </summary>
    Node Nfr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nfr;</c>
    /// representing U+1D52B.
    /// </summary>
    Node nfr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ngE;</c>
    /// representing U+02267 U+00338.
    /// </summary>
    Node ngE { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nge;</c>
    /// representing U+02271.
    /// </summary>
    Node nge { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ngeq;</c>
    /// representing U+02271.
    /// </summary>
    Node ngeq { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ngeqq;</c>
    /// representing U+02267 U+00338.
    /// </summary>
    Node ngeqq { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ngeqslant;</c>
    /// representing U+02A7E U+00338.
    /// </summary>
    Node ngeqslant { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nges;</c>
    /// representing U+02A7E U+00338.
    /// </summary>
    Node nges { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nGg;</c>
    /// representing U+022D9 U+00338.
    /// </summary>
    Node nGg { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ngsim;</c>
    /// representing U+02275.
    /// </summary>
    Node ngsim { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nGt;</c>
    /// representing U+0226B U+020D2.
    /// </summary>
    Node nGt { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ngt;</c>
    /// representing U+0226F.
    /// </summary>
    Node ngt { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ngtr;</c>
    /// representing U+0226F.
    /// </summary>
    Node ngtr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nGtv;</c>
    /// representing U+0226B U+00338.
    /// </summary>
    Node nGtv { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nhArr;</c>
    /// representing U+021CE.
    /// </summary>
    Node nhArr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nharr;</c>
    /// representing U+021AE.
    /// </summary>
    Node nharr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nhpar;</c>
    /// representing U+02AF2.
    /// </summary>
    Node nhpar { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ni;</c>
    /// representing U+0220B.
    /// </summary>
    Node ni { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nis;</c>
    /// representing U+022FC.
    /// </summary>
    Node nis { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nisd;</c>
    /// representing U+022FA.
    /// </summary>
    Node nisd { get; }

    /// <summary>
    /// Gets character reference <c>&amp;niv;</c>
    /// representing U+0220B.
    /// </summary>
    Node niv { get; }

    /// <summary>
    /// Gets character reference <c>&amp;NJcy;</c>
    /// representing U+0040A.
    /// </summary>
    Node NJcy { get; }

    /// <summary>
    /// Gets character reference <c>&amp;njcy;</c>
    /// representing U+0045A.
    /// </summary>
    Node njcy { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nlArr;</c>
    /// representing U+021CD.
    /// </summary>
    Node nlArr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nlarr;</c>
    /// representing U+0219A.
    /// </summary>
    Node nlarr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nldr;</c>
    /// representing U+02025.
    /// </summary>
    Node nldr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nlE;</c>
    /// representing U+02266 U+00338.
    /// </summary>
    Node nlE { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nle;</c>
    /// representing U+02270.
    /// </summary>
    Node nle { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nLeftarrow;</c>
    /// representing U+021CD.
    /// </summary>
    Node nLeftarrow { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nleftarrow;</c>
    /// representing U+0219A.
    /// </summary>
    Node nleftarrow { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nLeftrightarrow;</c>
    /// representing U+021CE.
    /// </summary>
    Node nLeftrightarrow { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nleftrightarrow;</c>
    /// representing U+021AE.
    /// </summary>
    Node nleftrightarrow { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nleq;</c>
    /// representing U+02270.
    /// </summary>
    Node nleq { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nleqq;</c>
    /// representing U+02266 U+00338.
    /// </summary>
    Node nleqq { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nleqslant;</c>
    /// representing U+02A7D U+00338.
    /// </summary>
    Node nleqslant { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nles;</c>
    /// representing U+02A7D U+00338.
    /// </summary>
    Node nles { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nless;</c>
    /// representing U+0226E.
    /// </summary>
    Node nless { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nLl;</c>
    /// representing U+022D8 U+00338.
    /// </summary>
    Node nLl { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nlsim;</c>
    /// representing U+02274.
    /// </summary>
    Node nlsim { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nLt;</c>
    /// representing U+0226A U+020D2.
    /// </summary>
    Node nLt { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nlt;</c>
    /// representing U+0226E.
    /// </summary>
    Node nlt { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nltri;</c>
    /// representing U+022EA.
    /// </summary>
    Node nltri { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nltrie;</c>
    /// representing U+022EC.
    /// </summary>
    Node nltrie { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nLtv;</c>
    /// representing U+0226A U+00338.
    /// </summary>
    Node nLtv { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nmid;</c>
    /// representing U+02224.
    /// </summary>
    Node nmid { get; }

    /// <summary>
    /// Gets character reference <c>&amp;NoBreak;</c>
    /// representing U+02060.
    /// </summary>
    Node NoBreak { get; }

    /// <summary>
    /// Gets character reference <c>&amp;NonBreakingSpace;</c>
    /// representing U+000A0.
    /// </summary>
    Node NonBreakingSpace { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Nopf;</c>
    /// representing U+02115.
    /// </summary>
    Node Nopf { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nopf;</c>
    /// representing U+1D55F.
    /// </summary>
    Node nopf { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Not;</c>
    /// representing U+02AEC.
    /// </summary>
    Node Not { get; }

    /// <summary>
    /// Gets character reference <c>&amp;not;</c>
    /// representing U+000AC.
    /// </summary>
    Node not { get; }

    /// <summary>
    /// Gets character reference <c>&amp;NotCongruent;</c>
    /// representing U+02262.
    /// </summary>
    Node NotCongruent { get; }

    /// <summary>
    /// Gets character reference <c>&amp;NotCupCap;</c>
    /// representing U+0226D.
    /// </summary>
    Node NotCupCap { get; }

    /// <summary>
    /// Gets character reference <c>&amp;NotDoubleVerticalBar;</c>
    /// representing U+02226.
    /// </summary>
    Node NotDoubleVerticalBar { get; }

    /// <summary>
    /// Gets character reference <c>&amp;NotElement;</c>
    /// representing U+02209.
    /// </summary>
    Node NotElement { get; }

    /// <summary>
    /// Gets character reference <c>&amp;NotEqual;</c>
    /// representing U+02260.
    /// </summary>
    Node NotEqual { get; }

    /// <summary>
    /// Gets character reference <c>&amp;NotEqualTilde;</c>
    /// representing U+02242 U+00338.
    /// </summary>
    Node NotEqualTilde { get; }

    /// <summary>
    /// Gets character reference <c>&amp;NotExists;</c>
    /// representing U+02204.
    /// </summary>
    Node NotExists { get; }

    /// <summary>
    /// Gets character reference <c>&amp;NotGreater;</c>
    /// representing U+0226F.
    /// </summary>
    Node NotGreater { get; }

    /// <summary>
    /// Gets character reference <c>&amp;NotGreaterEqual;</c>
    /// representing U+02271.
    /// </summary>
    Node NotGreaterEqual { get; }

    /// <summary>
    /// Gets character reference <c>&amp;NotGreaterFullEqual;</c>
    /// representing U+02267 U+00338.
    /// </summary>
    Node NotGreaterFullEqual { get; }

    /// <summary>
    /// Gets character reference <c>&amp;NotGreaterGreater;</c>
    /// representing U+0226B U+00338.
    /// </summary>
    Node NotGreaterGreater { get; }

    /// <summary>
    /// Gets character reference <c>&amp;NotGreaterLess;</c>
    /// representing U+02279.
    /// </summary>
    Node NotGreaterLess { get; }

    /// <summary>
    /// Gets character reference <c>&amp;NotGreaterSlantEqual;</c>
    /// representing U+02A7E U+00338.
    /// </summary>
    Node NotGreaterSlantEqual { get; }

    /// <summary>
    /// Gets character reference <c>&amp;NotGreaterTilde;</c>
    /// representing U+02275.
    /// </summary>
    Node NotGreaterTilde { get; }

    /// <summary>
    /// Gets character reference <c>&amp;NotHumpDownHump;</c>
    /// representing U+0224E U+00338.
    /// </summary>
    Node NotHumpDownHump { get; }

    /// <summary>
    /// Gets character reference <c>&amp;NotHumpEqual;</c>
    /// representing U+0224F U+00338.
    /// </summary>
    Node NotHumpEqual { get; }

    /// <summary>
    /// Gets character reference <c>&amp;notin;</c>
    /// representing U+02209.
    /// </summary>
    Node notin { get; }

    /// <summary>
    /// Gets character reference <c>&amp;notindot;</c>
    /// representing U+022F5 U+00338.
    /// </summary>
    Node notindot { get; }

    /// <summary>
    /// Gets character reference <c>&amp;notinE;</c>
    /// representing U+022F9 U+00338.
    /// </summary>
    Node notinE { get; }

    /// <summary>
    /// Gets character reference <c>&amp;notinva;</c>
    /// representing U+02209.
    /// </summary>
    Node notinva { get; }

    /// <summary>
    /// Gets character reference <c>&amp;notinvb;</c>
    /// representing U+022F7.
    /// </summary>
    Node notinvb { get; }

    /// <summary>
    /// Gets character reference <c>&amp;notinvc;</c>
    /// representing U+022F6.
    /// </summary>
    Node notinvc { get; }

    /// <summary>
    /// Gets character reference <c>&amp;NotLeftTriangle;</c>
    /// representing U+022EA.
    /// </summary>
    Node NotLeftTriangle { get; }

    /// <summary>
    /// Gets character reference <c>&amp;NotLeftTriangleBar;</c>
    /// representing U+029CF U+00338.
    /// </summary>
    Node NotLeftTriangleBar { get; }

    /// <summary>
    /// Gets character reference <c>&amp;NotLeftTriangleEqual;</c>
    /// representing U+022EC.
    /// </summary>
    Node NotLeftTriangleEqual { get; }

    /// <summary>
    /// Gets character reference <c>&amp;NotLess;</c>
    /// representing U+0226E.
    /// </summary>
    Node NotLess { get; }

    /// <summary>
    /// Gets character reference <c>&amp;NotLessEqual;</c>
    /// representing U+02270.
    /// </summary>
    Node NotLessEqual { get; }

    /// <summary>
    /// Gets character reference <c>&amp;NotLessGreater;</c>
    /// representing U+02278.
    /// </summary>
    Node NotLessGreater { get; }

    /// <summary>
    /// Gets character reference <c>&amp;NotLessLess;</c>
    /// representing U+0226A U+00338.
    /// </summary>
    Node NotLessLess { get; }

    /// <summary>
    /// Gets character reference <c>&amp;NotLessSlantEqual;</c>
    /// representing U+02A7D U+00338.
    /// </summary>
    Node NotLessSlantEqual { get; }

    /// <summary>
    /// Gets character reference <c>&amp;NotLessTilde;</c>
    /// representing U+02274.
    /// </summary>
    Node NotLessTilde { get; }

    /// <summary>
    /// Gets character reference <c>&amp;NotNestedGreaterGreater;</c>
    /// representing U+02AA2 U+00338.
    /// </summary>
    Node NotNestedGreaterGreater { get; }

    /// <summary>
    /// Gets character reference <c>&amp;NotNestedLessLess;</c>
    /// representing U+02AA1 U+00338.
    /// </summary>
    Node NotNestedLessLess { get; }

    /// <summary>
    /// Gets character reference <c>&amp;notni;</c>
    /// representing U+0220C.
    /// </summary>
    Node notni { get; }

    /// <summary>
    /// Gets character reference <c>&amp;notniva;</c>
    /// representing U+0220C.
    /// </summary>
    Node notniva { get; }

    /// <summary>
    /// Gets character reference <c>&amp;notnivb;</c>
    /// representing U+022FE.
    /// </summary>
    Node notnivb { get; }

    /// <summary>
    /// Gets character reference <c>&amp;notnivc;</c>
    /// representing U+022FD.
    /// </summary>
    Node notnivc { get; }

    /// <summary>
    /// Gets character reference <c>&amp;NotPrecedes;</c>
    /// representing U+02280.
    /// </summary>
    Node NotPrecedes { get; }

    /// <summary>
    /// Gets character reference <c>&amp;NotPrecedesEqual;</c>
    /// representing U+02AAF U+00338.
    /// </summary>
    Node NotPrecedesEqual { get; }

    /// <summary>
    /// Gets character reference <c>&amp;NotPrecedesSlantEqual;</c>
    /// representing U+022E0.
    /// </summary>
    Node NotPrecedesSlantEqual { get; }

    /// <summary>
    /// Gets character reference <c>&amp;NotReverseElement;</c>
    /// representing U+0220C.
    /// </summary>
    Node NotReverseElement { get; }

    /// <summary>
    /// Gets character reference <c>&amp;NotRightTriangle;</c>
    /// representing U+022EB.
    /// </summary>
    Node NotRightTriangle { get; }

    /// <summary>
    /// Gets character reference <c>&amp;NotRightTriangleBar;</c>
    /// representing U+029D0 U+00338.
    /// </summary>
    Node NotRightTriangleBar { get; }

    /// <summary>
    /// Gets character reference <c>&amp;NotRightTriangleEqual;</c>
    /// representing U+022ED.
    /// </summary>
    Node NotRightTriangleEqual { get; }

    /// <summary>
    /// Gets character reference <c>&amp;NotSquareSubset;</c>
    /// representing U+0228F U+00338.
    /// </summary>
    Node NotSquareSubset { get; }

    /// <summary>
    /// Gets character reference <c>&amp;NotSquareSubsetEqual;</c>
    /// representing U+022E2.
    /// </summary>
    Node NotSquareSubsetEqual { get; }

    /// <summary>
    /// Gets character reference <c>&amp;NotSquareSuperset;</c>
    /// representing U+02290 U+00338.
    /// </summary>
    Node NotSquareSuperset { get; }

    /// <summary>
    /// Gets character reference <c>&amp;NotSquareSupersetEqual;</c>
    /// representing U+022E3.
    /// </summary>
    Node NotSquareSupersetEqual { get; }

    /// <summary>
    /// Gets character reference <c>&amp;NotSubset;</c>
    /// representing U+02282 U+020D2.
    /// </summary>
    Node NotSubset { get; }

    /// <summary>
    /// Gets character reference <c>&amp;NotSubsetEqual;</c>
    /// representing U+02288.
    /// </summary>
    Node NotSubsetEqual { get; }

    /// <summary>
    /// Gets character reference <c>&amp;NotSucceeds;</c>
    /// representing U+02281.
    /// </summary>
    Node NotSucceeds { get; }

    /// <summary>
    /// Gets character reference <c>&amp;NotSucceedsEqual;</c>
    /// representing U+02AB0 U+00338.
    /// </summary>
    Node NotSucceedsEqual { get; }

    /// <summary>
    /// Gets character reference <c>&amp;NotSucceedsSlantEqual;</c>
    /// representing U+022E1.
    /// </summary>
    Node NotSucceedsSlantEqual { get; }

    /// <summary>
    /// Gets character reference <c>&amp;NotSucceedsTilde;</c>
    /// representing U+0227F U+00338.
    /// </summary>
    Node NotSucceedsTilde { get; }

    /// <summary>
    /// Gets character reference <c>&amp;NotSuperset;</c>
    /// representing U+02283 U+020D2.
    /// </summary>
    Node NotSuperset { get; }

    /// <summary>
    /// Gets character reference <c>&amp;NotSupersetEqual;</c>
    /// representing U+02289.
    /// </summary>
    Node NotSupersetEqual { get; }

    /// <summary>
    /// Gets character reference <c>&amp;NotTilde;</c>
    /// representing U+02241.
    /// </summary>
    Node NotTilde { get; }

    /// <summary>
    /// Gets character reference <c>&amp;NotTildeEqual;</c>
    /// representing U+02244.
    /// </summary>
    Node NotTildeEqual { get; }

    /// <summary>
    /// Gets character reference <c>&amp;NotTildeFullEqual;</c>
    /// representing U+02247.
    /// </summary>
    Node NotTildeFullEqual { get; }

    /// <summary>
    /// Gets character reference <c>&amp;NotTildeTilde;</c>
    /// representing U+02249.
    /// </summary>
    Node NotTildeTilde { get; }

    /// <summary>
    /// Gets character reference <c>&amp;NotVerticalBar;</c>
    /// representing U+02224.
    /// </summary>
    Node NotVerticalBar { get; }

    /// <summary>
    /// Gets character reference <c>&amp;npar;</c>
    /// representing U+02226.
    /// </summary>
    Node npar { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nparallel;</c>
    /// representing U+02226.
    /// </summary>
    Node nparallel { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nparsl;</c>
    /// representing U+02AFD U+020E5.
    /// </summary>
    Node nparsl { get; }

    /// <summary>
    /// Gets character reference <c>&amp;npart;</c>
    /// representing U+02202 U+00338.
    /// </summary>
    Node npart { get; }

    /// <summary>
    /// Gets character reference <c>&amp;npolint;</c>
    /// representing U+02A14.
    /// </summary>
    Node npolint { get; }

    /// <summary>
    /// Gets character reference <c>&amp;npr;</c>
    /// representing U+02280.
    /// </summary>
    Node npr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nprcue;</c>
    /// representing U+022E0.
    /// </summary>
    Node nprcue { get; }

    /// <summary>
    /// Gets character reference <c>&amp;npre;</c>
    /// representing U+02AAF U+00338.
    /// </summary>
    Node npre { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nprec;</c>
    /// representing U+02280.
    /// </summary>
    Node nprec { get; }

    /// <summary>
    /// Gets character reference <c>&amp;npreceq;</c>
    /// representing U+02AAF U+00338.
    /// </summary>
    Node npreceq { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nrArr;</c>
    /// representing U+021CF.
    /// </summary>
    Node nrArr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nrarr;</c>
    /// representing U+0219B.
    /// </summary>
    Node nrarr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nrarrc;</c>
    /// representing U+02933 U+00338.
    /// </summary>
    Node nrarrc { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nrarrw;</c>
    /// representing U+0219D U+00338.
    /// </summary>
    Node nrarrw { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nRightarrow;</c>
    /// representing U+021CF.
    /// </summary>
    Node nRightarrow { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nrightarrow;</c>
    /// representing U+0219B.
    /// </summary>
    Node nrightarrow { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nrtri;</c>
    /// representing U+022EB.
    /// </summary>
    Node nrtri { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nrtrie;</c>
    /// representing U+022ED.
    /// </summary>
    Node nrtrie { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nsc;</c>
    /// representing U+02281.
    /// </summary>
    Node nsc { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nsccue;</c>
    /// representing U+022E1.
    /// </summary>
    Node nsccue { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nsce;</c>
    /// representing U+02AB0 U+00338.
    /// </summary>
    Node nsce { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Nscr;</c>
    /// representing U+1D4A9.
    /// </summary>
    Node Nscr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nscr;</c>
    /// representing U+1D4C3.
    /// </summary>
    Node nscr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nshortmid;</c>
    /// representing U+02224.
    /// </summary>
    Node nshortmid { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nshortparallel;</c>
    /// representing U+02226.
    /// </summary>
    Node nshortparallel { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nsim;</c>
    /// representing U+02241.
    /// </summary>
    Node nsim { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nsime;</c>
    /// representing U+02244.
    /// </summary>
    Node nsime { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nsimeq;</c>
    /// representing U+02244.
    /// </summary>
    Node nsimeq { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nsmid;</c>
    /// representing U+02224.
    /// </summary>
    Node nsmid { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nspar;</c>
    /// representing U+02226.
    /// </summary>
    Node nspar { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nsqsube;</c>
    /// representing U+022E2.
    /// </summary>
    Node nsqsube { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nsqsupe;</c>
    /// representing U+022E3.
    /// </summary>
    Node nsqsupe { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nsub;</c>
    /// representing U+02284.
    /// </summary>
    Node nsub { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nsubE;</c>
    /// representing U+02AC5 U+00338.
    /// </summary>
    Node nsubE { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nsube;</c>
    /// representing U+02288.
    /// </summary>
    Node nsube { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nsubset;</c>
    /// representing U+02282 U+020D2.
    /// </summary>
    Node nsubset { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nsubseteq;</c>
    /// representing U+02288.
    /// </summary>
    Node nsubseteq { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nsubseteqq;</c>
    /// representing U+02AC5 U+00338.
    /// </summary>
    Node nsubseteqq { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nsucc;</c>
    /// representing U+02281.
    /// </summary>
    Node nsucc { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nsucceq;</c>
    /// representing U+02AB0 U+00338.
    /// </summary>
    Node nsucceq { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nsup;</c>
    /// representing U+02285.
    /// </summary>
    Node nsup { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nsupE;</c>
    /// representing U+02AC6 U+00338.
    /// </summary>
    Node nsupE { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nsupe;</c>
    /// representing U+02289.
    /// </summary>
    Node nsupe { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nsupset;</c>
    /// representing U+02283 U+020D2.
    /// </summary>
    Node nsupset { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nsupseteq;</c>
    /// representing U+02289.
    /// </summary>
    Node nsupseteq { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nsupseteqq;</c>
    /// representing U+02AC6 U+00338.
    /// </summary>
    Node nsupseteqq { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ntgl;</c>
    /// representing U+02279.
    /// </summary>
    Node ntgl { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Ntilde;</c>
    /// representing U+000D1.
    /// </summary>
    Node Ntilde { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ntilde;</c>
    /// representing U+000F1.
    /// </summary>
    Node ntilde { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ntlg;</c>
    /// representing U+02278.
    /// </summary>
    Node ntlg { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ntriangleleft;</c>
    /// representing U+022EA.
    /// </summary>
    Node ntriangleleft { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ntrianglelefteq;</c>
    /// representing U+022EC.
    /// </summary>
    Node ntrianglelefteq { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ntriangleright;</c>
    /// representing U+022EB.
    /// </summary>
    Node ntriangleright { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ntrianglerighteq;</c>
    /// representing U+022ED.
    /// </summary>
    Node ntrianglerighteq { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Nu;</c>
    /// representing U+0039D.
    /// </summary>
    Node Nu { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nu;</c>
    /// representing U+003BD.
    /// </summary>
    Node nu { get; }

    /// <summary>
    /// Gets character reference <c>&amp;num;</c>
    /// representing U+00023.
    /// </summary>
    Node num { get; }

    /// <summary>
    /// Gets character reference <c>&amp;numero;</c>
    /// representing U+02116.
    /// </summary>
    Node numero { get; }

    /// <summary>
    /// Gets character reference <c>&amp;numsp;</c>
    /// representing U+02007.
    /// </summary>
    Node numsp { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nvap;</c>
    /// representing U+0224D U+020D2.
    /// </summary>
    Node nvap { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nVDash;</c>
    /// representing U+022AF.
    /// </summary>
    Node nVDash { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nVdash;</c>
    /// representing U+022AE.
    /// </summary>
    Node nVdash { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nvDash;</c>
    /// representing U+022AD.
    /// </summary>
    Node nvDash { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nvdash;</c>
    /// representing U+022AC.
    /// </summary>
    Node nvdash { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nvge;</c>
    /// representing U+02265 U+020D2.
    /// </summary>
    Node nvge { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nvgt;</c>
    /// representing U+0003E U+020D2.
    /// </summary>
    Node nvgt { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nvHarr;</c>
    /// representing U+02904.
    /// </summary>
    Node nvHarr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nvinfin;</c>
    /// representing U+029DE.
    /// </summary>
    Node nvinfin { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nvlArr;</c>
    /// representing U+02902.
    /// </summary>
    Node nvlArr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nvle;</c>
    /// representing U+02264 U+020D2.
    /// </summary>
    Node nvle { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nvlt;</c>
    /// representing U+0003C U+020D2.
    /// </summary>
    Node nvlt { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nvltrie;</c>
    /// representing U+022B4 U+020D2.
    /// </summary>
    Node nvltrie { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nvrArr;</c>
    /// representing U+02903.
    /// </summary>
    Node nvrArr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nvrtrie;</c>
    /// representing U+022B5 U+020D2.
    /// </summary>
    Node nvrtrie { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nvsim;</c>
    /// representing U+0223C U+020D2.
    /// </summary>
    Node nvsim { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nwarhk;</c>
    /// representing U+02923.
    /// </summary>
    Node nwarhk { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nwArr;</c>
    /// representing U+021D6.
    /// </summary>
    Node nwArr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nwarr;</c>
    /// representing U+02196.
    /// </summary>
    Node nwarr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nwarrow;</c>
    /// representing U+02196.
    /// </summary>
    Node nwarrow { get; }

    /// <summary>
    /// Gets character reference <c>&amp;nwnear;</c>
    /// representing U+02927.
    /// </summary>
    Node nwnear { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Oacute;</c>
    /// representing U+000D3.
    /// </summary>
    Node Oacute { get; }

    /// <summary>
    /// Gets character reference <c>&amp;oacute;</c>
    /// representing U+000F3.
    /// </summary>
    Node oacute { get; }

    /// <summary>
    /// Gets character reference <c>&amp;oast;</c>
    /// representing U+0229B.
    /// </summary>
    Node oast { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ocir;</c>
    /// representing U+0229A.
    /// </summary>
    Node ocir { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Ocirc;</c>
    /// representing U+000D4.
    /// </summary>
    Node Ocirc { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ocirc;</c>
    /// representing U+000F4.
    /// </summary>
    Node ocirc { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Ocy;</c>
    /// representing U+0041E.
    /// </summary>
    Node Ocy { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ocy;</c>
    /// representing U+0043E.
    /// </summary>
    Node ocy { get; }

    /// <summary>
    /// Gets character reference <c>&amp;odash;</c>
    /// representing U+0229D.
    /// </summary>
    Node odash { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Odblac;</c>
    /// representing U+00150.
    /// </summary>
    Node Odblac { get; }

    /// <summary>
    /// Gets character reference <c>&amp;odblac;</c>
    /// representing U+00151.
    /// </summary>
    Node odblac { get; }

    /// <summary>
    /// Gets character reference <c>&amp;odiv;</c>
    /// representing U+02A38.
    /// </summary>
    Node odiv { get; }

    /// <summary>
    /// Gets character reference <c>&amp;odot;</c>
    /// representing U+02299.
    /// </summary>
    Node odot { get; }

    /// <summary>
    /// Gets character reference <c>&amp;odsold;</c>
    /// representing U+029BC.
    /// </summary>
    Node odsold { get; }

    /// <summary>
    /// Gets character reference <c>&amp;OElig;</c>
    /// representing U+00152.
    /// </summary>
    Node OElig { get; }

    /// <summary>
    /// Gets character reference <c>&amp;oelig;</c>
    /// representing U+00153.
    /// </summary>
    Node oelig { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ofcir;</c>
    /// representing U+029BF.
    /// </summary>
    Node ofcir { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Ofr;</c>
    /// representing U+1D512.
    /// </summary>
    Node Ofr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ofr;</c>
    /// representing U+1D52C.
    /// </summary>
    Node ofr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ogon;</c>
    /// representing U+002DB.
    /// </summary>
    Node ogon { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Ograve;</c>
    /// representing U+000D2.
    /// </summary>
    Node Ograve { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ograve;</c>
    /// representing U+000F2.
    /// </summary>
    Node ograve { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ogt;</c>
    /// representing U+029C1.
    /// </summary>
    Node ogt { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ohbar;</c>
    /// representing U+029B5.
    /// </summary>
    Node ohbar { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ohm;</c>
    /// representing U+003A9.
    /// </summary>
    Node ohm { get; }

    /// <summary>
    /// Gets character reference <c>&amp;oint;</c>
    /// representing U+0222E.
    /// </summary>
    Node oint { get; }

    /// <summary>
    /// Gets character reference <c>&amp;olarr;</c>
    /// representing U+021BA.
    /// </summary>
    Node olarr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;olcir;</c>
    /// representing U+029BE.
    /// </summary>
    Node olcir { get; }

    /// <summary>
    /// Gets character reference <c>&amp;olcross;</c>
    /// representing U+029BB.
    /// </summary>
    Node olcross { get; }

    /// <summary>
    /// Gets character reference <c>&amp;oline;</c>
    /// representing U+0203E.
    /// </summary>
    Node oline { get; }

    /// <summary>
    /// Gets character reference <c>&amp;olt;</c>
    /// representing U+029C0.
    /// </summary>
    Node olt { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Omacr;</c>
    /// representing U+0014C.
    /// </summary>
    Node Omacr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;omacr;</c>
    /// representing U+0014D.
    /// </summary>
    Node omacr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Omega;</c>
    /// representing U+003A9.
    /// </summary>
    Node Omega { get; }

    /// <summary>
    /// Gets character reference <c>&amp;omega;</c>
    /// representing U+003C9.
    /// </summary>
    Node omega { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Omicron;</c>
    /// representing U+0039F.
    /// </summary>
    Node Omicron { get; }

    /// <summary>
    /// Gets character reference <c>&amp;omicron;</c>
    /// representing U+003BF.
    /// </summary>
    Node omicron { get; }

    /// <summary>
    /// Gets character reference <c>&amp;omid;</c>
    /// representing U+029B6.
    /// </summary>
    Node omid { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ominus;</c>
    /// representing U+02296.
    /// </summary>
    Node ominus { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Oopf;</c>
    /// representing U+1D546.
    /// </summary>
    Node Oopf { get; }

    /// <summary>
    /// Gets character reference <c>&amp;oopf;</c>
    /// representing U+1D560.
    /// </summary>
    Node oopf { get; }

    /// <summary>
    /// Gets character reference <c>&amp;opar;</c>
    /// representing U+029B7.
    /// </summary>
    Node opar { get; }

    /// <summary>
    /// Gets character reference <c>&amp;OpenCurlyDoubleQuote;</c>
    /// representing U+0201C.
    /// </summary>
    Node OpenCurlyDoubleQuote { get; }

    /// <summary>
    /// Gets character reference <c>&amp;OpenCurlyQuote;</c>
    /// representing U+02018.
    /// </summary>
    Node OpenCurlyQuote { get; }

    /// <summary>
    /// Gets character reference <c>&amp;operp;</c>
    /// representing U+029B9.
    /// </summary>
    Node operp { get; }

    /// <summary>
    /// Gets character reference <c>&amp;oplus;</c>
    /// representing U+02295.
    /// </summary>
    Node oplus { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Or;</c>
    /// representing U+02A54.
    /// </summary>
    Node Or { get; }

    /// <summary>
    /// Gets character reference <c>&amp;or;</c>
    /// representing U+02228.
    /// </summary>
    Node or { get; }

    /// <summary>
    /// Gets character reference <c>&amp;orarr;</c>
    /// representing U+021BB.
    /// </summary>
    Node orarr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ord;</c>
    /// representing U+02A5D.
    /// </summary>
    Node ord { get; }

    /// <summary>
    /// Gets character reference <c>&amp;order;</c>
    /// representing U+02134.
    /// </summary>
    Node order { get; }

    /// <summary>
    /// Gets character reference <c>&amp;orderof;</c>
    /// representing U+02134.
    /// </summary>
    Node orderof { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ordf;</c>
    /// representing U+000AA.
    /// </summary>
    Node ordf { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ordm;</c>
    /// representing U+000BA.
    /// </summary>
    Node ordm { get; }

    /// <summary>
    /// Gets character reference <c>&amp;origof;</c>
    /// representing U+022B6.
    /// </summary>
    Node origof { get; }

    /// <summary>
    /// Gets character reference <c>&amp;oror;</c>
    /// representing U+02A56.
    /// </summary>
    Node oror { get; }

    /// <summary>
    /// Gets character reference <c>&amp;orslope;</c>
    /// representing U+02A57.
    /// </summary>
    Node orslope { get; }

    /// <summary>
    /// Gets character reference <c>&amp;orv;</c>
    /// representing U+02A5B.
    /// </summary>
    Node orv { get; }

    /// <summary>
    /// Gets character reference <c>&amp;oS;</c>
    /// representing U+024C8.
    /// </summary>
    Node oS { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Oscr;</c>
    /// representing U+1D4AA.
    /// </summary>
    Node Oscr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;oscr;</c>
    /// representing U+02134.
    /// </summary>
    Node oscr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Oslash;</c>
    /// representing U+000D8.
    /// </summary>
    Node Oslash { get; }

    /// <summary>
    /// Gets character reference <c>&amp;oslash;</c>
    /// representing U+000F8.
    /// </summary>
    Node oslash { get; }

    /// <summary>
    /// Gets character reference <c>&amp;osol;</c>
    /// representing U+02298.
    /// </summary>
    Node osol { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Otilde;</c>
    /// representing U+000D5.
    /// </summary>
    Node Otilde { get; }

    /// <summary>
    /// Gets character reference <c>&amp;otilde;</c>
    /// representing U+000F5.
    /// </summary>
    Node otilde { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Otimes;</c>
    /// representing U+02A37.
    /// </summary>
    Node Otimes { get; }

    /// <summary>
    /// Gets character reference <c>&amp;otimes;</c>
    /// representing U+02297.
    /// </summary>
    Node otimes { get; }

    /// <summary>
    /// Gets character reference <c>&amp;otimesas;</c>
    /// representing U+02A36.
    /// </summary>
    Node otimesas { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Ouml;</c>
    /// representing U+000D6.
    /// </summary>
    Node Ouml { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ouml;</c>
    /// representing U+000F6.
    /// </summary>
    Node ouml { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ovbar;</c>
    /// representing U+0233D.
    /// </summary>
    Node ovbar { get; }

    /// <summary>
    /// Gets character reference <c>&amp;OverBar;</c>
    /// representing U+0203E.
    /// </summary>
    Node OverBar { get; }

    /// <summary>
    /// Gets character reference <c>&amp;OverBrace;</c>
    /// representing U+023DE.
    /// </summary>
    Node OverBrace { get; }

    /// <summary>
    /// Gets character reference <c>&amp;OverBracket;</c>
    /// representing U+023B4.
    /// </summary>
    Node OverBracket { get; }

    /// <summary>
    /// Gets character reference <c>&amp;OverParenthesis;</c>
    /// representing U+023DC.
    /// </summary>
    Node OverParenthesis { get; }

    /// <summary>
    /// Gets character reference <c>&amp;par;</c>
    /// representing U+02225.
    /// </summary>
    Node par { get; }

    /// <summary>
    /// Gets character reference <c>&amp;para;</c>
    /// representing U+000B6.
    /// </summary>
    Node para { get; }

    /// <summary>
    /// Gets character reference <c>&amp;parallel;</c>
    /// representing U+02225.
    /// </summary>
    Node parallel { get; }

    /// <summary>
    /// Gets character reference <c>&amp;parsim;</c>
    /// representing U+02AF3.
    /// </summary>
    Node parsim { get; }

    /// <summary>
    /// Gets character reference <c>&amp;parsl;</c>
    /// representing U+02AFD.
    /// </summary>
    Node parsl { get; }

    /// <summary>
    /// Gets character reference <c>&amp;part;</c>
    /// representing U+02202.
    /// </summary>
    Node part { get; }

    /// <summary>
    /// Gets character reference <c>&amp;PartialD;</c>
    /// representing U+02202.
    /// </summary>
    Node PartialD { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Pcy;</c>
    /// representing U+0041F.
    /// </summary>
    Node Pcy { get; }

    /// <summary>
    /// Gets character reference <c>&amp;pcy;</c>
    /// representing U+0043F.
    /// </summary>
    Node pcy { get; }

    /// <summary>
    /// Gets character reference <c>&amp;percnt;</c>
    /// representing U+00025.
    /// </summary>
    Node percnt { get; }

    /// <summary>
    /// Gets character reference <c>&amp;period;</c>
    /// representing U+0002E.
    /// </summary>
    Node period { get; }

    /// <summary>
    /// Gets character reference <c>&amp;permil;</c>
    /// representing U+02030.
    /// </summary>
    Node permil { get; }

    /// <summary>
    /// Gets character reference <c>&amp;perp;</c>
    /// representing U+022A5.
    /// </summary>
    Node perp { get; }

    /// <summary>
    /// Gets character reference <c>&amp;pertenk;</c>
    /// representing U+02031.
    /// </summary>
    Node pertenk { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Pfr;</c>
    /// representing U+1D513.
    /// </summary>
    Node Pfr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;pfr;</c>
    /// representing U+1D52D.
    /// </summary>
    Node pfr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Phi;</c>
    /// representing U+003A6.
    /// </summary>
    Node Phi { get; }

    /// <summary>
    /// Gets character reference <c>&amp;phi;</c>
    /// representing U+003C6.
    /// </summary>
    Node phi { get; }

    /// <summary>
    /// Gets character reference <c>&amp;phiv;</c>
    /// representing U+003D5.
    /// </summary>
    Node phiv { get; }

    /// <summary>
    /// Gets character reference <c>&amp;phmmat;</c>
    /// representing U+02133.
    /// </summary>
    Node phmmat { get; }

    /// <summary>
    /// Gets character reference <c>&amp;phone;</c>
    /// representing U+0260E.
    /// </summary>
    Node phone { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Pi;</c>
    /// representing U+003A0.
    /// </summary>
    Node Pi { get; }

    /// <summary>
    /// Gets character reference <c>&amp;pi;</c>
    /// representing U+003C0.
    /// </summary>
    Node pi { get; }

    /// <summary>
    /// Gets character reference <c>&amp;pitchfork;</c>
    /// representing U+022D4.
    /// </summary>
    Node pitchfork { get; }

    /// <summary>
    /// Gets character reference <c>&amp;piv;</c>
    /// representing U+003D6.
    /// </summary>
    Node piv { get; }

    /// <summary>
    /// Gets character reference <c>&amp;planck;</c>
    /// representing U+0210F.
    /// </summary>
    Node planck { get; }

    /// <summary>
    /// Gets character reference <c>&amp;planckh;</c>
    /// representing U+0210E.
    /// </summary>
    Node planckh { get; }

    /// <summary>
    /// Gets character reference <c>&amp;plankv;</c>
    /// representing U+0210F.
    /// </summary>
    Node plankv { get; }

    /// <summary>
    /// Gets character reference <c>&amp;plus;</c>
    /// representing U+0002B.
    /// </summary>
    Node plus { get; }

    /// <summary>
    /// Gets character reference <c>&amp;plusacir;</c>
    /// representing U+02A23.
    /// </summary>
    Node plusacir { get; }

    /// <summary>
    /// Gets character reference <c>&amp;plusb;</c>
    /// representing U+0229E.
    /// </summary>
    Node plusb { get; }

    /// <summary>
    /// Gets character reference <c>&amp;pluscir;</c>
    /// representing U+02A22.
    /// </summary>
    Node pluscir { get; }

    /// <summary>
    /// Gets character reference <c>&amp;plusdo;</c>
    /// representing U+02214.
    /// </summary>
    Node plusdo { get; }

    /// <summary>
    /// Gets character reference <c>&amp;plusdu;</c>
    /// representing U+02A25.
    /// </summary>
    Node plusdu { get; }

    /// <summary>
    /// Gets character reference <c>&amp;pluse;</c>
    /// representing U+02A72.
    /// </summary>
    Node pluse { get; }

    /// <summary>
    /// Gets character reference <c>&amp;PlusMinus;</c>
    /// representing U+000B1.
    /// </summary>
    Node PlusMinus { get; }

    /// <summary>
    /// Gets character reference <c>&amp;plusmn;</c>
    /// representing U+000B1.
    /// </summary>
    Node plusmn { get; }

    /// <summary>
    /// Gets character reference <c>&amp;plussim;</c>
    /// representing U+02A26.
    /// </summary>
    Node plussim { get; }

    /// <summary>
    /// Gets character reference <c>&amp;plustwo;</c>
    /// representing U+02A27.
    /// </summary>
    Node plustwo { get; }

    /// <summary>
    /// Gets character reference <c>&amp;pm;</c>
    /// representing U+000B1.
    /// </summary>
    Node pm { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Poincareplane;</c>
    /// representing U+0210C.
    /// </summary>
    Node Poincareplane { get; }

    /// <summary>
    /// Gets character reference <c>&amp;pointint;</c>
    /// representing U+02A15.
    /// </summary>
    Node pointint { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Popf;</c>
    /// representing U+02119.
    /// </summary>
    Node Popf { get; }

    /// <summary>
    /// Gets character reference <c>&amp;popf;</c>
    /// representing U+1D561.
    /// </summary>
    Node popf { get; }

    /// <summary>
    /// Gets character reference <c>&amp;pound;</c>
    /// representing U+000A3.
    /// </summary>
    Node pound { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Pr;</c>
    /// representing U+02ABB.
    /// </summary>
    Node Pr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;pr;</c>
    /// representing U+0227A.
    /// </summary>
    Node pr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;prap;</c>
    /// representing U+02AB7.
    /// </summary>
    Node prap { get; }

    /// <summary>
    /// Gets character reference <c>&amp;prcue;</c>
    /// representing U+0227C.
    /// </summary>
    Node prcue { get; }

    /// <summary>
    /// Gets character reference <c>&amp;prE;</c>
    /// representing U+02AB3.
    /// </summary>
    Node prE { get; }

    /// <summary>
    /// Gets character reference <c>&amp;pre;</c>
    /// representing U+02AAF.
    /// </summary>
    Node pre { get; }

    /// <summary>
    /// Gets character reference <c>&amp;prec;</c>
    /// representing U+0227A.
    /// </summary>
    Node prec { get; }

    /// <summary>
    /// Gets character reference <c>&amp;precapprox;</c>
    /// representing U+02AB7.
    /// </summary>
    Node precapprox { get; }

    /// <summary>
    /// Gets character reference <c>&amp;preccurlyeq;</c>
    /// representing U+0227C.
    /// </summary>
    Node preccurlyeq { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Precedes;</c>
    /// representing U+0227A.
    /// </summary>
    Node Precedes { get; }

    /// <summary>
    /// Gets character reference <c>&amp;PrecedesEqual;</c>
    /// representing U+02AAF.
    /// </summary>
    Node PrecedesEqual { get; }

    /// <summary>
    /// Gets character reference <c>&amp;PrecedesSlantEqual;</c>
    /// representing U+0227C.
    /// </summary>
    Node PrecedesSlantEqual { get; }

    /// <summary>
    /// Gets character reference <c>&amp;PrecedesTilde;</c>
    /// representing U+0227E.
    /// </summary>
    Node PrecedesTilde { get; }

    /// <summary>
    /// Gets character reference <c>&amp;preceq;</c>
    /// representing U+02AAF.
    /// </summary>
    Node preceq { get; }

    /// <summary>
    /// Gets character reference <c>&amp;precnapprox;</c>
    /// representing U+02AB9.
    /// </summary>
    Node precnapprox { get; }

    /// <summary>
    /// Gets character reference <c>&amp;precneqq;</c>
    /// representing U+02AB5.
    /// </summary>
    Node precneqq { get; }

    /// <summary>
    /// Gets character reference <c>&amp;precnsim;</c>
    /// representing U+022E8.
    /// </summary>
    Node precnsim { get; }

    /// <summary>
    /// Gets character reference <c>&amp;precsim;</c>
    /// representing U+0227E.
    /// </summary>
    Node precsim { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Prime;</c>
    /// representing U+02033.
    /// </summary>
    Node Prime { get; }

    /// <summary>
    /// Gets character reference <c>&amp;prime;</c>
    /// representing U+02032.
    /// </summary>
    Node prime { get; }

    /// <summary>
    /// Gets character reference <c>&amp;primes;</c>
    /// representing U+02119.
    /// </summary>
    Node primes { get; }

    /// <summary>
    /// Gets character reference <c>&amp;prnap;</c>
    /// representing U+02AB9.
    /// </summary>
    Node prnap { get; }

    /// <summary>
    /// Gets character reference <c>&amp;prnE;</c>
    /// representing U+02AB5.
    /// </summary>
    Node prnE { get; }

    /// <summary>
    /// Gets character reference <c>&amp;prnsim;</c>
    /// representing U+022E8.
    /// </summary>
    Node prnsim { get; }

    /// <summary>
    /// Gets character reference <c>&amp;prod;</c>
    /// representing U+0220F.
    /// </summary>
    Node prod { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Product;</c>
    /// representing U+0220F.
    /// </summary>
    Node Product { get; }

    /// <summary>
    /// Gets character reference <c>&amp;profalar;</c>
    /// representing U+0232E.
    /// </summary>
    Node profalar { get; }

    /// <summary>
    /// Gets character reference <c>&amp;profline;</c>
    /// representing U+02312.
    /// </summary>
    Node profline { get; }

    /// <summary>
    /// Gets character reference <c>&amp;profsurf;</c>
    /// representing U+02313.
    /// </summary>
    Node profsurf { get; }

    /// <summary>
    /// Gets character reference <c>&amp;prop;</c>
    /// representing U+0221D.
    /// </summary>
    Node prop { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Proportion;</c>
    /// representing U+02237.
    /// </summary>
    Node Proportion { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Proportional;</c>
    /// representing U+0221D.
    /// </summary>
    Node Proportional { get; }

    /// <summary>
    /// Gets character reference <c>&amp;propto;</c>
    /// representing U+0221D.
    /// </summary>
    Node propto { get; }

    /// <summary>
    /// Gets character reference <c>&amp;prsim;</c>
    /// representing U+0227E.
    /// </summary>
    Node prsim { get; }

    /// <summary>
    /// Gets character reference <c>&amp;prurel;</c>
    /// representing U+022B0.
    /// </summary>
    Node prurel { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Pscr;</c>
    /// representing U+1D4AB.
    /// </summary>
    Node Pscr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;pscr;</c>
    /// representing U+1D4C5.
    /// </summary>
    Node pscr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Psi;</c>
    /// representing U+003A8.
    /// </summary>
    Node Psi { get; }

    /// <summary>
    /// Gets character reference <c>&amp;psi;</c>
    /// representing U+003C8.
    /// </summary>
    Node psi { get; }

    /// <summary>
    /// Gets character reference <c>&amp;puncsp;</c>
    /// representing U+02008.
    /// </summary>
    Node puncsp { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Qfr;</c>
    /// representing U+1D514.
    /// </summary>
    Node Qfr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;qfr;</c>
    /// representing U+1D52E.
    /// </summary>
    Node qfr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;qint;</c>
    /// representing U+02A0C.
    /// </summary>
    Node qint { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Qopf;</c>
    /// representing U+0211A.
    /// </summary>
    Node Qopf { get; }

    /// <summary>
    /// Gets character reference <c>&amp;qopf;</c>
    /// representing U+1D562.
    /// </summary>
    Node qopf { get; }

    /// <summary>
    /// Gets character reference <c>&amp;qprime;</c>
    /// representing U+02057.
    /// </summary>
    Node qprime { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Qscr;</c>
    /// representing U+1D4AC.
    /// </summary>
    Node Qscr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;qscr;</c>
    /// representing U+1D4C6.
    /// </summary>
    Node qscr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;quaternions;</c>
    /// representing U+0210D.
    /// </summary>
    Node quaternions { get; }

    /// <summary>
    /// Gets character reference <c>&amp;quatint;</c>
    /// representing U+02A16.
    /// </summary>
    Node quatint { get; }

    /// <summary>
    /// Gets character reference <c>&amp;quest;</c>
    /// representing U+0003F.
    /// </summary>
    Node quest { get; }

    /// <summary>
    /// Gets character reference <c>&amp;questeq;</c>
    /// representing U+0225F.
    /// </summary>
    Node questeq { get; }

    /// <summary>
    /// Gets character reference <c>&amp;QUOT;</c>
    /// representing U+00022.
    /// </summary>
    Node QUOT { get; }

    /// <summary>
    /// Gets character reference <c>&amp;quot;</c>
    /// representing U+00022.
    /// </summary>
    Node quot { get; }

    /// <summary>
    /// Gets character reference <c>&amp;rAarr;</c>
    /// representing U+021DB.
    /// </summary>
    Node rAarr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;race;</c>
    /// representing U+0223D U+00331.
    /// </summary>
    Node race { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Racute;</c>
    /// representing U+00154.
    /// </summary>
    Node Racute { get; }

    /// <summary>
    /// Gets character reference <c>&amp;racute;</c>
    /// representing U+00155.
    /// </summary>
    Node racute { get; }

    /// <summary>
    /// Gets character reference <c>&amp;radic;</c>
    /// representing U+0221A.
    /// </summary>
    Node radic { get; }

    /// <summary>
    /// Gets character reference <c>&amp;raemptyv;</c>
    /// representing U+029B3.
    /// </summary>
    Node raemptyv { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Rang;</c>
    /// representing U+027EB.
    /// </summary>
    Node Rang { get; }

    /// <summary>
    /// Gets character reference <c>&amp;rang;</c>
    /// representing U+027E9.
    /// </summary>
    Node rang { get; }

    /// <summary>
    /// Gets character reference <c>&amp;rangd;</c>
    /// representing U+02992.
    /// </summary>
    Node rangd { get; }

    /// <summary>
    /// Gets character reference <c>&amp;range;</c>
    /// representing U+029A5.
    /// </summary>
    Node range { get; }

    /// <summary>
    /// Gets character reference <c>&amp;rangle;</c>
    /// representing U+027E9.
    /// </summary>
    Node rangle { get; }

    /// <summary>
    /// Gets character reference <c>&amp;raquo;</c>
    /// representing U+000BB.
    /// </summary>
    Node raquo { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Rarr;</c>
    /// representing U+021A0.
    /// </summary>
    Node Rarr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;rArr;</c>
    /// representing U+021D2.
    /// </summary>
    Node rArr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;rarr;</c>
    /// representing U+02192.
    /// </summary>
    Node rarr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;rarrap;</c>
    /// representing U+02975.
    /// </summary>
    Node rarrap { get; }

    /// <summary>
    /// Gets character reference <c>&amp;rarrb;</c>
    /// representing U+021E5.
    /// </summary>
    Node rarrb { get; }

    /// <summary>
    /// Gets character reference <c>&amp;rarrbfs;</c>
    /// representing U+02920.
    /// </summary>
    Node rarrbfs { get; }

    /// <summary>
    /// Gets character reference <c>&amp;rarrc;</c>
    /// representing U+02933.
    /// </summary>
    Node rarrc { get; }

    /// <summary>
    /// Gets character reference <c>&amp;rarrfs;</c>
    /// representing U+0291E.
    /// </summary>
    Node rarrfs { get; }

    /// <summary>
    /// Gets character reference <c>&amp;rarrhk;</c>
    /// representing U+021AA.
    /// </summary>
    Node rarrhk { get; }

    /// <summary>
    /// Gets character reference <c>&amp;rarrlp;</c>
    /// representing U+021AC.
    /// </summary>
    Node rarrlp { get; }

    /// <summary>
    /// Gets character reference <c>&amp;rarrpl;</c>
    /// representing U+02945.
    /// </summary>
    Node rarrpl { get; }

    /// <summary>
    /// Gets character reference <c>&amp;rarrsim;</c>
    /// representing U+02974.
    /// </summary>
    Node rarrsim { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Rarrtl;</c>
    /// representing U+02916.
    /// </summary>
    Node Rarrtl { get; }

    /// <summary>
    /// Gets character reference <c>&amp;rarrtl;</c>
    /// representing U+021A3.
    /// </summary>
    Node rarrtl { get; }

    /// <summary>
    /// Gets character reference <c>&amp;rarrw;</c>
    /// representing U+0219D.
    /// </summary>
    Node rarrw { get; }

    /// <summary>
    /// Gets character reference <c>&amp;rAtail;</c>
    /// representing U+0291C.
    /// </summary>
    Node rAtail { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ratail;</c>
    /// representing U+0291A.
    /// </summary>
    Node ratail { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ratio;</c>
    /// representing U+02236.
    /// </summary>
    Node ratio { get; }

    /// <summary>
    /// Gets character reference <c>&amp;rationals;</c>
    /// representing U+0211A.
    /// </summary>
    Node rationals { get; }

    /// <summary>
    /// Gets character reference <c>&amp;RBarr;</c>
    /// representing U+02910.
    /// </summary>
    Node RBarr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;rBarr;</c>
    /// representing U+0290F.
    /// </summary>
    Node rBarr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;rbarr;</c>
    /// representing U+0290D.
    /// </summary>
    Node rbarr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;rbbrk;</c>
    /// representing U+02773.
    /// </summary>
    Node rbbrk { get; }

    /// <summary>
    /// Gets character reference <c>&amp;rbrace;</c>
    /// representing U+0007D.
    /// </summary>
    Node rbrace { get; }

    /// <summary>
    /// Gets character reference <c>&amp;rbrack;</c>
    /// representing U+0005D.
    /// </summary>
    Node rbrack { get; }

    /// <summary>
    /// Gets character reference <c>&amp;rbrke;</c>
    /// representing U+0298C.
    /// </summary>
    Node rbrke { get; }

    /// <summary>
    /// Gets character reference <c>&amp;rbrksld;</c>
    /// representing U+0298E.
    /// </summary>
    Node rbrksld { get; }

    /// <summary>
    /// Gets character reference <c>&amp;rbrkslu;</c>
    /// representing U+02990.
    /// </summary>
    Node rbrkslu { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Rcaron;</c>
    /// representing U+00158.
    /// </summary>
    Node Rcaron { get; }

    /// <summary>
    /// Gets character reference <c>&amp;rcaron;</c>
    /// representing U+00159.
    /// </summary>
    Node rcaron { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Rcedil;</c>
    /// representing U+00156.
    /// </summary>
    Node Rcedil { get; }

    /// <summary>
    /// Gets character reference <c>&amp;rcedil;</c>
    /// representing U+00157.
    /// </summary>
    Node rcedil { get; }

    /// <summary>
    /// Gets character reference <c>&amp;rceil;</c>
    /// representing U+02309.
    /// </summary>
    Node rceil { get; }

    /// <summary>
    /// Gets character reference <c>&amp;rcub;</c>
    /// representing U+0007D.
    /// </summary>
    Node rcub { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Rcy;</c>
    /// representing U+00420.
    /// </summary>
    Node Rcy { get; }

    /// <summary>
    /// Gets character reference <c>&amp;rcy;</c>
    /// representing U+00440.
    /// </summary>
    Node rcy { get; }

    /// <summary>
    /// Gets character reference <c>&amp;rdca;</c>
    /// representing U+02937.
    /// </summary>
    Node rdca { get; }

    /// <summary>
    /// Gets character reference <c>&amp;rdldhar;</c>
    /// representing U+02969.
    /// </summary>
    Node rdldhar { get; }

    /// <summary>
    /// Gets character reference <c>&amp;rdquo;</c>
    /// representing U+0201D.
    /// </summary>
    Node rdquo { get; }

    /// <summary>
    /// Gets character reference <c>&amp;rdquor;</c>
    /// representing U+0201D.
    /// </summary>
    Node rdquor { get; }

    /// <summary>
    /// Gets character reference <c>&amp;rdsh;</c>
    /// representing U+021B3.
    /// </summary>
    Node rdsh { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Re;</c>
    /// representing U+0211C.
    /// </summary>
    Node Re { get; }

    /// <summary>
    /// Gets character reference <c>&amp;real;</c>
    /// representing U+0211C.
    /// </summary>
    Node real { get; }

    /// <summary>
    /// Gets character reference <c>&amp;realine;</c>
    /// representing U+0211B.
    /// </summary>
    Node realine { get; }

    /// <summary>
    /// Gets character reference <c>&amp;realpart;</c>
    /// representing U+0211C.
    /// </summary>
    Node realpart { get; }

    /// <summary>
    /// Gets character reference <c>&amp;reals;</c>
    /// representing U+0211D.
    /// </summary>
    Node reals { get; }

    /// <summary>
    /// Gets character reference <c>&amp;rect;</c>
    /// representing U+025AD.
    /// </summary>
    Node rect { get; }

    /// <summary>
    /// Gets character reference <c>&amp;REG;</c>
    /// representing U+000AE.
    /// </summary>
    Node REG { get; }

    /// <summary>
    /// Gets character reference <c>&amp;reg;</c>
    /// representing U+000AE.
    /// </summary>
    Node reg { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ReverseElement;</c>
    /// representing U+0220B.
    /// </summary>
    Node ReverseElement { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ReverseEquilibrium;</c>
    /// representing U+021CB.
    /// </summary>
    Node ReverseEquilibrium { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ReverseUpEquilibrium;</c>
    /// representing U+0296F.
    /// </summary>
    Node ReverseUpEquilibrium { get; }

    /// <summary>
    /// Gets character reference <c>&amp;rfisht;</c>
    /// representing U+0297D.
    /// </summary>
    Node rfisht { get; }

    /// <summary>
    /// Gets character reference <c>&amp;rfloor;</c>
    /// representing U+0230B.
    /// </summary>
    Node rfloor { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Rfr;</c>
    /// representing U+0211C.
    /// </summary>
    Node Rfr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;rfr;</c>
    /// representing U+1D52F.
    /// </summary>
    Node rfr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;rHar;</c>
    /// representing U+02964.
    /// </summary>
    Node rHar { get; }

    /// <summary>
    /// Gets character reference <c>&amp;rhard;</c>
    /// representing U+021C1.
    /// </summary>
    Node rhard { get; }

    /// <summary>
    /// Gets character reference <c>&amp;rharu;</c>
    /// representing U+021C0.
    /// </summary>
    Node rharu { get; }

    /// <summary>
    /// Gets character reference <c>&amp;rharul;</c>
    /// representing U+0296C.
    /// </summary>
    Node rharul { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Rho;</c>
    /// representing U+003A1.
    /// </summary>
    Node Rho { get; }

    /// <summary>
    /// Gets character reference <c>&amp;rho;</c>
    /// representing U+003C1.
    /// </summary>
    Node rho { get; }

    /// <summary>
    /// Gets character reference <c>&amp;rhov;</c>
    /// representing U+003F1.
    /// </summary>
    Node rhov { get; }

    /// <summary>
    /// Gets character reference <c>&amp;RightAngleBracket;</c>
    /// representing U+027E9.
    /// </summary>
    Node RightAngleBracket { get; }

    /// <summary>
    /// Gets character reference <c>&amp;RightArrow;</c>
    /// representing U+02192.
    /// </summary>
    Node RightArrow { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Rightarrow;</c>
    /// representing U+021D2.
    /// </summary>
    Node Rightarrow { get; }

    /// <summary>
    /// Gets character reference <c>&amp;rightarrow;</c>
    /// representing U+02192.
    /// </summary>
    Node rightarrow { get; }

    /// <summary>
    /// Gets character reference <c>&amp;RightArrowBar;</c>
    /// representing U+021E5.
    /// </summary>
    Node RightArrowBar { get; }

    /// <summary>
    /// Gets character reference <c>&amp;RightArrowLeftArrow;</c>
    /// representing U+021C4.
    /// </summary>
    Node RightArrowLeftArrow { get; }

    /// <summary>
    /// Gets character reference <c>&amp;rightarrowtail;</c>
    /// representing U+021A3.
    /// </summary>
    Node rightarrowtail { get; }

    /// <summary>
    /// Gets character reference <c>&amp;RightCeiling;</c>
    /// representing U+02309.
    /// </summary>
    Node RightCeiling { get; }

    /// <summary>
    /// Gets character reference <c>&amp;RightDoubleBracket;</c>
    /// representing U+027E7.
    /// </summary>
    Node RightDoubleBracket { get; }

    /// <summary>
    /// Gets character reference <c>&amp;RightDownTeeVector;</c>
    /// representing U+0295D.
    /// </summary>
    Node RightDownTeeVector { get; }

    /// <summary>
    /// Gets character reference <c>&amp;RightDownVector;</c>
    /// representing U+021C2.
    /// </summary>
    Node RightDownVector { get; }

    /// <summary>
    /// Gets character reference <c>&amp;RightDownVectorBar;</c>
    /// representing U+02955.
    /// </summary>
    Node RightDownVectorBar { get; }

    /// <summary>
    /// Gets character reference <c>&amp;RightFloor;</c>
    /// representing U+0230B.
    /// </summary>
    Node RightFloor { get; }

    /// <summary>
    /// Gets character reference <c>&amp;rightharpoondown;</c>
    /// representing U+021C1.
    /// </summary>
    Node rightharpoondown { get; }

    /// <summary>
    /// Gets character reference <c>&amp;rightharpoonup;</c>
    /// representing U+021C0.
    /// </summary>
    Node rightharpoonup { get; }

    /// <summary>
    /// Gets character reference <c>&amp;rightleftarrows;</c>
    /// representing U+021C4.
    /// </summary>
    Node rightleftarrows { get; }

    /// <summary>
    /// Gets character reference <c>&amp;rightleftharpoons;</c>
    /// representing U+021CC.
    /// </summary>
    Node rightleftharpoons { get; }

    /// <summary>
    /// Gets character reference <c>&amp;rightrightarrows;</c>
    /// representing U+021C9.
    /// </summary>
    Node rightrightarrows { get; }

    /// <summary>
    /// Gets character reference <c>&amp;rightsquigarrow;</c>
    /// representing U+0219D.
    /// </summary>
    Node rightsquigarrow { get; }

    /// <summary>
    /// Gets character reference <c>&amp;RightTee;</c>
    /// representing U+022A2.
    /// </summary>
    Node RightTee { get; }

    /// <summary>
    /// Gets character reference <c>&amp;RightTeeArrow;</c>
    /// representing U+021A6.
    /// </summary>
    Node RightTeeArrow { get; }

    /// <summary>
    /// Gets character reference <c>&amp;RightTeeVector;</c>
    /// representing U+0295B.
    /// </summary>
    Node RightTeeVector { get; }

    /// <summary>
    /// Gets character reference <c>&amp;rightthreetimes;</c>
    /// representing U+022CC.
    /// </summary>
    Node rightthreetimes { get; }

    /// <summary>
    /// Gets character reference <c>&amp;RightTriangle;</c>
    /// representing U+022B3.
    /// </summary>
    Node RightTriangle { get; }

    /// <summary>
    /// Gets character reference <c>&amp;RightTriangleBar;</c>
    /// representing U+029D0.
    /// </summary>
    Node RightTriangleBar { get; }

    /// <summary>
    /// Gets character reference <c>&amp;RightTriangleEqual;</c>
    /// representing U+022B5.
    /// </summary>
    Node RightTriangleEqual { get; }

    /// <summary>
    /// Gets character reference <c>&amp;RightUpDownVector;</c>
    /// representing U+0294F.
    /// </summary>
    Node RightUpDownVector { get; }

    /// <summary>
    /// Gets character reference <c>&amp;RightUpTeeVector;</c>
    /// representing U+0295C.
    /// </summary>
    Node RightUpTeeVector { get; }

    /// <summary>
    /// Gets character reference <c>&amp;RightUpVector;</c>
    /// representing U+021BE.
    /// </summary>
    Node RightUpVector { get; }

    /// <summary>
    /// Gets character reference <c>&amp;RightUpVectorBar;</c>
    /// representing U+02954.
    /// </summary>
    Node RightUpVectorBar { get; }

    /// <summary>
    /// Gets character reference <c>&amp;RightVector;</c>
    /// representing U+021C0.
    /// </summary>
    Node RightVector { get; }

    /// <summary>
    /// Gets character reference <c>&amp;RightVectorBar;</c>
    /// representing U+02953.
    /// </summary>
    Node RightVectorBar { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ring;</c>
    /// representing U+002DA.
    /// </summary>
    Node ring { get; }

    /// <summary>
    /// Gets character reference <c>&amp;risingdotseq;</c>
    /// representing U+02253.
    /// </summary>
    Node risingdotseq { get; }

    /// <summary>
    /// Gets character reference <c>&amp;rlarr;</c>
    /// representing U+021C4.
    /// </summary>
    Node rlarr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;rlhar;</c>
    /// representing U+021CC.
    /// </summary>
    Node rlhar { get; }

    /// <summary>
    /// Gets character reference <c>&amp;rlm;</c>
    /// representing U+0200F.
    /// </summary>
    Node rlm { get; }

    /// <summary>
    /// Gets character reference <c>&amp;rmoust;</c>
    /// representing U+023B1.
    /// </summary>
    Node rmoust { get; }

    /// <summary>
    /// Gets character reference <c>&amp;rmoustache;</c>
    /// representing U+023B1.
    /// </summary>
    Node rmoustache { get; }

    /// <summary>
    /// Gets character reference <c>&amp;rnmid;</c>
    /// representing U+02AEE.
    /// </summary>
    Node rnmid { get; }

    /// <summary>
    /// Gets character reference <c>&amp;roang;</c>
    /// representing U+027ED.
    /// </summary>
    Node roang { get; }

    /// <summary>
    /// Gets character reference <c>&amp;roarr;</c>
    /// representing U+021FE.
    /// </summary>
    Node roarr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;robrk;</c>
    /// representing U+027E7.
    /// </summary>
    Node robrk { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ropar;</c>
    /// representing U+02986.
    /// </summary>
    Node ropar { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Ropf;</c>
    /// representing U+0211D.
    /// </summary>
    Node Ropf { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ropf;</c>
    /// representing U+1D563.
    /// </summary>
    Node ropf { get; }

    /// <summary>
    /// Gets character reference <c>&amp;roplus;</c>
    /// representing U+02A2E.
    /// </summary>
    Node roplus { get; }

    /// <summary>
    /// Gets character reference <c>&amp;rotimes;</c>
    /// representing U+02A35.
    /// </summary>
    Node rotimes { get; }

    /// <summary>
    /// Gets character reference <c>&amp;RoundImplies;</c>
    /// representing U+02970.
    /// </summary>
    Node RoundImplies { get; }

    /// <summary>
    /// Gets character reference <c>&amp;rpar;</c>
    /// representing U+00029.
    /// </summary>
    Node rpar { get; }

    /// <summary>
    /// Gets character reference <c>&amp;rpargt;</c>
    /// representing U+02994.
    /// </summary>
    Node rpargt { get; }

    /// <summary>
    /// Gets character reference <c>&amp;rppolint;</c>
    /// representing U+02A12.
    /// </summary>
    Node rppolint { get; }

    /// <summary>
    /// Gets character reference <c>&amp;rrarr;</c>
    /// representing U+021C9.
    /// </summary>
    Node rrarr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Rrightarrow;</c>
    /// representing U+021DB.
    /// </summary>
    Node Rrightarrow { get; }

    /// <summary>
    /// Gets character reference <c>&amp;rsaquo;</c>
    /// representing U+0203A.
    /// </summary>
    Node rsaquo { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Rscr;</c>
    /// representing U+0211B.
    /// </summary>
    Node Rscr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;rscr;</c>
    /// representing U+1D4C7.
    /// </summary>
    Node rscr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Rsh;</c>
    /// representing U+021B1.
    /// </summary>
    Node Rsh { get; }

    /// <summary>
    /// Gets character reference <c>&amp;rsh;</c>
    /// representing U+021B1.
    /// </summary>
    Node rsh { get; }

    /// <summary>
    /// Gets character reference <c>&amp;rsqb;</c>
    /// representing U+0005D.
    /// </summary>
    Node rsqb { get; }

    /// <summary>
    /// Gets character reference <c>&amp;rsquo;</c>
    /// representing U+02019.
    /// </summary>
    Node rsquo { get; }

    /// <summary>
    /// Gets character reference <c>&amp;rsquor;</c>
    /// representing U+02019.
    /// </summary>
    Node rsquor { get; }

    /// <summary>
    /// Gets character reference <c>&amp;rthree;</c>
    /// representing U+022CC.
    /// </summary>
    Node rthree { get; }

    /// <summary>
    /// Gets character reference <c>&amp;rtimes;</c>
    /// representing U+022CA.
    /// </summary>
    Node rtimes { get; }

    /// <summary>
    /// Gets character reference <c>&amp;rtri;</c>
    /// representing U+025B9.
    /// </summary>
    Node rtri { get; }

    /// <summary>
    /// Gets character reference <c>&amp;rtrie;</c>
    /// representing U+022B5.
    /// </summary>
    Node rtrie { get; }

    /// <summary>
    /// Gets character reference <c>&amp;rtrif;</c>
    /// representing U+025B8.
    /// </summary>
    Node rtrif { get; }

    /// <summary>
    /// Gets character reference <c>&amp;rtriltri;</c>
    /// representing U+029CE.
    /// </summary>
    Node rtriltri { get; }

    /// <summary>
    /// Gets character reference <c>&amp;RuleDelayed;</c>
    /// representing U+029F4.
    /// </summary>
    Node RuleDelayed { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ruluhar;</c>
    /// representing U+02968.
    /// </summary>
    Node ruluhar { get; }

    /// <summary>
    /// Gets character reference <c>&amp;rx;</c>
    /// representing U+0211E.
    /// </summary>
    Node rx { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Sacute;</c>
    /// representing U+0015A.
    /// </summary>
    Node Sacute { get; }

    /// <summary>
    /// Gets character reference <c>&amp;sacute;</c>
    /// representing U+0015B.
    /// </summary>
    Node sacute { get; }

    /// <summary>
    /// Gets character reference <c>&amp;sbquo;</c>
    /// representing U+0201A.
    /// </summary>
    Node sbquo { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Sc;</c>
    /// representing U+02ABC.
    /// </summary>
    Node Sc { get; }

    /// <summary>
    /// Gets character reference <c>&amp;sc;</c>
    /// representing U+0227B.
    /// </summary>
    Node sc { get; }

    /// <summary>
    /// Gets character reference <c>&amp;scap;</c>
    /// representing U+02AB8.
    /// </summary>
    Node scap { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Scaron;</c>
    /// representing U+00160.
    /// </summary>
    Node Scaron { get; }

    /// <summary>
    /// Gets character reference <c>&amp;scaron;</c>
    /// representing U+00161.
    /// </summary>
    Node scaron { get; }

    /// <summary>
    /// Gets character reference <c>&amp;sccue;</c>
    /// representing U+0227D.
    /// </summary>
    Node sccue { get; }

    /// <summary>
    /// Gets character reference <c>&amp;scE;</c>
    /// representing U+02AB4.
    /// </summary>
    Node scE { get; }

    /// <summary>
    /// Gets character reference <c>&amp;sce;</c>
    /// representing U+02AB0.
    /// </summary>
    Node sce { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Scedil;</c>
    /// representing U+0015E.
    /// </summary>
    Node Scedil { get; }

    /// <summary>
    /// Gets character reference <c>&amp;scedil;</c>
    /// representing U+0015F.
    /// </summary>
    Node scedil { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Scirc;</c>
    /// representing U+0015C.
    /// </summary>
    Node Scirc { get; }

    /// <summary>
    /// Gets character reference <c>&amp;scirc;</c>
    /// representing U+0015D.
    /// </summary>
    Node scirc { get; }

    /// <summary>
    /// Gets character reference <c>&amp;scnap;</c>
    /// representing U+02ABA.
    /// </summary>
    Node scnap { get; }

    /// <summary>
    /// Gets character reference <c>&amp;scnE;</c>
    /// representing U+02AB6.
    /// </summary>
    Node scnE { get; }

    /// <summary>
    /// Gets character reference <c>&amp;scnsim;</c>
    /// representing U+022E9.
    /// </summary>
    Node scnsim { get; }

    /// <summary>
    /// Gets character reference <c>&amp;scpolint;</c>
    /// representing U+02A13.
    /// </summary>
    Node scpolint { get; }

    /// <summary>
    /// Gets character reference <c>&amp;scsim;</c>
    /// representing U+0227F.
    /// </summary>
    Node scsim { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Scy;</c>
    /// representing U+00421.
    /// </summary>
    Node Scy { get; }

    /// <summary>
    /// Gets character reference <c>&amp;scy;</c>
    /// representing U+00441.
    /// </summary>
    Node scy { get; }

    /// <summary>
    /// Gets character reference <c>&amp;sdot;</c>
    /// representing U+022C5.
    /// </summary>
    Node sdot { get; }

    /// <summary>
    /// Gets character reference <c>&amp;sdotb;</c>
    /// representing U+022A1.
    /// </summary>
    Node sdotb { get; }

    /// <summary>
    /// Gets character reference <c>&amp;sdote;</c>
    /// representing U+02A66.
    /// </summary>
    Node sdote { get; }

    /// <summary>
    /// Gets character reference <c>&amp;searhk;</c>
    /// representing U+02925.
    /// </summary>
    Node searhk { get; }

    /// <summary>
    /// Gets character reference <c>&amp;seArr;</c>
    /// representing U+021D8.
    /// </summary>
    Node seArr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;searr;</c>
    /// representing U+02198.
    /// </summary>
    Node searr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;searrow;</c>
    /// representing U+02198.
    /// </summary>
    Node searrow { get; }

    /// <summary>
    /// Gets character reference <c>&amp;sect;</c>
    /// representing U+000A7.
    /// </summary>
    Node sect { get; }

    /// <summary>
    /// Gets character reference <c>&amp;semi;</c>
    /// representing U+0003B.
    /// </summary>
    Node semi { get; }

    /// <summary>
    /// Gets character reference <c>&amp;seswar;</c>
    /// representing U+02929.
    /// </summary>
    Node seswar { get; }

    /// <summary>
    /// Gets character reference <c>&amp;setminus;</c>
    /// representing U+02216.
    /// </summary>
    Node setminus { get; }

    /// <summary>
    /// Gets character reference <c>&amp;setmn;</c>
    /// representing U+02216.
    /// </summary>
    Node setmn { get; }

    /// <summary>
    /// Gets character reference <c>&amp;sext;</c>
    /// representing U+02736.
    /// </summary>
    Node sext { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Sfr;</c>
    /// representing U+1D516.
    /// </summary>
    Node Sfr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;sfr;</c>
    /// representing U+1D530.
    /// </summary>
    Node sfr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;sfrown;</c>
    /// representing U+02322.
    /// </summary>
    Node sfrown { get; }

    /// <summary>
    /// Gets character reference <c>&amp;sharp;</c>
    /// representing U+0266F.
    /// </summary>
    Node sharp { get; }

    /// <summary>
    /// Gets character reference <c>&amp;SHCHcy;</c>
    /// representing U+00429.
    /// </summary>
    Node SHCHcy { get; }

    /// <summary>
    /// Gets character reference <c>&amp;shchcy;</c>
    /// representing U+00449.
    /// </summary>
    Node shchcy { get; }

    /// <summary>
    /// Gets character reference <c>&amp;SHcy;</c>
    /// representing U+00428.
    /// </summary>
    Node SHcy { get; }

    /// <summary>
    /// Gets character reference <c>&amp;shcy;</c>
    /// representing U+00448.
    /// </summary>
    Node shcy { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ShortDownArrow;</c>
    /// representing U+02193.
    /// </summary>
    Node ShortDownArrow { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ShortLeftArrow;</c>
    /// representing U+02190.
    /// </summary>
    Node ShortLeftArrow { get; }

    /// <summary>
    /// Gets character reference <c>&amp;shortmid;</c>
    /// representing U+02223.
    /// </summary>
    Node shortmid { get; }

    /// <summary>
    /// Gets character reference <c>&amp;shortparallel;</c>
    /// representing U+02225.
    /// </summary>
    Node shortparallel { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ShortRightArrow;</c>
    /// representing U+02192.
    /// </summary>
    Node ShortRightArrow { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ShortUpArrow;</c>
    /// representing U+02191.
    /// </summary>
    Node ShortUpArrow { get; }

    /// <summary>
    /// Gets character reference <c>&amp;shy;</c>
    /// representing U+000AD.
    /// </summary>
    Node shy { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Sigma;</c>
    /// representing U+003A3.
    /// </summary>
    Node Sigma { get; }

    /// <summary>
    /// Gets character reference <c>&amp;sigma;</c>
    /// representing U+003C3.
    /// </summary>
    Node sigma { get; }

    /// <summary>
    /// Gets character reference <c>&amp;sigmaf;</c>
    /// representing U+003C2.
    /// </summary>
    Node sigmaf { get; }

    /// <summary>
    /// Gets character reference <c>&amp;sigmav;</c>
    /// representing U+003C2.
    /// </summary>
    Node sigmav { get; }

    /// <summary>
    /// Gets character reference <c>&amp;sim;</c>
    /// representing U+0223C.
    /// </summary>
    Node sim { get; }

    /// <summary>
    /// Gets character reference <c>&amp;simdot;</c>
    /// representing U+02A6A.
    /// </summary>
    Node simdot { get; }

    /// <summary>
    /// Gets character reference <c>&amp;sime;</c>
    /// representing U+02243.
    /// </summary>
    Node sime { get; }

    /// <summary>
    /// Gets character reference <c>&amp;simeq;</c>
    /// representing U+02243.
    /// </summary>
    Node simeq { get; }

    /// <summary>
    /// Gets character reference <c>&amp;simg;</c>
    /// representing U+02A9E.
    /// </summary>
    Node simg { get; }

    /// <summary>
    /// Gets character reference <c>&amp;simgE;</c>
    /// representing U+02AA0.
    /// </summary>
    Node simgE { get; }

    /// <summary>
    /// Gets character reference <c>&amp;siml;</c>
    /// representing U+02A9D.
    /// </summary>
    Node siml { get; }

    /// <summary>
    /// Gets character reference <c>&amp;simlE;</c>
    /// representing U+02A9F.
    /// </summary>
    Node simlE { get; }

    /// <summary>
    /// Gets character reference <c>&amp;simne;</c>
    /// representing U+02246.
    /// </summary>
    Node simne { get; }

    /// <summary>
    /// Gets character reference <c>&amp;simplus;</c>
    /// representing U+02A24.
    /// </summary>
    Node simplus { get; }

    /// <summary>
    /// Gets character reference <c>&amp;simrarr;</c>
    /// representing U+02972.
    /// </summary>
    Node simrarr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;slarr;</c>
    /// representing U+02190.
    /// </summary>
    Node slarr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;SmallCircle;</c>
    /// representing U+02218.
    /// </summary>
    Node SmallCircle { get; }

    /// <summary>
    /// Gets character reference <c>&amp;smallsetminus;</c>
    /// representing U+02216.
    /// </summary>
    Node smallsetminus { get; }

    /// <summary>
    /// Gets character reference <c>&amp;smashp;</c>
    /// representing U+02A33.
    /// </summary>
    Node smashp { get; }

    /// <summary>
    /// Gets character reference <c>&amp;smeparsl;</c>
    /// representing U+029E4.
    /// </summary>
    Node smeparsl { get; }

    /// <summary>
    /// Gets character reference <c>&amp;smid;</c>
    /// representing U+02223.
    /// </summary>
    Node smid { get; }

    /// <summary>
    /// Gets character reference <c>&amp;smile;</c>
    /// representing U+02323.
    /// </summary>
    Node smile { get; }

    /// <summary>
    /// Gets character reference <c>&amp;smt;</c>
    /// representing U+02AAA.
    /// </summary>
    Node smt { get; }

    /// <summary>
    /// Gets character reference <c>&amp;smte;</c>
    /// representing U+02AAC.
    /// </summary>
    Node smte { get; }

    /// <summary>
    /// Gets character reference <c>&amp;smtes;</c>
    /// representing U+02AAC U+0FE00.
    /// </summary>
    Node smtes { get; }

    /// <summary>
    /// Gets character reference <c>&amp;SOFTcy;</c>
    /// representing U+0042C.
    /// </summary>
    Node SOFTcy { get; }

    /// <summary>
    /// Gets character reference <c>&amp;softcy;</c>
    /// representing U+0044C.
    /// </summary>
    Node softcy { get; }

    /// <summary>
    /// Gets character reference <c>&amp;sol;</c>
    /// representing U+0002F.
    /// </summary>
    Node sol { get; }

    /// <summary>
    /// Gets character reference <c>&amp;solb;</c>
    /// representing U+029C4.
    /// </summary>
    Node solb { get; }

    /// <summary>
    /// Gets character reference <c>&amp;solbar;</c>
    /// representing U+0233F.
    /// </summary>
    Node solbar { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Sopf;</c>
    /// representing U+1D54A.
    /// </summary>
    Node Sopf { get; }

    /// <summary>
    /// Gets character reference <c>&amp;sopf;</c>
    /// representing U+1D564.
    /// </summary>
    Node sopf { get; }

    /// <summary>
    /// Gets character reference <c>&amp;spades;</c>
    /// representing U+02660.
    /// </summary>
    Node spades { get; }

    /// <summary>
    /// Gets character reference <c>&amp;spadesuit;</c>
    /// representing U+02660.
    /// </summary>
    Node spadesuit { get; }

    /// <summary>
    /// Gets character reference <c>&amp;spar;</c>
    /// representing U+02225.
    /// </summary>
    Node spar { get; }

    /// <summary>
    /// Gets character reference <c>&amp;sqcap;</c>
    /// representing U+02293.
    /// </summary>
    Node sqcap { get; }

    /// <summary>
    /// Gets character reference <c>&amp;sqcaps;</c>
    /// representing U+02293 U+0FE00.
    /// </summary>
    Node sqcaps { get; }

    /// <summary>
    /// Gets character reference <c>&amp;sqcup;</c>
    /// representing U+02294.
    /// </summary>
    Node sqcup { get; }

    /// <summary>
    /// Gets character reference <c>&amp;sqcups;</c>
    /// representing U+02294 U+0FE00.
    /// </summary>
    Node sqcups { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Sqrt;</c>
    /// representing U+0221A.
    /// </summary>
    Node Sqrt { get; }

    /// <summary>
    /// Gets character reference <c>&amp;sqsub;</c>
    /// representing U+0228F.
    /// </summary>
    Node sqsub { get; }

    /// <summary>
    /// Gets character reference <c>&amp;sqsube;</c>
    /// representing U+02291.
    /// </summary>
    Node sqsube { get; }

    /// <summary>
    /// Gets character reference <c>&amp;sqsubset;</c>
    /// representing U+0228F.
    /// </summary>
    Node sqsubset { get; }

    /// <summary>
    /// Gets character reference <c>&amp;sqsubseteq;</c>
    /// representing U+02291.
    /// </summary>
    Node sqsubseteq { get; }

    /// <summary>
    /// Gets character reference <c>&amp;sqsup;</c>
    /// representing U+02290.
    /// </summary>
    Node sqsup { get; }

    /// <summary>
    /// Gets character reference <c>&amp;sqsupe;</c>
    /// representing U+02292.
    /// </summary>
    Node sqsupe { get; }

    /// <summary>
    /// Gets character reference <c>&amp;sqsupset;</c>
    /// representing U+02290.
    /// </summary>
    Node sqsupset { get; }

    /// <summary>
    /// Gets character reference <c>&amp;sqsupseteq;</c>
    /// representing U+02292.
    /// </summary>
    Node sqsupseteq { get; }

    /// <summary>
    /// Gets character reference <c>&amp;squ;</c>
    /// representing U+025A1.
    /// </summary>
    Node squ { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Square;</c>
    /// representing U+025A1.
    /// </summary>
    Node Square { get; }

    /// <summary>
    /// Gets character reference <c>&amp;square;</c>
    /// representing U+025A1.
    /// </summary>
    Node square { get; }

    /// <summary>
    /// Gets character reference <c>&amp;SquareIntersection;</c>
    /// representing U+02293.
    /// </summary>
    Node SquareIntersection { get; }

    /// <summary>
    /// Gets character reference <c>&amp;SquareSubset;</c>
    /// representing U+0228F.
    /// </summary>
    Node SquareSubset { get; }

    /// <summary>
    /// Gets character reference <c>&amp;SquareSubsetEqual;</c>
    /// representing U+02291.
    /// </summary>
    Node SquareSubsetEqual { get; }

    /// <summary>
    /// Gets character reference <c>&amp;SquareSuperset;</c>
    /// representing U+02290.
    /// </summary>
    Node SquareSuperset { get; }

    /// <summary>
    /// Gets character reference <c>&amp;SquareSupersetEqual;</c>
    /// representing U+02292.
    /// </summary>
    Node SquareSupersetEqual { get; }

    /// <summary>
    /// Gets character reference <c>&amp;SquareUnion;</c>
    /// representing U+02294.
    /// </summary>
    Node SquareUnion { get; }

    /// <summary>
    /// Gets character reference <c>&amp;squarf;</c>
    /// representing U+025AA.
    /// </summary>
    Node squarf { get; }

    /// <summary>
    /// Gets character reference <c>&amp;squf;</c>
    /// representing U+025AA.
    /// </summary>
    Node squf { get; }

    /// <summary>
    /// Gets character reference <c>&amp;srarr;</c>
    /// representing U+02192.
    /// </summary>
    Node srarr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Sscr;</c>
    /// representing U+1D4AE.
    /// </summary>
    Node Sscr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;sscr;</c>
    /// representing U+1D4C8.
    /// </summary>
    Node sscr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ssetmn;</c>
    /// representing U+02216.
    /// </summary>
    Node ssetmn { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ssmile;</c>
    /// representing U+02323.
    /// </summary>
    Node ssmile { get; }

    /// <summary>
    /// Gets character reference <c>&amp;sstarf;</c>
    /// representing U+022C6.
    /// </summary>
    Node sstarf { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Star;</c>
    /// representing U+022C6.
    /// </summary>
    Node Star { get; }

    /// <summary>
    /// Gets character reference <c>&amp;star;</c>
    /// representing U+02606.
    /// </summary>
    Node star { get; }

    /// <summary>
    /// Gets character reference <c>&amp;starf;</c>
    /// representing U+02605.
    /// </summary>
    Node starf { get; }

    /// <summary>
    /// Gets character reference <c>&amp;straightepsilon;</c>
    /// representing U+003F5.
    /// </summary>
    Node straightepsilon { get; }

    /// <summary>
    /// Gets character reference <c>&amp;straightphi;</c>
    /// representing U+003D5.
    /// </summary>
    Node straightphi { get; }

    /// <summary>
    /// Gets character reference <c>&amp;strns;</c>
    /// representing U+000AF.
    /// </summary>
    Node strns { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Sub;</c>
    /// representing U+022D0.
    /// </summary>
    Node Sub { get; }

    /// <summary>
    /// Gets character reference <c>&amp;sub;</c>
    /// representing U+02282.
    /// </summary>
    Node sub { get; }

    /// <summary>
    /// Gets character reference <c>&amp;subdot;</c>
    /// representing U+02ABD.
    /// </summary>
    Node subdot { get; }

    /// <summary>
    /// Gets character reference <c>&amp;subE;</c>
    /// representing U+02AC5.
    /// </summary>
    Node subE { get; }

    /// <summary>
    /// Gets character reference <c>&amp;sube;</c>
    /// representing U+02286.
    /// </summary>
    Node sube { get; }

    /// <summary>
    /// Gets character reference <c>&amp;subedot;</c>
    /// representing U+02AC3.
    /// </summary>
    Node subedot { get; }

    /// <summary>
    /// Gets character reference <c>&amp;submult;</c>
    /// representing U+02AC1.
    /// </summary>
    Node submult { get; }

    /// <summary>
    /// Gets character reference <c>&amp;subnE;</c>
    /// representing U+02ACB.
    /// </summary>
    Node subnE { get; }

    /// <summary>
    /// Gets character reference <c>&amp;subne;</c>
    /// representing U+0228A.
    /// </summary>
    Node subne { get; }

    /// <summary>
    /// Gets character reference <c>&amp;subplus;</c>
    /// representing U+02ABF.
    /// </summary>
    Node subplus { get; }

    /// <summary>
    /// Gets character reference <c>&amp;subrarr;</c>
    /// representing U+02979.
    /// </summary>
    Node subrarr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Subset;</c>
    /// representing U+022D0.
    /// </summary>
    Node Subset { get; }

    /// <summary>
    /// Gets character reference <c>&amp;subset;</c>
    /// representing U+02282.
    /// </summary>
    Node subset { get; }

    /// <summary>
    /// Gets character reference <c>&amp;subseteq;</c>
    /// representing U+02286.
    /// </summary>
    Node subseteq { get; }

    /// <summary>
    /// Gets character reference <c>&amp;subseteqq;</c>
    /// representing U+02AC5.
    /// </summary>
    Node subseteqq { get; }

    /// <summary>
    /// Gets character reference <c>&amp;SubsetEqual;</c>
    /// representing U+02286.
    /// </summary>
    Node SubsetEqual { get; }

    /// <summary>
    /// Gets character reference <c>&amp;subsetneq;</c>
    /// representing U+0228A.
    /// </summary>
    Node subsetneq { get; }

    /// <summary>
    /// Gets character reference <c>&amp;subsetneqq;</c>
    /// representing U+02ACB.
    /// </summary>
    Node subsetneqq { get; }

    /// <summary>
    /// Gets character reference <c>&amp;subsim;</c>
    /// representing U+02AC7.
    /// </summary>
    Node subsim { get; }

    /// <summary>
    /// Gets character reference <c>&amp;subsub;</c>
    /// representing U+02AD5.
    /// </summary>
    Node subsub { get; }

    /// <summary>
    /// Gets character reference <c>&amp;subsup;</c>
    /// representing U+02AD3.
    /// </summary>
    Node subsup { get; }

    /// <summary>
    /// Gets character reference <c>&amp;succ;</c>
    /// representing U+0227B.
    /// </summary>
    Node succ { get; }

    /// <summary>
    /// Gets character reference <c>&amp;succapprox;</c>
    /// representing U+02AB8.
    /// </summary>
    Node succapprox { get; }

    /// <summary>
    /// Gets character reference <c>&amp;succcurlyeq;</c>
    /// representing U+0227D.
    /// </summary>
    Node succcurlyeq { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Succeeds;</c>
    /// representing U+0227B.
    /// </summary>
    Node Succeeds { get; }

    /// <summary>
    /// Gets character reference <c>&amp;SucceedsEqual;</c>
    /// representing U+02AB0.
    /// </summary>
    Node SucceedsEqual { get; }

    /// <summary>
    /// Gets character reference <c>&amp;SucceedsSlantEqual;</c>
    /// representing U+0227D.
    /// </summary>
    Node SucceedsSlantEqual { get; }

    /// <summary>
    /// Gets character reference <c>&amp;SucceedsTilde;</c>
    /// representing U+0227F.
    /// </summary>
    Node SucceedsTilde { get; }

    /// <summary>
    /// Gets character reference <c>&amp;succeq;</c>
    /// representing U+02AB0.
    /// </summary>
    Node succeq { get; }

    /// <summary>
    /// Gets character reference <c>&amp;succnapprox;</c>
    /// representing U+02ABA.
    /// </summary>
    Node succnapprox { get; }

    /// <summary>
    /// Gets character reference <c>&amp;succneqq;</c>
    /// representing U+02AB6.
    /// </summary>
    Node succneqq { get; }

    /// <summary>
    /// Gets character reference <c>&amp;succnsim;</c>
    /// representing U+022E9.
    /// </summary>
    Node succnsim { get; }

    /// <summary>
    /// Gets character reference <c>&amp;succsim;</c>
    /// representing U+0227F.
    /// </summary>
    Node succsim { get; }

    /// <summary>
    /// Gets character reference <c>&amp;SuchThat;</c>
    /// representing U+0220B.
    /// </summary>
    Node SuchThat { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Sum;</c>
    /// representing U+02211.
    /// </summary>
    Node Sum { get; }

    /// <summary>
    /// Gets character reference <c>&amp;sum;</c>
    /// representing U+02211.
    /// </summary>
    Node sum { get; }

    /// <summary>
    /// Gets character reference <c>&amp;sung;</c>
    /// representing U+0266A.
    /// </summary>
    Node sung { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Sup;</c>
    /// representing U+022D1.
    /// </summary>
    Node Sup { get; }

    /// <summary>
    /// Gets character reference <c>&amp;sup;</c>
    /// representing U+02283.
    /// </summary>
    Node sup { get; }

    /// <summary>
    /// Gets character reference <c>&amp;sup1;</c>
    /// representing U+000B9.
    /// </summary>
    Node sup1 { get; }

    /// <summary>
    /// Gets character reference <c>&amp;sup2;</c>
    /// representing U+000B2.
    /// </summary>
    Node sup2 { get; }

    /// <summary>
    /// Gets character reference <c>&amp;sup3;</c>
    /// representing U+000B3.
    /// </summary>
    Node sup3 { get; }

    /// <summary>
    /// Gets character reference <c>&amp;supdot;</c>
    /// representing U+02ABE.
    /// </summary>
    Node supdot { get; }

    /// <summary>
    /// Gets character reference <c>&amp;supdsub;</c>
    /// representing U+02AD8.
    /// </summary>
    Node supdsub { get; }

    /// <summary>
    /// Gets character reference <c>&amp;supE;</c>
    /// representing U+02AC6.
    /// </summary>
    Node supE { get; }

    /// <summary>
    /// Gets character reference <c>&amp;supe;</c>
    /// representing U+02287.
    /// </summary>
    Node supe { get; }

    /// <summary>
    /// Gets character reference <c>&amp;supedot;</c>
    /// representing U+02AC4.
    /// </summary>
    Node supedot { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Superset;</c>
    /// representing U+02283.
    /// </summary>
    Node Superset { get; }

    /// <summary>
    /// Gets character reference <c>&amp;SupersetEqual;</c>
    /// representing U+02287.
    /// </summary>
    Node SupersetEqual { get; }

    /// <summary>
    /// Gets character reference <c>&amp;suphsol;</c>
    /// representing U+027C9.
    /// </summary>
    Node suphsol { get; }

    /// <summary>
    /// Gets character reference <c>&amp;suphsub;</c>
    /// representing U+02AD7.
    /// </summary>
    Node suphsub { get; }

    /// <summary>
    /// Gets character reference <c>&amp;suplarr;</c>
    /// representing U+0297B.
    /// </summary>
    Node suplarr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;supmult;</c>
    /// representing U+02AC2.
    /// </summary>
    Node supmult { get; }

    /// <summary>
    /// Gets character reference <c>&amp;supnE;</c>
    /// representing U+02ACC.
    /// </summary>
    Node supnE { get; }

    /// <summary>
    /// Gets character reference <c>&amp;supne;</c>
    /// representing U+0228B.
    /// </summary>
    Node supne { get; }

    /// <summary>
    /// Gets character reference <c>&amp;supplus;</c>
    /// representing U+02AC0.
    /// </summary>
    Node supplus { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Supset;</c>
    /// representing U+022D1.
    /// </summary>
    Node Supset { get; }

    /// <summary>
    /// Gets character reference <c>&amp;supset;</c>
    /// representing U+02283.
    /// </summary>
    Node supset { get; }

    /// <summary>
    /// Gets character reference <c>&amp;supseteq;</c>
    /// representing U+02287.
    /// </summary>
    Node supseteq { get; }

    /// <summary>
    /// Gets character reference <c>&amp;supseteqq;</c>
    /// representing U+02AC6.
    /// </summary>
    Node supseteqq { get; }

    /// <summary>
    /// Gets character reference <c>&amp;supsetneq;</c>
    /// representing U+0228B.
    /// </summary>
    Node supsetneq { get; }

    /// <summary>
    /// Gets character reference <c>&amp;supsetneqq;</c>
    /// representing U+02ACC.
    /// </summary>
    Node supsetneqq { get; }

    /// <summary>
    /// Gets character reference <c>&amp;supsim;</c>
    /// representing U+02AC8.
    /// </summary>
    Node supsim { get; }

    /// <summary>
    /// Gets character reference <c>&amp;supsub;</c>
    /// representing U+02AD4.
    /// </summary>
    Node supsub { get; }

    /// <summary>
    /// Gets character reference <c>&amp;supsup;</c>
    /// representing U+02AD6.
    /// </summary>
    Node supsup { get; }

    /// <summary>
    /// Gets character reference <c>&amp;swarhk;</c>
    /// representing U+02926.
    /// </summary>
    Node swarhk { get; }

    /// <summary>
    /// Gets character reference <c>&amp;swArr;</c>
    /// representing U+021D9.
    /// </summary>
    Node swArr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;swarr;</c>
    /// representing U+02199.
    /// </summary>
    Node swarr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;swarrow;</c>
    /// representing U+02199.
    /// </summary>
    Node swarrow { get; }

    /// <summary>
    /// Gets character reference <c>&amp;swnwar;</c>
    /// representing U+0292A.
    /// </summary>
    Node swnwar { get; }

    /// <summary>
    /// Gets character reference <c>&amp;szlig;</c>
    /// representing U+000DF.
    /// </summary>
    Node szlig { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Tab;</c>
    /// representing U+00009.
    /// </summary>
    Node Tab { get; }

    /// <summary>
    /// Gets character reference <c>&amp;target;</c>
    /// representing U+02316.
    /// </summary>
    Node target { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Tau;</c>
    /// representing U+003A4.
    /// </summary>
    Node Tau { get; }

    /// <summary>
    /// Gets character reference <c>&amp;tau;</c>
    /// representing U+003C4.
    /// </summary>
    Node tau { get; }

    /// <summary>
    /// Gets character reference <c>&amp;tbrk;</c>
    /// representing U+023B4.
    /// </summary>
    Node tbrk { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Tcaron;</c>
    /// representing U+00164.
    /// </summary>
    Node Tcaron { get; }

    /// <summary>
    /// Gets character reference <c>&amp;tcaron;</c>
    /// representing U+00165.
    /// </summary>
    Node tcaron { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Tcedil;</c>
    /// representing U+00162.
    /// </summary>
    Node Tcedil { get; }

    /// <summary>
    /// Gets character reference <c>&amp;tcedil;</c>
    /// representing U+00163.
    /// </summary>
    Node tcedil { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Tcy;</c>
    /// representing U+00422.
    /// </summary>
    Node Tcy { get; }

    /// <summary>
    /// Gets character reference <c>&amp;tcy;</c>
    /// representing U+00442.
    /// </summary>
    Node tcy { get; }

    /// <summary>
    /// Gets character reference <c>&amp;tdot;</c>
    /// representing U+020DB.
    /// </summary>
    Node tdot { get; }

    /// <summary>
    /// Gets character reference <c>&amp;telrec;</c>
    /// representing U+02315.
    /// </summary>
    Node telrec { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Tfr;</c>
    /// representing U+1D517.
    /// </summary>
    Node Tfr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;tfr;</c>
    /// representing U+1D531.
    /// </summary>
    Node tfr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;there4;</c>
    /// representing U+02234.
    /// </summary>
    Node there4 { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Therefore;</c>
    /// representing U+02234.
    /// </summary>
    Node Therefore { get; }

    /// <summary>
    /// Gets character reference <c>&amp;therefore;</c>
    /// representing U+02234.
    /// </summary>
    Node therefore { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Theta;</c>
    /// representing U+00398.
    /// </summary>
    Node Theta { get; }

    /// <summary>
    /// Gets character reference <c>&amp;theta;</c>
    /// representing U+003B8.
    /// </summary>
    Node theta { get; }

    /// <summary>
    /// Gets character reference <c>&amp;thetasym;</c>
    /// representing U+003D1.
    /// </summary>
    Node thetasym { get; }

    /// <summary>
    /// Gets character reference <c>&amp;thetav;</c>
    /// representing U+003D1.
    /// </summary>
    Node thetav { get; }

    /// <summary>
    /// Gets character reference <c>&amp;thickapprox;</c>
    /// representing U+02248.
    /// </summary>
    Node thickapprox { get; }

    /// <summary>
    /// Gets character reference <c>&amp;thicksim;</c>
    /// representing U+0223C.
    /// </summary>
    Node thicksim { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ThickSpace;</c>
    /// representing U+0205F U+0200A.
    /// </summary>
    Node ThickSpace { get; }

    /// <summary>
    /// Gets character reference <c>&amp;thinsp;</c>
    /// representing U+02009.
    /// </summary>
    Node thinsp { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ThinSpace;</c>
    /// representing U+02009.
    /// </summary>
    Node ThinSpace { get; }

    /// <summary>
    /// Gets character reference <c>&amp;thkap;</c>
    /// representing U+02248.
    /// </summary>
    Node thkap { get; }

    /// <summary>
    /// Gets character reference <c>&amp;thksim;</c>
    /// representing U+0223C.
    /// </summary>
    Node thksim { get; }

    /// <summary>
    /// Gets character reference <c>&amp;THORN;</c>
    /// representing U+000DE.
    /// </summary>
    Node THORN { get; }

    /// <summary>
    /// Gets character reference <c>&amp;thorn;</c>
    /// representing U+000FE.
    /// </summary>
    Node thorn { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Tilde;</c>
    /// representing U+0223C.
    /// </summary>
    Node Tilde { get; }

    /// <summary>
    /// Gets character reference <c>&amp;tilde;</c>
    /// representing U+002DC.
    /// </summary>
    Node tilde { get; }

    /// <summary>
    /// Gets character reference <c>&amp;TildeEqual;</c>
    /// representing U+02243.
    /// </summary>
    Node TildeEqual { get; }

    /// <summary>
    /// Gets character reference <c>&amp;TildeFullEqual;</c>
    /// representing U+02245.
    /// </summary>
    Node TildeFullEqual { get; }

    /// <summary>
    /// Gets character reference <c>&amp;TildeTilde;</c>
    /// representing U+02248.
    /// </summary>
    Node TildeTilde { get; }

    /// <summary>
    /// Gets character reference <c>&amp;times;</c>
    /// representing U+000D7.
    /// </summary>
    Node times { get; }

    /// <summary>
    /// Gets character reference <c>&amp;timesb;</c>
    /// representing U+022A0.
    /// </summary>
    Node timesb { get; }

    /// <summary>
    /// Gets character reference <c>&amp;timesbar;</c>
    /// representing U+02A31.
    /// </summary>
    Node timesbar { get; }

    /// <summary>
    /// Gets character reference <c>&amp;timesd;</c>
    /// representing U+02A30.
    /// </summary>
    Node timesd { get; }

    /// <summary>
    /// Gets character reference <c>&amp;tint;</c>
    /// representing U+0222D.
    /// </summary>
    Node tint { get; }

    /// <summary>
    /// Gets character reference <c>&amp;toea;</c>
    /// representing U+02928.
    /// </summary>
    Node toea { get; }

    /// <summary>
    /// Gets character reference <c>&amp;top;</c>
    /// representing U+022A4.
    /// </summary>
    Node top { get; }

    /// <summary>
    /// Gets character reference <c>&amp;topbot;</c>
    /// representing U+02336.
    /// </summary>
    Node topbot { get; }

    /// <summary>
    /// Gets character reference <c>&amp;topcir;</c>
    /// representing U+02AF1.
    /// </summary>
    Node topcir { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Topf;</c>
    /// representing U+1D54B.
    /// </summary>
    Node Topf { get; }

    /// <summary>
    /// Gets character reference <c>&amp;topf;</c>
    /// representing U+1D565.
    /// </summary>
    Node topf { get; }

    /// <summary>
    /// Gets character reference <c>&amp;topfork;</c>
    /// representing U+02ADA.
    /// </summary>
    Node topfork { get; }

    /// <summary>
    /// Gets character reference <c>&amp;tosa;</c>
    /// representing U+02929.
    /// </summary>
    Node tosa { get; }

    /// <summary>
    /// Gets character reference <c>&amp;tprime;</c>
    /// representing U+02034.
    /// </summary>
    Node tprime { get; }

    /// <summary>
    /// Gets character reference <c>&amp;TRADE;</c>
    /// representing U+02122.
    /// </summary>
    Node TRADE { get; }

    /// <summary>
    /// Gets character reference <c>&amp;trade;</c>
    /// representing U+02122.
    /// </summary>
    Node trade { get; }

    /// <summary>
    /// Gets character reference <c>&amp;triangle;</c>
    /// representing U+025B5.
    /// </summary>
    Node triangle { get; }

    /// <summary>
    /// Gets character reference <c>&amp;triangledown;</c>
    /// representing U+025BF.
    /// </summary>
    Node triangledown { get; }

    /// <summary>
    /// Gets character reference <c>&amp;triangleleft;</c>
    /// representing U+025C3.
    /// </summary>
    Node triangleleft { get; }

    /// <summary>
    /// Gets character reference <c>&amp;trianglelefteq;</c>
    /// representing U+022B4.
    /// </summary>
    Node trianglelefteq { get; }

    /// <summary>
    /// Gets character reference <c>&amp;triangleq;</c>
    /// representing U+0225C.
    /// </summary>
    Node triangleq { get; }

    /// <summary>
    /// Gets character reference <c>&amp;triangleright;</c>
    /// representing U+025B9.
    /// </summary>
    Node triangleright { get; }

    /// <summary>
    /// Gets character reference <c>&amp;trianglerighteq;</c>
    /// representing U+022B5.
    /// </summary>
    Node trianglerighteq { get; }

    /// <summary>
    /// Gets character reference <c>&amp;tridot;</c>
    /// representing U+025EC.
    /// </summary>
    Node tridot { get; }

    /// <summary>
    /// Gets character reference <c>&amp;trie;</c>
    /// representing U+0225C.
    /// </summary>
    Node trie { get; }

    /// <summary>
    /// Gets character reference <c>&amp;triminus;</c>
    /// representing U+02A3A.
    /// </summary>
    Node triminus { get; }

    /// <summary>
    /// Gets character reference <c>&amp;TripleDot;</c>
    /// representing U+020DB.
    /// </summary>
    Node TripleDot { get; }

    /// <summary>
    /// Gets character reference <c>&amp;triplus;</c>
    /// representing U+02A39.
    /// </summary>
    Node triplus { get; }

    /// <summary>
    /// Gets character reference <c>&amp;trisb;</c>
    /// representing U+029CD.
    /// </summary>
    Node trisb { get; }

    /// <summary>
    /// Gets character reference <c>&amp;tritime;</c>
    /// representing U+02A3B.
    /// </summary>
    Node tritime { get; }

    /// <summary>
    /// Gets character reference <c>&amp;trpezium;</c>
    /// representing U+023E2.
    /// </summary>
    Node trpezium { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Tscr;</c>
    /// representing U+1D4AF.
    /// </summary>
    Node Tscr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;tscr;</c>
    /// representing U+1D4C9.
    /// </summary>
    Node tscr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;TScy;</c>
    /// representing U+00426.
    /// </summary>
    Node TScy { get; }

    /// <summary>
    /// Gets character reference <c>&amp;tscy;</c>
    /// representing U+00446.
    /// </summary>
    Node tscy { get; }

    /// <summary>
    /// Gets character reference <c>&amp;TSHcy;</c>
    /// representing U+0040B.
    /// </summary>
    Node TSHcy { get; }

    /// <summary>
    /// Gets character reference <c>&amp;tshcy;</c>
    /// representing U+0045B.
    /// </summary>
    Node tshcy { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Tstrok;</c>
    /// representing U+00166.
    /// </summary>
    Node Tstrok { get; }

    /// <summary>
    /// Gets character reference <c>&amp;tstrok;</c>
    /// representing U+00167.
    /// </summary>
    Node tstrok { get; }

    /// <summary>
    /// Gets character reference <c>&amp;twixt;</c>
    /// representing U+0226C.
    /// </summary>
    Node twixt { get; }

    /// <summary>
    /// Gets character reference <c>&amp;twoheadleftarrow;</c>
    /// representing U+0219E.
    /// </summary>
    Node twoheadleftarrow { get; }

    /// <summary>
    /// Gets character reference <c>&amp;twoheadrightarrow;</c>
    /// representing U+021A0.
    /// </summary>
    Node twoheadrightarrow { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Uacute;</c>
    /// representing U+000DA.
    /// </summary>
    Node Uacute { get; }

    /// <summary>
    /// Gets character reference <c>&amp;uacute;</c>
    /// representing U+000FA.
    /// </summary>
    Node uacute { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Uarr;</c>
    /// representing U+0219F.
    /// </summary>
    Node Uarr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;uArr;</c>
    /// representing U+021D1.
    /// </summary>
    Node uArr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;uarr;</c>
    /// representing U+02191.
    /// </summary>
    Node uarr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Uarrocir;</c>
    /// representing U+02949.
    /// </summary>
    Node Uarrocir { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Ubrcy;</c>
    /// representing U+0040E.
    /// </summary>
    Node Ubrcy { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ubrcy;</c>
    /// representing U+0045E.
    /// </summary>
    Node ubrcy { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Ubreve;</c>
    /// representing U+0016C.
    /// </summary>
    Node Ubreve { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ubreve;</c>
    /// representing U+0016D.
    /// </summary>
    Node ubreve { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Ucirc;</c>
    /// representing U+000DB.
    /// </summary>
    Node Ucirc { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ucirc;</c>
    /// representing U+000FB.
    /// </summary>
    Node ucirc { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Ucy;</c>
    /// representing U+00423.
    /// </summary>
    Node Ucy { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ucy;</c>
    /// representing U+00443.
    /// </summary>
    Node ucy { get; }

    /// <summary>
    /// Gets character reference <c>&amp;udarr;</c>
    /// representing U+021C5.
    /// </summary>
    Node udarr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Udblac;</c>
    /// representing U+00170.
    /// </summary>
    Node Udblac { get; }

    /// <summary>
    /// Gets character reference <c>&amp;udblac;</c>
    /// representing U+00171.
    /// </summary>
    Node udblac { get; }

    /// <summary>
    /// Gets character reference <c>&amp;udhar;</c>
    /// representing U+0296E.
    /// </summary>
    Node udhar { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ufisht;</c>
    /// representing U+0297E.
    /// </summary>
    Node ufisht { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Ufr;</c>
    /// representing U+1D518.
    /// </summary>
    Node Ufr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ufr;</c>
    /// representing U+1D532.
    /// </summary>
    Node ufr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Ugrave;</c>
    /// representing U+000D9.
    /// </summary>
    Node Ugrave { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ugrave;</c>
    /// representing U+000F9.
    /// </summary>
    Node ugrave { get; }

    /// <summary>
    /// Gets character reference <c>&amp;uHar;</c>
    /// representing U+02963.
    /// </summary>
    Node uHar { get; }

    /// <summary>
    /// Gets character reference <c>&amp;uharl;</c>
    /// representing U+021BF.
    /// </summary>
    Node uharl { get; }

    /// <summary>
    /// Gets character reference <c>&amp;uharr;</c>
    /// representing U+021BE.
    /// </summary>
    Node uharr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;uhblk;</c>
    /// representing U+02580.
    /// </summary>
    Node uhblk { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ulcorn;</c>
    /// representing U+0231C.
    /// </summary>
    Node ulcorn { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ulcorner;</c>
    /// representing U+0231C.
    /// </summary>
    Node ulcorner { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ulcrop;</c>
    /// representing U+0230F.
    /// </summary>
    Node ulcrop { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ultri;</c>
    /// representing U+025F8.
    /// </summary>
    Node ultri { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Umacr;</c>
    /// representing U+0016A.
    /// </summary>
    Node Umacr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;umacr;</c>
    /// representing U+0016B.
    /// </summary>
    Node umacr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;uml;</c>
    /// representing U+000A8.
    /// </summary>
    Node uml { get; }

    /// <summary>
    /// Gets character reference <c>&amp;UnderBar;</c>
    /// representing U+0005F.
    /// </summary>
    Node UnderBar { get; }

    /// <summary>
    /// Gets character reference <c>&amp;UnderBrace;</c>
    /// representing U+023DF.
    /// </summary>
    Node UnderBrace { get; }

    /// <summary>
    /// Gets character reference <c>&amp;UnderBracket;</c>
    /// representing U+023B5.
    /// </summary>
    Node UnderBracket { get; }

    /// <summary>
    /// Gets character reference <c>&amp;UnderParenthesis;</c>
    /// representing U+023DD.
    /// </summary>
    Node UnderParenthesis { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Union;</c>
    /// representing U+022C3.
    /// </summary>
    Node Union { get; }

    /// <summary>
    /// Gets character reference <c>&amp;UnionPlus;</c>
    /// representing U+0228E.
    /// </summary>
    Node UnionPlus { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Uogon;</c>
    /// representing U+00172.
    /// </summary>
    Node Uogon { get; }

    /// <summary>
    /// Gets character reference <c>&amp;uogon;</c>
    /// representing U+00173.
    /// </summary>
    Node uogon { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Uopf;</c>
    /// representing U+1D54C.
    /// </summary>
    Node Uopf { get; }

    /// <summary>
    /// Gets character reference <c>&amp;uopf;</c>
    /// representing U+1D566.
    /// </summary>
    Node uopf { get; }

    /// <summary>
    /// Gets character reference <c>&amp;UpArrow;</c>
    /// representing U+02191.
    /// </summary>
    Node UpArrow { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Uparrow;</c>
    /// representing U+021D1.
    /// </summary>
    Node Uparrow { get; }

    /// <summary>
    /// Gets character reference <c>&amp;uparrow;</c>
    /// representing U+02191.
    /// </summary>
    Node uparrow { get; }

    /// <summary>
    /// Gets character reference <c>&amp;UpArrowBar;</c>
    /// representing U+02912.
    /// </summary>
    Node UpArrowBar { get; }

    /// <summary>
    /// Gets character reference <c>&amp;UpArrowDownArrow;</c>
    /// representing U+021C5.
    /// </summary>
    Node UpArrowDownArrow { get; }

    /// <summary>
    /// Gets character reference <c>&amp;UpDownArrow;</c>
    /// representing U+02195.
    /// </summary>
    Node UpDownArrow { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Updownarrow;</c>
    /// representing U+021D5.
    /// </summary>
    Node Updownarrow { get; }

    /// <summary>
    /// Gets character reference <c>&amp;updownarrow;</c>
    /// representing U+02195.
    /// </summary>
    Node updownarrow { get; }

    /// <summary>
    /// Gets character reference <c>&amp;UpEquilibrium;</c>
    /// representing U+0296E.
    /// </summary>
    Node UpEquilibrium { get; }

    /// <summary>
    /// Gets character reference <c>&amp;upharpoonleft;</c>
    /// representing U+021BF.
    /// </summary>
    Node upharpoonleft { get; }

    /// <summary>
    /// Gets character reference <c>&amp;upharpoonright;</c>
    /// representing U+021BE.
    /// </summary>
    Node upharpoonright { get; }

    /// <summary>
    /// Gets character reference <c>&amp;uplus;</c>
    /// representing U+0228E.
    /// </summary>
    Node uplus { get; }

    /// <summary>
    /// Gets character reference <c>&amp;UpperLeftArrow;</c>
    /// representing U+02196.
    /// </summary>
    Node UpperLeftArrow { get; }

    /// <summary>
    /// Gets character reference <c>&amp;UpperRightArrow;</c>
    /// representing U+02197.
    /// </summary>
    Node UpperRightArrow { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Upsi;</c>
    /// representing U+003D2.
    /// </summary>
    Node Upsi { get; }

    /// <summary>
    /// Gets character reference <c>&amp;upsi;</c>
    /// representing U+003C5.
    /// </summary>
    Node upsi { get; }

    /// <summary>
    /// Gets character reference <c>&amp;upsih;</c>
    /// representing U+003D2.
    /// </summary>
    Node upsih { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Upsilon;</c>
    /// representing U+003A5.
    /// </summary>
    Node Upsilon { get; }

    /// <summary>
    /// Gets character reference <c>&amp;upsilon;</c>
    /// representing U+003C5.
    /// </summary>
    Node upsilon { get; }

    /// <summary>
    /// Gets character reference <c>&amp;UpTee;</c>
    /// representing U+022A5.
    /// </summary>
    Node UpTee { get; }

    /// <summary>
    /// Gets character reference <c>&amp;UpTeeArrow;</c>
    /// representing U+021A5.
    /// </summary>
    Node UpTeeArrow { get; }

    /// <summary>
    /// Gets character reference <c>&amp;upuparrows;</c>
    /// representing U+021C8.
    /// </summary>
    Node upuparrows { get; }

    /// <summary>
    /// Gets character reference <c>&amp;urcorn;</c>
    /// representing U+0231D.
    /// </summary>
    Node urcorn { get; }

    /// <summary>
    /// Gets character reference <c>&amp;urcorner;</c>
    /// representing U+0231D.
    /// </summary>
    Node urcorner { get; }

    /// <summary>
    /// Gets character reference <c>&amp;urcrop;</c>
    /// representing U+0230E.
    /// </summary>
    Node urcrop { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Uring;</c>
    /// representing U+0016E.
    /// </summary>
    Node Uring { get; }

    /// <summary>
    /// Gets character reference <c>&amp;uring;</c>
    /// representing U+0016F.
    /// </summary>
    Node uring { get; }

    /// <summary>
    /// Gets character reference <c>&amp;urtri;</c>
    /// representing U+025F9.
    /// </summary>
    Node urtri { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Uscr;</c>
    /// representing U+1D4B0.
    /// </summary>
    Node Uscr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;uscr;</c>
    /// representing U+1D4CA.
    /// </summary>
    Node uscr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;utdot;</c>
    /// representing U+022F0.
    /// </summary>
    Node utdot { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Utilde;</c>
    /// representing U+00168.
    /// </summary>
    Node Utilde { get; }

    /// <summary>
    /// Gets character reference <c>&amp;utilde;</c>
    /// representing U+00169.
    /// </summary>
    Node utilde { get; }

    /// <summary>
    /// Gets character reference <c>&amp;utri;</c>
    /// representing U+025B5.
    /// </summary>
    Node utri { get; }

    /// <summary>
    /// Gets character reference <c>&amp;utrif;</c>
    /// representing U+025B4.
    /// </summary>
    Node utrif { get; }

    /// <summary>
    /// Gets character reference <c>&amp;uuarr;</c>
    /// representing U+021C8.
    /// </summary>
    Node uuarr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Uuml;</c>
    /// representing U+000DC.
    /// </summary>
    Node Uuml { get; }

    /// <summary>
    /// Gets character reference <c>&amp;uuml;</c>
    /// representing U+000FC.
    /// </summary>
    Node uuml { get; }

    /// <summary>
    /// Gets character reference <c>&amp;uwangle;</c>
    /// representing U+029A7.
    /// </summary>
    Node uwangle { get; }

    /// <summary>
    /// Gets character reference <c>&amp;vangrt;</c>
    /// representing U+0299C.
    /// </summary>
    Node vangrt { get; }

    /// <summary>
    /// Gets character reference <c>&amp;varepsilon;</c>
    /// representing U+003F5.
    /// </summary>
    Node varepsilon { get; }

    /// <summary>
    /// Gets character reference <c>&amp;varkappa;</c>
    /// representing U+003F0.
    /// </summary>
    Node varkappa { get; }

    /// <summary>
    /// Gets character reference <c>&amp;varnothing;</c>
    /// representing U+02205.
    /// </summary>
    Node varnothing { get; }

    /// <summary>
    /// Gets character reference <c>&amp;varphi;</c>
    /// representing U+003D5.
    /// </summary>
    Node varphi { get; }

    /// <summary>
    /// Gets character reference <c>&amp;varpi;</c>
    /// representing U+003D6.
    /// </summary>
    Node varpi { get; }

    /// <summary>
    /// Gets character reference <c>&amp;varpropto;</c>
    /// representing U+0221D.
    /// </summary>
    Node varpropto { get; }

    /// <summary>
    /// Gets character reference <c>&amp;vArr;</c>
    /// representing U+021D5.
    /// </summary>
    Node vArr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;varr;</c>
    /// representing U+02195.
    /// </summary>
    Node varr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;varrho;</c>
    /// representing U+003F1.
    /// </summary>
    Node varrho { get; }

    /// <summary>
    /// Gets character reference <c>&amp;varsigma;</c>
    /// representing U+003C2.
    /// </summary>
    Node varsigma { get; }

    /// <summary>
    /// Gets character reference <c>&amp;varsubsetneq;</c>
    /// representing U+0228A U+0FE00.
    /// </summary>
    Node varsubsetneq { get; }

    /// <summary>
    /// Gets character reference <c>&amp;varsubsetneqq;</c>
    /// representing U+02ACB U+0FE00.
    /// </summary>
    Node varsubsetneqq { get; }

    /// <summary>
    /// Gets character reference <c>&amp;varsupsetneq;</c>
    /// representing U+0228B U+0FE00.
    /// </summary>
    Node varsupsetneq { get; }

    /// <summary>
    /// Gets character reference <c>&amp;varsupsetneqq;</c>
    /// representing U+02ACC U+0FE00.
    /// </summary>
    Node varsupsetneqq { get; }

    /// <summary>
    /// Gets character reference <c>&amp;vartheta;</c>
    /// representing U+003D1.
    /// </summary>
    Node vartheta { get; }

    /// <summary>
    /// Gets character reference <c>&amp;vartriangleleft;</c>
    /// representing U+022B2.
    /// </summary>
    Node vartriangleleft { get; }

    /// <summary>
    /// Gets character reference <c>&amp;vartriangleright;</c>
    /// representing U+022B3.
    /// </summary>
    Node vartriangleright { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Vbar;</c>
    /// representing U+02AEB.
    /// </summary>
    Node Vbar { get; }

    /// <summary>
    /// Gets character reference <c>&amp;vBar;</c>
    /// representing U+02AE8.
    /// </summary>
    Node vBar { get; }

    /// <summary>
    /// Gets character reference <c>&amp;vBarv;</c>
    /// representing U+02AE9.
    /// </summary>
    Node vBarv { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Vcy;</c>
    /// representing U+00412.
    /// </summary>
    Node Vcy { get; }

    /// <summary>
    /// Gets character reference <c>&amp;vcy;</c>
    /// representing U+00432.
    /// </summary>
    Node vcy { get; }

    /// <summary>
    /// Gets character reference <c>&amp;VDash;</c>
    /// representing U+022AB.
    /// </summary>
    Node VDash { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Vdash;</c>
    /// representing U+022A9.
    /// </summary>
    Node Vdash { get; }

    /// <summary>
    /// Gets character reference <c>&amp;vDash;</c>
    /// representing U+022A8.
    /// </summary>
    Node vDash { get; }

    /// <summary>
    /// Gets character reference <c>&amp;vdash;</c>
    /// representing U+022A2.
    /// </summary>
    Node vdash { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Vdashl;</c>
    /// representing U+02AE6.
    /// </summary>
    Node Vdashl { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Vee;</c>
    /// representing U+022C1.
    /// </summary>
    Node Vee { get; }

    /// <summary>
    /// Gets character reference <c>&amp;vee;</c>
    /// representing U+02228.
    /// </summary>
    Node vee { get; }

    /// <summary>
    /// Gets character reference <c>&amp;veebar;</c>
    /// representing U+022BB.
    /// </summary>
    Node veebar { get; }

    /// <summary>
    /// Gets character reference <c>&amp;veeeq;</c>
    /// representing U+0225A.
    /// </summary>
    Node veeeq { get; }

    /// <summary>
    /// Gets character reference <c>&amp;vellip;</c>
    /// representing U+022EE.
    /// </summary>
    Node vellip { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Verbar;</c>
    /// representing U+02016.
    /// </summary>
    Node Verbar { get; }

    /// <summary>
    /// Gets character reference <c>&amp;verbar;</c>
    /// representing U+0007C.
    /// </summary>
    Node verbar { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Vert;</c>
    /// representing U+02016.
    /// </summary>
    Node Vert { get; }

    /// <summary>
    /// Gets character reference <c>&amp;vert;</c>
    /// representing U+0007C.
    /// </summary>
    Node vert { get; }

    /// <summary>
    /// Gets character reference <c>&amp;VerticalBar;</c>
    /// representing U+02223.
    /// </summary>
    Node VerticalBar { get; }

    /// <summary>
    /// Gets character reference <c>&amp;VerticalLine;</c>
    /// representing U+0007C.
    /// </summary>
    Node VerticalLine { get; }

    /// <summary>
    /// Gets character reference <c>&amp;VerticalSeparator;</c>
    /// representing U+02758.
    /// </summary>
    Node VerticalSeparator { get; }

    /// <summary>
    /// Gets character reference <c>&amp;VerticalTilde;</c>
    /// representing U+02240.
    /// </summary>
    Node VerticalTilde { get; }

    /// <summary>
    /// Gets character reference <c>&amp;VeryThinSpace;</c>
    /// representing U+0200A.
    /// </summary>
    Node VeryThinSpace { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Vfr;</c>
    /// representing U+1D519.
    /// </summary>
    Node Vfr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;vfr;</c>
    /// representing U+1D533.
    /// </summary>
    Node vfr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;vltri;</c>
    /// representing U+022B2.
    /// </summary>
    Node vltri { get; }

    /// <summary>
    /// Gets character reference <c>&amp;vnsub;</c>
    /// representing U+02282 U+020D2.
    /// </summary>
    Node vnsub { get; }

    /// <summary>
    /// Gets character reference <c>&amp;vnsup;</c>
    /// representing U+02283 U+020D2.
    /// </summary>
    Node vnsup { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Vopf;</c>
    /// representing U+1D54D.
    /// </summary>
    Node Vopf { get; }

    /// <summary>
    /// Gets character reference <c>&amp;vopf;</c>
    /// representing U+1D567.
    /// </summary>
    Node vopf { get; }

    /// <summary>
    /// Gets character reference <c>&amp;vprop;</c>
    /// representing U+0221D.
    /// </summary>
    Node vprop { get; }

    /// <summary>
    /// Gets character reference <c>&amp;vrtri;</c>
    /// representing U+022B3.
    /// </summary>
    Node vrtri { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Vscr;</c>
    /// representing U+1D4B1.
    /// </summary>
    Node Vscr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;vscr;</c>
    /// representing U+1D4CB.
    /// </summary>
    Node vscr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;vsubnE;</c>
    /// representing U+02ACB U+0FE00.
    /// </summary>
    Node vsubnE { get; }

    /// <summary>
    /// Gets character reference <c>&amp;vsubne;</c>
    /// representing U+0228A U+0FE00.
    /// </summary>
    Node vsubne { get; }

    /// <summary>
    /// Gets character reference <c>&amp;vsupnE;</c>
    /// representing U+02ACC U+0FE00.
    /// </summary>
    Node vsupnE { get; }

    /// <summary>
    /// Gets character reference <c>&amp;vsupne;</c>
    /// representing U+0228B U+0FE00.
    /// </summary>
    Node vsupne { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Vvdash;</c>
    /// representing U+022AA.
    /// </summary>
    Node Vvdash { get; }

    /// <summary>
    /// Gets character reference <c>&amp;vzigzag;</c>
    /// representing U+0299A.
    /// </summary>
    Node vzigzag { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Wcirc;</c>
    /// representing U+00174.
    /// </summary>
    Node Wcirc { get; }

    /// <summary>
    /// Gets character reference <c>&amp;wcirc;</c>
    /// representing U+00175.
    /// </summary>
    Node wcirc { get; }

    /// <summary>
    /// Gets character reference <c>&amp;wedbar;</c>
    /// representing U+02A5F.
    /// </summary>
    Node wedbar { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Wedge;</c>
    /// representing U+022C0.
    /// </summary>
    Node Wedge { get; }

    /// <summary>
    /// Gets character reference <c>&amp;wedge;</c>
    /// representing U+02227.
    /// </summary>
    Node wedge { get; }

    /// <summary>
    /// Gets character reference <c>&amp;wedgeq;</c>
    /// representing U+02259.
    /// </summary>
    Node wedgeq { get; }

    /// <summary>
    /// Gets character reference <c>&amp;weierp;</c>
    /// representing U+02118.
    /// </summary>
    Node weierp { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Wfr;</c>
    /// representing U+1D51A.
    /// </summary>
    Node Wfr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;wfr;</c>
    /// representing U+1D534.
    /// </summary>
    Node wfr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Wopf;</c>
    /// representing U+1D54E.
    /// </summary>
    Node Wopf { get; }

    /// <summary>
    /// Gets character reference <c>&amp;wopf;</c>
    /// representing U+1D568.
    /// </summary>
    Node wopf { get; }

    /// <summary>
    /// Gets character reference <c>&amp;wp;</c>
    /// representing U+02118.
    /// </summary>
    Node wp { get; }

    /// <summary>
    /// Gets character reference <c>&amp;wr;</c>
    /// representing U+02240.
    /// </summary>
    Node wr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;wreath;</c>
    /// representing U+02240.
    /// </summary>
    Node wreath { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Wscr;</c>
    /// representing U+1D4B2.
    /// </summary>
    Node Wscr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;wscr;</c>
    /// representing U+1D4CC.
    /// </summary>
    Node wscr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;xcap;</c>
    /// representing U+022C2.
    /// </summary>
    Node xcap { get; }

    /// <summary>
    /// Gets character reference <c>&amp;xcirc;</c>
    /// representing U+025EF.
    /// </summary>
    Node xcirc { get; }

    /// <summary>
    /// Gets character reference <c>&amp;xcup;</c>
    /// representing U+022C3.
    /// </summary>
    Node xcup { get; }

    /// <summary>
    /// Gets character reference <c>&amp;xdtri;</c>
    /// representing U+025BD.
    /// </summary>
    Node xdtri { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Xfr;</c>
    /// representing U+1D51B.
    /// </summary>
    Node Xfr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;xfr;</c>
    /// representing U+1D535.
    /// </summary>
    Node xfr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;xhArr;</c>
    /// representing U+027FA.
    /// </summary>
    Node xhArr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;xharr;</c>
    /// representing U+027F7.
    /// </summary>
    Node xharr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Xi;</c>
    /// representing U+0039E.
    /// </summary>
    Node Xi { get; }

    /// <summary>
    /// Gets character reference <c>&amp;xi;</c>
    /// representing U+003BE.
    /// </summary>
    Node xi { get; }

    /// <summary>
    /// Gets character reference <c>&amp;xlArr;</c>
    /// representing U+027F8.
    /// </summary>
    Node xlArr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;xlarr;</c>
    /// representing U+027F5.
    /// </summary>
    Node xlarr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;xmap;</c>
    /// representing U+027FC.
    /// </summary>
    Node xmap { get; }

    /// <summary>
    /// Gets character reference <c>&amp;xnis;</c>
    /// representing U+022FB.
    /// </summary>
    Node xnis { get; }

    /// <summary>
    /// Gets character reference <c>&amp;xodot;</c>
    /// representing U+02A00.
    /// </summary>
    Node xodot { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Xopf;</c>
    /// representing U+1D54F.
    /// </summary>
    Node Xopf { get; }

    /// <summary>
    /// Gets character reference <c>&amp;xopf;</c>
    /// representing U+1D569.
    /// </summary>
    Node xopf { get; }

    /// <summary>
    /// Gets character reference <c>&amp;xoplus;</c>
    /// representing U+02A01.
    /// </summary>
    Node xoplus { get; }

    /// <summary>
    /// Gets character reference <c>&amp;xotime;</c>
    /// representing U+02A02.
    /// </summary>
    Node xotime { get; }

    /// <summary>
    /// Gets character reference <c>&amp;xrArr;</c>
    /// representing U+027F9.
    /// </summary>
    Node xrArr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;xrarr;</c>
    /// representing U+027F6.
    /// </summary>
    Node xrarr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Xscr;</c>
    /// representing U+1D4B3.
    /// </summary>
    Node Xscr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;xscr;</c>
    /// representing U+1D4CD.
    /// </summary>
    Node xscr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;xsqcup;</c>
    /// representing U+02A06.
    /// </summary>
    Node xsqcup { get; }

    /// <summary>
    /// Gets character reference <c>&amp;xuplus;</c>
    /// representing U+02A04.
    /// </summary>
    Node xuplus { get; }

    /// <summary>
    /// Gets character reference <c>&amp;xutri;</c>
    /// representing U+025B3.
    /// </summary>
    Node xutri { get; }

    /// <summary>
    /// Gets character reference <c>&amp;xvee;</c>
    /// representing U+022C1.
    /// </summary>
    Node xvee { get; }

    /// <summary>
    /// Gets character reference <c>&amp;xwedge;</c>
    /// representing U+022C0.
    /// </summary>
    Node xwedge { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Yacute;</c>
    /// representing U+000DD.
    /// </summary>
    Node Yacute { get; }

    /// <summary>
    /// Gets character reference <c>&amp;yacute;</c>
    /// representing U+000FD.
    /// </summary>
    Node yacute { get; }

    /// <summary>
    /// Gets character reference <c>&amp;YAcy;</c>
    /// representing U+0042F.
    /// </summary>
    Node YAcy { get; }

    /// <summary>
    /// Gets character reference <c>&amp;yacy;</c>
    /// representing U+0044F.
    /// </summary>
    Node yacy { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Ycirc;</c>
    /// representing U+00176.
    /// </summary>
    Node Ycirc { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ycirc;</c>
    /// representing U+00177.
    /// </summary>
    Node ycirc { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Ycy;</c>
    /// representing U+0042B.
    /// </summary>
    Node Ycy { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ycy;</c>
    /// representing U+0044B.
    /// </summary>
    Node ycy { get; }

    /// <summary>
    /// Gets character reference <c>&amp;yen;</c>
    /// representing U+000A5.
    /// </summary>
    Node yen { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Yfr;</c>
    /// representing U+1D51C.
    /// </summary>
    Node Yfr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;yfr;</c>
    /// representing U+1D536.
    /// </summary>
    Node yfr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;YIcy;</c>
    /// representing U+00407.
    /// </summary>
    Node YIcy { get; }

    /// <summary>
    /// Gets character reference <c>&amp;yicy;</c>
    /// representing U+00457.
    /// </summary>
    Node yicy { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Yopf;</c>
    /// representing U+1D550.
    /// </summary>
    Node Yopf { get; }

    /// <summary>
    /// Gets character reference <c>&amp;yopf;</c>
    /// representing U+1D56A.
    /// </summary>
    Node yopf { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Yscr;</c>
    /// representing U+1D4B4.
    /// </summary>
    Node Yscr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;yscr;</c>
    /// representing U+1D4CE.
    /// </summary>
    Node yscr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;YUcy;</c>
    /// representing U+0042E.
    /// </summary>
    Node YUcy { get; }

    /// <summary>
    /// Gets character reference <c>&amp;yucy;</c>
    /// representing U+0044E.
    /// </summary>
    Node yucy { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Yuml;</c>
    /// representing U+00178.
    /// </summary>
    Node Yuml { get; }

    /// <summary>
    /// Gets character reference <c>&amp;yuml;</c>
    /// representing U+000FF.
    /// </summary>
    Node yuml { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Zacute;</c>
    /// representing U+00179.
    /// </summary>
    Node Zacute { get; }

    /// <summary>
    /// Gets character reference <c>&amp;zacute;</c>
    /// representing U+0017A.
    /// </summary>
    Node zacute { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Zcaron;</c>
    /// representing U+0017D.
    /// </summary>
    Node Zcaron { get; }

    /// <summary>
    /// Gets character reference <c>&amp;zcaron;</c>
    /// representing U+0017E.
    /// </summary>
    Node zcaron { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Zcy;</c>
    /// representing U+00417.
    /// </summary>
    Node Zcy { get; }

    /// <summary>
    /// Gets character reference <c>&amp;zcy;</c>
    /// representing U+00437.
    /// </summary>
    Node zcy { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Zdot;</c>
    /// representing U+0017B.
    /// </summary>
    Node Zdot { get; }

    /// <summary>
    /// Gets character reference <c>&amp;zdot;</c>
    /// representing U+0017C.
    /// </summary>
    Node zdot { get; }

    /// <summary>
    /// Gets character reference <c>&amp;zeetrf;</c>
    /// representing U+02128.
    /// </summary>
    Node zeetrf { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ZeroWidthSpace;</c>
    /// representing U+0200B.
    /// </summary>
    Node ZeroWidthSpace { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Zeta;</c>
    /// representing U+00396.
    /// </summary>
    Node Zeta { get; }

    /// <summary>
    /// Gets character reference <c>&amp;zeta;</c>
    /// representing U+003B6.
    /// </summary>
    Node zeta { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Zfr;</c>
    /// representing U+02128.
    /// </summary>
    Node Zfr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;zfr;</c>
    /// representing U+1D537.
    /// </summary>
    Node zfr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;ZHcy;</c>
    /// representing U+00416.
    /// </summary>
    Node ZHcy { get; }

    /// <summary>
    /// Gets character reference <c>&amp;zhcy;</c>
    /// representing U+00436.
    /// </summary>
    Node zhcy { get; }

    /// <summary>
    /// Gets character reference <c>&amp;zigrarr;</c>
    /// representing U+021DD.
    /// </summary>
    Node zigrarr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Zopf;</c>
    /// representing U+02124.
    /// </summary>
    Node Zopf { get; }

    /// <summary>
    /// Gets character reference <c>&amp;zopf;</c>
    /// representing U+1D56B.
    /// </summary>
    Node zopf { get; }

    /// <summary>
    /// Gets character reference <c>&amp;Zscr;</c>
    /// representing U+1D4B5.
    /// </summary>
    Node Zscr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;zscr;</c>
    /// representing U+1D4CF.
    /// </summary>
    Node zscr { get; }

    /// <summary>
    /// Gets character reference <c>&amp;zwj;</c>
    /// representing U+0200D.
    /// </summary>
    Node zwj { get; }

    /// <summary>
    /// Gets character reference <c>&amp;zwnj;</c>
    /// representing U+0200C.
    /// </summary>
    Node zwnj { get; }
}
