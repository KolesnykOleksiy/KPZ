using AbstractFactory.Devices;

namespace AbstractFactory.IProneDevices;

public class iProneLaptop : ILaptop
{
    public void ShowLaptopCharacteristics()
    {
        Console.WriteLine("MackBook Air 13 brand: IProne");
    }
}