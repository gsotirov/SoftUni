using System;

namespace Problem_04__Matrix_of_Palindromes
{
	class MatrixOfPalindromes
	{
		public static void Main ()
		{
			int rows = 0;
			int cols = 0;

			// Check input
			try
			{
				rows = int.Parse(Console.ReadLine());
				cols = int.Parse(Console.ReadLine());
			}
			catch(Exception e)
			{
				if(e is FormatException)
				{
					Console.WriteLine ("Format error! {0}", e.Message);
				}
				else if(e is OverflowException)
				{
					Console.WriteLine ("Overflow exception! {0}", e.Message);
				}
				else 
				{
					Exception ue = new Exception ("Unknown exception! Please try again with valid input!");
					Console.WriteLine (ue.Message);
				}
				return;
			}

			if((rows > 0 && cols > 0) && (rows < 14 && cols < 14))
			{

				// Create the matrix...
				string[,] matrixOfPalindromes = CreatePalindromeMatrix (rows, cols);

				// Print the matrix on the console...
				PrintMatrix (matrixOfPalindromes);
			}
			else
			{
				Console.WriteLine ("You must enter numbers between 1 and 13 inclusive!");
			}
		}

		public static string[,] CreatePalindromeMatrix (int rows, int cols)
		{

			char[] alphabet = { 
				'a', 'b', 'c', 'd', 'e', 'f',
				'g', 'h', 'i', 'j', 'k', 'l',
				'm', 'n', 'o', 'p', 'q', 'r',
				's', 't', 'u', 'v', 'w', 'x',
				'y', 'z'
			};

			string[,] palMatrix = new string[rows, cols];
			int x = 0;
			int y = 0;

			for (int i = 0; i < rows; i++) 
			{
				for (int j = i; j < cols + i; j++) 
				{
					palMatrix[x, y] += "" + alphabet[i] + alphabet[j] + alphabet[i];
					y++;
				}
				x++;
				y = 0;
			}

			return palMatrix;
		}

		public static void PrintMatrix (string[,] palMatrix)
		{
			Console.WriteLine ("\n---- Matrix of Palindromes ---\n");
			for (int row = 0; row < palMatrix.GetLength(0); row++) 
			{
				for (int col = 0; col < palMatrix.GetLength(1); col++) 
				{
					Console.Write ("{0} ", palMatrix[row, col]);
				}
				Console.WriteLine ();
			}
		}
	}
}
