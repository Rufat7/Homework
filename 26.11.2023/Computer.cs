using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;



public class ComputerDirector
{
	public void ConstructComputer(IComputerBuilder builder)
	{
		builder.SetProcessor("");
		builder.SetRAM(16);
		builder.SetStorage("SSD");
		builder.SetGraphicsCard("Integrated Graphics");
	}
}
