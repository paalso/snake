using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    

    class Program
    {
        public static int WIDTH = 100;
        public static int HEIGTH = 40;

        public static void DrawField(int width, int heigth)
        {
            Console.SetBufferSize(width, heigth);
            HorizontalLine topLine = new HorizontalLine(0, width - 2, 0, '+');
            HorizontalLine bottomLine = new HorizontalLine(0, width - 2, heigth - 1, '+');

            VerticalLine leftLine = new VerticalLine(0, heigth - 1, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, heigth - 1, width - 2, '+');

            topLine.Draw();
            bottomLine.Draw();
            leftLine.Draw();
            rightLine.Draw();
        }

        static void Main(string[] args)
        {
            Console.SetWindowSize(WIDTH, HEIGTH);
            Console.SetBufferSize(WIDTH, HEIGTH);
            Walls walls = new Walls(WIDTH, HEIGTH);
            walls.Draw();

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            var foodCreator = new FoodCreator(WIDTH, HEIGTH, '$');
            var food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                if (walls.IsHit(snake))
                {
                    Console.WriteLine("GAME OVER!");
                    break;
                }
                if (snake.Eat(food)) {
                    food = foodCreator.CreateFood();
                    food.Draw();
                } else
                    snake.Move();
                Thread.Sleep(100);

                if (Console.KeyAvailable)
                    snake.HandleKey(Console.ReadKey().Key);
            }

            Console.ReadKey();
        }
    }
}
