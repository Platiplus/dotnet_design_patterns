using System;

namespace TemplateMethod
{
	public class ConcreteClassB : AbstractClass
	{
		public override void PrimitiveOperationOne()
		{
			Console.WriteLine("ConcreteClassB.PrimitiveOperationOne()");
		}

		public override void PrimitiveOperationTwo()
		{
			Console.WriteLine("ConcreteClassB.PrimitiveOperationTwo()");
		}
	}
}
