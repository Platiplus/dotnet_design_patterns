using System;

namespace Strategy
{
	class Program
	{
		static void Main(string[] args)
		{
			SortedList studentRecords = new SortedList();
			studentRecords.Add("John");
			studentRecords.Add("Doe");
			studentRecords.Add("Mary");
			studentRecords.Add("Ethan");

			studentRecords.SetSortStrategy(new QuickSort());
			studentRecords.Sort();

			studentRecords.SetSortStrategy(new ShellSort());
			studentRecords.Sort();

			studentRecords.SetSortStrategy(new MergeSort());
			studentRecords.Sort();

			Console.ReadKey();
		}
	}
}
