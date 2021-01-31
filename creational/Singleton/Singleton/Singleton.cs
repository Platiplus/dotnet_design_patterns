using System;

namespace Singleton
{
	public sealed class Singleton
	{
		private static Singleton instance = null;
		public static Singleton GetInstance
		{
			get 
			{
				if (instance == null)
				{
					Console.WriteLine("New instance of Singleton Class");
					instance = new Singleton();
				}
				else 
				{
					Console.WriteLine("Singleton class already has instance, serving old instance.");
				}

				return instance;
			}
		}
	}
}
