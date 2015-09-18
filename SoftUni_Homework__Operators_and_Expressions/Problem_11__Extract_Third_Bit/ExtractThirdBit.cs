using System;

namespace Problem_11__Extract_Third_Bit
{
	class ExtractThirdBit
	{
		public static void Main ()
		{
			Console.WriteLine ("Please enter a number to see what value it's third bit has:");
			int inputNumber = int.Parse (Console.ReadLine());

			int thirdBit = (inputNumber >> 3) & 1;

			Console.WriteLine ("The third bit of {0} is {1}", inputNumber, thirdBit);
		}
	}
}
