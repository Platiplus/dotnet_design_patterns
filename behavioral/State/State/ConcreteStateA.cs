namespace State
{
	public class ConcreteStateA : State
	{
		public override void Handle(Context ctx)
		{
			ctx.State = new ConcreteStateB();
		}
	}
}
