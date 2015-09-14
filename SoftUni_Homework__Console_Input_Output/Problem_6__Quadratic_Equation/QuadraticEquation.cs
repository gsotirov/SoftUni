using System;

namespace Problem_6__Quadratic_Equation
{
	class QuadraticEquation
	{
		public static void Main ()
		{
			Console.WriteLine ("===== Quadratic Equation =====\n");

			Console.WriteLine ("\nPlease specify 'a': ");
			decimal a = decimal.Parse(Console.ReadLine ());
			Console.WriteLine ("Please specify 'b': ");
			decimal b = decimal.Parse (Console.ReadLine());
			Console.WriteLine ("Please specify 'c': ");
			decimal c = decimal.Parse (Console.ReadLine());

			bool hasRealRoots = CheckIfHasRealRoots (a, b, c);

			if (hasRealRoots) 
			{
				decimal firstRoot = FindFirstRoot (a, b, c);
				decimal secondRoot = FindSecondRoot (a, b, c);

				string output = (firstRoot == secondRoot) ? "x1=x2=" + firstRoot : "x1=" + firstRoot + ";x2=" + secondRoot;

				Console.WriteLine (output);
			} 
			else 
			{
				Console.WriteLine ("No real roots");
			}
		}

		public static decimal FindFirstRoot (decimal a, decimal b, decimal c)
		{
			decimal bNeg = (-1) * b;
			decimal discriminant = (decimal)(Math.Pow ((double)b, 2) - (double)(4 * a * c));
			decimal squareRootOfDiscriminant = (decimal)Math.Sqrt ((double)discriminant);

			return (bNeg - squareRootOfDiscriminant) / (2 * a);
		}

		public static decimal FindSecondRoot (decimal a, decimal b, decimal c)
		{
			decimal bNeg = (-1) * b;
			decimal discriminant = (decimal)(Math.Pow ((double)b, 2) - (double)(4 * a * c));
			decimal squareRootOfDiscriminant = (decimal)Math.Sqrt ((double)discriminant);

			return (bNeg + squareRootOfDiscriminant) / (2 * a);
		}

		public static bool CheckIfHasRealRoots (decimal a, decimal b, decimal c)
		{
			decimal discriminant = (decimal)(Math.Pow ((double)b, 2) - (double)(4 * a * c));

			return (discriminant >= 0);
		}
	}
}
