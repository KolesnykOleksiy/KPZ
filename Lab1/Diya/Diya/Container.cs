namespace Diya;

public class Container
{
    private IEnumerable<IDocument> _documents;

    public Container(IEnumerable<IDocument> documents)
    {
        _documents = documents;
    }

    public void SortDocuments()
    {
        Console.WriteLine("sort by 1 parametr");
    }
    public void CustomSortDocuments()
    {
        Console.WriteLine("sort by another parametr");
    }

    public void ShowDocumentsInfo()
    {
        foreach (var document in _documents)
        {
            document.ShowName();
            document.ShowPhoto();
        }
    }
}