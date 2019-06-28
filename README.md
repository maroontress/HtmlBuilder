# HtmlBuilder

HtmlBuilder is a .NET library for building HTML documents.
It depends on .NET Standard 2.0.

## Examples

### Elements

Generate the HTML document with HtmlBuilder as follows:

```html
<html>
  <head>
    <title>My first web page</title>
  </head>
  <body>
    <p>Hello, World!</p>
  </body>
</html>
```

The following code provides the string `result`, which represents
the same HTML document (but it does not contain indentation or line breaks).

```csharp
var nodeOf = Nodes.NewFactory();
var html = nodeOf.Html.Add(
    nodeOf.Head.Add(
        nodeOf.Title.Add("My first web page")),
    nodeOf.Body.Add(
        nodeOf.P.Add("Hello, World!")));
var result = html.ToString();
```

> [See the result in .NET Fiddle](https://dotnetfiddle.net/YpuE8T)

### Attributes

The HTML attributes can be manipulated as follows:

```csharp
var nodeOf = Nodes.NewFactory();
var codeFragment = nodeOf.Pre.AddAttributes(("lang", "csharp"))
    .Add("var list = new List<string>();");
var result = codeFragment.ToString();
```

The string `result` represents as follows:

```html
<pre lang="csharp">var list = new List&lt;string&gt;();</pre>
```

> [See the result in .NET Fiddle](https://dotnetfiddle.net/kScW7Y)


The empty attribute can be generated as follows:

```csharp
var nodeOf = Nodes.NewFactory();
var div = nodeOf.Div
    .Add(nodeOf.Input.AddEmptyAttributes("disabled"))
    // Or, specify null to the value.
    .Add(nodeOf.Button.AddAttributes(("disabled", null)));
var result = div.ToString();
```

The string `result` represents as follows:

```html
<div>
  <input disabled>
  <button disabled></button>
</div>
```

> [See the result in .NET Fiddle](https://dotnetfiddle.net/mi6kIW)

Note that the `id` and `class` attributes are treated specially as follows:

```csharp
var nodeOf = Nodes.NewFactory();
var header = nodeOf.H1.WithId("intro")
    .WithClass("title", "anchor")
    .Add("Introduction");
var result = header.ToString();
```

The string `result` represents as follows:

```html
<h1 id="intro" class="title anchor">Introduction</h1>
```

> [See the result in .NET Fiddle](https://dotnetfiddle.net/KT5GJZ)

`Node` objects are immutable so that the Prototype pattern can be applied
as follows:

```csharp
var nodeOf = Nodes.NewFactory();
var reverseSpan = nodeOf.Span.WithClass("reverse");
var para = nodeOf.P.Add(
    reverseSpan.Add("reversed text"),
    nodeOf.Text(" means the console output. For example, "),
    reverseSpan.Add("low battery"),
    nodeOf.Text(" and so on."));
var result = para.ToString();
```

The string `result` represents as follows:

```html
<p><span class="reverse">reversed text</span> means the console output.
For example, <span class="reverse">low battery</span> and so on.</p>
```

> [See the result in .NET Fiddle](https://dotnetfiddle.net/W3D7AG)

### Character References

To include Character References, use `CharacterReference` method
as follows:

```csharp
var nodeOf = Nodes.NewFactory();
var span = nodeOf.Span.Add(
    nodeOf.CharacterReference(0x1f5fc));
var result = span.ToString();
```

The string `result` represents as follows:

```html
<span>&#x1F5FC;</span>
```

> [See the result in .NET Fiddle](https://dotnetfiddle.net/QF0Jjk)

### Named Character References

To include Named Character References, use `Entity` property as follows:

```csharp
var nodeOf = Nodes.NewFactory();
var span = nodeOf.Span.Add(
    nodeOf.Text("Copyright "),
    nodeOf.Entity.copy,
    nodeOf.Text(" 2019"));
var result = span.ToString();
```

The string `result` represents as follows:

```html
<span>Copyright &copy; 2019</span>
```

> [See the result in .NET Fiddle](https://dotnetfiddle.net/AJFEnI)

## API Reference

- [Maroontress.Html](https://maroontress.github.io/HtmlBuilder/api/latest/html/Maroontress.Html.html) namespace

## How to build

### Requirements to build

- Visual Studio 2019 Version 16.0
  or [.NET Core 2.2 SDK (SDK 2.2.203)][dotnet-core-sdk]

### How to get started

```plaintext
git clone URL
cd HtmlBuilder
dotnet restore
dotnet build
```

### How to get test coverage report with Coverlet

```plaintext
dotnet test -p:CollectCoverage=true -p:CoverletOutputFormat=opencover \
        --no-build HtmlBuilder.Test
dotnet ANYWHERE/reportgenerator.dll \
        --reports:HtmlBuilder.Test/coverage.opencover.xml \
        --targetdir:Coverlet-html
```

[dotnet-core-sdk]:
  https://dotnet.microsoft.com/download/dotnet-core/2.2
