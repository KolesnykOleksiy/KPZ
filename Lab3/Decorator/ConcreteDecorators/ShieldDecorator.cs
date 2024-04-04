namespace Decorator.ConcreteDecorators;

public class ShieldDecorator : PersonageDecorator
{
    public ShieldDecorator(ICharacter character) : base(character)
    {
        _character = character;
    }
    public override string Dress()
    {
        return _character.Dress() + " shield";
    }
   
}