using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char symbol;

        public Point(int x, int y, char symbol)
        {
            this.x = x;
            this.y = y;
            this.symbol = symbol;

            // Console.WriteLine("Создается новая точка");
        }

        public Point(Point point)
        {
            this.x = point.x;
            this.y = point.y;
            this.symbol = point.symbol;

            // Console.WriteLine("Создается новая точка");
        }

        public void Move(int offset, Direction direction)
        {
            var newX = x;
            var newY = y;
            switch (direction)
            {
                case Direction.LEFT:
                    newX -= offset;
                    break;
                case Direction.RIGHT:
                    newX += offset;
                    break;
                case Direction.UP:
                    newY -= offset;
                    break;
                case Direction.DOWN:
                    newY += offset;
                    break;
                default:
                    break;
            }
            x = newX; y = newY;
        }

        public Point Next(Direction direction)
        {
            var newX = x;
            var newY = y;
            var offset = 1;

            switch (direction)
            {
                case Direction.LEFT:
                    newX -= offset;
                    break;
                case Direction.RIGHT:
                    newX += offset;
                    break;
                case Direction.UP:
                    newY -= offset;
                    break;
                case Direction.DOWN:
                    newY += offset;
                    break;
                default:
                    break;
            }
            return new Point(newX, newY, symbol);
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
        }

        public void Clear()
        {
            symbol = ' ';
            Draw();
        }

        public bool IsHit(Point point)
        {
            if (this.Equals(point))
                return true;
            return false;
        }

        public override string ToString()
        {
            return String.Format("Point: x = {0}, y = {1}, symbol : {2}", x, y, symbol);
        }

        public override bool Equals(object obj)
        {
            var point = obj as Point;
            return point != null &&
                   x == point.x &&
                   y == point.y;
        }
    }
}
