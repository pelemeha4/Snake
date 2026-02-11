using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Map map = new Map();
            map.MapWidth = 80;
            map.MapHeight = 25;

            Snake snake = new Snake(40,12);

            Food food = new Food();
            food.GenerateNewPosition(map.MapWidth,map.MapHeight);

            while (true)
            {
                map.GenerateMap();
                food.Draw();
                snake.Draw();

                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey(true).Key;
                    switch (key)
                    {
                        case ConsoleKey.UpArrow: snake.ChangeDirection(Direction.Up); break;
                        case ConsoleKey.DownArrow: snake.ChangeDirection(Direction.Down); break;
                        case ConsoleKey.LeftArrow: snake.ChangeDirection(Direction.Left); break;
                        case ConsoleKey.RightArrow: snake.ChangeDirection(Direction.Right); break;
                        case ConsoleKey.Escape: return;
                    }
                }

                if (snake.X == food.X && snake.Y == food.Y)
                {
                    snake.Grow();
                    food.GenerateNewPosition(map.MapWidth, map.MapHeight);
                }

                snake.Move();

                Thread.Sleep(150);
            }

        }
    }
}
