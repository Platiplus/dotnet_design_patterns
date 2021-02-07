using System;

namespace Flyweight
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("---------- Flyweight Pattern ----------");
			FactoryFlyweight factory = new FactoryFlyweight();

			string color;

			Turtle turtle;

			while (true)
			{
				Console.WriteLine();
				Console.Write("Which turtle should we send to the screen? ");
				
				color = Console.ReadLine();

				turtle = factory.GetTurtle(color);
				if (turtle != null)
				{
					turtle.Show(color);
				}

				Console.WriteLine();
				Console.WriteLine("--------------------");
			}

		}
	}
}
