namespace Command
{
	public class Invoker 
	{
		private Command Command;

		public void SetCommand(Command command)
		{
			Command = command;
		}

		public void ExecuteCommand()
		{
			Command.Execute();
		}
	}
}
