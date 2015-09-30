using System;
using Mono.Math;

namespace Problem_06__Calculate_Factorials_Part2
{
	class CalculateFactorialsPartII
	{
		public static void Main ()
		{
			Console.WriteLine ("Please enter N:");
			int n = int.Parse (Console.ReadLine());
			Console.WriteLine ("Please enter K:");
			int k = int.Parse (Console.ReadLine());
			BigInteger output = 0;

			if (k > 1 && n > k && n < 100)
			{
				output = Factorial (n) / Factorial (k);
				Console.WriteLine (output);
			}
			else 
			{
				Console.WriteLine ("Error! Please make sure the following rule is met (1 < k < n < 100)!");
			}
		}

		public static BigInteger Factorial (int n)
		{
			if (n <= 1)
			{
				return 1;
			}
			return n * Factorial (n - 1);
		}
	}
}
