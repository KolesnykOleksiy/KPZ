namespace Memento;

public class Memento
{
    private string content;

    public Memento(string content)
    {
        this.content = content;
    }

    public string GetContent()
    {
        return content;
    }
}