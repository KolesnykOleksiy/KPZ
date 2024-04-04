namespace Proxy;

public class SmartTextReader : ITextRider
{
    public char[,] ReadTextFileAndSplit(string filePath)
    {
        if (!File.Exists(filePath))
        {
            Console.WriteLine("File not exist.");
            return null;
        }

        try
        {
            string[] lines = ReadAllLinesFromFile(filePath);
            char[,] charArray = SplitLinesIntoCharArray(lines);
            return charArray;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            return null;
        }
    }

    private string[] ReadAllLinesFromFile(string filePath)
    {
        return File.ReadAllLines(filePath);
    }

    private char[,] SplitLinesIntoCharArray(string[] lines)
    {
        int maxLength = GetMaxLength(lines);
        
        char[,] charArray = new char[lines.Length, maxLength];
        
        for (int i = 0; i < lines.Length; i++)
        {
            for (int j = 0; j < lines[i].Length; j++)
            {
                charArray[i, j] = lines[i][j];
            }
        }

        return charArray;
    }
    private int GetMaxLength(string[] lines)
    {
        int maxLength = 0;
        
        foreach (string line in lines)
        {
            if (line.Length > maxLength)
            {
                maxLength = line.Length;
            }
        }

        return maxLength;
    }
}