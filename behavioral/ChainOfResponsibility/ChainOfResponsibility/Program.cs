using System;

namespace ChainOfResponsibility
{
	class Program
	{
		static void Main(string[] args)
		{
			Handler h1 = new ConcreteHandlerOne();
			Handler h2 = new ConcreteHandlerTwo();
			Handler h3 = new ConcreteHandlerThree();

			h1.SetSuccessor(h2);
			h2.SetSuccessor(h3);

			int[] requests = { 2, 5, 24, 22, 18, 27, 20 };

			foreach (var request in requests)
			{
				h1.HandleRequest(request);
			}

			Console.ReadKey();
		}
	}
}
