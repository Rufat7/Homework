using System;
using System.Collections;

namespace FlyWeight
{
	public class FlyweightFactory
	{
		private Hashtable flyweights;

		private string Getkey(Shared shared) => shared.Company + "_" + shared.Position;

		public FlyweightFactory(List<Shared> shareds)
		{
			flyweights = new Hashtable();
			foreach (Shared shared in shareds)
				flyweights.Add(Getkey(shared), new Flyweight(shared));
		}

		public Flyweight GetFlyweight(Shared shared)
		{
			string key = Getkey(shared);
			if (!flyweights.ContainsKey(key))
			{
				Console.WriteLine("Фабрика легковесов: Общий объект по ключу " + key + " не найден. Создаем новый.");
				flyweights.Add(key, new Flyweight(shared));
			}
			else
			{
				Console.WriteLine("Фабрика легковесов: Извлекаем данные из имеющихся записей по ключу " + key + ".");
			}
			return (Flyweight)flyweights[key];
		}

		public void ListFlyweights()
		{
			int count = flyweights.Count;
			Console.WriteLine("\nФабрика легковесов: Всего " + count + " Записей:");
			foreach (Flyweight pair in flyweights.Values)
			{
				Console.WriteLine(pair.Getdata());
			}
		}
	}
}
