using AbstractFactory.KiaomiDevices;

namespace AbstractFactory.Factories;
using AbstractFactory.Devices;

public class KiaomiFactory: IDeviceFactory
{
    public IEBook CreateEBook()
    {
        IEBook ebook = new KiaomiEBook();
        return ebook;
    }
    public ILaptop CreateLaptop()
    {
        ILaptop laptop = new KiaomiLaptop();
        return laptop;
    }
    public INetbook CreateNetbook()
    {
        INetbook netbook = new KiaomiNetbook();
        return netbook;

    }
    public ISmartphone CreateSmartphone()
    {
        ISmartphone smartphone = new KiaomiSmartphone();
        return smartphone;

    }
}
