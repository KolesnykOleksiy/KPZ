namespace CoR;

class BrokenWireHandler: BaseHandler
{
    public override void Handle(int arg)
    {
        if (arg == 3)
        {
            Console.WriteLine("we will send you the master during today`s day ");
        }
        else
        {
            base.Handle(arg);
        }
    }
}