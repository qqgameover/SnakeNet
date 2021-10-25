using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeNet
{
    internal class Food
    {
        internal int FoodPosX { get; set; }
        internal int FoodPosY { get; set; }
        public Food(int height, int width)
        {
            var rng = new Random();
            FoodPosX = rng.Next(1, width);
            FoodPosY = rng.Next(1, height);
        }
    }
}
