using System;

namespace FlyWeight
{
	public struct Shared
	{
		private string company;
		private string position;

		public Shared(string company, string position)
		{
			this.company = company;
			this.position = position;
		}
		public string Company { get => company; }
		public string Position { get => position; }
	}
}
