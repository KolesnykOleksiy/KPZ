using AbstractFactory.Devices;

namespace AbstractFactory.BalaxyDevices;

public class BalaxyNetbook : INetbook
{
    public void ShowNetbookCharacteristics()
    {
        Console.WriteLine("NetBook brand: Balaxy");
    }
}