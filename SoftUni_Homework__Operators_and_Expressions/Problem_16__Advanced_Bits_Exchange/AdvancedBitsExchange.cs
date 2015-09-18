using System;

namespace Problem_16__Advanced_Bits_Exchange
{
	class AdvancedBitsExchange
	{
		public static void Main ()
		{
			uint number = uint.Parse (Console.ReadLine());
			int p = int.Parse (Console.ReadLine());
			int q = int.Parse (Console.ReadLine());
			int k = int.Parse (Console.ReadLine());

			bool overlap = CheckForOverlap (p, q, k);
			bool outOfRange = CheckOverflow (p, q, k);

			if (!outOfRange) 
			{
				if (!overlap) 
				{
					uint pattern = MakePattern (k);
					uint fMask = pattern << p;
					uint sMask = pattern << q;
					int diff = (p > q) ? p - q : q - p;

					uint exchanged = ExchangeBits (number, fMask, sMask, diff);

					Console.WriteLine (exchanged);
				}
				else 
				{
					Console.WriteLine ("overlapping");
				}
			}
			else 
			{
				Console.WriteLine ("out of range");
			}
		}

		public static uint ExchangeBits (uint number, uint fMask, uint sMask, int diff)
		{
			// Store all necessary bits.
			uint firstBits = number & fMask;
			uint secondBits = number & sMask;

			// Make the specific bits of the initial num to 0 so we can then easily change them.
			number &= ~(fMask | sMask);

			// Apply modified mask on the input number to modify it.
			number |= firstBits << diff;
			number |= secondBits >> diff;

			return number;
		}

		public static bool CheckOverflow (int p, int q, int k)
		{
			bool pOut = (p + k) > 31;
			bool qOut = (q + k) > 31;

			return pOut || qOut;
		}

		public static bool CheckForOverlap (int p, int q, int k)
		{
			int diff = (p > q) ? p - q : q - p;
			return (p + k) >= diff;
		}

		public static uint MakePattern (int k)
		{
			string patternStr = "";

			for (int i = 0; i < k; i++) 
			{
				patternStr += "1";
			}

			return (uint)Convert.ToInt32 (patternStr.PadLeft (32, '0'), 2);
		}
	}
}
