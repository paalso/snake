﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Figure
    {
        public List<Point> pList;
        public List<Point> PList => pList;

        /*
                public Figure(List<Point> pList)
                {
                    this.pList = pList;
                }
                */

        public void Draw()
        {
            foreach (Point point in pList)
            {
                point.Draw();
            }
        }

        public void Clear()
        {
            foreach (Point point in pList)
            {
                point.Clear();
            }
        }
    }
}
