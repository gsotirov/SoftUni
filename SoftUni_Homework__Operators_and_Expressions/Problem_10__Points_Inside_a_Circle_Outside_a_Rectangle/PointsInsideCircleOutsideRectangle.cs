using System;

namespace Problem_10__Points_Inside_a_Circle_Outside_a_Rectangle
{
	class PointsInsideCircleOutsideRectangle
	{
		public static void Main ()
		{
			Console.WriteLine ("Please enter point's X coordinate:");
			double pointX = double.Parse (Console.ReadLine());
			Console.WriteLine ("Please enter point's Y coordinate:");
			double pointY = double.Parse (Console.ReadLine());

			// Circle...
			double radius = 1.5;
			double circleX = 1;
			double circleY = 1;

			// Rectangle...
			double rectX = -1;
			double rectY = 1;
			double rectWidth = 6;
			double rectHeight = 2;

			bool isPointInsideCircle = CheckIfPointInCircle (radius, circleX, circleY, pointX, pointY);
			bool isPointOutsideRect = CheckIfPointOutsideRect (pointX, pointY, rectX, rectY, rectWidth, rectHeight);

			// If both conditions are met, point is within circle and outside the rectangle.
			string output = (isPointInsideCircle && isPointOutsideRect) ? "yes" : "no";

			// Print the result.
			Console.WriteLine ("Inside Circle, Outside Rectangle? - {0}", output);
		}

		static bool CheckIfPointInCircle (double radius, double circleX, double circleY, double pointX, double pointY)
		{
			// Check vector x and x -
			bool xOut = (pointX < (circleX - radius)) || (pointX > (circleX + radius));
			// Check vector y and y -
			bool yOut = (pointY < (circleY - radius)) || (pointY > (circleY + radius));
			// Calculate the distance from circle center to point.
			double distance = CalculateDistanceFromCenter (pointX - circleX, pointY - circleY);
			// Check if point lies within or outside the circle.
			bool rOut = distance > radius;

			// Return true if point is within circle.
			return !xOut && !yOut && !rOut;
		}

		static bool CheckIfPointOutsideRect (double pointX, double pointY, double rectX, double rectY, double rectWidth, double rectHeight)
		{
			// Return true if point outside the rectangle.
			return (pointX < rectX) || (pointX > (rectX + rectWidth)) || (pointY > rectY) || (pointY < (rectY - rectHeight));
		}

		public static double CalculateDistanceFromCenter (double x, double y)
		{
			double cathetus1 = x;
			double cathetus2 = y;

			double hypotenuse = Math.Sqrt((cathetus1 * cathetus1) + (cathetus2 * cathetus2));

			// Return the distance.
			return hypotenuse;
		}
	}
}
