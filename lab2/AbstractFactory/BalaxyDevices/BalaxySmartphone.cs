using AbstractFactory.Devices;

namespace AbstractFactory.BalaxyDevices;

public class BalaxySmartphone : ISmartphone
{
    public void ShowSmartphoneCharacteristics()
    {
        Console.WriteLine("Smartphone brand: Balaxy");
    }
}