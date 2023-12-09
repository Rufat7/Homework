using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class OfficeComputer : IComputerBuilder
{
	private Computer computer = new Computer();

	public void SetProcessor(string processor)
	{
		computer.Processor = "1650";
	}

	public void SetRAM(int ramSize)
	{
		computer.RAMSize = 8; 
	}

	public void SetGraphicsCard(string graphicsCard)
	{
		computer.GraphicsCard = "Integrated Graphics"; 
	}

	public void SetStorage(string storageType)
	{
		computer.StorageType = storageType; 
	}

	public Computer GetComputer()
	{
		return computer;
	}
}