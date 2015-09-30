using System;

namespace Problem_05__Calculate_Factorials
{
	class CalculateFactorials
	{
		public static void Main ()
		{
			Console.WriteLine ("Please enter N:");
			int n = int.Parse (Console.ReadLine ());
			Console.WriteLine ("Please enter X:");
			int x = int.Parse (Console.ReadLine ());
			double sum = 1;

			for (int i = 1; i <= n; i++) 
			{
				sum += Factorial(i) / Math.Pow (x, i);
			}

			Console.WriteLine ("{0:0.00000}", sum);
		}

		public static int Factorial (int n)
		{
			if (n <= 1)
			{
				return 1;
			}
			return n * Factorial (n - 1);
		}
	}
}
