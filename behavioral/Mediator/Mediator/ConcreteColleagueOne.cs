using System;

namespace Mediator
{
	public class ConcreteColleagueOne : Colleague
	{
		public ConcreteColleagueOne(Mediator mediator) : base(mediator) { }

		public void Send(string message)
		{
			_mediator.Send(message, this);
		}

		public void Notify(string message)
		{
			Console.WriteLine($"ColleagueOne informs, received message: {message}");
		}
	}
}
