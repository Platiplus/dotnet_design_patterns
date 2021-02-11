using System;

namespace Observer
{
	class Program
	{
		static void Main(string[] args)
		{
			ConcreteSubject concreteSubject = new ConcreteSubject();
			
			concreteSubject.Attach(new ConcreteObserver(concreteSubject, "X"));
			concreteSubject.Attach(new ConcreteObserver(concreteSubject, "Y"));
			concreteSubject.Attach(new ConcreteObserver(concreteSubject, "Z"));

			concreteSubject.SubjectState = "ABC";
			concreteSubject.Notify();

			concreteSubject.SubjectState = "XYZ";
			concreteSubject.Notify();

			Console.ReadKey();
		}
	}
}
