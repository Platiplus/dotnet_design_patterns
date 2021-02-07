namespace Interpreter
{
	public class UnitsExpression : Expression
	{
		public override string Five()
		{
			return "V";
		}

		public override string Four()
		{
			return "IV";
		}

		public override int Multiply()
		{
			return 1;
		}

		public override string Nine()
		{
			return "IX";
		}

		public override string One()
		{
			return "I";
		}
	}
}
