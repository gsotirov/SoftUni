using System;

namespace Problem_15_Joro_Football_Player
{
	class JoroFootballPlayer
	{
		//===================================
		// 100 / 100 according to the Judge
		//===================================
		public static void Main ()
		{
			const sbyte weekendsInYear = 52; // Should always be 52.

			string leapYearOrNot = Console.ReadLine();
			ushort numberOfHolidays = ushort.Parse(Console.ReadLine());
			sbyte numberOfHometownWeekends = sbyte.Parse(Console.ReadLine());
			sbyte additionalLeapYearPlays = (sbyte)((leapYearOrNot == "t") ? 3 : 0);
			sbyte numberOfNormalWeekends = (sbyte)(weekendsInYear - numberOfHometownWeekends);

			double plays = 0;
			double playsInNormalWeekends = ((double)(numberOfNormalWeekends * 2) / 3);
			double playsInHolidays = ((double)numberOfHolidays / 2);

			plays += numberOfHometownWeekends;
			plays += playsInNormalWeekends;
			plays += additionalLeapYearPlays;
			plays += playsInHolidays;

			plays = Math.Floor (plays); // Round it up.

			Console.WriteLine (plays); // Print it on the console.
		}
	}
}
