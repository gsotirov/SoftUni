using System;

namespace Problem_17__Volleyball
{
	class Volleyball
	{
		public static void Main ()
		{
			// ===================================
			//  100/100 according to the Judge
			// ===================================
			string yearType = Console.ReadLine ();
			int holidays = int.Parse (Console.ReadLine());
			int hometownWeekends = int.Parse (Console.ReadLine());

			const int totalWeekends = 48;
			const double weekendsNotAtWorkPer = 3 / 4.0;
			const double leapYearPer = 15 / 100.0;
			const double holidaysPer = 2 / 3.0;

			int normalWeekends = totalWeekends - hometownWeekends;

			double plays = 0;
			plays += hometownWeekends;
			plays += normalWeekends * weekendsNotAtWorkPer;
			plays += holidays * holidaysPer;
			if (yearType == "leap") 
			{
				plays += plays * leapYearPer;
			}
			int totalPlays = (int)Math.Floor (plays);

			Console.WriteLine (totalPlays);
		}
	}
}
