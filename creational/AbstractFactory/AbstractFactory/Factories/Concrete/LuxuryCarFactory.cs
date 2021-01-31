using AbstractFactory.Factories.Abstract;
using AbstractFactory.Models;
using AbstractFactory.Models.SoundSystems;
using AbstractFactory.Models.Wheels;

namespace AbstractFactory.Factories.Concrete
{
	public class LuxuryCarFactory : CarFactory
	{
		public override SoundSystem BuildSoundSystem()
		{
			return new ComplexSoundSystem();
		}

		public override Wheel BuildWheels()
		{
			return new ComplexWheel();
		}
	}
}
