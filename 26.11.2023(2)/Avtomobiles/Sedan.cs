using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

public class Sedan : IAutomobile
{
	public void GetInfo()
	{
		Console.WriteLine("This is a Sedan.");
		Console.WriteLine("Model: BMW M5F90");
		Console.WriteLine("Type: Sedan");
	}
}
