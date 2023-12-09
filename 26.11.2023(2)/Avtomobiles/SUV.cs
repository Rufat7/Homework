using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

public class SUV : IAutomobile
{
	public void GetInfo()
	{
		Console.WriteLine("This is an SUV.");
		Console.WriteLine("Model: BMW X5M");
		Console.WriteLine("Type: SUV");
	}
}