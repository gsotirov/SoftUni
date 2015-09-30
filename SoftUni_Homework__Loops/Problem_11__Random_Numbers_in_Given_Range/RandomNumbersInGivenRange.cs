using System;

namespace Problem_11__Random_Numbers_in_Given_Range
{
	class RandomNumbersInGivenRange
	{
		public static void Main ()
		{
			// Get the input...
			Console.WriteLine ("Please enter N:");
			int n = int.Parse (Console.ReadLine());
			Console.WriteLine ("Please enter Min:");
			int min = int.Parse (Console.ReadLine());
			Console.WriteLine ("Please enter Max:");
			int max = int.Parse (Console.ReadLine());

			// Initialize the randomizer...
			Random rand = new Random ();
			//Prepare the output container...
			string output = "";

			for (int i = 0; i < n; i++) 
			{
				output += rand.Next (min, max + 1) + " ";
			}

			// Print the result on the console...
			Console.WriteLine (output);
		}
	}
}
