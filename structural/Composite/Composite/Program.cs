using System;

namespace Composite
{
	class Program
	{
		static void Main(string[] args)
		{
			Composite root = new Composite("ProgramFiles");
			root.Add(new Leaf("Adobe"));
			root.Add(new Leaf("DBeaver"));
			root.Add(new Leaf("MongoDBCompass"));

			Composite component = new Composite("EpicGames");
			component.Add(new Leaf("DetroitBecomeHuman"));
			component.Add(new Leaf("Cyberpunk2077"));
			component.Add(new Leaf("SOMA"));

			root.Add(component);
			root.Add(new Leaf("Microsoft"));

			Leaf leaf = new Leaf("RiotGames");
			root.Add(leaf);
			root.Remove(leaf);

			root.Show(1);

			Console.ReadKey();
		}
	}
}
