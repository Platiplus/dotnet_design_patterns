using Bridge.Interfaces;
using System;

namespace Bridge
{
	class SmartTv
	{
		/* The bridge happens right here.
		 * We instantiate the channel interface so through methods we can show information about the concrete class
		 * without the need to instantiate it right away, because we don't know what the concrete class will be. */
		public IChannel CurrentChannel { get; set; }

		public void ShowCurrentChannel()
		{
			if (CurrentChannel != null)
			{
				Console.WriteLine(CurrentChannel.Channel());
			}
			else
			{
				Console.WriteLine("Please select a channel.");
			}
		}

		public void PlayTv()
		{
			if (CurrentChannel != null)
			{
				Console.WriteLine(CurrentChannel.Status());
			}
			else
			{
				Console.WriteLine("Please select a channel to watch something.");
			}
		}
	}
}
