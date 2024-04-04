using System.Threading.Channels;

namespace Decorator;

public class Warrior : ICharacter
{
    public override string ToString()
    {
        return "I am Warrior";
    }

    public string Dress()
    {
        return "I have: ";
    }
}