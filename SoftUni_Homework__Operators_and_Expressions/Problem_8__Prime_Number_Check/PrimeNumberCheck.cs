using System;

namespace Problem_8__Prime_Number_Check
{
	class PrimeNumberCheck
	{
		public static void Main ()
		{
			int number = int.Parse (Console.ReadLine());

			bool isNumberPrime = CheckIfPrime (number);

			Console.WriteLine ("Is Prime? - {0}", isNumberPrime);
		}

		public static bool CheckIfPrime (int number)
		{
			if (number < 0)
			{
				return false;
			}

			// Set a limit to save time.
			int limit = (int)(Math.Floor (Math.Sqrt (number)));

			if (number == 1) 
			{
				return false;
			}
			else if (number == 2) 
			{
				return true;
			}
			else if (number % 2 == 0)
			{
				return false;
			}
			else 
			{
				for (int i = 2; i <= limit; ++i) 
				{
					if (number % i == 0) 
					{
						return false;
					}
				}
			}
			return true;
		}
	}
}
