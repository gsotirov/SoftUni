using System;

namespace Problem_9__PrintSequence
{
	class PrintSequence
	{
		public static void Main ()
		{
			int len = 12;
			string output = "";

			for (int i = 2; i < len; i++) 
			{
				int num = (i % 2 == 0) ? i : (i * (-1));
				output += (i != (len - 1)) ? num + ", ": num.ToString();
			}
			Console.WriteLine ("{0}", output);
		}
	}
}