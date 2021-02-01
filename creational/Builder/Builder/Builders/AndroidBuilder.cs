using Builder.Interfaces;
using Builder.Models;

namespace Builder.Builders
{
	public class AndroidBuilder : ICellphone
	{
		Cellphone Cell;

		public AndroidBuilder()
		{
			Cell = new Cellphone("android");
		}

		public void BuildBattery()
		{
			Cell.Battery = "MAH_1500";
		}

		public void BuildCamera()
		{
			Cell.Camera = "15MP";
		}

		public void BuildOperatingSystem()
		{
			Cell.OperatingSystem = "Android 11";
		}

		public void BuildScreen()
		{
			Cell.Screen = "GorilaGlass 5";
		}

		public Cellphone Cellphone
		{
			get { return Cell; }
		}
	}
}
