using System;

namespace Problem_14__Modify_a_Bit_at_Given_Position
{
	class ModifyABitAtGivenPosition
	{
		public static void Main ()
		{
			Console.WriteLine ("Please enter a number:");
			int inputNumber = int.Parse (Console.ReadLine());
			Console.WriteLine ("Please enter a bit value (0 or 1):");
			int bitValue = int.Parse (Console.ReadLine());
			Console.WriteLine ("Please enter a position where you want to put the bit value:");
			int position = int.Parse (Console.ReadLine());

			int res;

			if (bitValue == 0) 
			{
				int mask = ~(1 << position);
				res = mask & inputNumber;
			}
			else 
			{
				int mask = 1 << position;
				res = mask | inputNumber;
			}

			Console.WriteLine (res);
		}
	}
}
