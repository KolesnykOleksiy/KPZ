using Observer;

namespace Composite;

public class LightTextNode: ILightNode
{
    private string Text { get; }

    public LightTextNode(string text)
    {
        Text = text;
    }

    public string InnerHTML()
    {
        return Text;
    }

    public string OuterHTML()
    {
        return Text;
    }
}