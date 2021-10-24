using System;

namespace SnakeNet
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new Game();
            while (true)
            {
                game.DrawBoard();
            }
        }
    }
}
