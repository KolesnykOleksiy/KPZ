namespace CoR;

class NoInternetConnectionHandler : BaseHandler
{
    public override void Handle(int arg)
    {
        if (arg == 1)
        {
            Console.WriteLine("we will send you the master within two days");
        }
        else
        {
            base.Handle(arg);
        }
    }
}