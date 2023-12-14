using System;
using FabricMethod.FabricMethod.Interfaces;

namespace FabricMethod.FabricMethod.Cars
{
	class JapaneseCar : ICar
	{
		public void ReleaseCar(IEngine engine)
		{
			Console.Write("Собрали Японский автомобиль: ");
			engine.ReleaseEngine();
		}
	}
}
