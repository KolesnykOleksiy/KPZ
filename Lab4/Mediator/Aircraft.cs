namespace Mediator;

public class Aircraft
{
    public string Name;
    private CommandCentre _mediator;

    public Aircraft(string name, CommandCentre mediator)
    {
        this.Name = name;
        this._mediator = mediator;
    }

    public void Land()
    {
        Console.WriteLine($"Aircraft {this.Name} is requesting to land.");
        _mediator.RequestLanding(this);
    }

    public void TakeOff()
    {
        Console.WriteLine($"Aircraft {this.Name} is taking off.");
        _mediator.ReleaseRunway(this);
    }
}