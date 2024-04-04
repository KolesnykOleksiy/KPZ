namespace Decorator;

public abstract class PersonageDecorator: ICharacter
{
    protected ICharacter _character;

    public PersonageDecorator(ICharacter character)
    {
        _character = character;
    }

    abstract public string Dress();
}