using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_07__Join_Lists
{
	class JoinLists
	{
		public static void Main ()
		{
			List<string> left = new List<string> (Console.ReadLine ().Split (' '));
			List<string> right = new List<string> (Console.ReadLine ().Split (' '));

			// Join the lists...
			left.AddRange (right);

			// Convert them to INT and remove duplicates...
			List<int> numbers = left
				.Select (x => int.Parse (x)) // Convert to Int...
				.Distinct() // Remove Duplicates...
				.OrderBy(x => x) // Order acsending...
				.ToList(); // Convert to List.

			// Print the result on the console...
			PrintList (numbers);
		}

		public static void PrintList (List<int> numbers)
		{
			Console.WriteLine ("\n ---- Join Lists ----\n");
			foreach (int num in numbers) 
			{
				Console.Write ("{0} ", num);
			}
		}
	}
}
