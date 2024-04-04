namespace Adapter;

public class Adapter : ILogger
{
    private FileWriter _fileWriter;

    public Adapter(FileWriter fileWriter)
    {
        _fileWriter = fileWriter;
    }

    public void Log(string message)
    {
        Console.WriteLine($"Adapted {_fileWriter.WriteLine(message)} \n");
    }

    public void Error(string message)
    {
        Console.WriteLine($"Adapted {_fileWriter.Write(message)} \n");
    }

    public void Warn(string message)
    {
        Console.WriteLine($"Adapted {_fileWriter.Write(message)} \n");
    }
}