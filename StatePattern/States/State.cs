using System;

namespace StateExample
{
	public abstract class State
	{
		protected TemperatureController temperatureController;
		public TemperatureController TemperatureController { set => temperatureController = value; }
		public abstract void IncreaseTemperature(int temperature);
		public abstract void DecreaseTemperature(int temperature);
	}
}
