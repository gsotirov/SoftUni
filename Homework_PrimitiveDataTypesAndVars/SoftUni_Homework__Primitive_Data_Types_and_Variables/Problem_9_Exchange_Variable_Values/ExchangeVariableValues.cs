using System;

namespace Problem_9_Exchange_Variable_Values
{
	class ExchangeVariableValues
	{
		public static void Main ()
		{
			int a = 5;
			int b = 10;

			Console.WriteLine ("Before:\na = {0}\nb = {1}", a, b);

			// Swap the values of 'a' and 'b'. 
			// Notice the vars are given to the function by reference, otherwise it won't work.
			Swap (ref a, ref b);

			Console.WriteLine ("After:\na = {0}\nb = {1}", a, b);

		}

		static void Swap (ref int a, ref int b)
		{
			int temp = a;
			a = b;
			b = temp;
		}
	}
}
