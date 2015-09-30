using System;

namespace Problem_19__Spiral_Matrix
{
	class SpiralMatrix
	{
		public static void Main ()
		{
			// Get the input...
			Console.WriteLine ("Please enter N:");
			string input = Console.ReadLine ();
			int n;

			// Input check...
			while (!int.TryParse(input, out n) || n < 1 || n > 20)
			{
				Console.WriteLine ("Please enter a valid N (1 - 20)");
				input = Console.ReadLine ();
			}
				
			// The magic...
			int sLen = n * n;
			int[,] spiral = new int[n, n];
			int x = 0;
			int y = 0;
			int dir = 0;
			int count = n;
			int steps = 1;
			int dirChange = 0;

			for (int i = 1; i <= sLen; i++) 
			{
				// Fill in the proper matrix cell with the next num 'i'
				spiral [y, x] = i; 

				// Check for length exceeding...
				if (steps < count) // 
				{
					// Inc the step with 1 after we've made sure 
					// that the steps taken do not exceed the length.
					steps++; 
				}
				else 
				{
					// Set steps back to 1
					steps = 1;

					// Here we check whether to decrement the count as
					// Every two direction changes we should do that.
					if (dirChange == 0)
					{
						count--;
					}

					// Checking whether we have 2 dir changes already, so to 
					// decrement the count...
					dirChange = (dirChange + 1) % 2;

					// Setting the direction. There are 4 directions, so we check by MOD4
					dir = (dir + 1) % 4;
				}

				// Switching to the next cell that needs to be filled in...
				MoveToCell (dir, ref x, ref y);
			}
			// Print the matrix on the console...
			PrintMatrixOnConsole (spiral);
		}

		public static void MoveToCell (int dir, ref int x, ref int y)
		{
			// Checks the direction to determine the values of X and Y, 
			// so the correct cell is filled in after the next iteration...
			switch (dir)
			{
			case 0:
				x++; // Right
				break;
			case 1:
				y++; // Down
				break;
			case 2:
				x--; // Left
				break;
			case 3:
				y--; // Up
				break;
			}
		}

		public static void PrintMatrixOnConsole (int[,] spiral)
		{
			Console.WriteLine ("\n--- Spiral ---\n");
			for (int row = 0; row < spiral.GetLength(0); row++) 
			{
				for (int col = 0; col < spiral.GetLength(1); col++) 
				{
					string pNum = spiral [row, col].ToString ().PadLeft (3, ' ');
					Console.Write ("{0} ", pNum);
				}
				Console.WriteLine ();
			}
		}
	}
}
