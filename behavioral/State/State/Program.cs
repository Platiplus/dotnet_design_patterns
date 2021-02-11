using System;

namespace State
{
	class Program
	{
		static void Main(string[] args)
		{
			Context ctx = new Context(new ConcreteStateA());
			ctx.Request();
			ctx.Request();
			ctx.Request();
			ctx.Request();

			Console.ReadKey();
		}
	}
}
