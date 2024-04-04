// See https://aka.ms/new-console-template for more information

using Adapter;

ILogger consoleLogger = new Logger();
consoleLogger.Log("Success");

ILogger fileLogger = new Adapter(new FileWriter());
fileLogger.Error("Fatal Error!!!");