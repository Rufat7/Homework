using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SedanFactory : IAutomobileFactory
{
	public IAutomobile CreateAutomobile()
	{
		return new Sedan();
	}
}