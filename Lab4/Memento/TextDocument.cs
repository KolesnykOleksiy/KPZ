namespace Memento;

public class TextDocument
{
    private string content;

    public TextDocument(string content)
    {
        this.content = content;
    }

    public string GetContent()
    {
        return content;
    }

    public void SetContent(string content)
    {
        this.content = content;
    }

    public Memento CreateMemento()
    {
        return new Memento(content);
    }

    public void RestoreMemento(Memento memento)
    {
        content = memento.GetContent();
    }
}