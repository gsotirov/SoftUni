using System;

namespace Problem_12__Extract_Bit_from_Integer
{
	class ExtractBitFromInteger
	{
		public static void Main ()
		{
			Console.WriteLine ("Please enter an integer number:");
			int inputNumber = int.Parse (Console.ReadLine());
			Console.WriteLine ("Please enter the position of the bit you want to check out:");
			int position = int.Parse (Console.ReadLine());

			int bit = (inputNumber >> position) & 1;

			Console.WriteLine ("The bit at position {0} of the number {1} is {2}", position, inputNumber, bit);
		}
	}
}
