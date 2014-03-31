﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SimpleShapeSketch
{
    class Rectangle : GraphicalObject
    {
        public Rectangle(int x1, int y1, int x2, int y2, Graphics graphics, Color colour)
            : base(graphics, colour, new Point(x1, y1), new Point(x2, y1), new Point(x1, y2), new Point(x2, y2))
        {
            // do stuff??
        }
        public override void paint()
        {
            _graphics.FillRectangle(new SolidBrush(_color), new System.Drawing.Rectangle(_topLeft, new Size(_topRight.X - _topLeft.X, _bottomLeft.Y - _topLeft.Y)));
        }

        public override void move(int dx, int dy)
        {
            // Move x
            _topLeft.X += dx;
            _topRight.X += dx;
            _bottomLeft.X += dx;
            _bottomRight.X += dx;

            // Move y
            _topLeft.Y += dy;
            _topRight.Y += dy;
            _bottomLeft.Y += dy;
            _bottomRight.Y += dy;
        }
        public override void resize(int x1, int y1, int x2, int y2)
        {
            _topLeft = new Point(x1, y1);
            _topRight = new Point(x2 , y1);
            _bottomLeft = new Point(x1, y2);
            _bottomRight = new Point(x2, y1);
        }
    }
}