using System;
using System.Collections.Generic;

namespace Flyweight
{
	/* The goal of this pattern is to reuse instantiated objects to preserve memory */
	public class FactoryFlyweight
	{
		private const string RedTurtle = "red";
		private const string BlueTurtle = "blue";
		private const string GreenTurtle = "green";
		private const string OrangeTurtle = "orange";

		private Dictionary<string, Turtle> turtleList = new Dictionary<string, Turtle>();

		public Turtle GetTurtle(string color)
		{
			Turtle t = null;

			if (turtleList.ContainsKey(color))
			{
				Console.WriteLine("Turtle already exists, deploying...");
				t = turtleList[color];
			}
			else
			{
				switch (color)
				{
					case RedTurtle:
						t = new Blue();
						break;
					case BlueTurtle:
						t = new Blue();
						break;
					case GreenTurtle:
						t = new Blue();
						break;
					case OrangeTurtle:
						t = new Blue();
						break;
					default:
						break;
				}

				if (t != null)
				{
					turtleList.Add(color, t);
					Console.WriteLine("Turtle didn't exist, adding to list and deploying...");
				}
			}

			return t;
		}
	}
}
