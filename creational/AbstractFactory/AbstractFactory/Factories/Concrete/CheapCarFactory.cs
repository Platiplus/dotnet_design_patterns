using AbstractFactory.Factories.Abstract;
using AbstractFactory.Models;
using AbstractFactory.Models.SoundSystems;
using AbstractFactory.Models.Wheels;

namespace AbstractFactory.Factories.Concrete
{
	public class CheapCarFactory : CarFactory
	{
		public override SoundSystem BuildSoundSystem()
		{
			return new SimpleSoundSystem();
		}

		public override Wheel BuildWheels()
		{
			return new SimpleWheel();
		}
	}
}
