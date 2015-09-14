using System;

namespace Problem_10__Fibonacci_Numbers
{
	class FibonacciNumbers
	{
		public static void Main ()
		{
			Console.WriteLine ("Please specify how many Fibonacci numbers you want to display: ");
			int n;

			while (!int.TryParse(Console.ReadLine(), out n))
			{
				Console.WriteLine ("Invalid number! Enter a valid Integer");
			}

			int a = 0;
			int b = 1;
			int c = 0;

			// Print the Fibonacci sequence on the Console.
			Console.Write ("Displayed {0} numbers of the Fibonacci sequence: \n---> ", n);
			Fibonacci (a, b, c, n);
		}

		// Recursive Fibonacci method.
		public static void Fibonacci (int a, int b, int c, int n)
		{
			// Set the stopping point of the recirsion to avoid big, big troubles :)
			if (c < n) 
			{
				// Fixing the digit-following comma...
				if (c == (n - 1)) 
				{
					Console.Write (a);
				} 
				else 
				{
					Console.Write (a + ", ");
				}

				// The method calls itself with changed params (Recursion).
				Fibonacci (b, a + b, ++c, n);
			}
		}
	}
}
