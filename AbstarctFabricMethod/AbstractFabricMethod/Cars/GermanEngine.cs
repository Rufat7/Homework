using System;
using FabricMethod.FabricMethod.Interfaces;

namespace FabricMethod.FabricMethod.Engines
{
	class GermanEngine : IEngine
	{
		public void ReleaseEngine() => Console.WriteLine("BMW M5F90");
	}
}
