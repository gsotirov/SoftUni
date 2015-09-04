using System;

namespace Problem_18_NineDigit_Magic_Number
{
	class NineDigitMagicNumber
	{
		public static void Main ()
		{
			int sum = int.Parse(Console.ReadLine());
			int diff = int.Parse(Console.ReadLine());
			int count = 0;
			int s = 111;
			int e = 777;
			int firstNumber = s;

			while (firstNumber <= e) 
			{
				int secondNumber = diff + firstNumber;
				int thirdNumber = diff + secondNumber;

				int firstSum = CalculateDigitSum (firstNumber);
				int secondSum = CalculateDigitSum (secondNumber);
				int thirdSum = CalculateDigitSum (thirdNumber);

				// Add some checks here...
				bool checkThirdNum = thirdNumber <= e;
				bool checkSum = (firstSum + secondSum + thirdSum) == sum;
				bool checkDigits = CheckIfDigitsAllowed (firstNumber) && CheckIfDigitsAllowed (secondNumber) && CheckIfDigitsAllowed (thirdNumber);

				// Check if the number meet the requirements...

				if (checkDigits && checkThirdNum && checkSum)
				{
					// If they DO, print them on the console...
					Console.WriteLine ("{0}{1}{2}", firstNumber, secondNumber, thirdNumber);
					count++;
				}
				firstNumber++;
			}
			if (count == 0) 
			{
				Console.WriteLine ("No");
			}
		}

		static bool CheckIfDigitsAllowed (int number)
		{
			bool allowed = true;
			int len = number.ToString().Length;

			for (int i = 0; i < len; i++) 
			{
				int digit = number % 10;
				if (digit < 1 || digit > 7)
				{
					allowed = false;
				}
				number /= 10;
			}

			return allowed;
		}

		static int CalculateDigitSum (int number)
		{
			int sum = 0;
			while(number > 0)
			{
				sum += number % 10;
				number /= 10;
			}
			return sum;
		}
	}
}
