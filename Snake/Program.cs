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
        public static int WIDTH = 80;
        public static int HEIGTH = 57;

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
/*
        public static Direction GetDirectionByKey(ConsoleKey key)
        {
            var direction;
            switch

        }
*/
        static void Main(string[] args)
        {
            // DrawField(WIDTH, HEIGTH);
            var fieldWidth = Console.BufferWidth;
            var fieldHeight = Console.BufferHeight;
            DrawField(fieldWidth, fieldHeight);

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            var foodCreator = new FoodCreator(fieldWidth, fieldHeight, '$');
            var food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
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
