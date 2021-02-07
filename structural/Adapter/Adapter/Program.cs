using System;

namespace Adapter
{
	class Program
	{
		static void Main(string[] args)
		{
			EnemyTank rx2018 = new EnemyTank();
			EnemyRobot c3po = new EnemyRobot();
			EnemyRobotAdapter robotAdapter = new EnemyRobotAdapter(c3po);

			Console.WriteLine("---------- ROBOT ---------");
			c3po.ReactAgainstHumans("John");
			c3po.MoveForward();
			c3po.Smash();

			Console.WriteLine("---------- TANK ---------");
			rx2018.Drive("Doe");
			rx2018.Move();
			rx2018.Firearm();

			Console.WriteLine("---------- ROBOT ADAPTER ---------");
			robotAdapter.Drive("Doe");
			robotAdapter.Move();
			robotAdapter.Firearm();

			Console.ReadKey();
		}
	}
}
