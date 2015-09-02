using System;

namespace Problem_10__ReformatCSharpCode
{
	class ReformatCSharpCode
	{
		public static void Main ()
		{
			Console.WriteLine ("Hi, I was a horribly formatted program, now I'm great :)");
			Console.WriteLine ("Numbers and squares:");

			for (int i = 0; i < 10; i++) 
			{
				Console.WriteLine ("{0} ---> {1}", i, i * i);
			}
		}
	}
}
