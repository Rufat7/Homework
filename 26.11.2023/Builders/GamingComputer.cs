using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class GamingComputer : IComputerBuilder
{
	private Computer computer = new Computer();

	public void SetProcessor(string processor)
	{
		computer.Processor = "3060Ti"; 
	}

	public void SetRAM(int ramSize)
	{
		computer.RAMSize = 16;
	}

	public void SetGraphicsCard(string graphicsCard)
	{
		computer.GraphicsCard = graphicsCard; 
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
