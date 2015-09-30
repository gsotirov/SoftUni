using System;

namespace Problem_04__Deck_of_Cards
{
	class DeckOfCards
	{
		public static void Main ()
		{
			char[] suits = { '\u2660', '\u2665', '\u2666', '\u2663' };
			string[] faces = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

			for (int i = 0; i < faces.Length; i++) 
			{
				for (int j = 0; j < suits.Length; j++) 
				{
					string face = (faces [i].Length < 2) ? " " + faces [i] : faces [i];
					char suit = suits [j];
					Console.Write ("{0}{1} ", face, suit);
				}
				Console.WriteLine ();
			}
		}
	}
}
