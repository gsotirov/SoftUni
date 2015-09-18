using System;

namespace Problem_15__Bits_Exchange
{
	class BitsExchange
	{
		public static void Main ()
		{
			Console.WriteLine ("=== Exchange bits at position 3,4,5 with bits at position 24,25,26 ===\n");
			Console.WriteLine ("Please enter a number which bits you want to exchange:");
			uint number = uint.Parse (Console.ReadLine());

			// We need a num with 3 1s in a row in binary rep. It's the number 7.
			const int pattern = 7;
			// We need the number of pos between the 3,4,5 and 24,25,26 bits.
			const int diff = 24 - 3;
			// First we mask bits 3,4,5
			const uint mask1 = pattern << 3;
			// Then we mask bits 24,25,26
			const uint mask2 = pattern << 24;

			// Store all necessary bits.
			uint firstBits = number & mask1;
			uint secondBits = number & mask2;

			// Make the specific bits of the initial num to 0 so we can then easily change them.
			number &= ~(mask1 | mask2);

			// Apply modified mask on the input number to modify it.
			number |= firstBits << diff;
			number |= secondBits >> diff;

			// Print the modified number.
			Console.WriteLine (number);
		}
	}
}
