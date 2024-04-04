// See https://aka.ms/new-console-template for more information

using Composite;

static List<ILightNode> CreateLightHTML(string text)
{
    var lines = text.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);
    var result = new List<ILightNode>();

    var isFirstLine = true;

    foreach (var line in lines)
    {
        if (string.IsNullOrWhiteSpace(line))
            continue;

        var elementTagName = "p";
        if (isFirstLine)
        {
            elementTagName = "h1";
            isFirstLine = false;
        }
        else if (line.Trim().Length < 20)
        {
            elementTagName = "h2";
        }
        else if (line.StartsWith(" "))
        {
            elementTagName = "blockquote";
        }

        result.Add(new LightElementNode(elementTagName, "block", "double", new List<string>(), new List<ILightNode> { new LightTextNode(line) }));
    }

    return result;
}

 static void Lightweight()
{
    var text = File.ReadAllText(@"C:\University\2Semestr\MYkpz\LAb3\LightWeight\book.txt");
    var lightHTMLTree = CreateLightHTML(text);

   
    Console.WriteLine(string.Join("", lightHTMLTree.Select(node => node.OuterHTML())));
   
}

Lightweight();
