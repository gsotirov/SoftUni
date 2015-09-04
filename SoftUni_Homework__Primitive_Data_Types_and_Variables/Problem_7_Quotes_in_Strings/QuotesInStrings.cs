using System;

namespace Problem_7_Quotes_in_Strings
{
	class QuotesInStrings
	{
		public static void Main ()
		{
			string withQuoted = "The \"use\" of quotations causes difficulties.";
			string withoutQuoted = @"The ""use"" of quotations causes difficulties.";

			Console.WriteLine (withQuoted);
			Console.WriteLine (withoutQuoted);
		}
	}
}
