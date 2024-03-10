namespace Diya;

public class ActionDocument :IDocument, IActionUser
{
    private IDocument _document;
    private int _info;

    public ActionDocument(IDocument document, int info)
    {
        _document = document;
        _info = info;
    }

    public void ShowName() => _document.ShowName();
    public void ShowPhoto() => _document.ShowPhoto();

    public void DoAction(IDocumentAction action) => action.Action(_info);
}