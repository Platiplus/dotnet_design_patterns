using System;

namespace FactoryMethod
{
	public class CharacterThree : ICharacter
	{
		public void Chosen()
		{
			Console.WriteLine("CharacterThree was chosen!");
		}
	}
}
