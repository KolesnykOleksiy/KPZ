namespace Builder;
using Builder.Heroes;

public class EnemyBuilder: IBuilder
{
    private Enemy _enemy;

    public EnemyBuilder()
    {
        _enemy = new();
    }

    public IBuilder BuildHead()
    {
        _enemy.Head = "Red helmet with horns \n";
        return this;
    }

    public IBuilder BuildBody()
    {
        _enemy.Body =  "Black armor \n Flaming sword \n ";
        return this;
    }

    public IBuilder BuildFeets()
    {
        _enemy.Feets = "Hooves \n ";
        return this;
    }

    public IBuilder DoAction()
    {
        DoBad();
        return this;
    }
    public void DoBad()
    {
        Console.WriteLine("Steal the princess");
    }

    public IPersonage GetHero()
    {
        Enemy enemy =  _enemy;
        _enemy = new();
        return enemy;
    }
}
