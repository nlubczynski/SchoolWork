using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SimpleShapeSketch
{
    public class GraphicalObject
    {
        // Member Variables
        protected Color _color;
        protected Point _topLeft, _topRight, _bottomLeft, _bottomRight;
        protected Graphics _graphics;

        // Get / Set
        public Color Color
        {
            get { return _color; }
            set { _color = value; }
        }
        public Point TopLeft
        {
            get { return _topLeft; }
        }
        public Point TopRight
        {
            get { return _topRight; }
        }
        public Point BottomLeft
        {
            get { return _bottomLeft; }
        }
        public Point BottomRight
        {
            get { return _bottomRight; }
        }

        public GraphicalObject(Graphics graphics, Color color, Point topLeft, Point topRight, Point bottomLeft, Point bottomRight)
        {
            // Graphics
            _graphics = graphics;
            
            // Object Properties
            _color = color;
            _topLeft = topLeft;
            _topRight = topRight;
            _bottomLeft = bottomLeft;
            _bottomRight = bottomRight;
        }

        // Virtual Functions
        public virtual void paint(){ }
        public virtual void move(int dx, int dy) { }
        public virtual void resize(int x1, int y1, int x2, int y2) { }

    }
}
