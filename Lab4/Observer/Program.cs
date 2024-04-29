// See https://aka.ms/new-console-template for more information

using Composite;
using Observer;

List<string> classes = new List<string> { "example-class", "another-class" };

List<ILightNode> children = new List<ILightNode>();
children.Add(new LightTextNode("Text inside block"));


LightElementNode elementNode = new LightElementNode("div", "block", "double", classes, children);
Action clickHandler = () =>
{
    Console.WriteLine(" Click event was triggered!");
};
Action hoverHandler = () =>
{
    Console.WriteLine(" Hover event was triggered!");
};
elementNode.AddEventListener("click", clickHandler);
elementNode.AddEventListener("hover", hoverHandler);

Console.WriteLine("InnerHTML: " + elementNode.InnerHTML());
Console.WriteLine("OuterHTML: " + elementNode.OuterHTML());
elementNode.TriggerEvent("click");
elementNode.TriggerEvent("hover");
