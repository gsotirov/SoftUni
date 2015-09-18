using System;

namespace Problem_7__Points_in_Circle
{
	class PointsInCircle
	{
		public static void Main ()
		{
			Console.WriteLine ("Please enter the number of tests you want to perform:");
			int numberOfTests = int.Parse (Console.ReadLine());

			for (int i = 0; i < numberOfTests; i++) 
			{
				Console.WriteLine ("Please insert X:");
				double x = double.Parse (Console.ReadLine());
				Console.WriteLine ("Please insert Y:");
				double y = double.Parse (Console.ReadLine());

				// Radius is 2
				const int radius = 2;

				bool isInsideCircle = false;

				double distanceBetweenCenterAndPoint = CalculateDistanceFromCenter (x, y);

				if (!(x == 0 && y > radius) && !(y == 0 && x > radius) && distanceBetweenCenterAndPoint <= radius) 
				{
					isInsideCircle = true;
				}

				Console.WriteLine ("Inside? - {0}", isInsideCircle);

			}
		}

		public static double CalculateDistanceFromCenter (double x, double y)
		{
			double cathetus1 = x;
			double cathetus2 = y;

			// Using the Pytagorean Theorem to find the distance between the center of the circle and the point.
			// If the distance is greater than the radius, point is out of the circle.
			// The Hypotenuse is the actual distance between the center and the point (x, y)
			double hypotenuse = Math.Sqrt((cathetus1 * cathetus1) + (cathetus2 * cathetus2));

			// Return the distance.
			return hypotenuse;
		}
	}
}
