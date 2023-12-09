using System;

namespace ComputerBuilder
{
	class Program
	{
		static void Main(string[] args)
		{
			
			IComputerBuilder officeBuilder = new OfficeComputer();
			IComputerBuilder gamingBuilder = new GamingComputer();
			IComputerBuilder designerBuilder = new DesignerComputer();

			
			ComputerDirector director = new ComputerDirector();

			
			director.ConstructComputer(officeBuilder);
			Computer officeComputer = officeBuilder.GetComputer();

			
			director.ConstructComputer(gamingBuilder);
			Computer gamingComputer = gamingBuilder.GetComputer();

			
			director.ConstructComputer(designerBuilder);
			Computer designerComputer = designerBuilder.GetComputer();

			
			Console.WriteLine("Office Computer:");
			Console.WriteLine(officeComputer);

			Console.WriteLine("\nGaming Computer:");
			Console.WriteLine(gamingComputer);

			Console.WriteLine("\nDesigner Computer:");
			Console.WriteLine(designerComputer);
		}
	}
}
