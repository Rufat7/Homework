using FabricMethod.FabricMethod.Interfaces;
using FabricMethod.FabricMethod.Engines;
using FabricMethod.FabricMethod.Cars;

namespace FabricMethod.FabricMethod
{

	class RussianFactory : IFactory
	{
	
		public IEngine createEngine()
		{
			return new RussianEngine();
		}

	
		public ICar createCar()
		{
			return new RussianCar();
		}

		public IEngine сreateEngine()
		{
			throw new NotImplementedException();
		}

		public ICar сreateCar()
		{
			throw new NotImplementedException();
		}
	}
}
