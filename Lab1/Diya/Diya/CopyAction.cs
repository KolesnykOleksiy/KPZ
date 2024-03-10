namespace Diya;

public class CopyAction : IDocumentAction
{
    public void Action(int info)
    {
        Console.WriteLine($"Copy code {info}"); //(або викликаю тут метод для копіювання)
    }
}