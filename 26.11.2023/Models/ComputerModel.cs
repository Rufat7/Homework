using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public class Computer
{
	public string Processor { get; set; }
	public int RAMSize { get; set; }
	public string GraphicsCard { get; set; }
	public string StorageType { get; set; }

	public override string ToString()
	{
		return $"Processor: {Processor}, RAM: {RAMSize}GB, Graphics Card: {GraphicsCard}, Storage: {StorageType}";
	}
}
