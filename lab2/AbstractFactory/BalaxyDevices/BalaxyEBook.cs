using AbstractFactory.Devices;

namespace AbstractFactory.BalaxyDevices;

public class BalaxyEBook :IEBook
{
    public void ShowEBookCharacteristics()
    {
        Console.WriteLine("Ebook brand: Balaxy");
    }
}