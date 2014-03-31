using System;
using System.Collections.Generic;
using System.Drawing;
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
        //List of undone objects
        public static List<GraphicalObject> _undoneObjects;
        //The currently selected object
        public static GraphicalObject _selected;
        //The point at which the newest item was created at
        public static System.Drawing.Point _anchorPoint;
        //Our main form
        public static MainForm _form;
        //previous point
        public static Point previousPoint;

        public enum State
        {
            Pointer, FreeDraw, StraighLine, Square, Rectangle, Circle, Ellipse, Polygon, ClosedPolygon
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
            _undoneObjects = new List<GraphicalObject>();
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

                case State.Ellipse:
                    _anchorPoint = point;
                    _objects.Add(new Ellipse(point.X, point.Y, point.X, point.Y, _form.getCanvas(), _color));
                    _selected = _objects.ElementAt(_objects.Count - 1);
                    break;

                case State.StraighLine:
                    _anchorPoint = point;
                    _objects.Add(new Line(point.X, point.Y, point.X, point.Y, _form.getCanvas(), _color));
                    _selected = _objects.ElementAt(_objects.Count - 1);
                    break;

                case State.Polygon:
                case State.FreeDraw:
                    _anchorPoint = point;
                    _objects.Add(new Line(point.X, point.Y, point.X, point.Y, _form.getCanvas(), _color));
                    _selected = _objects.ElementAt(_objects.Count - 1);
                    break;

                case State.ClosedPolygon:
                    {
                        _anchorPoint = point;
                        if (_selected == null)
                        {
                            _objects.Add(new Polygon(point.X, point.Y, point.X, point.Y, _form.getCanvas(), _color));
                            _selected = _objects.ElementAt(_objects.Count - 1);
                            break;
                        }
                        else
                        {
                            ((Polygon)_selected).addPoint(point);
                            break;
                        }
                    }
                case State.Rectangle:
                    _anchorPoint = point;
                    _objects.Add(new Rectangle(point.X, point.Y, point.X, point.Y, _form.getCanvas(), _color));
                    _selected = _objects.ElementAt(_objects.Count - 1);
                    break;

                case State.Circle:
                    _anchorPoint = point;
                    _objects.Add(new Circle(point.X, point.Y, point.X, point.Y, _form.getCanvas(), _color));
                    _selected = _objects.ElementAt(_objects.Count - 1);
                    break;


            }

            //Check for undo / redo
            _undoneObjects.Clear();
            redoUndoCheck();

            // Repaint
            repaint();
        }
        public static void mouseDrag(System.Drawing.Point point)
        {
            // Find the true points
            System.Drawing.Point topLeft, bottomRight;
            GraphicalObject.DrawQuadrant quadrant;
            if (_anchorPoint.X <= point.X && _anchorPoint.Y <= point.Y)
            {
                topLeft = _anchorPoint;
                bottomRight = point;
                quadrant = GraphicalObject.DrawQuadrant.BottomRight;
            }
            else if (_anchorPoint.X <= point.X && _anchorPoint.Y > point.Y)
            {
                topLeft = new System.Drawing.Point(_anchorPoint.X, point.Y);
                bottomRight = new System.Drawing.Point(point.X, _anchorPoint.Y);
                quadrant = GraphicalObject.DrawQuadrant.TopRight;
            }
            else if (_anchorPoint.X > point.X && _anchorPoint.Y > point.Y)
            {
                topLeft = point;
                bottomRight = _anchorPoint;
                quadrant = GraphicalObject.DrawQuadrant.TopLeft;
            }
            else
            {
                topLeft = new System.Drawing.Point(point.X, _anchorPoint.Y);
                bottomRight = new System.Drawing.Point(_anchorPoint.X, point.Y);
                quadrant = GraphicalObject.DrawQuadrant.BottomLeft;
            }

            switch (_state)
            {
                case State.Square:
                    if (_selected == null)
                        break;

                    // Resize
                    _selected.resize(topLeft.X, topLeft.Y, bottomRight.X, bottomRight.Y, quadrant);
                    break;

                case State.Rectangle:
                    if (_selected == null)
                        break;

                    // Resize
                    _selected.resize(topLeft.X, topLeft.Y, bottomRight.X, bottomRight.Y, quadrant);
                    break;

                case State.Ellipse:
                    if (_selected == null)
                        break;

                    // Resize
                    _selected.resize(topLeft.X, topLeft.Y, bottomRight.X, bottomRight.Y, quadrant);
                    break;

                case State.StraighLine:
                    if (_selected == null)
                        break;
                    // Resize
                    _selected.resize(topLeft.X, topLeft.Y, bottomRight.X, bottomRight.Y,quadrant);
                    break;

                case State.FreeDraw:
                    _anchorPoint = point;
                    if (_selected == null)
                        break;
                    //Resize
                    _objects.Add(new Line(previousPoint.X, previousPoint.Y, point.X, point.Y, _form.getCanvas(), _color));
                    _selected = _objects.ElementAt(_objects.Count - 1);
                    previousPoint = point;
                    break;


                case State.Circle:
                    if (_selected == null)
                        break;

                    // Resize
                    _selected.resize(topLeft.X, topLeft.Y, bottomRight.X, bottomRight.Y, quadrant);
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

        internal static void undo()
        {
            // Pop last object into undone objects
            _undoneObjects.Add(_objects.ElementAt(_objects.Count - 1));
            _objects.RemoveAt(_objects.Count - 1);

            //Check for redo undo
            redoUndoCheck();

            // Repaint
            repaint();
        }

        internal static void redo()
        {
            // Pop last undone object into objects
            _objects.Add(_undoneObjects.ElementAt(_undoneObjects.Count - 1));
            _undoneObjects.RemoveAt(_undoneObjects.Count - 1);

            //Check for redo undo
            redoUndoCheck();
            
            // Repaint
            repaint();
        }
        static internal void redoUndoCheck()
        {
            bool undo = _objects.Count > 0 ? true : false;
            bool redo = _undoneObjects.Count > 0 ? true : false;
            _form.setRedo(redo);
            _form.setUndo(undo);
        }
    }
}
