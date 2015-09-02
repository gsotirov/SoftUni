using System;
using Mono.Math; // For the BigInteger! Use the equivalent for Windows and it should work just fine.

namespace SoftUni_Homework__Math_For_Programmers
{
	class Start
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Problem 1:\nFind the 24th, 101st and 251st prime number.");
			TaskPrimeNumbers pn = new TaskPrimeNumbers ();
			pn.FindSpecificPrimes (24, 101, 251);

			Console.WriteLine (new String('=', 20) + "\n");

			Console.WriteLine("Problem 2:\nCheck if the 24th, 101st and 251st prime numbers are part of the base Fibonacci number set. What is their position?");
			TaskPrimesInFibonacci pf = new TaskPrimesInFibonacci ();
			pf.CheckIfPrimesAreInFibonacci (24, 101, 251); // Try with 1, 101, 251

			Console.WriteLine (new String('=', 20) + "\n");

			Console.WriteLine("Problem 3:\nFind 100!, 171! and 250!. Give all digits");
			TaskFactorials f = new TaskFactorials ();
			BigInteger fact1 = f.FindFactorial (100);
			BigInteger fact2 = f.FindFactorial (171);
			BigInteger fact3 = f.FindFactorial (250);
			Console.WriteLine ("100! = {0}\n171! = {1}\n250! = {2}\n", fact1, fact2, fact3);

			Console.WriteLine (new String('=', 20) + "\n");

			Console.WriteLine ("Problem 4:\nYou are given three right angled triangles. Find the length of their hypotenuses.");
			TaskHypotenuses h = new TaskHypotenuses ();
			h.FindHypotenuses (3, 4);
			h.FindHypotenuses (10, 12);
			h.FindHypotenuses (100, 250);

			Console.WriteLine (new String('=', 20) + "\n");

			Console.WriteLine ("Problem 5:\nNumeral System Convertions.");
			TaskNumeralSystems ns = new TaskNumeralSystems ();
			string decToBin = ns.ConvertDecToBinary (1234);
			string decToHex = ns.ConvertDecToHex (1234);
			int binToDec = ns.ConvertBinToDecimal ("1100101");
			string binToHex = ns.ConvertBinToHex ("1100101");
			int hexToDec = ns.ConvertHexToDecimal ("ABC");
			string hexToBin = ns.ConvertHexToBinary ("ABC");

			Console.WriteLine ("1234 to Binary: {0}", decToBin);
			Console.WriteLine ("1234 to Hex: {0}", decToHex);
			Console.WriteLine ("1100101 to Decimal: {0}", binToDec);
			Console.WriteLine ("1100101 to Hex: {0}", binToHex);
			Console.WriteLine ("ABC to Decimal: {0}", hexToDec);
			Console.WriteLine ("ABC to Binary: {0}", hexToBin);

			Console.WriteLine (new String('=', 20) + "\n");

			Console.WriteLine ("Problem 6:\nLeast Common Multiple");
			TaskLeastCommonMultiple lcm = new TaskLeastCommonMultiple ();
			int leastCommonMultiple = lcm.FindLCM (1234, 3456);
			Console.WriteLine ("The LCM of 1234 and 3456 is: {0}", leastCommonMultiple);
		}
	}
}
