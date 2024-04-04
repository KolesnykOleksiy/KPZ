namespace Composite;

public class LightElementNode: ILightNode
{
    private string TagName { get; }
    private string DisplayType { get; }
    private string ClosingType { get; }
    private List<string> Classes { get; }
    private List<ILightNode> Children { get; }

    public LightElementNode(string tagName, string displayType, string closingType, List<string> classes, List<ILightNode> children)
    {
        TagName = tagName;
        DisplayType = displayType;
        ClosingType = closingType;
        Classes = classes;
        Children = children;
    }

    public string InnerHTML()
    {
         string childrenHtml = string.Join("", Children.Select(child => child.OuterHTML()));
         return childrenHtml;

    }

    public string OuterHTML()
    {
        string classAttr = Classes.Count > 0 ? $" class=\"{string.Join(" ", Classes)}\"" : "";
        string openTag = $"<{TagName}{classAttr}>";
        string closeTag = ClosingType == "double" ? $"</{TagName}>" : "";
        return $"{openTag}{InnerHTML()}{closeTag}";
    }
}