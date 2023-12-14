using System;

namespace FlyWeight
{
	public class Flyweight
	{
		private Shared shared;

		public Flyweight(Shared shared) => this.shared = shared;

		public void Process(UNIQUE unique)
		{
			Console.WriteLine("Отображаем новые данные: общее - " + shared.Company + "-" + shared.Position + " и уникальное - " + unique.Name + "-" + unique.passport);
		}

		public string Getdata() => shared.Company + "_" + shared.Position;
	}
}
