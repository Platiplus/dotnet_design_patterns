﻿namespace Prototype
{
	class Employee : IEmployee
	{
		public string Name { get; set; }
		public int Age { get; set; }
		public string Type { get; set; }

		public IEmployee Clone()
		{
			return this.MemberwiseClone() as IEmployee;
		}
	}
}
