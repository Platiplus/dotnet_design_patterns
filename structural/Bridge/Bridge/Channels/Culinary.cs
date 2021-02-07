using Bridge.Interfaces;

namespace Bridge.Channels
{
	public class Culinary : IChannel
	{
		public string Channel()
		{
			return "You're watching the culinary channel!";
		}

		public string Status()
		{
			return "'Orange cakepop recipe' is on.";
		}
	}
}
