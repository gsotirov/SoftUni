using System;
using Mono.Math;

namespace Peters_Game
{
	class PetersGame
	{
		public static void Main ()
		{
			const int DIVIDER = 5;

			ulong startNumber = ulong.Parse (Console.ReadLine());
			ulong endNumber = ulong.Parse (Console.ReadLine());
			string replacementString = Console.ReadLine();

			BigInteger sum = 0;

			for (ulong i = startNumber; i < endNumber; i++) 
			{
				ulong numToSum = (i % DIVIDER == 0) ? i : i % DIVIDER;
				sum += numToSum;
			}

			bool sumEven = sum % 2 == 0;
			string sumStr = sum.ToString ();
			string digitToReplace = (sumEven) ? sumStr[0].ToString() : sumStr[sumStr.Length - 1].ToString();
			string output = sumStr.Replace(digitToReplace, replacementString);

			Console.WriteLine ("{0}", output);
		}
	}
}