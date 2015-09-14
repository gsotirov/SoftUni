using System;

namespace Problem_11__Numbers_in_Interval_Divisible_by_Given_Number
{
	class NumbersInIntervalDivisibleByGivenNumber
	{
		public static void Main ()
		{
			Console.WriteLine ("Please specify the start and the end of the sequence: ");
			Console.WriteLine ("\nEnter Starting number: ");
			int start, end;

			bool validStart = int.TryParse (Console.ReadLine(), out start);
			bool validEnd = int.TryParse (Console.ReadLine(), out end);

			string output = "";

			if (validStart && validEnd) 
			{
				const int DIVIDER = 5; // Divider
				int counter = 0;

				for (int i = start; i < end; i++) 
				{
					if (i % DIVIDER != 0)
					{
						continue;
					}

					output += (i != (end - 1)) ? i + ", " : i.ToString();
					counter++;
				}
				Console.WriteLine ("\n==== Numbers between {0} and {1} that are divisible by {2} are exactly {3} \n---> {4}", start, end, DIVIDER, counter, output);
			}
			else 
			{
				Console.WriteLine ("Invalid Starting or Ending number!");
			}
		}
	}
}
