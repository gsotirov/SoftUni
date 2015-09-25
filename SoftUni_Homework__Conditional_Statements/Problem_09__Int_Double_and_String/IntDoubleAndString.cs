using System;

namespace Problem_09__Int_Double_and_String
{
	class IntDoubleAndString
	{
		public static void Main ()
		{
			Console.WriteLine ("Please choose a type:\n1 --> int\n2 --> double\n3 --> string");
			int choice;
			while (!(int.TryParse(Console.ReadLine(), out choice) && choice > 0 && choice < 4))
			{
				Console.WriteLine ("Please enter a valid choice - 1, 2 or 3");
			}

			if (choice == 1 || choice == 2)
			{
				if (choice == 1)
				{
					Console.WriteLine ("Please enter an int:");
				}
				else 
				{
					Console.WriteLine ("Please enter a double:");
				}
				double input = double.Parse (Console.ReadLine());
				Console.WriteLine (input + 1);
			}
			else if (choice == 3)
			{
				Console.WriteLine ("Please enter a string:");
				Console.WriteLine (Console.ReadLine() + '*');
			}
		}
	}
}
