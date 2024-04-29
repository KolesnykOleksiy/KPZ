// See https://aka.ms/new-console-template for more information

using CoR;using DefaultNamespace;

var noInternetHandler = new NoInternetConnectionHandler();
var slowInternetHandler = new SlowInternetConnectionHandler();
var brokenWireHandler = new BrokenWireHandler();
var operatorH = new OperatorHandler();
noInternetHandler.SetNext(slowInternetHandler).SetNext(brokenWireHandler).SetNext(operatorH);

int input;
bool handled = false;

do
{
    Console.WriteLine("Enter a number (1, 2, 3, or 4) with your problem:");
    Console.WriteLine("1 - no internet connection");
    Console.WriteLine("2 - slow internet connection");
    Console.WriteLine("3 - you see a broken cable ");
    Console.WriteLine("4 - none of the proposed, call operator");

    if (int.TryParse(Console.ReadLine(), out input))
    {
        if (input >= 1 && input <= 4) // because I use Handle method as void
        {
            noInternetHandler.Handle(input);
            handled = true;
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number.");
        }
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a valid number.");
    }
} while (!handled);


