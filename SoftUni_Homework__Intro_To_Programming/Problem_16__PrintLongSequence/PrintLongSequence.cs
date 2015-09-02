using System;

namespace Problem_16__PrintLongSequence
{
	class PrintLongSequence
	{
		public static void Main ()
		{
			Console.WriteLine ("Please enter the length of the sequence:");
			int len;
			string input = Console.ReadLine ();
			bool checkInput = int.TryParse (input, out len);

			if (checkInput && len > 0) 
			{
				string output = "";

				for (int i = 2; i <= len; i++) {
					int num = (i % 2 == 0) ? i : (i * (-1));
					output += (i != (len)) ? num + ", " : num.ToString ();
				}
				Console.WriteLine ("{0}", output);
			} 
			else 
			{
				Console.WriteLine ("Please enter a valid length of the sequence! It should be a 32 bit positive Intereger!");
			}
		}
	}
}
