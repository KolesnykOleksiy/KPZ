namespace Memento;

public class TextEditor
{
    private TextDocument document;
    private List<Memento> mementos = new List<Memento>();

    public TextEditor(string content)
    {
        document = new TextDocument(content);
    }

    public string GetContent()
    {
        return document.GetContent();
    }

    public void SetContent(string content)
    {
        document.SetContent(content);
    }

    public void Save()
    {
        mementos.Add(document.CreateMemento());
    }

    public void Undo()
    {
        if (mementos.Count > 0)
        {
            Memento memento = mementos[mementos.Count - 1];
            mementos.RemoveAt(mementos.Count - 1);
            document.RestoreMemento(memento);
        }
        else
        {
            Console.WriteLine("No to undo.");
        }
    }

}