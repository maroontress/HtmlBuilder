namespace Maroontress.Html;

using Maroontress.Html.Impl;

/// <summary>
/// Provides <see cref="NodeFactory"/> instances.
/// </summary>
public static class Nodes
{
    /// <summary>
    /// Gets a new <see cref="NodeFactory"/> instance.
    /// </summary>
    /// <returns>
    /// The new <see cref="NodeFactory"/> instance.
    /// </returns>
    public static NodeFactory NewFactory()
        => new NodeFactoryImpl();
}
