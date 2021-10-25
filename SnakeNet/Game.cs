using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SnakeNet
{
    public class Game
    {
        internal Snake Player { get; set; }
        internal Board GameBoard { get; set; }
        public Game()
        {
            Player = new Snake();
            GameBoard = new Board(20, 40);
        }

        public void DrawBoard()
        {
            GameBoard.DrawBoard();
            Thread.Sleep(400);
        }

        public void GenerateNewFood()
        {
            GameBoard.SetNewFood();
        }
    }
}
