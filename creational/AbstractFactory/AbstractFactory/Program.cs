using AbstractFactory.Models;
using System;

namespace AbstractFactory
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("AbstractFactory Building Examples");

			Car carOne = ExecuteAbstractFactory.BuildCar("luxury");
			Car carTwo = ExecuteAbstractFactory.BuildCar("cheap");

			Console.ReadLine();
		}
	}
}
