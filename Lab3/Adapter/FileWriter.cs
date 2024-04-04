using System.Xml;

namespace Adapter;

public class FileWriter
{
    public string Write(string message)
    {
        return $"Write message in file -> {message}";
    }
    public string WriteLine(string message)
    {
        return $"Write message in file from new line -> {message}";
    }
}