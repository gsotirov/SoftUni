using System;

namespace Problem_5__Formatting_Numbers
{
	class FormattingNumbers
	{
		public static void Main ()
		{
			const int formatSize = 10;

			Console.WriteLine ("Please specify how many rows you'd like to format(between 1 and 5): ");
			int rows = int.Parse (Console.ReadLine());
			string formatted = "";

			// For testing purposes, I made it work with more than one row of numbers.
			for (int i = 0; i < rows; i++) 
			{
				Console.WriteLine ("Please enter 3 numbers on the next 3 lines:");
				int a = int.Parse (Console.ReadLine());
				double b = double.Parse (Console.ReadLine());
				double c = double.Parse (Console.ReadLine());

				// Format 'a' in hex aligned left.
				string af = FormatHexLeft (a, formatSize);
				// Format 'a' in bin aligned right and filled with 0s to the 10th digit.
				string afb = FormatBinaryPadded (a, formatSize);
				// Format 'b' to be printed with 2 digits after the floating point and be aligned to the right.
				string bf = FormatRight (b, formatSize);
				// Format 'c' to be printed with 3 digits after the floating point and be aligned to the left.
				string cf = FormatLeft (c, formatSize);

				// Add each row to the formatted string to adjust the output.
				formatted += String.Format("|{0}|{1}|{2}|{3}|\n", af, afb, bf, cf);
			}

			// Print the result on the console.
			Console.WriteLine (formatted);
		}

		static string FormatHexLeft (int num, int formatSize)
		{
			string numInHex = num.ToString("X");

			return numInHex.PadRight(formatSize, ' ');
		}

		static string FormatBinaryPadded (int num, int formatSize)
		{
			string numToBin = Convert.ToString (num, 2);

			return numToBin.PadLeft (formatSize, '0');
		}

		static string FormatRight (double num, int formatSize)
		{
			string numStr = num.ToString ();
			string formatted = String.Format ("{0:0.00}", double.Parse(numStr));

			return formatted.PadLeft (formatSize, ' ');
		}

		static string FormatLeft (double num, int formatSize)
		{
			string numStr = num.ToString ();
			string formatted = String.Format ("{0:0.000}", double.Parse(numStr));

			return formatted.PadRight (formatSize, ' ');
		}
	}
}
