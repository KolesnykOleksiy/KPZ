using System.Text.RegularExpressions;

namespace Proxy;

public class SmartTextReaderLocker: ITextRider
{
    private readonly ITextRider _textReader;
    private readonly Regex _fileRegex;

    public SmartTextReaderLocker(ITextRider textReader, string fileRegexPattern)
    {
        _textReader = textReader;
        _fileRegex = new Regex(fileRegexPattern);
    }

    public char[,] ReadTextFileAndSplit(string filePath)
    {
        if (_fileRegex.IsMatch(filePath))
        {
            Console.WriteLine("Access denied!");
            return null;
        }
        else
        {
            return _textReader.ReadTextFileAndSplit(filePath);
        }
    }
}