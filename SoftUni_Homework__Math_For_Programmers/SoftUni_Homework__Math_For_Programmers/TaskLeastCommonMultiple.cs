using System;
using Mono.Math;

 // For the BigInteger! Use the equivalent for Windows and it should work just fine.

namespace SoftUni_Homework__Math_For_Programmers
{
	public class TaskLeastCommonMultiple
	{
		public TaskLeastCommonMultiple()
		{
		}

		public int FindLCM(int n1, int n2)
		{
			int firstNumber; 
			int secondNumber;

			if (n1 > n2)
			{
				firstNumber = n1; 
				secondNumber = n2;
			}
			else
			{
				firstNumber = n2; 
				secondNumber = n1;
			}

			for (int i = 1; i <= secondNumber; i++)
			{
				if ((firstNumber * i) % secondNumber == 0)
				{
					return i * firstNumber;
				}
			}
			return secondNumber;
		}
	}

}
