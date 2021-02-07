namespace Command
{
	public abstract class Command
	{
		protected Receiver Receiver;

		public Command(Receiver receiver)
		{
			Receiver = receiver;
		}

		public abstract void Execute();
	}
}
