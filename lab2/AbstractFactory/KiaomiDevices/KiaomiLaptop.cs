using AbstractFactory.Devices;

namespace AbstractFactory.KiaomiDevices;

public class KiaomiLaptop : ILaptop
{
    public void ShowLaptopCharacteristics()
    {
        Console.WriteLine("Laptop brand: Kiaomi");
    }
}