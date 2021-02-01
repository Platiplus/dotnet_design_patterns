using Builder.Interfaces;
using Builder.Models;

namespace Builder.Builders
{
	public class IphoneBuilder : ICellphone
	{
		Cellphone Cell;

		public IphoneBuilder()
		{
			Cell = new Cellphone("iphone");
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
			Cell.OperatingSystem = "iOS 11";
		}

		public void BuildScreen()
		{
			Cell.Screen = "Amoled";
		}

		public Cellphone Cellphone
		{
			get { return Cell; }
		}
	}
}
