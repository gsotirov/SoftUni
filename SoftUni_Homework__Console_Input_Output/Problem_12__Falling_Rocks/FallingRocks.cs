using System;
using System.Collections.Generic;
using System.Threading;

namespace Problem_12__Falling_Rocks
{
	class FallingRocks
	{
		// ============================
		//  Still under development!!!
		// ============================
		public static void Main ()
		{
			// Engine here...
			Engine game = new Engine (Console.BufferWidth, Console.BufferHeight);
			game.start ();
		}
	}
	class Engine
	{
		// Fields.
		private int consoleWidth;
		private int consoleHeight;
		private Dwarf dwarf;
		private List<Rock> rocks;

		// Constructor.
		public Engine (int fieldWidth, int fieldHeight)
		{
			this.consoleWidth = fieldWidth;
			this.consoleHeight = fieldHeight;
			this.dwarf = new Dwarf ((this.consoleWidth / 2) - 1, this.consoleHeight - 1);
			this.rocks = new List<Rock> ();
		}

		// Methods.
		public void start ()
		{
			int rockStep = 4;
			int rockDrawTimeout = 1;
			int scoreTimeOut = 1;
			int scoreStep = 10;
			int score = 0;
			Random r = new Random ();
			char[] symbols = {'$', '+', '*', '&', '%', '@', '?', '!', ';'};


			while (true) 
			{
				Console.Clear ();
				this.dwarf.Draw ();
				bool isHit = false;
				Console.SetCursorPosition (0, 0);
				Console.Write ("Score: {0}", score);

				// Move the dwarf...
				if (Console.KeyAvailable) 
				{
					ConsoleKeyInfo key = Console.ReadKey (true);
					if (key.Key == ConsoleKey.LeftArrow) 
					{
						this.dwarf.MoveLeft ();
					}
					if (key.Key == ConsoleKey.RightArrow) 
					{
						this.dwarf.MoveRight ();
					}
				}

				// Draw rocks...
				foreach (Rock rock in rocks) 
				{
					rock.MoveDown ();
					rock.Draw ();

					if (rock.yPos == dwarf.yPos && rock.xPos == dwarf.xPos && rock.xPos == dwarf.xPos + 1 && rock.xPos == dwarf.xPos + 2) 
					{
						isHit = true;
					}
				}

				rocks.RemoveAll (x => x.yPos == this.consoleHeight - 1);

				if (scoreTimeOut % scoreStep == 0) 
				{
					score += 10;
				}

				if (rockDrawTimeout % rockStep == 0) 
				{
					this.rocks.Add(new Rock(r.Next(1, this.consoleWidth - 1), 1, symbols[r.Next(0, 8)]));
				}

				scoreTimeOut++;
				rockDrawTimeout++;

				if (isHit) 
				{
					Console.SetCursorPosition (10, 10);
					Console.Write ("GAME OVER");
					break;
				}

				Thread.Sleep (150);
			}
		}
	}
	class Rock
	{
		// Fields.
		public int xPos { get; set; }
		public int yPos { get; set; }
		private char symbol;

		// Constructor.
		public Rock(int xPos, int yPos, char symbol)
		{
			this.xPos = xPos;
			this.yPos = yPos;
			this.symbol = symbol;
		}

		// Methods.
		public void Draw ()
		{
			Console.SetCursorPosition (xPos, yPos);
			Console.Write (symbol);
		}
		public void MoveDown ()
		{
			this.yPos++;
		}
	}
	class Dwarf
	{
		// Fields.
		public int xPos { get; set; }
		public int yPos { get; set; }
		private const int size = 3;

		// Constructor.
		public Dwarf(int xPos, int yPos)
		{
			this.xPos = xPos;
			this.yPos = yPos;
		}

		// Methods.
		public void Draw ()
		{
			Console.SetCursorPosition (this.xPos, this.yPos);
			Console.Write ("(0)");
		}

		public void MoveLeft ()
		{
			this.xPos--;
		}

		public void MoveRight ()
		{
			this.xPos++;
		}
	}
}
