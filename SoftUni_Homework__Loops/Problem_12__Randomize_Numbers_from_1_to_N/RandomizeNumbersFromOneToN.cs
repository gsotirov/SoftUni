using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_12__Randomize_Numbers_from_1_to_N
{
	class RandomizeNumbersFromOneToN
	{
		public static void Main ()
		{
			// Get the input...
			Console.WriteLine ("Please enter N:");
			string input = Console.ReadLine();
			int n;

			// A little input check :)
			while (!int.TryParse(input, out n) || n < 0)
			{
				Console.WriteLine ("Please enter a valid N:");
				input = Console.ReadLine ();
			}

			// Initialize an array and store the values from 1 to N in it...
			int[] numbers = new int[n];
			for (int i = 0; i < n; i++) 
			{
				numbers [i] = i + 1;
			}

			// Randomize the numbers and assign them to the randomized array...
			int[] randomized = RandomizeNumbers (numbers);

			// Print the result on the console...
			Console.WriteLine ("\n--- Shuffled ---");
			for (int m = 0; m < randomized.Length; m++) 
			{
				Console.Write ("{0} ", randomized[m]);
			}
		}

		/*
		 * Method: @return RandomizeNumbers(@params);
		 * @params: int[] numbers -> array of numbers to shuffle;
		 * @returns: an Integer array holding the shuffled numbers;
		 */
		public static int[] RandomizeNumbers (int[] numbers)
		{
			// Initialize the randomizr...
			Random randomizr = new Random ();
			/* 
			 * Declare a List of type KeyValuePair<int, int>
			 * It will be responsible for holding a completely random values with random keys.
			 * Check the loop bellow.
			 */
			List<KeyValuePair<int, int>> randoms = new List<KeyValuePair<int, int>> ();

			/*
			 * Here we fill in the KeyValuePair List with the values from 1 to N, but at completely 
			 * random positions (Keys).
			 * Once done, it should look something like this:
			 * List of Key-Value Pairs:
			 * 1 pair = 4 -> 1;
			 * 2 pair = 43 -> 2;
			 * 3 pair = 5 -> 3;
			 * 4 pair = 26 -> 4;
			 * ...
			 * n pair = random key -> n;
			 */
			for (int i = 1; i <= numbers.Length; i++) 
			{
				randoms.Add(new KeyValuePair<int, int>(randomizr.Next(), i));
			}

			/*
			 * We already have the values with random Keys.
			 * Now we use Linq(you can google it, it's great :)) to make sure the Keys are sorted in an Acsending order.
			 * Once done, it will look like this:
			 * Sorted List:
			 * 1 pair = 4 -> 1;
			 * 2 pair = 5 -> 3;
			 * 3 pair = 26 -> 4;
			 * 4 pair = 43 -> 2;
			 * ...
			 * You can see that the values are now shuffled.
			 */
			var sorted = 
				from num in randoms
				orderby num.Key
				select num;

			// Create an Output array to store the values with proper indices...
			int[] output = new int[numbers.Length];

			int index = 0;
			foreach (KeyValuePair<int, int> number in sorted) 
			{
				// Fill in the Output array...
				output [index] = number.Value;
				index += 1;
			}

			// Return the Output array...
			return output;
		}
	}
}
