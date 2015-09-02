using System;

namespace Problem_15__AgeAfterTenYears
{
	class AgeAfterTenYears
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Please enter your current age:");
			int age;
			string output = Console.ReadLine ();
			bool checkInput = int.TryParse (output, out age);

			if (checkInput) {
				Console.WriteLine ("Your age in 10 years will be {0}", age + 10);
			} 
			else 
			{
				Console.WriteLine ("Please enter a valid current age!");
			}
		}
	}
}
