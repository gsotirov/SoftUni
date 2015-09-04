using System;

namespace Problem_17_Sunglasses
{
	class Sunglasses
	{
		//===================================
		// 100 / 100 according to the Judge
		//===================================
		public static void Main ()
		{
			int n = int.Parse(Console.ReadLine());

			int framesHeight = n;
			int framesWidth = 2 * n;
			int lensWidth = framesWidth - 2;
			int blanks = n;
			int bridgeWidth = n;
			int bridgePos = (int)(Math.Floor ((double)framesHeight / 2) + 1);

			string output = "";

			for (int i = 1; i <= framesHeight; i++) 
			{
				if (i == 1 || i == (framesHeight)) 
				{
					output += new String('*', framesWidth) + new String(' ', blanks) + new String('*', framesWidth) + "\n";
				}
				else if (i == bridgePos) {
					output += "*" + new String ('/', lensWidth) + "*" + new String ('|', bridgeWidth) + "*" + new String ('/', lensWidth) + "*\n";
				} 
				else 
				{
					output += "*" + new String ('/', lensWidth) + "*" + new String (' ', blanks) + "*" + new String ('/', lensWidth) + "*\n";
				}
			}

			Console.WriteLine(output);
		}
	}
}
