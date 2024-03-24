using AbstractFactory.BalaxyDevices;
using AbstractFactory.Devices;
using AbstractFactory.KiaomiDevices;

namespace AbstractFactory.Factories;

public class BalaxyFactory : IDeviceFactory
{
    public IEBook CreateEBook()
    {
        IEBook ebook = new BalaxyEBook();
        return ebook;
    }
    public ILaptop CreateLaptop()
    {
        ILaptop laptop = new BalaxyLaptop();
        return laptop;
    }
    public INetbook CreateNetbook()
    {
        INetbook netbook = new BalaxyNetbook();
        return netbook;

    }
    public ISmartphone CreateSmartphone()
    {
        ISmartphone smartphone = new BalaxySmartphone();
        return smartphone;

    }
}