using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace Problem_09__Extract_URLs_from_Text
{
	class ExtractURLsFromText
	{
		public static void Main ()
		{
			string text = Console.ReadLine ();

			// Find the URLs in the text, if any...
			List<string> urls = FindURLs (text);

			if (urls.Count > 0)
			{
				// Print the result on the console.
				PrintList (urls);
			}
			else
			{
				Console.WriteLine ("No URLs found in the text!");
			}
		}

		public static List<string> FindURLs (string text)
		{
			List<string> mathes = new List<string> ();

			// The pattern to check against.
			const string pattern = @"\b(?:https?://|www\.)\S+\b";

			// Set up the checker.
			Regex urlParser = new Regex (pattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);

			// Find matches and if any, add the to the urls list...
			foreach (Match mtc in urlParser.Matches(text)) 
			{
				mathes.Add (mtc.ToString());
			}

			return mathes;
		}

		public static void PrintList (List<string> urls)
		{
			Console.WriteLine ("\n ---- Extract URLs ----\n");
			foreach (var url in urls) 
			{
				Console.WriteLine ("{0} ", url);
			}
		}
	}
}