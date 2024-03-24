using AbstractFactory.Devices;

namespace AbstractFactory.IProneDevices;

public class iProneEBook :IEBook
{
    public void ShowEBookCharacteristics()
    {
        Console.WriteLine("Ebook brand: Iprone");
    }
}