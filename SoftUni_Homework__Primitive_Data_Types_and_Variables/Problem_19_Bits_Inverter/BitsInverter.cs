using System;

namespace Problem_19_Bits_Inverter
{
	class BitsInverter
	{
		public static void Main ()
		{
			sbyte n = sbyte.Parse (Console.ReadLine());
			sbyte step = sbyte.Parse (Console.ReadLine());

			string bitsStr = "";

			for (int i = 0; i < n; i++) 
			{
				string byteStr = Convert.ToString(int.Parse (Console.ReadLine()), 2);
				if (byteStr.Length < 8) 
				{
					// Add 0s to bytes where necessary so they are with the proper length(8).
					byteStr = byteStr.PadLeft (8, '0');
				}
				bitsStr += byteStr;
			}

			int len = bitsStr.Length;
			string output = "";


			for (int j = 0; j < len; j++) 
			{
				char digit = bitsStr[j];

				if (j == 0 || j % step == 0) 
				{
					digit = (digit == '0') ? '1' : '0';
				}

				output += digit;

				if (output.Length == 8) 
				{
					Console.WriteLine(Convert.ToInt32(output, 2));
					output = "";
				}
			}
		}
	}
}
