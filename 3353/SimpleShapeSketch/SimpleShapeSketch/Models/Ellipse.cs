using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleShapeSketch
{
    [Serializable]
    public class Ellipse : GraphicalObject
    {
        public Ellipse(int x1, int y1, int x2, int y2, Graphics graphics, Color color)
            : base(graphics, color, new Point(x1, y1), new Point(x2, y1), new Point(x1, y2), new Point(x2, y2))
        {
            //do something
        }

        public override void paint()
        {
            _graphics.FillEllipse(new SolidBrush(_color), new System.Drawing.Rectangle(_topLeft, new Size(_topRight.X - _topLeft.X, _bottomLeft.Y - _topLeft.Y)));
        }
        protected Ellipse(){}
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

        public override void resize(int x1, int y1, int x2, int y2, DrawQuadrant quadrant)
        {
            _topLeft = new Point(x1, y1);
            _topRight = new Point(x2, y1);
            _bottomLeft = new Point(x1, y2);
            _bottomRight = new Point(x2, y2);
        }
        public override bool contains(Point location)
        {
            Point center = new Point(
                  (_topLeft.X + _topRight.X)/2,
                  (_topLeft.Y + _bottomLeft.Y)/2);

            double _xRadius = (_topRight.X - _topLeft.X) / 2;
            double _yRadius = (_bottomLeft.Y - _topLeft.Y) / 2;


            if (_xRadius <= 0.0 || _yRadius <= 0.0)
                return false;
            /* This is a more general form of the circle equation
             *
             * X^2/a^2 + Y^2/b^2 <= 1
             */

            Point normalized = new Point(location.X - center.X,
                                         location.Y - center.Y);

            return ((double)(normalized.X * normalized.X)
                     / (_xRadius * _xRadius)) + ((double)(normalized.Y * normalized.Y) / (_yRadius * _yRadius))
                <= 1.0;
        }
        public override GraphicalObject Clone()
        {
            return new Ellipse(_topLeft.X, _topLeft.Y, _bottomRight.X, _bottomRight.Y, Program.getCanvas(), _color);
        }
    }
}
