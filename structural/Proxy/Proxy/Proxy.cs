namespace Proxy
{
	public class Proxy : Subject
	{
		private RealSubject RealSubject;

		public override void Request()
		{
			if (RealSubject == null)
			{
				RealSubject = new RealSubject();
			}

			RealSubject.Request();
		}
	}
}
