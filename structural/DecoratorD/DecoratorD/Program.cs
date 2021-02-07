using System;

namespace Decorator
{
	class Program
	{
		static void Main(string[] args)
		{
			Book skDeadZone = new Book("Stephen King", "DeadZone", 3);
			skDeadZone.Show();

			Video skDarkTower = new Video("Nikolaj Arcel", "The Dark Tower", 95, 2);
			skDarkTower.Show();

			Console.WriteLine("Lending a video...");
			
			Borrowed borrowedVideo = new Borrowed(skDarkTower);
			borrowedVideo.LendItem("John");
			borrowedVideo.LendItem("Doe");
			borrowedVideo.Show();

			Console.WriteLine("Returning a video...");
			borrowedVideo.ReturnItem("John");
			borrowedVideo.Show();
		}
	}
}
