// See https://aka.ms/new-console-template for more information

using AbstractFactory.Factories;

IDeviceFactory  iprone = new iProneFactory();
var mackbook = iprone.CreateLaptop();
var ebook = iprone.CreateEBook();
ebook.ShowEBookCharacteristics();
mackbook.ShowLaptopCharacteristics();

IDeviceFactory kiaomi = new KiaomiFactory();
var netbook = kiaomi.CreateNetbook();
netbook.ShowNetbookCharacteristics();

IDeviceFactory balaxy = new BalaxyFactory();
var smartphone = balaxy.CreateSmartphone();
smartphone.ShowSmartphoneCharacteristics();