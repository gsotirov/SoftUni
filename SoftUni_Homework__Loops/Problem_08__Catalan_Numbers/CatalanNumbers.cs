using System;
using Mono.Math;

namespace Problem_08__Catalan_Numbers
{
	class CatalanNumbers
	{
		public static void Main ()
		{
			Console.WriteLine ("Please enter N:");
			int n = int.Parse (Console.ReadLine());
			BigInteger res = 0;

			if (n > 1 && n < 100)
			{
				res = Factorial (2 * n) / (Factorial (n + 1) * Factorial (n));
				Console.WriteLine (res);
			}
			else 
			{
				Console.WriteLine("Error! N must be bigger than 1 and smaller than 100!");
			}
		}

		public static BigInteger Factorial (int n)
		{
			if (n <= 1)
			{
				return 1;
			}
			return  n * Factorial (n - 1);
		}
	}
}
