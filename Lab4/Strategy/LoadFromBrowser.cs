namespace Strategy;

public class LoadFromBrowser: IStrategy
{
    public void LoadImage(string href)
    {
        Console.WriteLine($"Load image from browser by link {href}");
    }
}