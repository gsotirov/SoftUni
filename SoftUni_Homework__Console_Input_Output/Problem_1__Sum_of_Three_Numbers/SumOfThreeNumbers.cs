using System;

namespace Problem_1__Sum_of_Three_Numbers
{
	class SumOfThreeNumbers
	{
		public static void Main ()
		{
			decimal firstNumber = decimal.Parse (Console.ReadLine ());
			decimal secondNumber = decimal.Parse (Console.ReadLine ());
			decimal thirdNumber = decimal.Parse (Console.ReadLine ());

			Console.WriteLine ("Sum = {0}", firstNumber + secondNumber + thirdNumber);
		}
	}
}
