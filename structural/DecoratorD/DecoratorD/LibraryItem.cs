namespace Decorator
{
	public abstract class LibraryItem
	{
		public int NumberOfCopies { get; set; }
		public abstract void Show();
	}
}
