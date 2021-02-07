using System;

namespace ChainOfResponsibility
{
	public class ConcreteHandlerThree : Handler
	{
		public override void HandleRequest(int request)
		{
			if (request >= 20 && request < 30)
			{
				Console.WriteLine($"{GetType().Name} handled request {request}");
			}
			else if (Successor != null)
			{
				Successor.HandleRequest(request);
			}
		}
	}
}
