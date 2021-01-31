using AbstractFactory.Models;

namespace AbstractFactory.Factories.Abstract
{
	public abstract class CarFactory
	{
		public abstract Wheel BuildWheels();
		public abstract SoundSystem BuildSoundSystem();
	}
}
