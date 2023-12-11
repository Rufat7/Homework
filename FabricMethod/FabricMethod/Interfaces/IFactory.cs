using FabricMethod.FabricMethod.Interfaces;

namespace FabricMethod.FabricMethod.Interfaces
{
	interface IFactory
	{
		IEngine сreateEngine();
		ICar сreateCar();
		IEngine createEngine();
		ICar createCar();
	}
}
