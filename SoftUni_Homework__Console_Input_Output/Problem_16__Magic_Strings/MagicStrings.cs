using System;
using System.Collections.Generic;

namespace Problem_16__Magic_Strings
{
	class MagicStrings
	{
		public static void Main ()
		{
			// ============================================================================
			//  100/100 according to the Judge. With some help from the author's solution!
			// ============================================================================
			int diff = int.Parse (Console.ReadLine());
			char[] letters = {'k', 'n', 'p', 's'};
			int len = letters.Length;
			List<string> result = new List<string> ();


			for (int a = 0; a < len; a++) 
			{
				for (int b = 0; b < len; b++) 
				{
					for (int c = 0; c < len; c++) 
					{
						for (int d = 0; d < len; d++) 
						{
							string combinationOfLeftLetters = "" + letters [a] + letters [b] + letters [c] + letters [d];
							int leftWeight = CalculateLettersWeight (combinationOfLeftLetters);

							for (int e = 0; e < len; e++) 
							{
								for (int f = 0; f < len; f++) 
								{
									for (int g = 0; g < len; g++) 
									{
										for (int h = 0; h < len; h++) 
										{
											string combinationOfRightLetters = "" + letters [e] + letters [f] + letters [g] + letters [h];
											int rightWeight = CalculateLettersWeight (combinationOfRightLetters);
											if (Math.Abs (leftWeight - rightWeight) == diff) 
											{
												result.Add (combinationOfLeftLetters + combinationOfRightLetters);
											}
										}
									}
								}
							}
						}
					}
				}
			}

			if (result.Count > 0) 
			{
				foreach (var magicStr in result) 
				{
					Console.WriteLine (magicStr);
				}
			}
			else 
			{
				Console.WriteLine ("No");
			}
		}

		static int CalculateLettersWeight (string combinationOfLetters)

		{
			int weight = 0;

			for (int i = 0; i < combinationOfLetters.Length; i++) 
			{
				switch (combinationOfLetters [i]) 
				{
					case 's':
						weight += 3;
					break;
					case 'n':
						weight += 4;
					break;
					case 'k':
						weight += 1;
					break;
					case 'p':
						weight += 5;
					break;
				}
			}

			return weight;
		}
	}
}
