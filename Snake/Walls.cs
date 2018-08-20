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

        public Walls(int width, int heigth)

        {
            HorizontalLine topLine = new HorizontalLine(0, width - 2, 0, '+');
            HorizontalLine bottomLine = new HorizontalLine(0, width - 2, heigth - 1, '+');

            VerticalLine leftLine = new VerticalLine(0, heigth - 1, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, heigth - 1, width - 2, '+');

            wallsList = new List<Figure>();
            wallsList.Add(topLine);
            wallsList.Add(bottomLine);
            wallsList.Add(leftLine);
            wallsList.Add(rightLine);
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
