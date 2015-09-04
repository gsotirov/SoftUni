using System;

namespace Problem_12_Null_Value_Arithmetic
{
	class NullValueArithmetic
	{
		public static void Main ()
		{
			int? nullInteger = null;
			double? nullDouble = null;

			Console.WriteLine ("Null Integer: {0}\nNull double: {1}", nullInteger, nullDouble);

			int? resultOne = nullInteger + 24;
			double? resultTwo = nullDouble + null;

			Console.WriteLine ("Add 24 to the Null Integer: {0}\nAdd null to the Null double: {1}", resultOne, resultTwo);
		}
	}
}
