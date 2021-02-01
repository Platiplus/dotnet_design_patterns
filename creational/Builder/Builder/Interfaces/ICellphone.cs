using Builder.Models;

namespace Builder.Interfaces
{
	public interface ICellphone
	{
		void BuildScreen();
		void BuildBattery();
		void BuildOperatingSystem();
		void BuildCamera();

		Cellphone Cellphone { get; }
	}
}
