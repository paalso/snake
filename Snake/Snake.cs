using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
    public Direction direction { get; set; }

        public Snake (Point tail, int len, Direction direction)
        {
            this.direction = direction;
            pList = new List <Point> ();
            for (int i = 0; i < len; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }

        public void Move()
        {
            Point tail = pList.First();
            Point newHead = GetNextPoint();

            pList.Remove(tail);
            pList.Add(newHead);

            tail.Clear();
            newHead.Draw();
        }

        public void HandleKey(ConsoleKey pressedKey)
        {
            switch (pressedKey)
            {
                case ConsoleKey.LeftArrow:
                    direction = Direction.LEFT; break;
                case ConsoleKey.RightArrow:
                    direction = Direction.RIGHT; break;
                case ConsoleKey.UpArrow:
                    direction = Direction.UP; break;
                case ConsoleKey.DownArrow:
                    direction = Direction.DOWN; break;
            }
        }

        internal bool Eat(Point food)
        {
            
            var head = GetNextPoint();
            if (head.IsHit(food))
            {
                food.symbol = head.symbol;
                pList.Add(food);
                return true;
            } else
                return false;
        }


        private Point GetNextPoint()
        {
            return pList.Last().Next(direction);
        }

        private bool IsHit (Point point)
        {
            var head = pList.Last();
            return head.IsHit(point);
        }

    }
}
