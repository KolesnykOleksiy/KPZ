using AbstractFactory.Devices;

namespace AbstractFactory.IProneDevices;

public class iProneSmartphone : ISmartphone
{
    public void ShowSmartphoneCharacteristics()
    {
        Console.WriteLine("IProne PineApple 10");
    }
}