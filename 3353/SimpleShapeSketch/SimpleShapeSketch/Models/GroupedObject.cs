using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleShapeSketch
{
    public class GroupedObject : GraphicalObject
    {
        List<GraphicalObject> groupedObjectList;

        public GroupedObject(int x1, int y1, int x2, int y2, Graphics graphics, Color color)
            : base(graphics, color, new Point(x1, y1), new Point(x2, y1), new Point(x1, y2), new Point(x2, y2))
        {
            groupedObjectList = new List<GraphicalObject>();
        }

        public override void paint()
        {
            foreach (GraphicalObject graphicObject in groupedObjectList)
            {
                graphicObject.Color = _color;
                graphicObject.paint();
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

            foreach (GraphicalObject graphicObject in groupedObjectList)
            {
                graphicObject.move(dx, dy);
            }
        }

        public override bool contains(Point p)
        {
            if (p.X <= _topLeft.X || p.X >= _topRight.X)
                return false;
            if (p.Y <= _topLeft.Y || p.Y >= _bottomLeft.Y)
                return false;

            return true;
        }

        public void addObject(GraphicalObject newGraphicsObject)
        {
            groupedObjectList.Add(newGraphicsObject);

            foreach (GraphicalObject graphicsObject in groupedObjectList)
            {

                //set top right
                if (_topRight.X < graphicsObject.TopRight.X)
                {
                    _topRight.X = graphicsObject.TopRight.X;
                }
                if (_topRight.Y > graphicsObject.TopRight.Y)
                {
                    _topRight.Y = graphicsObject.TopRight.Y;
                }
                //set top left
                if (_topLeft.X > graphicsObject.TopLeft.X)
                {
                    _topLeft.X = graphicsObject.TopLeft.X;
                }
                if (_topLeft.Y > graphicsObject.TopLeft.Y)
                {
                    _topLeft.Y = graphicsObject.TopLeft.Y;
                }
                //set bot right
                if (_bottomRight.X < graphicsObject.BottomRight.X)
                {
                    _bottomRight.X = graphicsObject.BottomRight.X;
                }
                if (_bottomRight.Y < graphicsObject.BottomRight.Y)
                {
                    _bottomRight.Y = graphicsObject.BottomRight.Y;
                }
                //set bot left
                if (_bottomLeft.X > graphicsObject.BottomLeft.X)
                {
                    _bottomLeft.X = graphicsObject.BottomLeft.X;
                }
                if (_bottomLeft.Y < graphicsObject.BottomLeft.Y)
                {
                    _bottomLeft.Y = graphicsObject.BottomLeft.Y;
                }
            }
        }

        public GraphicalObject removeObject(Point p)
        {
            //get object point is in
            foreach (GraphicalObject go in groupedObjectList)
            {
                if (go.contains(p))
                {
                    GraphicalObject rmv = groupedObjectList.Find(g => g == go);
                    groupedObjectList.Remove(rmv);
                    return rmv;
                }
            }

            return null;

        }

        public override void resize(int x1, int y1, int x2, int y2, DrawQuadrant quadrant)
        {
            //do nothing
        }

        public override GraphicalObject Clone()
        {
            GroupedObject clone = new GroupedObject(_topLeft.X, _topLeft.Y, _bottomRight.X, _bottomRight.Y, Program.getCanvas(), _color);

            foreach (GraphicalObject graphicObject in groupedObjectList)
            {
                clone.addObject(graphicObject);
            }

            return clone;
        }

        public List<GraphicalObject> getGroupedObjectList()
        {
            return groupedObjectList;
        }
    }
}
