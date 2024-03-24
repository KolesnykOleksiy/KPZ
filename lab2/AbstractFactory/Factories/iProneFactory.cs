using AbstractFactory.Devices;
using AbstractFactory.IProneDevices;

namespace AbstractFactory.Factories;

public class iProneFactory : IDeviceFactory
{
    public IEBook CreateEBook()
    {
        IEBook ebook = new iProneEBook();
        return ebook;
    }
    public ILaptop CreateLaptop()
    {
        ILaptop macbook = new iProneLaptop();
        return macbook;
    }
    public INetbook CreateNetbook()
    {
        INetbook netbook = new iProneNetbook();
        return netbook;

    }
    public ISmartphone CreateSmartphone()
    {
        ISmartphone iphone = new iProneSmartphone();
        return iphone;

    }
}