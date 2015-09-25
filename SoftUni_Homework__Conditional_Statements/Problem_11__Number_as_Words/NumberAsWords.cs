using System;

namespace Problem_11__Number_as_Words
{
	class NumberAsWords
	{
		public static void Main ()
		{
			Console.WriteLine ("Please enter an integer from 0 to 999 inclusive:");
			ushort number = 0;

			try
			{
				number = ushort.Parse (Console.ReadLine());
			}
			catch (Exception e)
			{
				if (e is FormatException)
				{
					Exception fe = new FormatException ("Error! Input was not in the correct format!");
					Console.WriteLine (fe.Message);
				}
				else if (e is OverflowException)
				{
					Exception oe = new OverflowException("Error! Input should be a positive 16-bit integer!");
					Console.WriteLine (oe.Message);
				}
				else 
				{
					Console.WriteLine ("Error occured!!!");
				}
				return;
			}

			if (number < 0 || number > 999)
			{
				Console.WriteLine ("Invalid Input! Number should be in the range 0 - 999!");
				return;
			}

			// Declare the output...
			string output = "";

			// Set some important values (I'll use arrays)...
			/*-------------------------------------------------*/
			// First array will store the names of the first 20 numbers (from 0 to 19).
			string[] singles = {
				"Zero", "One", "Two", 
				"Three", "Four", "Five", 
				"Six", "Seven", "Eight",
				"Nine", "Ten", "Eleven",
				"Twelve", "Thirteen", "Fourteen",
				"Fifteen", "Sixteen", "Seventeen",
				"Eighteen", "Nineteen"
			};
			// Second array will store the names of the decimals (20, 30, ..., 90).
			string[] decimals = {
				"Twenty", "Thirty", "Fourty",
				"Fifty", "Sixty", "Seventy",
				"Eighty", "Ninety"
			};

			// Here comes the Magic... :-)

			// Some bools to make it easier...
			bool isBetween0and19 = (number >= 0) && (number <= 19);
			bool isBetween19and99 = (number > 19) && (number <= 99);
			bool isBeween100and999 = (number >= 100) && (number <= 999);

			// Now, we have 3 cases...
			// Range(0-19), Range(19-99) and Range(100-999)

			// 0-19
			if (isBetween0and19)
			{
				output = TransformLowRangeNumber (number, singles);
			}
			// 19-99
			else if (isBetween19and99)
			{
				output = TransformMiddleRangeNumber (number, singles, decimals);
			}
			// 100-999
			else if (isBeween100and999)
			{
				output = TransformHighRangeNumber (number, singles, decimals);
			}

			Console.WriteLine (output);
		}

		public static string TransformLowRangeNumber (ushort number, string[] singles)
		{
			return singles [number];
		}

		public static string TransformMiddleRangeNumber (ushort number, string[] singles, string[] decimals)
		{
			ushort ones = (ushort)(number % 10);
			ushort decs = (ushort)((number / 10) % 10);

			return decimals [decs - 2] + " " + singles[ones].ToLower();
		}

		static string TransformHighRangeNumber (ushort number, string[] singles, string[] decimals)
		{
			ushort ones = (ushort)(number % 10);
			ushort decs = (ushort)((number / 10) % 10);
			ushort hunds = (ushort)((number / 100) % 10);

			if (number == 100) 
			{
				return singles[hunds] + " hundred";
			}

			if (decs < 2) 
			{
				ones += (ushort)(10 * decs);
				return singles [hunds] + " hundred and " + singles [ones].ToLower();
			}
			else 
			{
				return singles [hunds] + " hundred and" + decimals [decs - 2].ToLower() + " " + singles [ones].ToLower();
			}
		}
	}
}
