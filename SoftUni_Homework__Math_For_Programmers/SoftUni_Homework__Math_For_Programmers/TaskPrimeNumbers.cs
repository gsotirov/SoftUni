using System;

namespace SoftUni_Homework__Math_For_Programmers
{
	public class TaskPrimeNumbers
	{
		public TaskPrimeNumbers ()
		{
		}

		public void FindSpecificPrimes(int f, int s, int t)
		{

			int prime = 8;
			int counter = 4;

			int[] primes = new int[5000];

			// Store the first primes...
			primes [0] = 2;
			primes [1] = 3;
			primes [2] = 5;
			primes [3] = 7;

			while (true) 
			{
				if (prime == 10000) 
				{
					break;
				}

				bool isDivByTwo = prime % 2 == 0;
				bool isDivByThree = prime % 3 == 0;
				bool isDivByFive = prime % 5 == 0;
				bool isDivBySeven = prime % 7 == 0;
				bool isDivBySelf = prime / prime == 1;

				if (!isDivByTwo && !isDivByThree && !isDivByFive && !isDivBySeven && isDivBySelf) 
				{
					primes [counter] = prime;
					counter += 1;
				}

				prime += 1;
			}
			Console.WriteLine ("The {0}th prime number is: {1}", f, primes[f - 1]);
			Console.WriteLine ("The {0}th prime number is: {1}", s, primes[s - 1]);
			Console.WriteLine ("The {0}th prime number is: {1}", t, primes[t - 1]);
		}
	}
}

