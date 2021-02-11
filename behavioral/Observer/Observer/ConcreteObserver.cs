using System;

namespace Observer
{
	class ConcreteObserver : Observer
	{
		private string _name;
		private string _subjectState;
		private ConcreteSubject _subject;

		public ConcreteObserver(ConcreteSubject subject, string name)
		{
			_subject = subject;
			_name = name;
		}

		public override void Update()
		{
			_subjectState = _subject.SubjectState;
			Console.WriteLine($"Observer {_name}: your next state is: {_subjectState}");
		}
	}
}
