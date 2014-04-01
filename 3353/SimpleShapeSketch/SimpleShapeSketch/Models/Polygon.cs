using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleShapeSketch
{
    [Serializable]
    public class Polygon : GraphicalObject
    {
        private List<Point> points;

        public Polygon(int x1, int y1, int x2, int y2, Graphics graphics, Color color)
            : base(graphics, color, new Point(x1, y1), new Point(x2, y1), new Point(x1, y2), new Point(x2, y2))
        {
            points = new List<Point>();
            addPoint(new Point(x1, y1));
        }

        public void addPoint(Point point)
        {
            points.Add(point);
        }
        private Polygon(){}
        public override void paint()
        {
            _graphics.FillPolygon(new SolidBrush(_color), points.ToArray());
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

            for (int i = 0; i < points.Count; i++)
            {
                int x = points[i].X;
                int y = points[i].Y;

                x += dx;
                y += dy;

                points[i] = new Point(x, y);
            }

        }

        public override void resize(int x1, int y1, int x2, int y2, DrawQuadrant quadrant)
        {
            //do nothing
        }

        public override bool contains(Point p)
        {

            Point p1, p2;

            bool inside = false;
            Point[] poly = points.ToArray();

            if (poly.Length < 3)
            {
                return inside;
            }

            Point oldPoint = new Point(
            poly[poly.Length - 1].X, poly[poly.Length - 1].Y);

            for (int i = 0; i < poly.Length; i++)
            {
                Point newPoint = new Point(poly[i].X, poly[i].Y);

                if (newPoint.X > oldPoint.X)
                {
                    p1 = oldPoint;
                    p2 = newPoint;
                }
                else
                {
                    p1 = newPoint;
                    p2 = oldPoint;
                }

                if ((newPoint.X < p.X) == (p.X <= oldPoint.X)
                && ((long)p.Y - (long)p1.Y) * (long)(p2.X - p1.X)
                 < ((long)p2.Y - (long)p1.Y) * (long)(p.X - p1.X))
                {
                    inside = !inside;
                }

                oldPoint = newPoint;
            }

            return inside;
        }
        public override GraphicalObject Clone()
        {
            return new Polygon(_topLeft.X, _topLeft.Y, _bottomRight.X, _bottomRight.Y, Program.getCanvas(), _color);
        }
    }
}
