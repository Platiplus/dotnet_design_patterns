using System;

namespace TemplateMethod
{
	public abstract class AbstractClass
	{
		public abstract void PrimitiveOperationOne();
		public abstract void PrimitiveOperationTwo();
		public void TemplateMethod()
		{
			PrimitiveOperationOne();
			PrimitiveOperationTwo();
			Console.WriteLine();
		}
	}
}
