using System;
using System.Collections.Generic;

namespace Composite
{
	public class Composite : Component
	{
		private List<Component> Children = new List<Component>();

		public Composite(string name) : base(name) {}

		public override void Add(Component c)
		{
			Children.Add(c);
		}

		public override void Remove(Component c)
		{
			Children.Remove(c);
		}

		public override void Show(int depth)
		{
			Console.WriteLine(new string('-', depth) + Name);

			foreach (var component in Children)
			{
				component.Show(depth + 1);
			}
		}
	}
}
