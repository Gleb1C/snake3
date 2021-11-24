﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake3
{
    internal class VerticalLine
    {
        List<Point> pList;

        public VerticalLine(int x, int yUp, int yDown, char sym)
        {
            pList = new List<Point>();
            for (int y = yUp; y <= yDown; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }

        }



        public void Drow()
        {

            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
