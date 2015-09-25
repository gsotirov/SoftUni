using System;

namespace Problem_07__Sort_Three_Numbers
{
	class SortThreeNumbers
	{
		public static void Main ()
		{
			// Input...
			double a = double.Parse (Console.ReadLine());
			double b = double.Parse (Console.ReadLine());
			double c = double.Parse (Console.ReadLine());

			string sorted = SortNumbersDescending (a, b, c);

			Console.WriteLine (sorted);
		}

		public static string SortNumbersDescending (double a, double b, double c)
		{
			double min = double.MinValue;
			double mid = double.MinValue;
			double max = double.MinValue;

			if (a > b) 
			{
				if (a > c) 
				{
					if (b > c) 
					{
						max = a;
						mid = b;
						min = c;
					}
					else 
					{
						max = a;
						mid = c;
						min = b;
					}
				} 
				else 
				{
					max = c;
					mid = a;
					min = b;
				}
			}
			else 
			{
				if (b > c) 
				{
					if (a > c)
					{
						max = b;
						mid = a;
						min = c;
					}
					else
					{
						max = b;
						mid = c;
						min = a;
					}
				}
				else 
				{
					max = c;
					mid = b;
					min = a;
				}
			}

			string output = max + ", " + mid + ", " + min;
			return output;
		}
	}
}
