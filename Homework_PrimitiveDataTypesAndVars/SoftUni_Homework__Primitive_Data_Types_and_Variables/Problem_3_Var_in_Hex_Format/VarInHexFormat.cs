using System;

namespace Problem_3_Var_in_Hex_Format
{
	class VarInHexFormat
	{
		public static void Main ()
		{
			string num = "0xFE"; // 254 in Hex is 0xFE

			// Print it on the console, converted back to Int...
			Console.WriteLine (Convert.ToInt32(num, 16));
		}
	}
}
