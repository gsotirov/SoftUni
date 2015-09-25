using System;

namespace Problem_04__Multiplication_Sign
{
	class MuliplicationSign
	{
		public static void Main ()
		{
			double firstNumber = double.Parse (Console.ReadLine());
			double secondNumber = double.Parse (Console.ReadLine());
			double thirdNumber = double.Parse (Console.ReadLine());
			char result = '0';

			// First we check if one or more numbers are 0. If so, the result is 0.
			if (firstNumber != 0 || secondNumber != 0 || thirdNumber != 0)
			{
				// As the task requires us to use sequence of IFs, here they are...

				// Check if all negative...
				bool allNegative = firstNumber < 0 && secondNumber < 0 && thirdNumber < 0;
				// Result should be NEGATIVE
				if (allNegative)
				{
					result = '-';
				}
				// Check if first two neg, last pos...
				bool firstSecondNegThirdPos = firstNumber < 0 && secondNumber < 0 && thirdNumber > 0;
				// Result should be POSITIVE
				if (firstSecondNegThirdPos)
				{
					result = '+';
				}
				// Check if first and third neg, second pos...
				bool firstThirdNegSecondPos = firstNumber < 0 && secondNumber > 0 && thirdNumber < 0;
				// Result should be POSITIVE
				if (firstThirdNegSecondPos)
				{
					result = '+';
				}
				// Check if first neg, second and third pos...
				bool firstNegSecondThirdPos = firstNumber < 0 && secondNumber > 0 && thirdNumber > 0;
				// Result should be NEGATIVE
				if (firstNegSecondThirdPos)
				{
					result = '-';
				}
				// Check if first pos, second and third neg...
				bool firstPosSecondThirdNeg = firstNumber > 0 && secondNumber < 0 && thirdNumber < 0;
				// Result should be POSITIVE
				if (firstPosSecondThirdNeg)
				{
					result = '+';
				}
				// Check if first and third pos, second neg...
				bool firstThirdPosSecondNeg = firstNumber > 0 && secondNumber < 0 && thirdNumber > 0;
				// Result should be NEGATIVE
				if (firstThirdPosSecondNeg)
				{
					result = '-';
				}
				// Check if first and second pos, third neg...
				bool firstSecondPosThirdNeg = firstNumber > 0 && secondNumber > 0 && thirdNumber < 0;
				// Result should be NEGATIVE
				if (firstSecondPosThirdNeg)
				{
					result = '-';
				}
				// Check if all positive...
				bool allPositive = firstNumber > 0 && secondNumber > 0 && thirdNumber > 0;
				// Result should be POSITIVE
				if (allPositive)
				{
					result = '+';
				}
				Console.WriteLine (result);
			}
		}
	}
}
