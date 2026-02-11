using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Map
    {
        private const char WALL_SYMBOL = '|';

        private const char FLOOR_SYMBOL = '-';

        public int MapWidth { get; set; }
        public int MapHeight { get; set; }

        public void GenerateMap()
        {
            Console.Clear();
            for (int i = 0; i < MapWidth; i++)
                Console.Write(FLOOR_SYMBOL);

            Console.WriteLine();

            for (int row = 0; row < MapHeight - 2; row++)
            {
                Console.Write(WALL_SYMBOL);
                for (int col = 0; col < MapWidth - 2; col++) Console.Write(" ");
                Console.WriteLine(WALL_SYMBOL);
            }

            for (int i = 0; i < MapWidth; i++) Console.Write(FLOOR_SYMBOL);
        }
    }
}
