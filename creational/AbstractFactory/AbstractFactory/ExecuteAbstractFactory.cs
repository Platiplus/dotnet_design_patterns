using AbstractFactory.Factories.Abstract;
using AbstractFactory.Factories.Concrete;
using AbstractFactory.Models;

namespace AbstractFactory
{
	public class ExecuteAbstractFactory
	{
		public static Car BuildCar(string carType)
		{
			CarFactory carFactory;

			switch (carType)
			{
				case "luxury":
					carFactory = new LuxuryCarFactory();
					break;
				case "cheap":
					carFactory = new CheapCarFactory();
					break;
				default:
					carFactory = null;
					break;
			}

			Car car = new Car
			{
				Wheel = carFactory.BuildWheels(),
				SoundSystem = carFactory.BuildSoundSystem()
			};

			return car;
		}
	}
}
