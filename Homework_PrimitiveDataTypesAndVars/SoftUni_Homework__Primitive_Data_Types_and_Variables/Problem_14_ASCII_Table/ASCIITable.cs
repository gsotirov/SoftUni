using System;

namespace Problem_14_ASCII_Table
{
	class ASCIITable
	{
		public static void Main ()
		{
			string output = "";

			for (int i = 0; i < 256; i++) 
			{
				char symbol = (char)i;
				output += (i != 255) ? symbol.ToString() + ", " : symbol.ToString();
			}
			Console.WriteLine ("--- ASCII Symbols ---\n{0}", output);
		}
	}
}
