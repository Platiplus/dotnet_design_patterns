using System;

namespace Decorator
{
	public class Book : LibraryItem
	{
		public string Author { get; set; }
		public string Title { get; set; }

		public Book(string author, string title, int numberOfCopies)
		{
			Author = author;
			Title = title;
			NumberOfCopies = numberOfCopies;
		}

		public override void Show()
		{
			Console.WriteLine("\n---------- Book ----------");
			Console.WriteLine($"Author: {Author}");
			Console.WriteLine($"Title: {Title}");
			Console.WriteLine($"Number of Copies: {NumberOfCopies}");
		}
	}
}
