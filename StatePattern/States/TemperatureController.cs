using System;

namespace StateExample
{
	public class TemperatureController
	{
		private State state;

		public TemperatureController(State initialState)
		{
			SetState(initialState);
		}

		public void SetState(State newState)
		{
			state = newState;
			state.TemperatureController = this;
		}

		public void IncreaseTemperature(int temperature)
		{
			state.IncreaseTemperature(temperature);
		}

		public void DecreaseTemperature(int temperature)
		{
			state.DecreaseTemperature(temperature);
		}
	}
}
