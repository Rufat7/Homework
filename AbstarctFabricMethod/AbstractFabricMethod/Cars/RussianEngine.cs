using System;
using FabricMethod.FabricMethod.Interfaces;

namespace FabricMethod.FabricMethod.Engines
{
	class RussianEngine : IEngine
	{
		public void ReleaseEngine() => Console.WriteLine("LADA ВАЗ 2107");
	}
}
