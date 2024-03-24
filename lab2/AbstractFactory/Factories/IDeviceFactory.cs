using AbstractFactory.Devices;

namespace AbstractFactory.Factories;


public interface IDeviceFactory
{
    public IEBook CreateEBook();
    public ILaptop CreateLaptop();
    public INetbook CreateNetbook();
    public ISmartphone CreateSmartphone();
}