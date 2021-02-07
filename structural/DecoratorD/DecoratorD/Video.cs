using System;

namespace Decorator
{
	public class Video : LibraryItem
	{
		public string Director { get; set; }
		public string Title { get; set; }
		public int DurationInMinutes { get; set; }

		public Video(string director, string title, int duration, int numberOfCopies)
		{
			Director = director;
			Title = title;
			DurationInMinutes = duration;
			NumberOfCopies = numberOfCopies;
		}

		public override void Show()
		{
			Console.WriteLine($"\n---------- Video ----------");
			Console.WriteLine($"Director: {Director}");
			Console.WriteLine($"Title: {Title}");
			Console.WriteLine($"Duration in minutes: {DurationInMinutes}");
			Console.WriteLine($"Number of copies: {NumberOfCopies}");
		}
	}
}
