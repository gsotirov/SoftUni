using System;

namespace Problem_15__Hex_to_Decimal_Convertion
{
	class HexToDecimalConvertion
	{
		public static void Main ()
		{
			string input = Console.ReadLine ();
			int len = input.Length;
			const int BASE = 16; // The base
			long dec = 0;

			for (int i = 0; i < len; i++) 
			{
				dec += GetDigit (input [len - i - 1]) * (long)(Math.Pow (BASE, i));
			}

			Console.WriteLine ("\n--- Decimal ---\n{0}", dec);
		}
		public static long GetDigit (char ch)
		{
			long output = 0;

			switch (ch) 
			{
				case 'A':
					output = 10;
					break;
				case 'B':
					output = 11;
					break;
				case 'C':
					output = 12;
					break;
				case 'D':
					output = 13;
					break;
				case 'E':
					output = 14;
					break;
				case 'F':
					output = 15;
					break;
				default:
					output = long.Parse (ch.ToString());
					break;
			}

			return output;
		}
	}
}
