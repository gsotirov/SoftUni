using System;
using System.Globalization;

namespace Problem_01__Difference_Between_Dates
{
	class DifferenceBetweenDates
	{
		public static void Main ()
		{
			CultureInfo provider = CultureInfo.InvariantCulture;
			DateTime startDate;
			DateTime endDate;

			try
			{
				startDate = DateTime.ParseExact(Console.ReadLine(), "d.MM.yyyy", provider);
				endDate = DateTime.ParseExact(Console.ReadLine(), "d.MM.yyyy", provider);
			}
			catch (FormatException fe)
			{
				Console.WriteLine("Error! {0}", fe.Message);
				return;
			}

			int daysBetween = GetDaysBetweenDates (startDate, endDate);

			Console.WriteLine ("Days difference - {0}", daysBetween);
		}

		public static int GetDaysBetweenDates (DateTime startDate, DateTime endDate)
		{
			TimeSpan diff = endDate.Subtract(startDate);
			return (int)diff.TotalDays;
		}
	}
}
