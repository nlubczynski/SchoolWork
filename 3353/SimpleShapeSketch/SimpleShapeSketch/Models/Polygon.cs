using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleShapeSketch
{
    public class Polygon : GraphicalObject
    {
        private List<Point> points;

        public Polygon(int x1, int y1, int x2, int y2, Graphics graphics, Color color)
            : base(graphics, color, new Point(x1, y1), new Point(x2, y1), new Point(x1, y2), new Point(x2, y2))
        {
            addPoint(new Point(x1, y1));
        }

        public void addPoint(Point point)
        {
            points.Add(point);
        }

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
        }

        public override void resize(int x1, int y1, int x2, int y2)
        {
            //do nothing
        }
    }
}
