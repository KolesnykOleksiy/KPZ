using AbstractFactory.Devices;

namespace AbstractFactory.KiaomiDevices;

public class KiaomiEBook: IEBook
{
    public void ShowEBookCharacteristics()
    {
        Console.WriteLine("Ebook brand: Kiaomi");
    }
}
