using System;
using System.Collections.Generic;

namespace Problem_12__Zero_Subset
{
	class ZeroSubset
	{
		public static void Main ()
		{
			string[] input = Console.ReadLine ().Split (' ');
			List<int> numbers = new List<int> ();

			foreach (string numStr in input) 
			{
				numbers.Add (int.Parse(numStr));
			}

			int sum = 0;
			string subSeq = "";

			for (int i = 0; i < numbers.Count; i++) 
			{
				int sub = numbers [i];
				sum = sub;
				subSeq += sub + " ";

				for (int j = i + 1; j < numbers.Count; j++) 
				{
					int nextSub = numbers [j];
					sum += nextSub;
					subSeq += nextSub + " ";
					if (sum == 0)
					{
						Console.WriteLine (subSeq);
						sum = 0;
						subSeq = "";
					}
				}
				subSeq = "";
				sum = 0;
			}
		}

	}
}
