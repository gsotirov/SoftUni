using System;

namespace Problem_13__Binary_to_Decimal
{
	class BinaryToDecimal
	{
		public static void Main ()
		{
			string input = Console.ReadLine();
			int len = input.Length;
			long dec = 0;
			const int BASE = 2; // The base

			for (int i = 0; i < len; i++) 
			{
				int digit = int.Parse(input[len - i - 1].ToString());
				dec += (long)(digit * (Math.Pow((double)BASE, i)));
			}

			Console.WriteLine ("\n--- Decimal ---\n{0}", dec);
		}
	}
}
