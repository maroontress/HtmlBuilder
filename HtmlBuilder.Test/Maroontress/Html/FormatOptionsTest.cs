namespace Maroontress.Html.Test;

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public sealed class FormatOptionsTest
{
    [TestMethod]
    public void NegativeIndentWith()
    {
        Assert.ThrowsException<ArgumentException>(
            () => new FormatOptions(-1));
    }

    [TestMethod]
    public void IndentWithIsGreaterThan8()
    {
        Assert.ThrowsException<ArgumentException>(
            () => new FormatOptions(9));
    }

    [TestMethod]
    public void TextIndent()
    {
        var nodeOf = Nodes.NewFactory();
        var html = nodeOf.Html.Add(
            nodeOf.Body.Add(
                nodeOf.Text("abc"),
                nodeOf.U.Add("def"),
                nodeOf.Text("ghi"),
                nodeOf.P.Add(
                    nodeOf.Text("abc"),
                    nodeOf.U.Add("def"),
                    nodeOf.Text("ghi")),
                nodeOf.Div.Add(
                    nodeOf.P.Add(
                        nodeOf.Text("abc"),
                        nodeOf.U.Add("def"),
                        nodeOf.Text("ghi"))),
                nodeOf.B.Add("abc"),
                nodeOf.U.Add("def"),
                nodeOf.Text("ghi"),
                nodeOf.P.Add(
                    nodeOf.Div.Add("abc")),
                nodeOf.P.Add(
                    nodeOf.P.Add("abc"))));
        var result = html.ToString(new FormatOptions(4, "\n"));
        var lines = new[]
        {
            "<html>",
            "    <body>",
            "        abc<u>def</u>ghi",
            "        <p>abc<u>def</u>ghi</p>",
            "        <div>",
            "            <p>abc<u>def</u>ghi</p>",
            "        </div>",
            "        <b>abc</b><u>def</u>ghi",
            "        <p><div>abc</div></p>",
            "        <p><p>abc</p></p>",
            "    </body>",
            "</html>",
            "",
        };
        var expected = string.Join("\n", lines);

        Assert.AreEqual(expected, result);
    }
}
