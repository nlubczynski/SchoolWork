using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SimpleShapeSketch
{
    class Square : Rectangle
    {
        public Square(int x1, int y1, int x2, int y2, Graphics graphics, Color colour)
            : base(x1, y1, x2, y2, graphics, colour)
        {
            // do stuff??
        }

        public override void resize(int x1, int y1, int x2, int y2, DrawQuadrant quadrant)
        {
            // Contrain it (square)
            int min = (x2 - x1) < (y2 - y1) ? (x2 - x1) : (y2 - y1);

            // Resize it
            base.resize(x1, y1, x1 + min, y1 + min, quadrant);
        }
    }
}
