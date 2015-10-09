using System;
using System.Collections.Generic;

namespace Problem_03__Longest_Area_in_Array
{
	class LongestAreaInArray
	{
		public static void Main ()
		{
			int n;
			string[] stringsArray;

			// Checking for errors...
			try
			{
				n = int.Parse(Console.ReadLine());
				stringsArray = new string[n];
			}
			catch(Exception e)
			{
				if(e is FormatException)
				{
					Console.WriteLine ("\n--- Format Exception ---\n{0}", e.Message);
				}
				else if(e is OverflowException)
				{
					Console.WriteLine ("\n--- Overflow Exception ---\n{0}", e.Message);
				}
				else
				{
					Exception ue = new Exception ("Unknown exception thrown!");
					Console.WriteLine ("\n--- {0} ---\nPlease try again entering proper integer value!", ue.Message);
				}
				return;
			}

			// Filling in the array of strings...
			for (int i = 0; i < n; i++) 
			{
				stringsArray [i] = Console.ReadLine ();
			}

			// Find the longest equal area in the array of strings...
			List<string> longestArea = FindLongestAreaOfEqualsStrings (stringsArray);

			// Print the result on the console...
			PrintStringsOnConsole ("Longest Area in Array of Strings", longestArea);
		}

		public static List<string> FindLongestAreaOfEqualsStrings (string[] stringsArray)
		{
			int arrlen = stringsArray.Length;
			int currentSeqLen = 1;
			int bestLen = 1;
			string bestStrSoFar = "";

			for (int i = 1; i < arrlen; i++) 
			{
				if(String.Equals(stringsArray[i], stringsArray[i - 1]))
				{
					currentSeqLen++;
					if(currentSeqLen > bestLen)
					{
						bestLen = currentSeqLen;
						bestStrSoFar = stringsArray [i];
					}
				}
				else
				{
					currentSeqLen = 1;
				}
			}

			List<string> output = new List<string> ();
			if(bestLen == 1)
			{
				output.Add(stringsArray [0]);
			}
			else
			{
				for (int j = 0; j < bestLen; j++) 
				{
					output.Add(bestStrSoFar);
				}
			}
			return output;
		}

		public static void PrintStringsOnConsole (string printMsg, List<string> longestArea)
		{
			Console.WriteLine ("\n--- {0} ---", printMsg);
			Console.WriteLine (longestArea.Count);
			foreach (string str in longestArea) 
			{
				Console.WriteLine (str);
			}
		}
	}
}
