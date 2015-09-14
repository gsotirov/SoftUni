using System;

namespace Problem_13__Working_Hours
{
	class WorkingHours
	{
		public static void Main ()
		{
			// ==================================
			//  100/100 according to the Judge
			// ==================================
			uint requiredHours = uint.Parse(Console.ReadLine ());
			uint daysToFinishProject = uint.Parse(Console.ReadLine ());
			sbyte productivityInput = sbyte.Parse(Console.ReadLine ());

			const sbyte bikingTimePercent = 10;
			const sbyte dailyWorkingHours = 12;

			double biking = ((double)daysToFinishProject / 100) * (double)bikingTimePercent;
			double daysToWork = daysToFinishProject - biking;
			double maxProductiveWorkingHours = daysToWork * dailyWorkingHours;
			double productivity = (double)productivityInput / 100;
			int realProductiveHours = (int)(Math.Floor (maxProductiveWorkingHours * productivity));

			int difference = (int)realProductiveHours - (int)requiredHours;

			string output = (difference >= 0) ? "Yes\n" + difference : "No\n" + difference;

			Console.WriteLine (output);
		}
	}
}

