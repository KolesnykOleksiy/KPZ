namespace Diya;

public class Document :IDocument
{
    private string _name;
    private string _photo;

    public Document(string name, string photo)
    {
        _name = name;
        _photo = photo;
    }

    public void ShowName()
    {
        Console.WriteLine($"name {_name}");
    }
    public void ShowPhoto()
    {
        Console.WriteLine($"photo: {_photo}");
    }
}