namespace Adapter
{
	public class EnemyRobotAdapter : IEnemyAttack
	{
		EnemyRobot Robot;

		public EnemyRobotAdapter(EnemyRobot newRobot)
		{
			Robot = newRobot;
		}

		public void Drive(string pilot)
		{
			Robot.ReactAgainstHumans(pilot);
		}

		public void Firearm()
		{
			Robot.Smash();
		}

		public void Move()
		{
			Robot.MoveForward();
		}
	}
}
