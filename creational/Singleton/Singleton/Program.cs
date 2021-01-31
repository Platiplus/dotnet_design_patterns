using System;

namespace Singleton
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Press any key to get an instance of Singleton Class");
			Console.ReadKey();

			Singleton instanceOne = Singleton.GetInstance;
			Console.ReadKey();
			
			Singleton instanceTwo = Singleton.GetInstance;
			Console.ReadKey();
			
			Singleton instanceThree = Singleton.GetInstance;
			Console.ReadKey();
		}
	}
}
