using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            GameBoard = new Board(40, 40);
        }
    }
}
