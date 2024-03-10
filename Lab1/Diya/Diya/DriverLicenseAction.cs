namespace Diya;

public class DriverLicenseAction : IDocumentAction
{
    public void Action(int info)
    {
        Console.WriteLine($"driver's license will need to be renewed through {info} days");
    }
}