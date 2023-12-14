using System;

namespace StateExample
{
	public class IceState : State
	{
		public override void IncreaseTemperature(int temperature)
		{
			if (temperature > 0)
			{
				Console.WriteLine($"Лёд тает, превращаясь в воду при {temperature}°C");
				temperatureController.SetState(new WaterState());
			}
		}
		public override void DecreaseTemperature(int temperature)
		{ }		
	}
}
