using System;

namespace Adapter
{
	public class EnemyRobot
	{
		readonly Random Generator = new Random();
		
		public void Smash()
		{
			int attackDamage = Generator.Next(10) + 1;
			Console.WriteLine("Enemy robot done {0} damage smashing you with its hands!", attackDamage);
		}

		public void MoveForward()
		{
			int movement = Generator.Next(5) + 1;
			Console.WriteLine("Enemy robot walked {0} units of distance.", movement);
		}

		public void ReactAgainstHumans(string pilot)
		{
			Console.WriteLine("Enemy robot sees {0} and it's ready to attack!", pilot);
		}
	}
}
