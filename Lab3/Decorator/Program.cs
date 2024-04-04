// See https://aka.ms/new-console-template for more information

using Decorator;
using Decorator.ConcreteDecorators;

ICharacter warrior = new Warrior();
Console.WriteLine($"{warrior.ToString()}");

warrior = new ShieldDecorator(warrior);
warrior = new SwordDecorator(warrior);

Console.WriteLine($"{warrior.Dress()}");

