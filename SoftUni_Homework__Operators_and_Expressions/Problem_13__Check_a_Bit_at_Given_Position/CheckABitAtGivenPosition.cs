using System;

namespace Problem_13__Check_a_Bit_at_Given_Position
{
	class CheckABitAtGivenPosition
	{
		public static void Main ()
		{
			Console.WriteLine ("Please enter a number to see if it's bit at a given position is 1:");
			int inputNumber = int.Parse (Console.ReadLine());
			Console.WriteLine ("Please enter a position:");
			int position = int.Parse (Console.ReadLine());

			bool result = ((inputNumber >> position) & 1) == 1;

			Console.WriteLine ("Bit @ p == 1 ? - {0}", result);
		}
	}
}
