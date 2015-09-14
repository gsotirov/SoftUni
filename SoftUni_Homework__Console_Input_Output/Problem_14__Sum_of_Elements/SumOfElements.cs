using System;

namespace Problem_14__Sum_of_Elements
{
	class SumOfElements
	{
		public static void Main ()
		{
			// =================================
			//  100/100 according to the Judge
			// =================================
			string input = Console.ReadLine ();
			string[] numbers = input.Split (' ');

			long max = FindMaxInArray (numbers);
			long sum = FindSumOfArray (numbers);

			string output = CheckIfEqual (sum, max);

			Console.WriteLine (output);

		}

		public static long FindMaxInArray (string[] numbers)
		{
			long maxValue = int.MinValue;

			for (int i = 0; i < numbers.Length; i++) 
			{
				int number = int.Parse (numbers [i]);
				if (number > maxValue) 
				{
					maxValue = number;
				}
			}

			return maxValue;
		}

		static long FindSumOfArray (string[] numbers)
		{
			long sum = 0;

			for (int i = 0; i < numbers.Length; i++) 
			{
				sum += int.Parse (numbers [i]);
			}

			return sum;
		}

		static string CheckIfEqual (long sum, long max)
		{
			long maxDoubled = 2 * max;

			if (sum == maxDoubled) 
			{
				return "Yes, sum=" + max;
			}
			else 
			{
				long diff = Math.Abs (sum - maxDoubled);
				return "No, diff=" + diff;
			}
		}
	}
}
