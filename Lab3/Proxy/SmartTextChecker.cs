namespace Proxy;

public class SmartTextChecker : ITextRider
{
    private readonly ITextRider _textReader;

    public SmartTextChecker(ITextRider textReader)
    {
        _textReader = textReader;
    }
    
    public char[,] ReadTextFileAndSplit(string filePath)
    {
        
        char[,] result = _textReader.ReadTextFileAndSplit(filePath);
        
        if (result != null)
        {
            int lines = result.GetLength(0);
            int characters = result.GetLength(1);

            Console.WriteLine($"File {filePath} successfully read.");
            Console.WriteLine($": count of lines {lines}");
            Console.WriteLine($"count of symbols: {characters}");
        }
        else
        {
            Console.WriteLine($" An error occurred while reading the file {filePath}");
        }

        Console.WriteLine($"Closing the file: {filePath}");
        
        return result;
    }
}