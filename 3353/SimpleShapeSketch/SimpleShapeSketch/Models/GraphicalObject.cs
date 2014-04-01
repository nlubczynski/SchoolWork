using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Xml.Serialization;

namespace SimpleShapeSketch
{
    [Serializable]
    public abstract class GraphicalObject
    {
        // Member Variables
        protected Color _color;
        protected Point _topLeft, _topRight, _bottomLeft, _bottomRight;
        [NonSerialized]
        protected Graphics _graphics;
        public enum DrawQuadrant
        {
            BottomRight, TopRight, TopLeft, BottomLeft
        }

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
        public Graphics Graphics
        {
            get { return _graphics; }
            set { _graphics = value; }
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
        public GraphicalObject(GraphicalObject g) : this(g._graphics, g.Color, g._topLeft, g._topRight, g._bottomLeft, g._bottomRight) { }
        protected GraphicalObject(){}

        // Virtual Functions
        public abstract void paint();
        public abstract void move(int dx, int dy);
        public abstract void resize(int x1, int y1, int x2, int y2, DrawQuadrant quadrant);
        public abstract bool contains(Point p);
        public abstract GraphicalObject Clone();

    }
}
