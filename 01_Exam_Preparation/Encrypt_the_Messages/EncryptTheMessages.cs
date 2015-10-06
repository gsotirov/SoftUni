using System;
using System.Collections.Generic;

namespace Encrypt_the_Messages
{
	class EncryptTheMessages
	{
		public static void Main ()
		{
			List<string> messages = new List<string> ();
			string input = "";
			const int charDifference = 13;

			// Check when the input STARTS.
			while (true) 
			{
				if (input.ToLower () == "start") 
				{
					input = Console.ReadLine ();
					break;
				}
				input = Console.ReadLine ();
			}

			// Add the proper messages to the Messages list until the END of transmission.
			while (input.ToLower() != "end")
			{
				if (!String.IsNullOrEmpty (input)) 
				{
					messages.Add (input);
				}
				input = Console.ReadLine ();
			}

			// Here's where the magic begins...

			if (messages.Count > 0) // Check if there are any messages at all.
			{
				List<string> encryptedMessages = new List<string> ();

				// Declare a dictionary to store our special values.
				Dictionary<char, char> specials = new Dictionary<char, char> () {
					{ ' ', '+' },
					{ '!', '$' },
					{ '.', '&' },
					{ ',', '%' },
					{ '?', '#' }
				};

				foreach (var message in messages) 
				{
					// Split the message to characters.
					char[] messageChars = message.ToCharArray ();
					// Reverse the message.
					Array.Reverse (messageChars);

					for (int i = 0; i < messageChars.Length; i++) 
					{
						bool checkIfBetweenAM = (messageChars[i] >= 'a' && messageChars[i] <= 'm') || (messageChars[i] >= 'A' && messageChars[i] <= 'M');
						bool checkIfBetweenNZ = (messageChars[i] >= 'n' && messageChars[i] <= 'z') || (messageChars[i] >= 'N' && messageChars[i] <= 'Z');

						if (specials.ContainsKey(messageChars[i]))
						{
							messageChars[i] = specials[messageChars[i]];
						}
						else if (checkIfBetweenAM)
						{
							messageChars [i] = (char)(messageChars [i] + charDifference);
						}
						else if (checkIfBetweenNZ)
						{
							messageChars [i] = (char)(messageChars [i] - charDifference);
						}
					}

					encryptedMessages.Add (new string(messageChars));
				}

				// Print the result on the console.
				Console.WriteLine ("Total number of messages: {0}", encryptedMessages.Count);
				foreach (var encMessage in encryptedMessages) 
				{
					Console.WriteLine ("{0}", encMessage);
				}
			} 
			else 
			{
				Console.WriteLine ("No messages sent.");
			}

		}
	}
}