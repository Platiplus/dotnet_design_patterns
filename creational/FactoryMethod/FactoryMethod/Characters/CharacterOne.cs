using System;

namespace FactoryMethod
{
	public class CharacterOne : ICharacter
	{
		public void Chosen()
		{
			Console.WriteLine("CharacterOne was chosen!");
		}
	}
}
