using System;

namespace Mediator
{
	public class ConcreteColleagueTwo : Colleague
	{
		public ConcreteColleagueTwo(Mediator mediator) : base(mediator) { }

		public void Send(string message)
		{
			_mediator.Send(message, this);
		}

		public void Notify(string message)
		{
			Console.WriteLine($"ColleagueTwo informs, received message: {message}");
		}
	}
}
