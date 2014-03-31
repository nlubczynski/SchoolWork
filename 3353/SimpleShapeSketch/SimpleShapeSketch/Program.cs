using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleShapeSketch
{
    static class Program
    {

        //Current state
        public static State _state;
        //Curent colour
        public static System.Drawing.Color _color;
        //List of all the objects
        public static List<GraphicalObject> _objects;
        //The currently selected object
        public static GraphicalObject _selected;
        //The point at which the newest item was created at
        public static System.Drawing.Point _anchorPoint;
        //Our main form
        public static MainForm _form;

        public enum State
        {
            Pointer, FreeDraw, StraighLine, Square, Rectangle, Circle, Ellipse, Polygon, Move
        }
        public static State CurrentState
        {
            get { return _state; }
            set { _state = value; }
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Set base stuff
            _state = State.Pointer;
            _color = System.Drawing.Color.Red;
            _objects = new List<GraphicalObject>();
            _form = new MainForm(_color);

            // Create the main window
            Application.Run(_form);
        }
        public static void mouseDown(System.Drawing.Point point)
        {
            switch (_state)
            {
                case State.Square:
                    _anchorPoint = point;
                    _objects.Add(new Square(point.X, point.Y, point.X, point.Y, _form.getCanvas(), _color));
                    _selected = _objects.ElementAt(_objects.Count - 1);
                    break;
                case State.Rectangle:
                    _anchorPoint = point;
                    _objects.Add(new Rectangle(point.X, point.Y, point.X, point.Y, _form.getCanvas(), _color));
                    _selected = _objects.ElementAt(_objects.Count - 1);
                    break;
            }

            // Repaint
            repaint();
        }
        public static void mouseDrag(System.Drawing.Point point)
        {
            // Find the true points
            System.Drawing.Point topLeft, bottomRight;
            if (_anchorPoint.X <= point.X && _anchorPoint.Y <= point.Y)
            {
                topLeft = _anchorPoint;
                bottomRight = point;
            }
            else if (_anchorPoint.X <= point.X && _anchorPoint.Y > point.Y)
            {
                topLeft = new System.Drawing.Point(_anchorPoint.X, point.Y);
                bottomRight = new System.Drawing.Point(point.X, _anchorPoint.Y);
            }
            else if (_anchorPoint.X > point.X && _anchorPoint.Y > point.Y)
            {
                topLeft = point;
                bottomRight = _anchorPoint;
            }
            else
            {
                topLeft = new System.Drawing.Point(point.X, _anchorPoint.Y);
                bottomRight = new System.Drawing.Point(_anchorPoint.X, point.Y);
            }

            switch (_state)
            {
                case State.Square:
                    if (_selected == null)
                        break;

                    // Resize
                    _selected.resize(topLeft.X, topLeft.Y, bottomRight.X, bottomRight.Y);
                    break;
                case State.Rectangle:
                    if (_selected == null)
                        break;

                    // Resize
                    _selected.resize(topLeft.X, topLeft.Y, bottomRight.X, bottomRight.Y);
                    break;
            }

            // Repaint
            repaint();
        }
        public static void repaint()
        {
            // Refresh
            _form.refreshCanvas();

            // Draw
            foreach (GraphicalObject go in _objects)
                go.paint();
        }
    }
}
