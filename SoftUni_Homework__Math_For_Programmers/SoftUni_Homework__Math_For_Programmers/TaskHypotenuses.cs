using System;
using Mono.Math; // For the BigInteger! Use the equivalent for Windows and it should work just fine.

namespace SoftUni_Homework__Math_For_Programmers
{
	public class TaskHypotenuses
	{
		public TaskHypotenuses()
		{
		}

		public void FindHypotenuses(int c1, int c2)
		{
			double hypotenuses = Math.Sqrt((Math.Pow((double)c1, 2) + Math.Pow((double)c2, 2)));

			Console.WriteLine ("The lenght of the hypotenuses of a Right Triangle with Cathetis - {0} and {1} is {2}", c1, c2, hypotenuses);

		}
	}
}
