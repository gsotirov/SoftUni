using System;

namespace Problem_2__Gravitation_on_the_Moon
{
	class GravitationOnTheMoon
	{
		public static void Main ()
		{
			double weightOnEarth = double.Parse (Console.ReadLine());
			const double moonWeightPercentage = 17 / 100.0;
			double weightOnMoon = weightOnEarth * moonWeightPercentage;

			Console.WriteLine (weightOnMoon);
		}
	}
}
