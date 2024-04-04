namespace Adapter;

public class Logger : ILogger
{
    public void Log(string message)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Message -> {message} \n");
        Console.ResetColor(); 
    }
    public void Error(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Message -> {message} \n");
        Console.ResetColor();
    }
    public void Warn(string message)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"Message -> {message} \n");
        Console.ResetColor();
    }
}