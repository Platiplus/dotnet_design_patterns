namespace Flyweight
{
	public abstract class Turtle
	{
		protected string Condition { get; set; }
		protected string Action { get; set; }
		public string Color { get; set; }

		public abstract void Show(string color);
	}
}
