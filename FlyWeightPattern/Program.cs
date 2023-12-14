using System;
using System.Collections.Generic;

namespace FlyWeight
{
	class Program
	{
		static void AddSpecialistDatabase(FlyweightFactory ff, string company, string position, string name, string passport)
		{
			Console.WriteLine();
			Flyweight flyweight = ff.GetFlyweight(new Shared(company, position));
			flyweight.Process(new UNIQUE(name, passport));
		}

		static void Main(string[] args)
		{
			FlyweightFactory factory = new FlyweightFactory(new List<Shared>()
			{
				new Shared("Microsoft","-Управляющий"),
				new Shared("Google","Android-разработчики"),
				new Shared("Google","Web-разработчики"),
				new Shared("Apple","Iphone-разработчики"),
			});
			factory.ListFlyweights();

			AddSpecialistDatabase(factory,
				"Google",
				"Web-разработчики",
				"Али",
				"АМ-321234445");
			AddSpecialistDatabase(factory,
				"Apple",
				"Разработчики",
				"Ахмед",
				"БМ-7623712537");

			factory.ListFlyweights();
		}
	}
}
