using System;

namespace Problem_16_Half_Sum
{
	class HalfSum
	{
		//===================================
		// 100 / 100 according to the Judge
		//===================================
		public static void Main ()
		{
			int n = int.Parse(Console.ReadLine());
			int sequenceLength = 2 * n;
			int leftSum = 0;
			int rightSum = 0;
			string output = "";

			for(int i = 0; i < sequenceLength; i++) 
			{
				if(i < n) 
				{
					leftSum += int.Parse(Console.ReadLine());
				} 
				else 
				{
					rightSum += int.Parse(Console.ReadLine());
				}
			}

			if (leftSum == rightSum) 
			{
				output = "Yes, sum=" + leftSum;
			} 
			else 
			{
				output = (leftSum < rightSum) ? "No, diff=" + (rightSum - leftSum) : "No, diff=" + (leftSum - rightSum);
			}

			Console.WriteLine(output);
		}
	}
}
