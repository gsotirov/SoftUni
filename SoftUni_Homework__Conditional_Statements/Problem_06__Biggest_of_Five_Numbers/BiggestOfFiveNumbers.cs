using System;

namespace Problem_06__Biggest_of_Five_Numbers
{
	class BiggestOfFiveNumbers
	{
		public static void Main ()
		{
			// Input...
			double a = double.Parse (Console.ReadLine());
			double b = double.Parse (Console.ReadLine());
			double c = double.Parse (Console.ReadLine());
			double d = double.Parse (Console.ReadLine());
			double e = double.Parse (Console.ReadLine());

			double biggest = CompareNumbers (a, b, c, d, e);

			// Print the result on the console...
			Console.WriteLine (biggest);
		}

		public static double CompareNumbers (double a, double b, double c, double d, double e)
		{
			double biggest = double.MinValue;

			// Only FIVE IFs required...
			/*---------------------------*/

			// Checking 'a'...
			if (a >= b && a >= c && a >= d && a >= e)
			{
				biggest = a;
			}
			// Checking 'b'...
			if (b >= a && b >= c && b >= d && b >= e)
			{
				biggest = b;
			}
			// Checking 'c'...
			if (c >= a && c >= b && c >= d && c >= e)
			{
				biggest = c;
			}
			// Checking 'd'...
			if (d >= a && d >= b && d >= c && d >= e)
			{
				biggest = d;
			}
			// Checking 'e'...
			if (e >= a && e >= b && e >= c && e >= d)
			{
				biggest = e;
			}

			return biggest;
		}
	}
}
