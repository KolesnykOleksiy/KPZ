using AbstractFactory.Devices;

namespace AbstractFactory.KiaomiDevices;

public class KiaomiSmartphone : ISmartphone
{
    public void ShowSmartphoneCharacteristics()
    {
        Console.WriteLine("smartphone brand: Kiaomi");
    }
}