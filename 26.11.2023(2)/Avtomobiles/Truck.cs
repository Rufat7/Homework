using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

public class Truck : IAutomobile
{
	public void GetInfo()
	{
		Console.WriteLine("This is a Truck.");
		Console.WriteLine("Model: Mercedes Benz");
		Console.WriteLine("Type: Truck");
	}
}