using AbstractFactory.Devices;

namespace AbstractFactory.KiaomiDevices;

public class KiaomiNetbook : INetbook
{
    public void ShowNetbookCharacteristics()
    {
        Console.WriteLine("Netbook brand: Kiaomi");
    }
}