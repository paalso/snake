using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Walls
    {
        private List<Figure> wallsList;

        public Walls(List<Figure> wallsList)
        {
            this.wallsList = wallsList;
        }

        public Walls(int mapWidth, int mapHeigth)

        {
            HorizontalLine topLine = new HorizontalLine(0, mapWidth - 2, 0, '+');
            HorizontalLine bottomLine = new HorizontalLine(0, mapWidth - 2, mapHeigth - 1, '+');

            VerticalLine leftLine = new VerticalLine(0, mapHeigth - 1, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, mapHeigth - 1, mapWidth - 2, '+');

            wallsList = new List<Figure>();
            wallsList.Add(topLine);
            wallsList.Add(bottomLine);
            wallsList.Add(leftLine);
            wallsList.Add(rightLine);
        }

        public bool IsHit(Snake snake)
        {
            foreach (var wall in wallsList)
                foreach (var point in wall.PList)
                    if (snake.GetNextPoint().Equals(point))
                        return true;
            return
                false;
        }

        public void Draw()
        {
            foreach (var item in wallsList)
            {
                item.Draw();
            }
        }
    }
}
