using System;
using System.Collections.Generic;

namespace Interpreter
{
	class Program
	{
		static void Main(string[] args)
		{
			string roman = "MCMXXVIII";

			Context context = new Context(roman);

			List<Expression> listExpressions = new List<Expression>();
			listExpressions.Add(new ThousandsExpression());
			listExpressions.Add(new HundredsExpression());
			listExpressions.Add(new DozensExpression());
			listExpressions.Add(new UnitsExpression());

			foreach (Expression exp in listExpressions)
			{
				exp.Interpreter(context);
			}

			Console.WriteLine($"{roman} = {context.Output}");
			Console.ReadKey();
		}
	}
}
