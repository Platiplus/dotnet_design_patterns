using System;

namespace Prototype
{
	class Program
	{
		static void Main(string[] args)
		{
			Employee employee = new Employee
			{
				Name = "John",
				Age = 30,
				Type = "CLT"
			};

			Employee clonedEmployee = (Employee)employee.Clone();
			clonedEmployee.Name = "Doe";
			clonedEmployee.Age = 40;

			Console.WriteLine("Permanent employee details:");
			Console.WriteLine("  Name: {0}, Age: {1}, Type: {2}", employee.Name, employee.Age, employee.Type);

			Console.WriteLine("Permanent cloned employee details:");
			Console.WriteLine("  Name: {0}, Age: {1}, Type: {2}", clonedEmployee.Name, clonedEmployee.Age, clonedEmployee.Type);

			Console.ReadKey();
		}
	}
}
