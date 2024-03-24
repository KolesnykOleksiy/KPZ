namespace Builder;

public class HeroDirector
{
    private readonly IBuilder _builder;

    public HeroDirector(IBuilder builder)
    {
        _builder = builder;
    }

    public void Build()
    {
        _builder.BuildHead().BuildBody().BuildFeets().DoAction();
    }
}