namespace Decorator
{
	/* This is the abstract decorator */
	public class Decorator : LibraryItem
	{
		protected LibraryItem LibraryItem;

		public Decorator(LibraryItem libraryItem)
		{
			LibraryItem = libraryItem;
		}

		public override void Show()
		{
			LibraryItem.Show();
		}
	}
}
