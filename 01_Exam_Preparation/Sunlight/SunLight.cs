using System;

namespace Sunlight
{
	class SunLight
	{
		public static void Main ()
		{
			sbyte input = sbyte.Parse (Console.ReadLine());

			int horizon = input * 3;
			int middleSunbeamOffset = (int)(Math.Floor ((double)horizon / 2));
			int sunCircleOffset = input;
			int diagSunBeamsLength = input - 1;
			int sunThickness = (int)(Math.Floor((double)input / 2));
			int offset = 1;

			string sunLight = new String('.', middleSunbeamOffset) + "*" + new String('.', middleSunbeamOffset) + "\n";
			sunLight += DrawSunbeams (diagSunBeamsLength, middleSunbeamOffset, offset, 1, horizon);

			sunLight += DrawSun (input, sunCircleOffset, sunThickness);
			sunLight += new String ('*', horizon) + "\n";
			sunLight += DrawSun (input, sunCircleOffset, sunThickness);

			offset = input - 1; // Change the offset for the sun reflection.

			sunLight += DrawSunbeams (diagSunBeamsLength, middleSunbeamOffset, offset, 0, horizon);
			sunLight += new String ('.', middleSunbeamOffset) + "*" + new String ('.', middleSunbeamOffset);

			Console.WriteLine (sunLight);
		}

		public static string DrawSun (sbyte input, int sunCircleOffset, int sunThickness)
		{
			string output = "";
			for (int i = 0; i < sunThickness; i++) 
			{
				output += new String ('.', sunCircleOffset) + new String('*', input) + new String ('.', sunCircleOffset) + "\n";
			}
			return output;
		}

		public static string DrawSunbeams (int diagSunBeamsLength, int middleSunbeamOffset, int offset, int offsetType, int horizon)
		{
			string output = "";

			for (int i = 0; i < diagSunBeamsLength; i++) 
			{
				for (int m = 0; m < horizon; m++) 
				{
					if (m == offset || m == horizon - 1 - offset || m == middleSunbeamOffset) 
					{
						output += "*";
					} 
					else 
					{
						output += ".";
					}
				}
				output += "\n";

				// Determine the offset type. If 0 the offset should be decremented, if 1 - incremented.
				// This will ensure that the function will work peoperly with the reflection of the sun.
				if (offsetType == 0)
				{
					offset--;
				} 
				else 
				{
					offset++;
				}
			}
			return output;
		}
	}
}