using System;

namespace Visitor
{
	class Program
	{
		static void Main(string[] args)
		{
			ObjectStructure objectStructure = new ObjectStructure();
			objectStructure.Attach(new ConcreteElementA());
			objectStructure.Attach(new ConcreteElementB());

			ConcreteVisitorOne concreteVisitorOne = new ConcreteVisitorOne();
			ConcreteVisitorTwo concreteVisitorTwo = new ConcreteVisitorTwo();

			objectStructure.Accept(concreteVisitorOne);
			objectStructure.Accept(concreteVisitorTwo);

			Console.ReadKey();
		}
	}
}
