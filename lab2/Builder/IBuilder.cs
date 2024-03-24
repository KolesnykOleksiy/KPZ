using Builder.Heroes;

namespace Builder;

public interface IBuilder
{
     IBuilder BuildHead();
     IBuilder BuildBody();
     IBuilder BuildFeets();
     IBuilder DoAction();
    public IPersonage GetHero();
}