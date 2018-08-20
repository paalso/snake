using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine : Figure
    {

        public VerticalLine(int yBottom, int yTop, int x, char symbol)
        {
            pList = new List<Point>();
            for (int i = yBottom; i <= yTop; i++)
                pList.Add(new Point(x, i, symbol));
        }
    }
}
