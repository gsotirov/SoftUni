using System;
using System.Collections.Generic;

namespace Problem_16__Decimal_to_Hex_Convertion
{
	class DecimalToHexConvertion
	{
		public static void Main ()
		{
			string input = Console.ReadLine ();
			long dec;
			const int BASE = 16; // The base
			List<string> hex = new List<string> ();

			// Input check...
			while (!long.TryParse(input, out dec))
			{
				Console.WriteLine ("Please enter a valid Integer:");
			}

			// The magic...
			while (dec > 0)
			{
				hex.Add(GetHex (dec % BASE));
				dec /= BASE;
			}

			// Reverse the array to make the values Right-to-Left
			hex.Reverse ();

			// Print the result on the console.
			Console.WriteLine ("\n--- Hex ---");
			foreach (string digit in hex) 
			{
				Console.Write ("{0}", digit);
			}
		}

		public static string GetHex (long num)
		{
			string output = "";

			switch (num)
			{
				case 10:
					output = "A";
					break;
				case 11:
					output = "B";
					break;
				case 12:
					output = "C";
					break;
				case 13:
					output = "D";
					break;
				case 14:
					output = "E";
					break;
				case 15:
					output = "F";
					break;
				default:
					output = num.ToString ();
				break;
			}

			return output;
		}
	}
}
