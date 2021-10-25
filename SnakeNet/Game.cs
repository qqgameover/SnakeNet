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
        internal int BoardHeight { get; set; }
        internal int BoardWidth { get; set; }
        internal Board GameBoard { get; set; }
        public Game(int height, int width)
        {
            BoardHeight = height;
            BoardWidth = width;
            GameBoard = new Board(height, width);
            Player = new Snake(height, width);
        }

        public void DrawBoard()
        {
            Player.MoveSnake();
            DrawTheSnake();
            GameBoard.DrawBoard();
            Thread.Sleep(400);
        }

        private void GetNewTail()
        {
            
        }

        public void GenerateNewFood()
        {
            GameBoard.SetNewFood();
        }

        public void DrawTheSnake()
        {
            GameBoard.BoardArray[Player.SnakeList[0], Player.SnakeList[1]] = 1;
            TerjeHjelpMeg();
        }

        public void TerjeHjelpMeg()
        {
            if (Player.SnakeList.Count < Player.SnakeLength * 2) return;
            GameBoard.BoardArray[Player.SnakeList[Player.SnakeList.Count - 2],
                Player.SnakeList[Player.SnakeList.Count - 1]] = 0;
            Player.SnakeList.RemoveRange(Player.SnakeList.Count - 2, 2);
        }
    }
}
