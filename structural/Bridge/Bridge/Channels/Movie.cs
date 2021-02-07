using Bridge.Interfaces;

namespace Bridge.Channels
{
	public class Movie : IChannel
	{
		public string Channel()
		{
			return "You're watching the movie channel!";
		}

		public string Status()
		{
			return "'The Avengers: Endgame' is on.";
		}
	}
}
