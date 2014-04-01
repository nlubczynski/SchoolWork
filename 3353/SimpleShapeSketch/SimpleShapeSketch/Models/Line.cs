using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleShapeSketch
{
    [Serializable]
    public class Line : GraphicalObject
    {
        Point _pointOne, _pointTwo;

        public Line(int x1, int y1, int x2, int y2, Graphics graphics, Color color)
            : base(graphics, color, new Point(x1, y1), new Point(x2, y1), new Point(x1, y2), new Point(x2, y2))
        {
            _pointOne = new Point(x1, y1);
            _pointTwo = new Point(x2, y2);
        }
        public Line(int x1, int y1, int x2, int y2, Graphics graphics, Color color, Point pointOne, Point pointTwo)
            : base(graphics, color, new Point(x1, y1), new Point(x2, y1), new Point(x1, y2), new Point(x2, y2))
        {
            _pointOne = pointOne;
            _pointTwo = pointTwo;
        }
        private Line(){}
        public override void paint()
        {
            _graphics.DrawLine(new Pen(new SolidBrush((_color))), _pointOne, _pointTwo);
        }

        public override void move(int dx, int dy)
        {
            // Move x
            _topLeft.X += dx;
            _topRight.X += dx;
            _bottomLeft.X += dx;
            _bottomRight.X += dx;
            _pointOne.X += dx;
            _pointTwo.X += dx;

            // Move y
            _topLeft.Y += dy;
            _topRight.Y += dy;
            _bottomLeft.Y += dy;
            _bottomRight.Y += dy;
            _pointOne.Y += dy;
            _pointTwo.Y += dy;
        }

        public override void resize(int x1, int y1, int x2, int y2, DrawQuadrant quadrant)
        {

            _topLeft = new Point(x1, y1);
            _topRight = new Point(x2, y1);
            _bottomLeft = new Point(x1, y2);
            _bottomRight = new Point(x2, y1);

            if (quadrant == DrawQuadrant.BottomRight)
            {
                _pointOne = new Point(x1, y1);
                _pointTwo = new Point(x2, y2);
            }
            else if (quadrant == DrawQuadrant.BottomLeft)
            {
                _pointOne = new Point(x2, y1);
                _pointTwo = new Point(x1, y2);
            }
            else if (quadrant == DrawQuadrant.TopLeft)
            {
                _pointOne = new Point(x2, y2);
                _pointTwo = new Point(x1, y1);
            }
            else if (quadrant == DrawQuadrant.TopRight)
            {
                _pointOne = new Point(x1, y2);
                _pointTwo = new Point(x2, y1);
            }
        }
        public override bool contains(Point p)
        {

            try
            {
                int m = (_pointTwo.Y - _pointOne.Y) / (_pointTwo.X - _pointOne.X);
                int b = _pointOne.Y - m * _pointOne.X;

                if (p.Y == m * p.X + b)
                    return true;
            }
            catch
            {
                return false;
            }

            

            return false;   
        }
        public override GraphicalObject Clone()
        {
            return new Line(_topLeft.X, _topLeft.Y, _bottomRight.X, _bottomRight.Y, Program.getCanvas(), _color, _pointOne, _pointTwo);
        }
    }
}
