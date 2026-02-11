using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Food
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        private Random random = new Random();

        public void GenerateNewPosition(int mapWidth, int mapHeight)
        {
            X = random.Next(1, mapWidth - 2);
            Y = random.Next(1, mapHeight - 2);
        }

        public void Draw()
        {
            Console.SetCursorPosition(X, Y);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("@");
            Console.ResetColor();
        }
    }
}
