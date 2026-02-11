using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    enum Direction
    {
        Up,     // Вверх
        Down,   // Вниз
        Left,   // Влево
        Right   // Вправо
    }
    
    class Snake
    {
        public int X {  get; private set; }
        public int Y { get; private set; }
        private Direction direction = Direction.Right;

        private List<(int X, int Y)> tail = new List<(int, int)>();
        private int tailLength = 3;

        public Snake(int startX, int startY)
        {
            X = startX;
            Y = startY;

            for (int i = 1; i <= tailLength; i++)
            {
                tail.Add((startX - i, startY));
            }
        }

        public void Move()
        {
            int oldX = X;
            int oldY = Y;

            switch (direction) 
            {
                case Direction.Left: X--; break;
                    case Direction.Right: X++; break;
                    case Direction.Up: Y--; break;
                    case Direction.Down: Y++; break;
            }

            tail.Insert(0, (oldX, oldY));

            if (tail.Count > tailLength)
            {
                tail.RemoveAt(tail.Count - 1);
            }
        }

        public void Grow()
        {
            tailLength++;
        }

        public void Draw()
        {
            // Рисуем хвост
            foreach (var segment in tail)
            {
                Console.SetCursorPosition(segment.X, segment.Y);
                Console.Write("■");
            }

            // Рисуем голову (поверх хвоста)
            Console.SetCursorPosition(X, Y);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("█");
            Console.ResetColor();
        }
        public void ChangeDirection(Direction newDir)
        {
            if ((direction == Direction.Up && newDir != Direction.Down) ||
                (direction == Direction.Down && newDir != Direction.Up) ||
                (direction == Direction.Left && newDir != Direction.Right) ||
                (direction == Direction.Right && newDir != Direction.Left))
            {
                direction = newDir;
            }
        }
    }
}
