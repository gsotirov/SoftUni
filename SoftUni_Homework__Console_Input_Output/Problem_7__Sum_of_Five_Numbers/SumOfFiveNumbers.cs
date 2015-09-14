using System;

namespace Problem_7__Sum_of_Five_Numbers
{
	class SumOfFiveNumbers
	{
		public static void Main ()
		{
			Console.WriteLine ("Please enter 5 numbers separeted by a space:");
			string input = Console.ReadLine ();
			string[] numbersStr = input.Split (' ');
			decimal sum = 0;

			foreach (string number in numbersStr) 
			{
				sum += decimal.Parse (number);
			}

			Console.WriteLine ("============\nSum = {0}", sum);
		}
	}
}
