using System;
using FabricMethod.FabricMethod.Interfaces;

namespace FabricMethod.FabricMethod.Cars
{
	class GermanCar : ICar
	{
		public void ReleaseCar(IEngine engine)
		{
			Console.Write("Собрали Немецкий автомобиль: ");
			engine.ReleaseEngine();
		}
	}
}