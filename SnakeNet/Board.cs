using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeNet
{
    internal class Board
    {
        internal int[,] BoardArray { get; set; }

        public Board(int height, int width)
        {
            BoardArray = new int[height, width];
        }
        internal void DrawBoard()
        {
            ClearBoard();
            for (int i = 0; i < BoardArray.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < BoardArray.GetLength(1); j++)
                {
                    if(BoardArray[i,j] == 0) Console.Write("#");
                    if(BoardArray[i, j] == 1) Console.Write(" ");
                    if(BoardArray[i,j] == 2) Console.Write("O");
                }
            }
        }

        internal void ClearBoard()
        {
            Console.Clear();
        }
    }
}
