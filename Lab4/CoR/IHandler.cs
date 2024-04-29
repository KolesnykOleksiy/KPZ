namespace CoR;

public interface IHandler
{
    public void Handle(int arg);
    IHandler SetNext(IHandler handler);
}