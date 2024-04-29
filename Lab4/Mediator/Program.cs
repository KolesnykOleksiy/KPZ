// See https://aka.ms/new-console-template for more information

using Mediator;

Runway[] runways = { new Runway(), new Runway() };
CommandCentre mediator = new CommandCentre();
foreach (var runway in runways)
{
    mediator.RegisterRunway(runway);
}

Aircraft aircraft1 = new Aircraft("Aircraft 1", mediator);
Aircraft aircraft2 = new Aircraft("Aircraft 2", mediator);

aircraft1.Land();
aircraft2.Land();

aircraft1.TakeOff();