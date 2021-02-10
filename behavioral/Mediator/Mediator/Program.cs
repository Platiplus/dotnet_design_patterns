using System;

namespace Mediator
{
	class Program
	{
		static void Main(string[] args)
		{
			ConcreteMediator mediator = new ConcreteMediator();
			ConcreteColleagueOne c1 = new ConcreteColleagueOne(mediator);
			ConcreteColleagueTwo c2 = new ConcreteColleagueTwo(mediator);

			mediator.ColleagueOne = c1;
			mediator.ColleagueTwo = c2;

			c1.Send("Test Message from ColleagueOne");
			c2.Send("Test Message from ColleagueTwo");

			Console.ReadKey();
		}
	}
}
