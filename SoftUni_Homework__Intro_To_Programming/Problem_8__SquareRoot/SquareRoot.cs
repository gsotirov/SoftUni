using System;

namespace Problem_8__SquareRoot
{
	class SquareRoot
	{
		public static void Main ()
		{
			Console.WriteLine ("Please enter a number to see its square root:");

			double number;
			string input = Console.ReadLine ();
			bool checkInput = double.TryParse (input, out number);

			if (checkInput) {
				double output = Math.Sqrt (number);
				Console.WriteLine ("The square root of {0} is {1}", number, output);
			} 
			else 
			{
				Console.WriteLine ("Please enter a valid number!");
			}
		}
	}
}
