using System;

namespace Problem_02__Numbers_not_Divisible_by_3_and_7
{
	class NumbersNotDivisibleBy3and7
	{
		public static void Main ()
		{
			int n = int.Parse (Console.ReadLine());

			for (int i = 1; i <= n; i++) 
			{
				if (i % 3 == 0 || i % 7 == 0)
				{
					continue;
				}
				Console.Write ("{0} ", i);
			}
		}
	}
}
