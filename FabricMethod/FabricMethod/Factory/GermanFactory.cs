using FabricMethod.FabricMethod.Interfaces;
using FabricMethod.FabricMethod.Engines;
using FabricMethod.FabricMethod.Cars;

namespace FabricMethod.FabricMethod
{

	class GermanFactory : IFactory
	{
		public IEngine createEngine()
		{
			return new GermanEngine();
		}
		public ICar createCar()
		{
			return new GermanCar();
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