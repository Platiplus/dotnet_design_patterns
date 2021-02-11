namespace State
{
	public class ConcreteStateB : State
	{
		public override void Handle(Context ctx)
		{
			ctx.State = new ConcreteStateA();
		}
	}
}
