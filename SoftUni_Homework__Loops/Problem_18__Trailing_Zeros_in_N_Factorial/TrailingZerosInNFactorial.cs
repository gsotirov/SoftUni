using System;
using Mono.Math;

namespace Problem_18__Trailing_Zeros_in_N_Factorial
{
	class TrailingZerosInNFactorial
	{
		public static void Main ()
		{
			// Get the input...
			Console.WriteLine ("Please enter N:");
			string input = Console.ReadLine ();
			ulong n;

			// Input check...
			while (!ulong.TryParse(input, out n) || n < 0)
			{
				Console.WriteLine ("Please enter a valid N(unsigned 64-bit integer):");
				input = Console.ReadLine ();
			}

			// The magic...
			BigInteger nFact = Factorial (n);

			int trailingZerosCount = GetTrailingZerosCount (nFact);

			Console.WriteLine ("\n--- Trailing Zeros ---\n{0}", trailingZerosCount);
		}

		public static BigInteger Factorial (ulong n)
		{
			if (n <= 1)
			{
				return 1;
			}
			return n * Factorial (n - 1);
		}

		public static int GetTrailingZerosCount (BigInteger num)
		{
			int count = 0;
			string numAsString = num.ToString ();
			int len = numAsString.Length;

			for (int i = 0; i < len; i++) 
			{
				int digit = int.Parse (numAsString[len - i - 1].ToString());
				if (digit != 0)
				{
					break;
				}
				count += 1;
			}

			return count;
		}
	}
}
