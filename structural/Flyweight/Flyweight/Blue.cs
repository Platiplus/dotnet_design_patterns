using System;

namespace Flyweight
{
	public class Blue : Turtle
	{
		public Blue()
		{
			Condition = "Turtle inside shell, ";
			Action = "spinning on the ground - ";
		}
		public override void Show(string color)
		{
			Color = color;
			Console.WriteLine(Condition + Action + color.ToUpper());
		}
	}
}
