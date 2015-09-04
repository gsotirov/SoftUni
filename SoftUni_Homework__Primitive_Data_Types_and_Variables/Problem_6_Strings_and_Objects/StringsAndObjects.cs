using System;

namespace Problem_6_Strings_and_Objects
{
	class StringsAndObjects
	{
		public static void Main ()
		{
			string hello = "Hello";
			string world = "World";

			object concat = hello + ", " + world; // Concatenate the two strings and assign the res to an object.

			string output = (string)concat; // Convert the object to string(explicitly) and assign it to a new string var.

			// Print the result on the console...
			Console.WriteLine (output);
		}
	}
}
