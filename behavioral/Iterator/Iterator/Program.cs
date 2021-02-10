using System;

namespace Iterator
{
	class Program
	{
		static void Main(string[] args)
		{
			ConcreteAggregate aggregate = new ConcreteAggregate();
			aggregate[0] = "A";
			aggregate[1] = "B";
			aggregate[2] = "C";
			aggregate[3] = "D";

			Iterator iterator = aggregate.CreateIterator();

			Console.WriteLine("Interacting with the collection of items.");

			object item = iterator.First();

			while (item != null)
			{
				Console.WriteLine(iterator.CurrentItem());
				item = iterator.Next();
			}

			Console.WriteLine("Printing is done = {0}", iterator.IsDone());
			Console.ReadKey();
		}
	}
}
