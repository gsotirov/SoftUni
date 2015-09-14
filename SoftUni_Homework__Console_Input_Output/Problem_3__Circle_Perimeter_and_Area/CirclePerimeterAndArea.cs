using System;

namespace Problem_3__Circle_Perimeter_and_Area
{
	class CirclePerimeterAndArea
	{
		public static void Main ()
		{
			decimal radius = decimal.Parse (Console.ReadLine());

			// Find the perimeter.
			decimal perimeter = CalculateCirclePerimeter (radius);
			// Find the area.
			decimal area = CalculateCircleArea (radius);

			// Print the result on the console.
			Console.WriteLine ("The perimeter of the circle with radius {0} is {1:0.00}", radius, perimeter);
			Console.WriteLine ("The area of the circle with radius {0} is {1:0.00}", radius, area);
		}

		public static decimal CalculateCirclePerimeter (decimal radius)
		{
			double PI = Math.PI;

			return (decimal)((2 * PI) * (double)radius);
		}

		public static decimal CalculateCircleArea (decimal radius)
		{
			double PI = Math.PI;

			return (decimal)(PI * (Math.Pow ((double)radius, 2)));
		}
	}
}
