// See https://aka.ms/new-console-template for more information

using Singletone;

Authenticator a1 = Authenticator.GetAuthenticator();
Authenticator a2 = Authenticator.GetAuthenticator();
a1.ShowInput();
a2.ShowInput(); // we have access to existing object 