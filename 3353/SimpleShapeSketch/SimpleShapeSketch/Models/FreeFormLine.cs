using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleShapeSketch
{
    public class FreeFormLine : GraphicalObject
    {
        private List<Line> lineArray;

        public FreeFormLine(int x1, int y1, int x2, int y2, Graphics graphics, Color color)
            : base(graphics, color, new Point(x1, y1), new Point(x2, y1), new Point(x1, y2), new Point(x2, y2))
        {
            lineArray = new List<Line>();
        }

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
        public override bool contains(Point p)
        {
            foreach (Line line in lineArray)
            {
                if (line.contains(p))
                    return true;
            }
            return false;
        }
    }
}
