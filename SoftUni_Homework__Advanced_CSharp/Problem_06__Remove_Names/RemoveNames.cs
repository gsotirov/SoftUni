using System;
using System.Collections.Generic;

namespace Problem_06__Remove_Names
{
	class RemoveNames
	{
		public static void Main ()
		{
			List<string> words = new List<string> (Console.ReadLine ().Split(' '));
			List<string> blackList = new List<string> (Console.ReadLine ().Split(' '));

			// Filter list...
			FilterBlacklisted (ref words, blackList);

			// Print the filtered list on the console...
			PrintList (words);
		}

		public static void FilterBlacklisted (ref List<string> words, List<string> blackList)
		{
			for (int i = 0; i < blackList.Count; i++) 
			{
				words.RemoveAll(x => x == blackList[i]);
			}
		}

		public static void PrintList (List<string> words)
		{
			Console.WriteLine ("\n--- Remove Names ---\n");
			if(words.Count > 0)
			{
				foreach (string word in words) 
				{
					Console.Write ("{0} ", word);
				}
			}
			else
			{
				Console.WriteLine ("No words left to display!");
			}
		}
	}
}
