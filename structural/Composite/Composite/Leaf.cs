using System;

namespace Composite
{
	public class Leaf : Component
	{
		public Leaf(string name) : base(name) { }

		public override void Add(Component c)
		{
			Console.WriteLine("Can't add leaf");
		}

		public override void Remove(Component c)
		{
			Console.WriteLine("Can't remove leaf");
		}

		public override void Show(int depth)
		{
			Console.WriteLine(new string('-', depth) + Name);
		}
	}
}
