using System;

namespace Problem_9__Sum_of_N_Numbers
{
	class SumOfNNumbers
	{
		public static void Main ()
		{
			Console.WriteLine ("Please enter N (length of the sequence):");
			int n;
			bool checkInput = int.TryParse(Console.ReadLine(), out n) && n > 0;

			if (checkInput) 
			{
				Console.WriteLine ("Please enter {0} numbers: ", n);

				decimal sum = 0;

				for (int i = 0; i < n; i++) 
				{
					int input;
					while (!int.TryParse(Console.ReadLine(), out input))
					{
						Console.WriteLine ("Invalid number! Enter a valid Integer");
					}

					sum += input;
				}

				Console.WriteLine ("Sum = {0}", sum);
			} 
			else 
			{
				Console.WriteLine ("Invalid length of the sequence!");
			}
		}
	}
}
