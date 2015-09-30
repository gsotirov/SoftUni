using System;

namespace Problem_01__Numbers_from_1_to_N
{
	class NumbersFromOnetoN
	{
		public static void Main ()
		{
			int n = int.Parse (Console.ReadLine());

			for (int i = 1; i <= n; i++) 
			{
				Console.Write ("{0} ", i);
			}
		}
	}
}
