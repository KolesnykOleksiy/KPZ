namespace Decorator;

public class Palladin: ICharacter
{
    public void ShowInfo()
    {
        Console.WriteLine("I am Palladin");
    }

    public string Dress()
    {
        return "I have: ";
    }
}