using System;

namespace Compound_Interest
{
	class CompoundInterest
	{
		public static void Main ()
		{
			double p = double.Parse (Console.ReadLine());
			int y = int.Parse (Console.ReadLine());
			double i = double.Parse (Console.ReadLine());
			double f = double.Parse (Console.ReadLine());

			double bankLoan = p * Math.Pow ((1 + i), y);
			double friendsLoan = p * (1 + f);

			// Check which loan is cheaper...
			if (bankLoan < friendsLoan) {
				Console.WriteLine ("{0:0.00} Bank", bankLoan);
			} 
			else 
			{
				Console.WriteLine ("{0:0.00} Friend", friendsLoan);
			}
		}
	}
}