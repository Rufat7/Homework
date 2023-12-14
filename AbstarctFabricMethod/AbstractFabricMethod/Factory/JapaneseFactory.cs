using FabricMethod.FabricMethod.Interfaces;
using FabricMethod.FabricMethod.Engines;
using FabricMethod.FabricMethod.Cars;

namespace FabricMethod.FabricMethod
{
	
	class JapaneseFactory : IFactory
	{
		public IEngine createEngine()
		{
			return new JapaneseEngine();
		}
	public ICar createCar()
		{
			return new JapaneseCar();
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
