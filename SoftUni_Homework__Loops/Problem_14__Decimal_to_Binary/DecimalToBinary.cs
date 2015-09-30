using System;
using System.Collections.Generic;

namespace Problem_14__Decimal_to_Binary
{
	class DecimalToBinary
	{
		public static void Main ()
		{
			Console.WriteLine ("Please enter an integer:");
			string input = Console.ReadLine();
			long dec;

			// Check the input...
			while (!long.TryParse(input, out dec))
			{
				Console.WriteLine ("Please enter a valid integer:");
				input = Console.ReadLine ();
			}

			// The magic...
			List<int> digits = new List<int> ();

			while (dec > 0) 
			{
				digits.Add ((int)(dec % 2));
				dec /= 2;
			}

			digits.Reverse (); // Reverse the elements as the binary needs to be Right-to-Left

			Console.WriteLine ("\n--- Binary ---");
			foreach (int digit in digits) 
			{
				Console.Write ("{0}", digit);
			}
		}
	}
}
