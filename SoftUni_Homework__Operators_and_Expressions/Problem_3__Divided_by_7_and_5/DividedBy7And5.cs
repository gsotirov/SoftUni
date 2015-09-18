using System;

namespace Problem_3__Divided_by_7_and_5
{
	class DividedBy7And5
	{
		public static void Main ()
		{
			int inputNumber = int.Parse (Console.ReadLine());
			const int DIVIDER = 7 * 5;

			// Checking if the number can be divided 
			// by 7 and 5 by dividing it by 7 * 5 (35).
			bool result = (inputNumber % DIVIDER == 0);

			Console.WriteLine ("Divided by 7 and 5? - {0}", result);
		}
	}
}
