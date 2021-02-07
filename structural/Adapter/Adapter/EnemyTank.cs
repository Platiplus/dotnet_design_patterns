using System;

namespace Adapter
{
	public class EnemyTank : IEnemyAttack
	{
		readonly Random Generator = new Random();

		public void Drive(string pilot)
		{
			Console.WriteLine("{0} is driving the tank.", pilot);
		}

		public void Firearm()
		{
			int attackDamage = Generator.Next(10) + 1;
			Console.WriteLine("Enemy tank done {0} damage.", attackDamage);
		}

		public void Move()
		{
			int movement = Generator.Next(5) + 1;
			Console.WriteLine("Enemy tank moved {0} units of distance.", movement);
		}
	}
}
