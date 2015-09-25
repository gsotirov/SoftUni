using System;

namespace Problem_05__Biggest_of_Three_Numbers
{
	class BiggestOfThreeNumbers
	{
		public static void Main ()
		{
			double a = double.Parse (Console.ReadLine());
			double b = double.Parse (Console.ReadLine());
			double c = double.Parse (Console.ReadLine());

			double biggest = double.MinValue;

			if (a >= b && a >= c) 
			{
				biggest = a;
			}

			if (b >= a && b >= c)
			{
				biggest = b;
			}

			if (c >= a && c >= b)
			{
				biggest = c;
			}

			Console.WriteLine (biggest);

			// ----------------------
			// === The easier way ===
			// ----------------------
			//const int numsCount = 3;
			//double max = double.MinValue;
			//for (int i = 0; i < numsCount; i++) 
			//{
			//	double num = double.Parse (Console.ReadLine());
			//	if (num > max) 
			//	{
			//		max = num;
			//	}
			//}

			//Console.WriteLine (max);
		}
	}
}
