using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public interface IComputerBuilder
{
	void SetProcessor(string processor);
	void SetRAM(int ram);
	void SetGraphicsCard(string graphicsCard);
	void SetStorage(string storage);
	Computer GetComputer();
}