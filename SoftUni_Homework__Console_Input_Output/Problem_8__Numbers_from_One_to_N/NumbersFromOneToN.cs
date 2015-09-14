using System;

namespace Problem_8__Numbers_from_One_to_N
{
	class NumbersFromOneToN
	{
		public static void Main ()
		{
			Console.WriteLine ("Please enter N (length of the sequence):");
			int n;
			bool checkInput = int.TryParse(Console.ReadLine(), out n);

			if (checkInput) 
			{
				for (int i = 1; i <= n; i++) 
				{
					Console.WriteLine (i);
				}
			} 
			else 
			{
				Console.WriteLine ("Invalid length of the sequence!!!");
			}
		}
	}
}
