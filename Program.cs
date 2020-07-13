using System;
using System.Collections.Generic;
using Chess.Pieces;

namespace Chess
{
	public class Program
	{
		
		static void Main()
		{
			int queenXPosition;
			int queenYPosition;
			int opponentXPosition;
			int opponentYPosition;

			Console.WriteLine("Welcome to PROGRAM NAME");
			queenXPosition = GetPosition("Queen", "X");
			queenYPosition = GetPosition("Queen", "Y");

			opponentXPosition = GetPosition("Enemy", "X");
			opponentYPosition = GetPosition("Enemy", "Y");

			Queen queen = new Queen(queenXPosition, queenYPosition);
			Console.WriteLine("Queen x: " + queen.PositionX);
			Console.WriteLine("Queen y: " + queen.PositionY);
		
		}

		private static int GetPosition (string gamePiece, string axis) 
		{
			Console.WriteLine("Please enter the " + axis + "position for the " + gamePiece);
			int position = int.Parse(Console.ReadLine());

			if (position <= 0 || position >= 9)
			{
				Console.WriteLine("Please enter a number betweeen 1 and 8, inclusive.");
				position = GetPosition(gamePiece, axis);
				return position;  
			} 
			else 
			{
				return position;
			}
		}

	}
}


// OOOOOOOO
// OOOOOOOO
// Grid <pos1, pos2>