using System;

namespace TemplateMethod
{
	public class ConcreteClassA : AbstractClass
	{
		public override void PrimitiveOperationOne()
		{
			Console.WriteLine("ConcreteClassA.PrimitiveOperationOne()");
		}

		public override void PrimitiveOperationTwo()
		{
			Console.WriteLine("ConcreteClassA.PrimitiveOperationTwo()");
		}
	}
}
