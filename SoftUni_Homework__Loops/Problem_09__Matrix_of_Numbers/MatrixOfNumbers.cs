using System;

namespace Problem_09__Matrix_of_Numbers
{
	class MatrixOfNumbers
	{
		public static void Main ()
		{
			Console.WriteLine ("Please enter N(1 <= n <= 20):");
			int n = int.Parse (Console.ReadLine());
			string output = "";

			for (int i = 1; i <= n; i++) 
			{
				for (int j = i; j < n + i; j++) 
				{
					output += (j < 10) ? " " + j + " " : j + " ";
				}
				output += "\n";
			}

			Console.WriteLine (output);
		}
	}
}
