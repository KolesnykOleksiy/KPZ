namespace CoR;

class SlowInternetConnectionHandler: BaseHandler
{
    public override void Handle(int arg)
    {
        if (arg == 2)
        {
            Console.WriteLine("Try to reboot router");
        }
        else
        {
            base.Handle(arg);
        }
    }
}