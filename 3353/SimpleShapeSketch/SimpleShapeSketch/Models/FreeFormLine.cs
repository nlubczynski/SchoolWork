using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleShapeSketch
{
    [Serializable]
    public class FreeFormLine : GraphicalObject
    {
        private List<Line> lineArray;

        public FreeFormLine(int x1, int y1, int x2, int y2, Graphics graphics, Color color)
            : base(graphics, color, new Point(x1, y1), new Point(x2, y1), new Point(x1, y2), new Point(x2, y2))
        {
            lineArray = new List<Line>();
        }
        private FreeFormLine(){}
        public void addLine(Line line)
        {
            lineArray.Add(line);
        }

        public override void paint()
        {
            foreach(Line line in lineArray)
            {
                    line.paint();
            }
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

            foreach (Line line in lineArray)
            {
                line.move(dx, dy);
            }
        }
        public override bool contains(Point p)
        {
            foreach (Line line in lineArray)
            {
                if (line.contains(p))
                    return true;
            }
            return false;
        }
        public override void resize(int x1, int y1, int x2, int y2, DrawQuadrant quadrant)
        {
            // do nothing
        }
        public override GraphicalObject Clone()
        {
            return new FreeFormLine(_topLeft.X, _topLeft.Y, _bottomRight.X, _bottomRight.Y, Program.getCanvas(), _color);
        }
    }
}
