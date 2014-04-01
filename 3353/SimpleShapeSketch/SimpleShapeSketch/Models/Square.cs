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
            switch (quadrant)
            {
                case DrawQuadrant.BottomRight:
                    base.resize(x1, y1, x1 + min, y1 + min, quadrant);
                    break;
                case DrawQuadrant.TopRight:
                    base.resize(x1 , y2 - min, x1 + min, y2, quadrant);
                    break;
                case DrawQuadrant.TopLeft:
                    base.resize(x2 - min, y2 - min, x2, y2, quadrant);
                    break;
                case DrawQuadrant.BottomLeft:
                    base.resize(x2 - min, y1, x2, y1 + min, quadrant);
                    break;
            }            
        }
        public override GraphicalObject Clone()
        {
            return new Square(_topLeft.X, _topLeft.Y, _bottomRight.X, _bottomRight.Y, Program.getCanvas(), _color);
        }
    }
}
