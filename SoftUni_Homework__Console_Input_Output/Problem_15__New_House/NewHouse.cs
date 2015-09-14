using System;

namespace Problem_15__New_House
{
	class NewHouse
	{
		public static void Main ()
		{
			// =================================
			//  100/100 according to the Judge
			// =================================
			int houseHeight = int.Parse (Console.ReadLine());
			int roofHeight = (houseHeight + 1) / 2;
			int roofOffset = (int)(Math.Floor ((double)houseHeight / 2));
			int houseWidthWithoutWalls = houseHeight - 2;

			string output = "";
			int roof = 1;

			for (int j = 0; j < roofHeight; j++) 
			{
				output += new String('-', roofOffset) + new String('*', roof) + new String('-', roofOffset) + "\n";
				roof += 2;
				roofOffset--;
			}

			for (int i = 0; i < houseHeight; i++) 
			{
				output += "|" + new String('*', houseWidthWithoutWalls) + "|\n";
			}

			Console.WriteLine (output);
		}
	}
}
