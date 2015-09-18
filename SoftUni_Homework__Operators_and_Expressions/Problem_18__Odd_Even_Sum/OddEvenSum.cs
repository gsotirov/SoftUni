using System;

namespace Problem_18__Odd_Even_Sum
{
	class OddEvenSum
	{
		public static void Main ()
		{
			int n = int.Parse (Console.ReadLine());
			int len = 2 * n;

			int sumOdd = 0;
			int sumEven = 0;

			string output = "";

			for (int i = 0; i < len; i++) 
			{
				int inputNumber = int.Parse (Console.ReadLine());

				if (i % 2 == 0) 
				{
					sumEven += inputNumber;
				}
				else 
				{
					sumOdd += inputNumber;
				}
			}

			if (sumEven == sumOdd) 
			{
				output = "Yes, sum=" + sumEven;
			}
			else 
			{
				int diff = Math.Abs (sumOdd - sumEven);
				output = "No, diff=" + diff;
			}

			Console.WriteLine (output);
		}
	}
}
