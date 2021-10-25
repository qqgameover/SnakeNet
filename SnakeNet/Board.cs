using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeNet
{
    internal class Board
    {
        public int[,] BoardArray { get; set; }
        private Food CurrentFood { get; set; }

        public Board(int height, int width)
        {
            BoardArray = new int[height + 2, width + 4];
            CreateWalls();
            CurrentFood = new Food(BoardArray.GetLength(0) - 1, BoardArray.GetLength(1) - 1);
            GenerateNewFood(CurrentFood.FoodPosY, CurrentFood.FoodPosX);
        }

        private void CreateWalls()
        {
            var height = BoardArray.GetLength(0);
            var width = BoardArray.GetLength(1);
            for (int j = 0; j < height; j++)
            {
                for (int i = 0; i < width; i++)
                {
                    BoardArray[0, i] = 1;
                    BoardArray[height - 1, i] = 1;
                    if (i == 0 || i == width - 1)
                    {
                        BoardArray[j, i] = 1;
                    }
                }
            }
        }

        internal void DrawBoard()
        {
            Console.SetCursorPosition(0, 0);
            Console.CursorVisible = false;
            ClearBoard();
            for (int i = 0; i < BoardArray.GetLength(0); i++)
            {
                if(i != 0) Console.WriteLine();
                for (int j = 0; j < BoardArray.GetLength(1); j++)
                {
                    if(BoardArray[i,j] == 0) Console.Write(" ");
                    if(BoardArray[i, j] == 1) Console.Write("#");
                    if(BoardArray[i,j] == 2) Console.Write("*");
                }
            }
        }

        internal static void ClearBoard()
        {
            Console.Clear();
        }

        public void GenerateNewFood(int y, int x)
        {
            BoardArray[y, x] = 2;
        }

        public void SetNewFood()
        {
            CurrentFood = new Food(BoardArray.GetLength(0) - 1, BoardArray.GetLength(1) - 1);
        }
    }
}
