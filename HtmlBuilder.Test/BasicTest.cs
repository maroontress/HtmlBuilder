#pragma warning disable CS1591

namespace Maroontress.Html.Test
{
    using System;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public sealed class BasicTest
    {
        [TestMethod]
        public void BasicExample()
        {
            var nodeOf = Nodes.NewFactory();
            var html = nodeOf.Html.Add(
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

            var result = html.ToString();

            Assert.AreEqual(
                "<html>"
                + "<head><title>Title</title></head>"
                + "<body><p class=\"a b\">It works!</p>"
                + "<p id=\"c\">Hello<wbr>World</p>"
                + "<img src=\"d.png\"></body>"
                + "</html>",
                result);
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
            var children = new[] { nodeOf.P, nodeOf.Br, }
                as IEnumerable<Node>;
            Assert.ThrowsException<InvalidOperationException>(
                () => custom.Add(children));
            Assert.ThrowsException<InvalidOperationException>(
                () => custom.Add(nodeOf.P, nodeOf.Br));
            Assert.ThrowsException<InvalidOperationException>(
                () => custom.Add("text"));
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
            CommonAttributeTest(custom);
        }

        [TestMethod]
        public void CustomTag()
        {
            var nodeOf = Nodes.NewFactory();
            var custom = nodeOf.Tag("custom");
            var children = new[] { nodeOf.P, nodeOf.Br, }
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
            CommonAttributeTest(custom);
        }

        [TestMethod]
        public void Name()
        {
            var nodeOf = Nodes.NewFactory();
            Assert.AreEqual("p", nodeOf.P.Name);
            Assert.AreEqual("br", nodeOf.Br.Name);
        }

        private static void CommonAttributeTest(Tag custom)
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
    }
}
