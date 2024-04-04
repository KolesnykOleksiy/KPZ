// See https://aka.ms/new-console-template for more information

using Proxy;

ITextRider checker = new SmartTextChecker(new SmartTextReader());
//checker.ReadTextFileAndSplit(@"C:\\University\\2Semestr\\MYkpz\\LAb3\\Proxy\\TextFile.txt");
//checker.ReadTextFileAndSplit("TextFile.txt");

ITextRider locker = new SmartTextReaderLocker(new SmartTextReader(), @"secret$");
locker.ReadTextFileAndSplit(@"C:\University\2Semestr\MYkpz\LAb3\Proxy\Filesecret");