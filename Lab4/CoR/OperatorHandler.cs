using CoR;

namespace DefaultNamespace;

class OperatorHandler: BaseHandler
{
    public override void Handle(int arg)
    {
        if (arg == 4)
        {
            Console.WriteLine("operator will contact you in a few minutes");
        }
        else
        {
            base.Handle(arg);
        }
    }
}