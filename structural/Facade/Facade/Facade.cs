using System;

namespace Facade
{
	public class Facade
	{
		private readonly SubsystemOne One;
		private readonly SubsystemTwo Two;
		private readonly SubsystemThree Three;

		public Facade()
		{
			One = new SubsystemOne();
			Two = new SubsystemTwo();
			Three = new SubsystemThree();
		}

		public void MethodA()
		{
			Console.WriteLine("\n---------- MethodA ----------");
			One.MethodOne();
			Three.MethodThree();
		}

		public void MethodB()
		{
			Console.WriteLine("\n---------- MethodB ----------");
			Two.MethodTwo();
			Three.MethodThree();
		}
	}
}
