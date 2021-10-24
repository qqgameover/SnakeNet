﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeNet
{
    internal class Board
    {
        internal int Height { get; set; }
        internal int Width { get; set; }

        public Board(int height, int width)
        {
            Height = height;
            Width = width;
        }
    }
}