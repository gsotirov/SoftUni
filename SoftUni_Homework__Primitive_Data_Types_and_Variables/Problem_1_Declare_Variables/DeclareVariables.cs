using System;

namespace Problem_1_Declare_Variables
{
	class DeclareVariables
	{
		public static void Main ()
		{
			// Variable declaration...
			ushort number1 = 52130;
			sbyte number2 = -115;
			int number3 = 4825932;
			sbyte number4 = 97;
			short number5 = -10000;

			Console.WriteLine ("{0} -> ushort\n{1} -> sbyte\n{2} -> int\n{3} -> sbyte\n{4} -> short", number1, number2, number3, number4, number5);
		}
	}
}
