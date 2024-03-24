// See https://aka.ms/new-console-template for more information

using Builder;

IBuilder heroBuilder = new HeroBuilder();
var director = new HeroDirector(heroBuilder);

director.Build();
var hero = heroBuilder.GetHero();
Console.WriteLine(hero);

//enemy
IBuilder enemyBuilder = new EnemyBuilder();
var director2 = new HeroDirector(enemyBuilder);
director2.Build();
var enemy = enemyBuilder.GetHero();
Console.WriteLine(enemy);