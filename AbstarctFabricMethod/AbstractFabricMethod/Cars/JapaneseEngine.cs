using System;
using FabricMethod.FabricMethod.Interfaces;

namespace FabricMethod.FabricMethod.Engines
{
	class JapaneseEngine : IEngine
	{
		public void ReleaseEngine() => Console.WriteLine("Nissan GTR R35");
	}
}
