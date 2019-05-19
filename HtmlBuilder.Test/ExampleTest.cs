namespace Maroontress.Html.Test
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public sealed class ExampleTest
    {
        [TestMethod]
        public void MyFirstWebPage()
        {
            var nodeOf = Nodes.NewFactory();
            var html = nodeOf.Html.Add(
                nodeOf.Head.Add(
                    nodeOf.Title.Add("My first web page")),
                nodeOf.Body.Add(
                    nodeOf.P.Add("Hello, World!")));
            var result = html.ToString();
            Assert.AreEqual(
                "<html><head><title>My first web page</title></head>"
                + "<body><p>Hello, World!</p></body></html>",
                result);
        }

        [TestMethod]
        public void AttributeManipulation()
        {
            var nodeOf = Nodes.NewFactory();
            var codeFragment = nodeOf.Pre.AddAttributes(("lang", "csharp"))
                .Add("var list = new List<string>();");
            var result = codeFragment.ToString();

            Assert.AreEqual(
                "<pre lang=\"csharp\">"
                + "var list = new List&lt;string&gt;();"
                + "</pre>",
                result);
        }

        [TestMethod]
        public void EmptyAttribute()
        {
            var nodeOf = Nodes.NewFactory();
            var div = nodeOf.Div
                .Add(nodeOf.Input.AddEmptyAttributes("disabled"))
                .Add(nodeOf.Button.AddAttributes(("disabled", null)));
            var result = div.ToString();

            Assert.AreEqual(
                "<div><input disabled><button disabled></button></div>",
                result);
        }

        [TestMethod]
        public void IdAndClass()
        {
            var nodeOf = Nodes.NewFactory();
            var header = nodeOf.H1.WithId("intro")
                .WithClass("title", "anchor")
                .Add("Introduction");
            var result = header.ToString();

            Assert.AreEqual(
                "<h1 id=\"intro\" class=\"title anchor\">Introduction</h1>",
                result);
        }

        [TestMethod]
        public void PrototypePattern()
        {
            var nodeOf = Nodes.NewFactory();
            var reverseSpan = nodeOf.Span.WithClass("reverse");
            var para = nodeOf.P.Add(
                reverseSpan.Add("reversed text"),
                nodeOf.Text(" means the console output. For example, "),
                reverseSpan.Add("low battery"),
                nodeOf.Text(" and so on."));
            var result = para.ToString();

            Assert.AreEqual(
                "<p><span class=\"reverse\">reversed text</span> means the "
                + "console output. For example, <span class=\"reverse\">low "
                + "battery</span> and so on.</p>",
                result);
        }
    }
}
