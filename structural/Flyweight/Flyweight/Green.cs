using System;

namespace Flyweight
{
	public class Green : Turtle
	{
		public Green()
		{
			Condition = "Turtle inside shell, ";
			Action = "spinning on the ground - ";
		}
		public override void Show(string color)
		{
			Color = color;
			Console.WriteLine(Condition, Action, color.ToUpper());
		}
	}
}
