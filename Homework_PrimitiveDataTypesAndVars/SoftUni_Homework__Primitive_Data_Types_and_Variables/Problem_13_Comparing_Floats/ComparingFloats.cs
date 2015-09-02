using System;

namespace Problem_13_Comparing_Floats
{
	class ComparingFloats
	{
		public static void Main ()
		{
			Console.WriteLine ("==== Comparing Floats ====\n");

			double a, b;
			bool areEqual;

			Console.WriteLine ("Please insert first Floating-point number:");
			bool checkA = double.TryParse (Console.ReadLine (), out a);

			Console.WriteLine ("Please insert second Floating-point number:");
			bool checkB = double.TryParse (Console.ReadLine (), out b);

			if (checkA && checkB) 
			{
				areEqual = AreFloatsEqual (a, b);
				Console.WriteLine ("Float numbers are equal: {0}", areEqual);
			} 
			else 
			{
				Console.WriteLine ("One or both of the numbers you've entered are not valid!");
			}
		}

		public static bool AreFloatsEqual (double a, double b)
		{
			const double EPS = 0.000001;
			return CompareFloats (a, b, EPS);
		}

		public static bool CompareFloats (double a, double b, double eps)
		{
			const double MIN_VALUE = Double.MinValue;
			double firstFloat = Math.Abs(a);
			double secondFloat = Math.Abs (b);
			double difference = Math.Abs (a - b);
			bool isAEqualToZero = a == 0;
			bool isBEqualToZero = b == 0;
			bool isAEqualToB = a == b;

			if (isAEqualToB) 
			{
				return true;
			} 
			else if (isAEqualToZero || isBEqualToZero || difference < MIN_VALUE) 
			{
				return difference < (eps * MIN_VALUE);
			} 
			else 
			{
				return difference / (firstFloat + secondFloat) < eps;
			}
		}
	}
}
