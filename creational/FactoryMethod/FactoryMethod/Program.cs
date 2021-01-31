using System;

namespace FactoryMethod
{
	class Program
	{
		static void Main(string[] args)
		{
			FactoryMethod factory = new FactoryMethod();

			Console.WriteLine("Choose your character");
			Console.WriteLine("CharacterOne || CharacterTwo || CharacterThree");

			string characterName = Console.ReadLine();
			ICharacter character = factory.ChooseCharacter(characterName);

			if (character != null)
			{
				character.Chosen();
			}
			else
			{
				Console.WriteLine("No valid character was chosen!");
			}

			Console.WriteLine("Press any key to continue...");
			Console.ReadKey();
		}
	}
}
