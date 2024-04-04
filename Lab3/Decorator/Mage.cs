namespace Decorator;

public class Mage: ICharacter
{
    public void ShowInfo()
    {
        Console.WriteLine("I am Mage");
    }

    public string Dress()
    {
        return "I have: ";
    }
}