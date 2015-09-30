using System;

namespace Problem_03__Min_Max_Sum_Average_of_N_Numbers
{
	class MinMaxSumAverageOfN
	{
		public static void Main ()
		{
			Console.WriteLine ("Please enter N:");
			string input = Console.ReadLine();
			int n;

			while(!int.TryParse(input, out n) || n == 0)
			{
				Console.WriteLine ("Invalid N!");
				input = Console.ReadLine ();
			}

			int[] numbers = new int[n];

			for (int i = 0; i < n; i++) 
			{
				try
				{
					Console.WriteLine("Enter number {0}: ", i + 1);
					numbers[i] = int.Parse(Console.ReadLine());
				}
				catch(FormatException fe)
				{
					Console.WriteLine ("Error occured! " + fe.Message);
				}
			}

			int min = GetMin (numbers);
			int max = GetMax (numbers);
			int sum = GetSum (numbers);
			double average = GetAverage (numbers);

			Console.WriteLine ("\nMin = {0}\nMax = {1}\nSum = {2}\nAverage = {3:0.00}", min, max, sum, average);
		}

		public static int GetMin (int[] numbers)
		{
			int min = int.MaxValue;
			for (int i = 0; i < numbers.Length; i++) 
			{
				if (numbers [i] < min) 
				{
					min = numbers [i];
				}
			}
			return min;
		}

		public static int GetSum (int[] numbers)
		{
			int sum = 0;
			for (int i = 0; i < numbers.Length; i++) 
			{
				sum += numbers [i];
			}
			return sum;
		}

		public static int GetMax (int[] numbers)
		{
			int max = int.MinValue;
			for (int i = 0; i < numbers.Length; i++) 
			{
				if (numbers [i] > max) 
				{
					max = numbers [i];
				}
			}
			return max;
		}

		public static double GetAverage (int[] numbers)
		{
			int sum = 0;
			int numCount = numbers.Length;

			for (int i = 0; i < numCount; i++) 
			{
				sum += numbers [i];
			}
			return (double)sum / numCount;
		}
	}
}
