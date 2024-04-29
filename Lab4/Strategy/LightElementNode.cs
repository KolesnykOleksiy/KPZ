using Observer;

namespace Composite;

public class LightElementNode: ILightNode
{
    private string TagName { get; }
    private string DisplayType { get; }
    private string ClosingType { get; }
    private List<string> Classes { get; }
    private List<ILightNode> Children { get; }
    private Dictionary<string, List<Action>> EventListeners { get; }

    public LightElementNode(string tagName, string displayType, string closingType, List<string> classes, List<ILightNode> children)
    {
        TagName = tagName;
        DisplayType = displayType;
        ClosingType = closingType;
        Classes = classes;
        Children = children;
        EventListeners = new Dictionary<string, List<Action>>();
    }
    public void AddEventListener(string @event, Action callback)
    {
        if (!EventListeners.ContainsKey(@event))
        {
            EventListeners[@event] = new List<Action>();
        }
        EventListeners[@event].Add(callback);
    }
    public void TriggerEvent(string @event)
    {
        if (EventListeners.ContainsKey(@event))
        {
            foreach (var callback in EventListeners[@event])
            {
                callback();
            }
        }
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