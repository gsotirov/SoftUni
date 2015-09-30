using System;

namespace Problem_17__Calculate_GCD
{
	class CalculateGCD
	{
		public static void Main ()
		{
			// Get the input...
			Console.WriteLine ("Please enter A:");
			int a = int.Parse (Console.ReadLine());
			Console.WriteLine ("Please enter B:");
			int b = int.Parse (Console.ReadLine());
			int r = int.MaxValue; // Just a value, different from 0! Can be 1, 2, 45, 23, ...

			int gcd = GCD (a, b, r);

			Console.WriteLine ("\n--- Greatest Common Divisor ---\n{0}", gcd);
		}

		// Recursively calculating the GCD following the Euclidean Algorithm.
		public static int GCD (int a, int b, int r)
		{
			r = a % b;

			if (r == 0)
			{
				return b;
			}

			a = b;
			b = r;

			return GCD (a, b, r);
		}
	}
}
