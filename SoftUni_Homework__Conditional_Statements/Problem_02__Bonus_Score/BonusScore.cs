using System;

namespace Problem_02__Bonus_Score
{
	class BonusScore
	{
		public static void Main ()
		{
			int score = int.Parse (Console.ReadLine());

			if (score > 0 && score < 10)
			{
				AmendScore (ref score);
				Console.WriteLine (score);
			}
			else
			{
				Console.WriteLine ("invalid score");
			}
		}

		// Amends the score var by its reference.
		public static void AmendScore (ref int score)
		{
			if (score >= 1 && score <= 3)
			{
				score *= 10;
			}
			if (score >= 4 && score <= 6)
			{
				score *= 100;
			}
			if (score >= 7 && score <= 9) 
			{
				score *= 1000;
			}
		}
	}
}
