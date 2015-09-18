using System;

namespace Problem_5__Third_Digit_is_7
{
	class ThirdDigitIs7
	{
		public static void Main ()
		{
			int num = int.Parse (Console.ReadLine());

			bool res = ((num /= 100) % 10 == 7) ? true : false;

			Console.WriteLine ("Third digit 7? - {0}", res);
		}
	}
}
