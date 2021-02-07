using System;
using System.Collections.Generic;

namespace Decorator
{
	/* This is the concrete Decorator */
	public class Borrowed : Decorator
	{
		protected List<string> Loans = new List<string>();
		public Borrowed(LibraryItem libraryItem) : base(libraryItem) { }

		public void LendItem(string name)
		{
			Loans.Add(name);
			LibraryItem.NumberOfCopies--;
		}

		public void ReturnItem(string name)
		{
			Loans.Remove(name);
			LibraryItem.NumberOfCopies++;
		}

		public override void Show()
		{
			base.Show();
			foreach (var item in Loans)
			{
				Console.WriteLine($"Borrowed: {item}");
			}
		}
	}
}
