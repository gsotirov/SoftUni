using System;

namespace Problem_10__Odd_Even_Product
{
	class OddEvenProduct
	{
		public static void Main ()
		{
			string input = Console.ReadLine ();
			string[] numsStr = input.Split (' ');
			int oddProduct = 1;
			int evenProduct = 1;

			for (int i = 0; i < numsStr.Length; i++) 
			{
				if (i % 2 == 0)
				{
					evenProduct *= int.Parse (numsStr[i]);
				}
				else
				{
					oddProduct *= int.Parse (numsStr[i]);
				}
			}

			int diff = oddProduct - evenProduct;

			if (diff == 0) 
			{
				Console.WriteLine ("yes\nproduct = {0}", evenProduct);
			}
			else 
			{
				Console.WriteLine ("no\nodd_product = {0}\neven_product = {1}", oddProduct, evenProduct);
			}
		}
	}
}
