#pragma warning disable SA1118

namespace Maroontress.Html.Test
{
    using System;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public sealed class BasicTest
    {
        [TestMethod]
        public void ToStringWithoutFormat()
        {
            var html = GetExample();

            Assert.AreEqual(
                "<html>"
                + "<head><title>Title</title></head>"
                + "<body><p class=\"a b\">It works!</p>"
                + "<p id=\"c\">Hello<wbr>World</p>"
                + "<img src=\"d.png\"></body>"
                + "</html>",
                html.ToString());
        }

        [TestMethod]
        public void ToStringWithFormat()
        {
            var html = GetExample();
            var result = html.ToString(new FormatOptions());
            var lines = new[]
            {
                "<html>",
                "  <head>",
                "    <title>Title</title>",
                "  </head>",
                "  <body>",
                "    <p class=\"a b\">It works!</p>",
                "    <p id=\"c\">Hello<wbr>World</p>",
                "    <img src=\"d.png\">",
                "  </body>",
                "</html>",
                "",
            };
            var expected = string.Join(Environment.NewLine, lines);

            Assert.AreEqual(expected, result);
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
                    nodeOf.Text("ghi")));
            var result = html.ToString(new FormatOptions());
            var lines = new[]
            {
                "<html>",
                "  <body>",
                "    abc<u>def</u>ghi",
                "    <p>abc<u>def</u>ghi</p>",
                "    <div>",
                "      <p>abc<u>def</u>ghi</p>",
                "    </div>",
                "    <b>abc</b><u>def</u>ghi",
                "  </body>",
                "</html>",
                "",
            };
            var expected = string.Join(Environment.NewLine, lines);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void EscapeTest()
        {
            var nodeOf = Nodes.NewFactory();
            var text = nodeOf.P.AddAttributes(("foo", "<\"&>"))
                .Add("<\"&>");

            var result = text.ToString();

            Assert.AreEqual(
                "<p foo=\"&lt;&quot;&amp;&gt;\">&lt;\"&amp;&gt;</p>",
                result);
        }

        [TestMethod]
        public void NodeFactory()
        {
            var nodeOf = Nodes.NewFactory();
            Assert.ThrowsException<ArgumentException>(
                () => nodeOf.EmptyTag(""));
            Assert.ThrowsException<ArgumentException>(
                () => nodeOf.EmptyTag("-"));
        }

        [TestMethod]
        public void CustomEmptyTag()
        {
            var nodeOf = Nodes.NewFactory();
            var custom = nodeOf.EmptyTag("custom");
            Check(
                custom.AddAttributes(("name", "value")),
                "<custom name=\"value\">");
            Check(
                custom.WithClass("a", "b"),
                "<custom class=\"a b\">");
            Check(
                custom.WithClass("a", "b").AddClass("c", "d"),
                "<custom class=\"a b c d\">");
            Check(
                custom.WithId("e"),
                "<custom id=\"e\">");
            Check(
                custom.AddAttributes(("name1", null), ("name2", null)),
                "<custom name1 name2>");
            Check(
                custom.AddEmptyAttributes("name1", "name2"),
                "<custom name1 name2>");
            Check(
                custom.AddAttributes(
                    ("UPPER1", "LOWER1"),
                    ("UPPER2", null)),
                "<custom upper1=\"LOWER1\" upper2>");
            Check(
                custom.AddAttributes(
                    ("name1", "1"),
                    ("name2", null),
                    ("name3", "3"),
                    ("name4", null),
                    ("name5", "5")),
                "<custom name1=\"1\" name2 name3=\"3\" name4 name5=\"5\">");
            CommonAttributeTest(custom);
        }

        [TestMethod]
        public void CustomTag()
        {
            var nodeOf = Nodes.NewFactory();
            var custom = nodeOf.Tag("custom");
            var children = new Node[] { nodeOf.P, nodeOf.Br, }
                as IEnumerable<Node>;
            Check(
                custom.Add(children),
                "<custom><p></p><br></custom>");
            Check(
                custom.Add(nodeOf.P, nodeOf.Br),
                "<custom><p></p><br></custom>");
            Check(
                custom.Add("text"),
                "<custom>text</custom>");
            Check(
                custom.AddAttributes(("name", "value")),
                "<custom name=\"value\"></custom>");
            Check(
                custom.WithClass("a", "b"),
                "<custom class=\"a b\"></custom>");
            Check(
                custom.WithClass("a", "b").AddClass("c", "d"),
                "<custom class=\"a b c d\"></custom>");
            Check(
                custom.WithId("e"),
                "<custom id=\"e\"></custom>");
            Check(
                custom.AddAttributes(("name1", null), ("name2", null)),
                "<custom name1 name2></custom>");
            Check(
                custom.AddEmptyAttributes("name1", "name2"),
                "<custom name1 name2></custom>");
            Check(
                custom.AddAttributes(
                    ("UPPER1", "LOWER1"),
                    ("UPPER2", null)),
                "<custom upper1=\"LOWER1\" upper2></custom>");
            Check(
                custom
                    .AddAttributes(
                        ("name1", "1"),
                        ("name2", null))
                    .AddAttributes(
                        ("name3", "3"),
                        ("name4", null),
                        ("name5", "5")),
                "<custom name1=\"1\" name2 name3=\"3\" name4 name5=\"5\">"
                + "</custom>");
            CommonAttributeTest(custom);
        }

        [TestMethod]
        public void Name()
        {
            var nodeOf = Nodes.NewFactory();
            Assert.AreEqual("p", nodeOf.P.Name);
            Assert.AreEqual("br", nodeOf.Br.Name);
        }

        [TestMethod]
        public void Kind()
        {
            var nodeOf = Nodes.NewFactory();
            Assert.AreEqual(NodeKind.Text, nodeOf.Text("").Kind);
            Assert.AreEqual(NodeKind.EmptyTag, nodeOf.Br.Kind);
            Assert.AreEqual(NodeKind.Tag, nodeOf.P.Kind);
            Assert.AreEqual(
                NodeKind.CharacterReference,
                nodeOf.Entity.amp.Kind);
        }

        [TestMethod]
        public void CharacterReference()
        {
            var nodeOf = Nodes.NewFactory();
            var span = nodeOf.Span.Add(
                nodeOf.Entity.copy,
                nodeOf.Text("2019"),
                nodeOf.CharacterReference(0x1234));
            Check(span, "<span>&copy;2019&#x1234;</span>");
        }

        private static void CommonAttributeTest<T>(T custom)
            where T : BaseTag<T>
        {
            Assert.ThrowsException<ArgumentException>(
                () => custom.AddAttributes(("", "")));
            Assert.ThrowsException<ArgumentException>(
                () => custom.AddAttributes(("na me", "")));
            Assert.ThrowsException<ArgumentException>(
                () => custom.AddAttributes(("id", "a")));
            Assert.ThrowsException<ArgumentException>(
                () => custom.AddAttributes(("class", "a")));
            Assert.ThrowsException<ArgumentException>(
                () => custom.AddAttributes(("a", "b"))
                    .AddAttributes(("a", "c")));
            Assert.ThrowsException<ArgumentException>(
                () => custom.AddAttributes(("a", "b"), ("a", "c")));

            Assert.ThrowsException<ArgumentException>(
                () => custom.WithId(""));
            Assert.ThrowsException<ArgumentException>(
                () => custom.WithId("a b"));

            Assert.ThrowsException<ArgumentException>(
                () => custom.WithClass(""));
            Assert.ThrowsException<ArgumentException>(
                () => custom.WithClass("a b"));
        }

        private static void Check(Node node, string expected)
        {
            Assert.AreEqual(expected, node.ToString());
        }

        private static Node GetExample()
        {
            var nodeOf = Nodes.NewFactory();
            return nodeOf.Html.Add(
                nodeOf.Head.Add(
                    nodeOf.Title.Add("Title")),
                nodeOf.Body.Add(
                    nodeOf.P.WithClass("a", "b")
                        .Add("It works!"),
                    nodeOf.P.WithId("c").Add(
                        nodeOf.Text("Hello"),
                        nodeOf.Wbr,
                        nodeOf.Text("World")),
                    nodeOf.Img.AddAttributes(("src", "d.png"))));
        }
    }
}
