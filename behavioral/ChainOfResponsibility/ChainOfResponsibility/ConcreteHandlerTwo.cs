﻿using System;

namespace ChainOfResponsibility
{
	public class ConcreteHandlerTwo : Handler
	{
		public override void HandleRequest(int request)
		{
			if (request >= 10 && request < 20)
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
