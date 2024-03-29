﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using console_chess.BoardElements;
using console_chess.chess;

namespace console_chess
{
    internal class Screen
    {
        public static void printBoard(Board board)
        {
            for (int i = 0; i <board.row;  i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j <board.col; j++)
                {

                       printPiece(board.piece(i,j));


                    
                }
                Console.WriteLine();

            }
            Console.WriteLine("  a b c d e f g h");
        }

        public static void printBoard(Board board, bool[,] possiblePositions)
        {

            ConsoleColor defaultBackgorund = Console.BackgroundColor;
            ConsoleColor altBackground = ConsoleColor.DarkGray;

            for (int i = 0; i < board.row; i++)
            {
                Console.Write(8 - i + " ");
                for (int j = 0; j < board.col; j++)
                {

                    if (possiblePositions[i,j])
                    {
                        Console.BackgroundColor = altBackground;
                    }
                    else
                    {
                        Console.BackgroundColor = defaultBackgorund;
                    }
                    printPiece(board.piece(i, j));
                    Console.BackgroundColor = defaultBackgorund;



                }
                Console.WriteLine();

            }
            Console.WriteLine("  a b c d e f g h");
            Console.BackgroundColor = defaultBackgorund; 
        }

        public static ChessPosition readChessPosition()
        {
            string s = Console.ReadLine();
            char column = s[0];
            int row = int.Parse(s[1] + "");
            return new ChessPosition(column, row);
             
        }

        public static void printPiece(Piece piece)
        {

            if (piece == null)
            {
                Console.Write("- ");

            }
            else
            { 

                if (piece.color == Color.White)
                {
                    Console.Write(piece);
                }
                else
                {
                    ConsoleColor aux = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(piece);
                    Console.ForegroundColor = aux;
                }
                Console.Write(" ");
            }
        }
    }
}
