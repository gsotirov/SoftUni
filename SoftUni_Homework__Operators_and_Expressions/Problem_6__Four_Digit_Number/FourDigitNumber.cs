using System;

namespace Problem_6__Four_Digit_Number
{
	class FourDigitNumber
	{
		public static void Main ()
		{
			Console.WriteLine ("Please insert a 4-digit number:");
			int inputNumber = int.Parse (Console.ReadLine());

			int sum = CalculateSumOfDigits (inputNumber);
			string reversed = ReverseNumber (inputNumber);
			string lastDigFront = PutLastDigitInFront (inputNumber);
			string secondThirdExhanged = ExchangeSecondThirdDigit (inputNumber);

			Console.WriteLine ("\n=== {0} ===\nSum: {1}\nReversed: {2}\nLast Digit In Front: {3}\nSecond and Third Digits Exchanged: {4}", inputNumber, sum, reversed, lastDigFront, secondThirdExhanged);
		}

		public static int CalculateSumOfDigits (int inputNumber)
		{
			int sum = 0;

			while (inputNumber > 0) 
			{
				sum += inputNumber % 10;
				inputNumber /= 10;
			}

			return sum;
		}

		public static string ReverseNumber (int inputNumber)
		{
			string reversed = "";

			while (inputNumber > 0) 
			{
				reversed += "" + inputNumber % 10;
				inputNumber /= 10;
			}

			return reversed;
		}

		public static string PutLastDigitInFront (int inputNumber)
		{
			char[] digits = inputNumber.ToString().ToCharArray();
			int len = digits.Length;
			string output = "";

			for (int i = 0; i < len; i++) 
			{
				if (i == 0) 
				{
					output += digits [digits.Length - 1 - i];
				}
				else 
				{
					output += digits [i - 1];
				}
			}

			return output;
		}

		public static string ExchangeSecondThirdDigit (int inputNumber)
		{
			char[] digits = inputNumber.ToString().ToCharArray();
			int len = digits.Length;

			char temp = digits [1];
			digits [1] = digits [2];
			digits [2] = temp;

			return new String (digits);
		}
	}
}
