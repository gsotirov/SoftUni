using System;
using Mono.Math;

 // For the BigInteger! Use the equivalent for Windows and it should work just fine.

namespace SoftUni_Homework__Math_For_Programmers
{
	public class TaskNumeralSystems
	{
		public TaskNumeralSystems()
		{
		}

		public string ConvertDecToBinary(int num)
		{
			return Convert.ToString (num, 2);
		}

		public string ConvertDecToHex(int num)
		{
			return num.ToString ("X");
		}

		public int ConvertBinToDecimal(string num)
		{
			return Convert.ToInt32 (num, 2);
		}

		public string ConvertBinToHex(string num)
		{
			return Convert.ToInt32("1011", 2).ToString("X");
		}

		public int ConvertHexToDecimal(string num)
		{
			return int.Parse(num, System.Globalization.NumberStyles.HexNumber);
		}

		public string ConvertHexToBinary(string num)
		{
			int dec = this.ConvertHexToDecimal (num);
			return this.ConvertDecToBinary (dec);
		}
	}

}
