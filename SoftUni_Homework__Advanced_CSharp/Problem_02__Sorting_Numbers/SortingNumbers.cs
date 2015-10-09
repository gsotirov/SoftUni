using System;

namespace Problem_02__Sorting_Numbers
{
	class SortingNumbers
	{
		public static void Main ()
		{
			int[] numbers;
			int n;

			// Catching errors...
			try
			{
				n = int.Parse(Console.ReadLine());
				numbers = new int[n];

				for (int i = 0; i < n; i++) 
				{
					numbers[i] = int.Parse(Console.ReadLine());
				}
			}
			catch (Exception e)
			{
				if (e is FormatException) 
				{
					Console.WriteLine ("\nFormat Error! {0}\nPlease make sure you enter only Integers!", e.Message);
				}
				else if (e is OverflowException) {
					Console.WriteLine ("\nOverflow Error! {0}", e.Message);
				}
				else 
				{
					Exception ue = new Exception ("Unknown exception thrown!");
					Console.WriteLine ("{0}! Please try again entering proper values!", ue.Message);
				}
				return;
			}

			// Sorting the array, using the Selection sort algorithm...
			SortArray(ref numbers);

			// Print the resul on the console...
			PrintResult ("Sorted", numbers);
		}

		public static void SortArray (ref int[] numbers)
		{
			int len = numbers.Length;
			int min;

			for (int i = 0; i < len; i++) 
			{
				min = i;
				for (int j = i + 1; j < len; j++) 
				{
					if(numbers[j] < numbers[min])
					{
						min = j;
					}
				}
				Swap(ref numbers[i], ref numbers[min]);
			}
		}

		public static void Swap (ref int a, ref int b)
		{
			int temp = a;
			a = b;
			b = temp;
		}

		public static void PrintResult (string mes, int[] arr)
		{
			Console.WriteLine("\n--- {0} ---", mes);
			foreach(int number in arr) 
			{
				Console.Write("{0} ", number);
			}
		}
	}
}
