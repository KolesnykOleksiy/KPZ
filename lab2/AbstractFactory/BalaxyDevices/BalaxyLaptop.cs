using AbstractFactory.Devices;

namespace AbstractFactory.BalaxyDevices;

public class BalaxyLaptop : ILaptop
{
    public void ShowLaptopCharacteristics()
    {
        Console.WriteLine("Laptop brand: Balaxy");
    }
}