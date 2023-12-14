using System;

namespace StateExample
{
	public class SteamState : State
	{
		public override void IncreaseTemperature(int temperature)
		{
			Console.WriteLine($"Температура пара повышается до {temperature}°C");
		}

		public override void DecreaseTemperature(int temperature)
		{
			if (temperature < 100)
			{
				Console.WriteLine($"Пар конденсируется в воду при {temperature}°C");
				temperatureController.SetState(new WaterState());
			}
			
		}
	}
}
