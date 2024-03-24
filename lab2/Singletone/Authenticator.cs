namespace Singletone;

sealed class Authenticator
{
    private static Authenticator? _instanceAuthenticator;
    private static object _refObj = new object();
    private string _someString = "test info";

    private Authenticator()
    {
        Console.WriteLine("Authentification");
    }

    public static Authenticator GetAuthenticator()
    {
        if (Authenticator._instanceAuthenticator == null)
        {
            lock (Authenticator._refObj)
            {
                if (Authenticator._instanceAuthenticator == null)
                {
                    Authenticator._instanceAuthenticator = new Authenticator();
                }
            }
        }

        return Authenticator._instanceAuthenticator;
    }

    public void ShowInput()
    {
        Console.WriteLine(_someString);
    }
}