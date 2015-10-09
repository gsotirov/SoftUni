using System;

namespace Problem_08__Longest_Word_in_Text
{
	class LongestWordInText
	{
		public static void Main ()
		{
			string[] wordsInText = Console.ReadLine().Split(' ');
			int bestLen = 0;
			int currentLength = 0;
			string longestWord = "";

			for (int i = 1; i < wordsInText.Length; i++) 
			{
				currentLength = wordsInText [i].Length;
				if (currentLength > bestLen)
				{
					bestLen = currentLength;
					longestWord = wordsInText [i];
				}
			}

			Console.WriteLine ("\n --- Longest word in the text ---\n>>> {0}", longestWord);
		}
	}
}
