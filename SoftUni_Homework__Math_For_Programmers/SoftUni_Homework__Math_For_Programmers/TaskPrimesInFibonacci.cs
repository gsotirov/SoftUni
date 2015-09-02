using System;

namespace SoftUni_Homework__Math_For_Programmers
{
	public class TaskPrimesInFibonacci
	{
		public TaskPrimesInFibonacci()
		{
		}

		public int[] FindSpecificPrimes(int f, int s, int t)
		{

			int prime = 1;
			int counter = 4;

			int[] primes = new int[5000];
			int[] output = new int[3];

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
			output [0] = primes [f - 1];
			output [1] = primes [s - 1];
			output [2] = primes [t - 1];

			return output;
		}

		public void CheckIfPrimesAreInFibonacci(int f, int s, int t)
		{
			int[] fibNums = new int[10000];
			int[] specificPrimes = this.FindSpecificPrimes (f, s, t);
			int counter = 2;
			int a = 0;
			int b = 1;
			int c = 0;

			fibNums [0] = 0;
			fibNums [1] = 1;

			while (true) 
			{
				if(counter == 10000)
				{
					break;
				}

				c = a + b;
				a = b;
				b = c;

				fibNums [counter] = c;

				if (fibNums [counter] == specificPrimes [0]) 
				{
					Console.WriteLine ("{0} is in the Fibonacci sequence at position: {1}", specificPrimes[0], counter);
				} 
				else if (fibNums [counter] == specificPrimes [1]) 
				{
					Console.WriteLine ("{0} is in the Fibonacci sequence at position: {1}", specificPrimes[1], counter);
				} 
				else if (fibNums [counter] == specificPrimes [2]) 
				{
					Console.WriteLine ("{0} is in the Fibonacci sequence at position: {1}", specificPrimes[2], counter);
				}
				counter++;
			}
		}
	}
}
