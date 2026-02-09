using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Program
    {
         uint MapWidth;
         uint MapHeight;

        class GenereticMap
        {
            public int MapWidth{ get; set; }
            public int MapHeight{ get; set; }

            public void Map()
            {
                for (int i = 0; i < MapWidth ; i++)
                    Console.Write("-");

                Console.WriteLine();

                for (int row = 0; row < MapHeight - 2; row++)
                {
                    Console.Write("|");
                    for (int col = 0; col < MapWidth - 2; col++) Console.Write(" ");
                    Console.WriteLine("|");
                }

                for (int i = 0; i < MapWidth; i++) Console.Write("-");
            }
        }

        class Snake
        {
            public int[] snakeLenght;


        }

        class Point
        {
            public int x;
            public int y;

            public Point (int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            public Point()
            {

            }

            

            public void GenereticPoint() 
            {
                Random random = new Random();

                x = random.Next(2, 5);

                y = random.Next(2, 5);

                Console.SetCursorPosition(x, y);

                Console.WriteLine("#");
            }
        }

        static void Main(string[] args)
        {
            GenereticMap map = new GenereticMap();
            map.MapWidth = 100;
            map.MapHeight = 30;

            // Отрисовываем карту
            map.Map();

            // Чтобы консоль не закрылась сразу

            Point point = new Point();

            point.GenereticPoint();

            Console.ReadLine();
        }
    }
}
