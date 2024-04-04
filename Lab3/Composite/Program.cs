// See https://aka.ms/new-console-template for more information

using Composite;

List<string> classes = new List<string> { "example-class", "another-class" };

List<ILightNode> children = new List<ILightNode>();
children.Add(new LightTextNode("Text inside block"));


LightElementNode elementNode = new LightElementNode("div", "block", "double", classes, children);

Console.WriteLine("InnerHTML: " + elementNode.InnerHTML());
Console.WriteLine("OuterHTML: " + elementNode.OuterHTML());