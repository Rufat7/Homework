using System;

class Program
{
	static void Main(string[] args)
	{
		IAutomobileFactory sedanFactory = new SedanFactory();
		IAutomobileFactory suvFactory = new SUVFactory();
		IAutomobileFactory truckFactory = new TruckFactory();

		IAutomobile sedan = sedanFactory.CreateAutomobile();
		IAutomobile suv = suvFactory.CreateAutomobile();
		IAutomobile truck = truckFactory.CreateAutomobile();

		Console.WriteLine("Details of Sedan:");
		sedan.GetInfo();

		Console.WriteLine("\nDetails of SUV:");
		suv.GetInfo();

		Console.WriteLine("\nDetails of Truck:");
		truck.GetInfo();
	}
}