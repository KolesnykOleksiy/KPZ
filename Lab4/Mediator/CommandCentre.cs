namespace Mediator;

public class CommandCentre
{
        private List<Runway> _runways = new List<Runway>();

        public void RegisterRunway(Runway runway)
        {
            _runways.Add(runway);
        }

        public void RequestLanding(Aircraft aircraft)
        {
            foreach (var runway in _runways)
            {
                if (!runway.IsBusy)
                {
                    Console.WriteLine($"Aircraft {aircraft.Name} has landed on runway {runway.Id}.");
                    runway.IsBusy = true;
                    runway.HighLightRed();
                    return;
                }
            }
            Console.WriteLine($"Could not land Aircraft {aircraft.Name}, all runways are busy."); //or I can return smth for aircraft
        }

        public void ReleaseRunway(Aircraft aircraft)
        {
            foreach (var runway in _runways)
            {
                if (runway.IsBusy)
                {
                    runway.IsBusy = false;
                    runway.HighLightGreen();
                    return;
                }
            }
        }
}