namespace Strategy;

public class Context
{
    private IStrategy _strategy;

    public Context(IStrategy strategy)        // I set concrete strategy in ctor
    {
        _strategy = strategy;
    }

    public void LoadImage(string href)
    {
        _strategy.LoadImage(href);
    }
}