using System;

namespace SnakeNet
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new Game(20, 40);
            while (true)
            {
                game.Player.HandleInput();
                game.DrawBoard();
            }
        }
    }
}
