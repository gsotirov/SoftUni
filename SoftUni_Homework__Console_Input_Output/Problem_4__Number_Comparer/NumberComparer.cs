using System;

namespace Problem_4__Number_Comparer
{
	class NumberComparer
	{
		public static void Main ()
		{
			int a = int.Parse (Console.ReadLine());
			int b = int.Parse (Console.ReadLine());

			// Check which is greater.
			int greater = CompareNumbers (a, b);

			// Print the result on the console.
			Console.WriteLine ("Greater: {0}", greater);
		}

		static int CompareNumbers (int a, int b)
		{
			int temp = a - b; // Store the value of a - b
			int k = (temp >> 31) & 1; // Check if result of a - b is negative, but checking the highest bit. If 1 - negative, if 0 - positive.
			int greater = a - k * temp; // Compare and assign the result to greater.

			return greater;
		}
	}
}
