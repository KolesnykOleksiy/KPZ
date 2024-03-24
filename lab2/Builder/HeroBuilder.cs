using System.Collections.Immutable;
using Builder.Heroes;

namespace Builder;


public class HeroBuilder : IBuilder
{
    private Hero _hero;

    public HeroBuilder()
    {
        _hero = new();
    }

    public IBuilder BuildHead()
    {
        _hero.Head = "White helmet with feathers \n";
        return this;
    }

    public IBuilder BuildBody()
    {
       _hero.Body =  "Gold armor \n Gold sword \n";
       return this;

    }

    public IBuilder BuildFeets()
    {
        _hero.Feets = "Flying shoe \n";
        return this;

    }
    
    public IBuilder DoAction()
    {
        DoGood();
        return this;

    }
    
    public void DoGood()
    {
        _hero.Do = "save the princess \n";
    }

    public IPersonage GetHero()
    {
        Hero hero = _hero;
        _hero = new();
        return hero;
    }
}