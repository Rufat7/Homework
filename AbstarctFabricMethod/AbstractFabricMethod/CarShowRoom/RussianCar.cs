using System;
using FabricMethod.FabricMethod.Interfaces;

namespace FabricMethod.FabricMethod.Cars
{
	class RussianCar : ICar
	{
		public void ReleaseCar(IEngine engine)
		{
			Console.Write("Собрали Российский автомобиль: ");
			engine.ReleaseEngine();
		}
	}
}
