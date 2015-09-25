using System;

namespace Problem_13__Triangle
{
	class Tirangle
	{
		public static void Main ()
		{
			// Input...
			short ax = short.Parse(Console.ReadLine());
			short ay = short.Parse(Console.ReadLine());
			short bx = short.Parse(Console.ReadLine());
			short by = short.Parse(Console.ReadLine());
			short cx = short.Parse(Console.ReadLine());
			short cy = short.Parse(Console.ReadLine());

			// Check distance between points...
			double ab = Math.Sqrt (((bx - ax) * (bx - ax)) + ((by - ay) * (by - ay)));
			double bc = Math.Sqrt (((cx - bx) * (cx - bx)) + ((cy - by) * (cy - by)));
			double ac = Math.Sqrt (((cx - ax) * (cx - ax)) + ((cy - ay) * (cy - ay)));

			// Some bools to make it easier...
			bool compareABtoC = ab + bc > ac;
			bool compareACtoB = ab + ac > bc;
			bool compareBCtoA = bc + ac > ab;

			if (compareABtoC && compareACtoB && compareBCtoA) 
			{
				double p = (ab + bc + ac) / 2;
				double area = Math.Sqrt(p * (p - ab) * (p - bc) * (p - ac));
				Console.WriteLine ("Yes\n{0:0.00}", area);
			}
			else 
			{
				Console.WriteLine ("No\n{0:0.00}", ab);
			}
		}
	}
}
