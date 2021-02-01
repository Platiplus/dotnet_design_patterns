using Builder.Interfaces;

namespace Builder.Models
{
	public class Manufacturer
	{
		public Cellphone Build(ICellphone cellphoneBuilder)
		{
			cellphoneBuilder.BuildBattery();
			cellphoneBuilder.BuildCamera();
			cellphoneBuilder.BuildOperatingSystem();
			cellphoneBuilder.BuildScreen();

			return cellphoneBuilder.Cellphone;
		}

	}
}
