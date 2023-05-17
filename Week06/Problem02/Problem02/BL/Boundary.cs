﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02.BL
{
    public class Boundary
    {
        public Boundary()
        {
            TopLeft = new Point(0, 0);
            TopRight = new Point(0, 90);
            BottomLeft = new Point(90, 0);
            BottomRight = new Point(90, 90);
        }
        public Boundary(Point TopLeft, Point TopRight, Point BottomLeft, Point BottomRight)
        {
            this.TopLeft = TopLeft;
            this.TopRight = TopRight;
            this.BottomLeft = BottomLeft;
            this.BottomRight = BottomRight;
        }
        public Point TopLeft;
        public Point TopRight;
        public Point BottomLeft;
        public Point BottomRight;
    }
}
