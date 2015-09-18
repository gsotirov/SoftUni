using System;

namespace Problem_4__Rectangles
{
	class Rectangles
	{
		public static void Main ()
		{
			Console.WriteLine ("Please enter rectangle's width:");
			double width = double.Parse (Console.ReadLine());
			Console.WriteLine ("Please enter rectangle's height:");
			double height = double.Parse (Console.ReadLine());

			double perimeter = (2 * width) + (2 * height);
			double area = width * height;

			Console.WriteLine ("Rectangle's Perimeter: {0}\nRectangle's Area: {1}", perimeter, area);
		}
	}
}
