using System;
using System.Collections.Generic;

namespace Problem_6__PrintNumbers
{
	class PrintNumbers
	{
		public static void Main ()
		{
			int num = 1; // The initial value of num is 1...
			int sumNum = 100; // Initialize the number that will be added to num each loop iteration...

			int[] numbers = new int[3]; // Create an array to store the output...
			int index = 0; // Initialize the index for the array, so the numbers to be stored properly...

			while (num < 1002)
			{
				numbers[index] = num; // Store the first value of num(1) in the array on position index(0)
				num += sumNum; // Add sumNum to it, so the second value becomes 101
				sumNum *= 9; // Multiply the sumNum by 9 to prepare it for the next add to num
				index++; // Increment the index so the next number is stored in the next array position
			}

			// Print the numbers on the Console...
			foreach (int number in numbers) 
			{
				Console.WriteLine ("{0}", number);
			}
		}
	}
}
