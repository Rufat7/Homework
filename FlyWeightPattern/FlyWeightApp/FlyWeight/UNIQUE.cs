using System;

namespace FlyWeight
{
	public struct UNIQUE
	{
		public string name;
		public string passport;

		public UNIQUE(string name, string passport)
		{
			this.name = name;
			this.passport = passport;
		}

		public string Name { get => name; }
		public string Passport { get => passport; }
	}
}
