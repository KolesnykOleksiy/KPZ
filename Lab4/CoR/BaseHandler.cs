namespace CoR;

abstract class BaseHandler : IHandler
{
    private IHandler? _next;

    public IHandler SetNext(IHandler next)
    {
        this._next = next;
        return next;
    }

    public virtual void Handle(int arg)
    {
        if (this._next != null)
        {
            this._next.Handle(arg);
        }
       
    }
}