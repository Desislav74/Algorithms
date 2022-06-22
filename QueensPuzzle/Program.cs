using System;
using System.Collections.Generic;

namespace QueensPuzzle
{
    class Program
    {
        private static HashSet<int> AtakedRows = new HashSet<int>();
        private static HashSet<int> AtakedCols = new HashSet<int>();
        private static HashSet<int> AtakedLeftDiagonals = new HashSet<int>();
        private static HashSet<int> AtakedRightDiagonals = new HashSet<int>();
        static void Main(string[] args)
        {
            var board = new bool [8, 8];

            PutQueens(board, 0);
        }

        private static void PutQueens(bool[,] board, int row)
        {
            if (row >= board.GetLength(0))
            {

                PrintBoard(board);
                return;
            }
            for (int col = 0; col < board.GetLength(1); col++)
            {
                if (CanPlaceQueen(row, col))
                {
                    AtakedRows.Add(row);
                    AtakedCols.Add(col);
                    AtakedLeftDiagonals.Add(row - col);
                    AtakedRightDiagonals.Add(row + col);
                    board[row, col] = true;

                    PutQueens(board, row + 1);

                    AtakedRows.Remove(row);
                    AtakedCols.Remove(col);
                    AtakedLeftDiagonals.Remove(row - col);
                    AtakedRightDiagonals.Remove(row + col);
                    board[row, col] = false;
                }
            }
        }

        private static void PrintBoard(bool[,] board)
        {
            for (int row = 0; row < board.GetLength((0)); row++)
            {
                for (int col = 0; col < board.GetLength((1)); col++)
                {
                    if (board[row, col])
                    {
                        Console.Write("* ");
                    }

                    else
                    {
                        Console.Write("- ");
                    }

                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }


        private static bool CanPlaceQueen(int row, int col)
        {
            return !AtakedRows.Contains(row)
                   && !AtakedCols.Contains(col)
                   && !AtakedLeftDiagonals.Contains(row - col)
                   && !AtakedRightDiagonals.Contains(row + col);
        }
    }
}
