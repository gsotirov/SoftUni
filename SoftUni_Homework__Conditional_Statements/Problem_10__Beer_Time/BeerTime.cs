using System;
using System.Threading;
using System.Globalization;

namespace Problem_10__Beer_Time
{
	class BeerTime
	{
		public static void Main ()
		{
			long input = 0;

			try
			{
				input = Convert.ToDateTime (Console.ReadLine ()).Ticks;
			}
			catch (FormatException e)
			{
				Console.WriteLine (e.Message);
				return;
			}

			// Let's count the ticks between times.

			// There was an issue with the fact that 1pm should be calculated as a date before midnight(the day before)
			// and 3pm is after midnight, so on the next day.
			// Here's how I devided to fix it. There are better ways for sure...
			long midNight = Convert.ToDateTime ("00:00 AM").Ticks;
			long start = Convert.ToDateTime ("01:00 PM").Ticks;
			long end = Convert.ToDateTime ("03:00 AM").Ticks;

			bool isBeforeEndAfterMidnight = (input >= midNight) && (input < end);
			bool isAfterStartAfterMidnight = (input >= midNight) && (input >= start);

			// Checking if it's beer time already...
			if (isAfterStartAfterMidnight || isBeforeEndAfterMidnight) 
			{
				Console.WriteLine ("beer time");
			}
			else 
			{
				Console.WriteLine ("non-beer time");
			}
		}
	}
}
