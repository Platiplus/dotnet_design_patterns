using System;

namespace FactoryMethod
{
	public class CharacterTwo : ICharacter
	{
		public void Chosen()
		{
			Console.WriteLine("CharacterTwo was chosen!");
		}
	}
}
