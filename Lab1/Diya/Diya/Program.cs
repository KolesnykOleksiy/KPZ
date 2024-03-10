// See https://aka.ms/new-console-template for more information
using Diya;
var passport = new Document("Oleksiy", "photo");
var idCode = new ActionDocument(passport, 123); //створення об'єктів
var driverLicense = new ActionDocument(passport, 20); 
var container = new Container(new IDocument[] { idCode, driverLicense, passport }); //передаємо документи через інтерфейс
container.ShowDocumentsInfo();
driverLicense.DoAction(new DriverLicenseAction()); //виклик методу
idCode.DoAction(new CopyAction());