namespace Interpreter
{
	public class DozensExpression : Expression
	{
		public override string Five()
		{
			return "L";
		}

		public override string Four()
		{
			return "XL";
		}

		public override int Multiply()
		{
			return 10;
		}

		public override string Nine()
		{
			return "XC";
		}

		public override string One()
		{
			return "X";
		}
	}
}
