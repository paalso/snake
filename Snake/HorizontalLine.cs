using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalLine : Figure
    {

        public HorizontalLine(int xLeft, int xRight, int y, char symbol)
        {
            //List<Point> pList = new List<Point>();
            // так неправильно, т.к. мы внутри цикла заводим новую переменную?

            pList = new List<Point>();
            for (int i = xLeft; i <= xRight; i++)
                pList.Add(new Point(i,y,symbol));
        }

        public void Draw()
        {
            foreach (Point point in pList)
            {
                point.Draw();
            }
        }

    }
}
