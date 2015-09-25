using System;

namespace Problem_03__Check_for_a_Play_Card
{
	class CheckForAPlayCard
	{
		public static void Main ()
		{
			string input = Console.ReadLine ();
			string[] cardsFaces = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

			string output = "No";

			for (int i = 0; i < cardsFaces.Length; i++) 
			{
				if (input == cardsFaces [i]) 
				{
					// Initialy the result is No. 
					// If the condition bellow is met, result becomes Yes, if not - stays No.
					output = "Yes";
				}
			}
			// Print the result on the console.
			Console.WriteLine (output);
		}
	}
}
