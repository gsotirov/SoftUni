using System;

namespace Problem_9__Trapezoids
{
	class Trapezoids
	{
		public static void Main ()
		{
			Console.WriteLine ("===== Trapezoid's area =====\n");
			Console.WriteLine ("Please enter a value for a:");
			double a = double.Parse (Console.ReadLine());
			Console.WriteLine ("Please enter a value for b:");
			double b = double.Parse (Console.ReadLine());
			Console.WriteLine ("Please enter a value for h:");
			double h = double.Parse (Console.ReadLine());

			double area = CalculateTrapezoidsArea (a, b, h);

			Console.WriteLine ("\nArea = {0}", area);
		}

		public static double CalculateTrapezoidsArea (double a, double b, double h)
		{
			return ((a + b) / 2) * h;
		}
	}
}
