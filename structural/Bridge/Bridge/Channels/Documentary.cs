using Bridge.Interfaces;

namespace Bridge.Channels
{
	public class Documentary : IChannel
	{
		public string Channel()
		{
			return "You're watching the documentary channel!";
		}

		public string Status()
		{
			return "'Ancient Aliens' is on.";
		}
	}
}
