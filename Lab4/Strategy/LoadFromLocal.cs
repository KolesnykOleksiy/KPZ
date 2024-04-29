namespace Strategy;

public class LoadFromLocal : IStrategy
{
    public void LoadImage(string path)
    {
        Console.WriteLine($"Load image from file system {path}");
    }
}