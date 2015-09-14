using System;
using System.Collections.Generic;

namespace Problem_17__Catch_the_Bits
{
	class CatchTheBits
	{
		public static void Main ()
		{
			// =======================================
			//  100/100 according to the Judge.
			// =======================================
			sbyte n = sbyte.Parse (Console.ReadLine());
			sbyte step = sbyte.Parse (Console.ReadLine());

			string bytes = "";

			// Get the input and prepare it for manipulation.
			for (int start = 0; start < n; start++) 
			{
				bytes += PrepareBytes (int.Parse(Console.ReadLine ()));
			}

			// Catch the bits by step.
			string coughtBits = CatchBits (bytes, step);

			// Prepare the output bytes.
			List<string> bytesAfterExtraction = PrepareOutputBytes (coughtBits);
	
			foreach (string b in bytesAfterExtraction) 
			{
				// Write each output byte on the console converted to decimal number.
				Console.WriteLine (Convert.ToInt32(b, 2));
			}
		}

		public static string PrepareBytes (int input)
		{
			string byteStr = Convert.ToString (input, 2);
			return (byteStr.Length < 8) ? byteStr.PadLeft (8, '0') : byteStr;
		}

		public static string CatchBits (string bytes, sbyte step)
		{
			string output = "";

			for (int i = 1; i < bytes.Length; i += step) 
			{
				output += bytes [i];
			}

			return output;
		}

		public static List<string> PrepareOutputBytes (string coughtBits)
		{
			List<string> output = new List<string> ();
			string bits = "";

			for (int i = 0; i < coughtBits.Length; i++) 
			{
				bits += coughtBits [i];

				if (bits.Length == 8)
				{
					output.Add (bits);
					bits = "";
				}
				else if (i == coughtBits.Length - 1)
				{
					output.Add (bits.PadRight(8, '0'));
				}
			}

			return output;
		}
	}
}
