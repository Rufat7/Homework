using System;

namespace StateExample
{
	public class WaterState : State
	{
		public override void IncreaseTemperature(int temperature)
		{
			Console.WriteLine($"Температура воды повышается до {temperature}°C");
		}

		public override void DecreaseTemperature(int temperature)
		{
			Console.WriteLine($"Температура воды понижается до {temperature}°C");
		}
	}
}
