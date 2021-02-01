using Builder.Builders;
using Builder.Interfaces;
using Builder.Models;
using System;

namespace Builder
{
	class Program
	{
		static void Main(string[] args)
		{
			Manufacturer manufacturer = new Manufacturer();
			ICellphone cellphoneBuilder;

			cellphoneBuilder = new AndroidBuilder();
			Cellphone androidPhone = manufacturer.Build(cellphoneBuilder);

			cellphoneBuilder = new IphoneBuilder();
			Cellphone iphone = manufacturer.Build(cellphoneBuilder);
			
			Console.WriteLine("New phone built with specs:");
			Console.WriteLine("    Name: {0}", androidPhone.Name);
			Console.WriteLine("    Camera: {0}", androidPhone.Camera);
			Console.WriteLine("    Screen: {0}", androidPhone.Screen);
			Console.WriteLine("    Battery: {0}", androidPhone.Battery);
			Console.WriteLine("    Operating System: {0}", androidPhone.OperatingSystem);
			Console.WriteLine();
			Console.WriteLine("New phone built with specs:");
			Console.WriteLine("    Name: {0}", iphone.Name);
			Console.WriteLine("    Camera: {0}", iphone.Camera);
			Console.WriteLine("    Screen: {0}", iphone.Screen);
			Console.WriteLine("    Battery: {0}", iphone.Battery);
			Console.WriteLine("    Operating System: {0}", iphone.OperatingSystem);

			Console.ReadKey();
		}
	}
}
