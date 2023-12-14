using System;
using FabricMethod.FabricMethod.Interfaces;
using FabricMethod.FabricMethod.Engines;
using FabricMethod.FabricMethod.Cars;

namespace FabricMethod.FabricMethod
{
	class Program
	{
		static void Main(string[] args)
		{

			IFactory japaneseFactory = new JapaneseFactory();
			IEngine japaneseEngine = japaneseFactory.createEngine();
			ICar japaneseCar = japaneseFactory.createCar();


			japaneseCar.ReleaseCar(japaneseEngine);

		
			IFactory russianFactory = new RussianFactory();
			IEngine russianEngine = russianFactory.createEngine();
			ICar russianCar = russianFactory.createCar();

	
			russianCar.ReleaseCar(russianEngine);

			IFactory germanFactory = new GermanFactory();
			IEngine germanEngine = germanFactory.createEngine();
			ICar germanCar = germanFactory.createCar();


			germanCar.ReleaseCar(germanEngine);
		}
	}
}
