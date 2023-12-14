using System;

namespace StateExample
{
	class Program
	{
		static void Main(string[] args)
		{
			TemperatureController temperatureController = new TemperatureController(new IceState());

			temperatureController.IncreaseTemperature(90); 
			temperatureController.IncreaseTemperature(100); 
			temperatureController.DecreaseTemperature(110); 
		}
	}
}
