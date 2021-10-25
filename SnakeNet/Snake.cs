using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeNet
{
    internal class Snake
    {
        private int SnakeHeadPosY { get; set; }
        private int SnakeHeadPosX { get; set; }
        private int SnakeDirectionY { get; set; }
        private int SnakeDirectionX { get; set; }
        private int SnakeLength { get; set; }

        public Snake(int boardHeight, int boardWidth)
        {
            SnakeHeadPosY = (boardHeight / 2);
            SnakeHeadPosX = (boardWidth / 2);
        }

        public void MoveSnake()
        {
            SnakeHeadPosY += SnakeDirectionY;
            SnakeHeadPosX += SnakeDirectionX;
        }

        public void HandleInput()
        {
            if(Console.KeyAvailable == false) return;
            var cki = Console.ReadKey(true);
            if (cki.Key == ConsoleKey.W)
            {
                SnakeDirectionY = 1;
                SnakeHeadPosX = 0;
            }
            if (cki.Key == ConsoleKey.R)
            {
                SnakeDirectionY = -1;
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
