using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace SnakeNet
{
    internal class Snake
    {
        internal int SnakeHeadPosY { get; set; }
        internal int SnakeHeadPosX { get; set; }
        private int SnakeDirectionY { get; set; }
        private int SnakeDirectionX { get; set; }
        internal List<int> SnakeList { get; set; }
        internal int SnakeLength { get; private set; }

        public Snake(int boardHeight, int boardWidth)
        {
            SnakeHeadPosY = (boardHeight / 2);
            SnakeHeadPosX = (boardWidth / 2);
            SnakeLength = 4;
            SnakeList = new List<int>();
        }
        public void MoveSnake()
        {
            SnakeHeadPosY += SnakeDirectionY;
            SnakeHeadPosX += SnakeDirectionX;
            SnakeList.Insert(0,SnakeHeadPosX);
            SnakeList.Insert(0, SnakeHeadPosY);
        }

        public void HandleInput()
        {
            if(Console.KeyAvailable == false) return;
            var cki = Console.ReadKey(true);
            if (cki.Key == ConsoleKey.W)
            {
                SnakeDirectionY = -1;
                SnakeDirectionX = 0;
            }
            if (cki.Key == ConsoleKey.R)
            {
                SnakeDirectionY = 1;
                SnakeDirectionX = 0;
            }
            if (cki.Key == ConsoleKey.A)
            {
                SnakeDirectionY = 0;
                SnakeDirectionX = -1;
            }
            if (cki.Key == ConsoleKey.S)
            {
                SnakeDirectionY = 0;
                SnakeDirectionX = 1;
            }
        }
    }
}
