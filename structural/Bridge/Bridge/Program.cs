using Bridge.Channels;
using System;

namespace Bridge
{
	class Program
	{
		private const char MovieChannel = '1';
		private const char DocumentaryChannel = '2';
		private const char CulinaryChannel = '3';

		static void Main(string[] args)
		{
			SmartTv myTv = new SmartTv();
			Console.WriteLine("Select a channel.");
			Console.WriteLine("1 - Movies \n2 - Documentaries \n3 - Culinary");
			
			var selectedChannel = Console.ReadKey();
			switch (selectedChannel.KeyChar)
			{
				case MovieChannel:
					myTv.CurrentChannel = new Movie();
					break;

				case DocumentaryChannel:
					myTv.CurrentChannel = new Documentary();
					break;

				case CulinaryChannel:
					myTv.CurrentChannel = new Culinary();
					break;

				default:
					Console.WriteLine("This channel doesn't exist.");
					break;
			}

			Console.WriteLine("\n");

			myTv.ShowCurrentChannel();
			myTv.PlayTv();

			Console.ReadKey();
		}
	}
}
