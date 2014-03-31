using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleShapeSketch
{
    public class Circle : Ellipse
    {
        public Circle(int x1, int y1, int x2, int y2, Graphics graphics, Color color)
            : base( x1,  y1,  x2,  y2,  graphics,  color)
        {
            //do something
        }

        public override void resize(int x1, int y1, int x2, int y2, DrawQuadrant quadrant)
        {
            // Contrain it (square)
            int min = (x2 - x1) < (y2 - y1) ? (x2 - x1) : (y2 - y1);

            // Resize it
            switch (quadrant)
            {
                case DrawQuadrant.BottomRight:
                    base.resize(x1, y1, x1 + min, y1 + min, quadrant);
                    break;
                case DrawQuadrant.TopRight:
                    base.resize(x1, y2 - min, x1 + min, y2, quadrant);
                    break;
                case DrawQuadrant.TopLeft:
                    base.resize(x2 - min, y2 - min, x2, y2, quadrant);
                    break;
                case DrawQuadrant.BottomLeft:
                    base.resize(x2 - min, y1, x2, y1 + min, quadrant);
                    break;
            }            

        }
    }
}
