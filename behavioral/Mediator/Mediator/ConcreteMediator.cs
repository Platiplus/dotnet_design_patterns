using System;

namespace Mediator
{
	public class ConcreteMediator : Mediator
	{
		private ConcreteColleagueOne _colleagueOne;
		private ConcreteColleagueTwo _colleagueTwo;

		public ConcreteColleagueOne ColleagueOne
		{
			set { _colleagueOne = value; }
		}

		public ConcreteColleagueTwo ColleagueTwo
		{
			set { _colleagueTwo = value; }
		}

		public override void Send(string message, Colleague colleague)
		{
			if (colleague == _colleagueOne)
			{
				_colleagueTwo.Notify(message);
			}
			else
			{
				_colleagueOne.Notify(message);
			}
		}
	}
}
