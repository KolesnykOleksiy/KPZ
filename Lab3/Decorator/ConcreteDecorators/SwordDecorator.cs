namespace Decorator.ConcreteDecorators;

public class SwordDecorator: PersonageDecorator
{
    public SwordDecorator(ICharacter character) : base(character)
    {
        _character = character;
    }
    public override string Dress()
    {
        return _character.Dress() + " sword";
    }
   
}