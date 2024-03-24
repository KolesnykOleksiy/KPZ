using AbstractFactory.Devices;

namespace AbstractFactory.IProneDevices;

public class iProneNetbook : INetbook
{
    public void ShowNetbookCharacteristics()
    {
        Console.WriteLine("Netbook brand: IProne");
    }
}