using System;

namespace Problem_1__Odd_or_Even
{
	class OddOrEven
	{
		public static void Main ()
		{
			int num = int.Parse (Console.ReadLine());

			bool output = (num % 2 != 0);

			Console.WriteLine ("Odd? - {0}", output);
		}
	}
}
