using System;

namespace FactoryMethod
{
	public class FactoryMethod
	{
		public ICharacter ChooseCharacter(string character)
		{
			switch (character.ToLower()) 
			{
				case "characterone":
					return new CharacterOne();
				case "charactertwo":
					return new CharacterTwo();
				case "characterthree":
					return new CharacterThree();
				default:
					return null;
			}
		}
	}
}
