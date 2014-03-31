using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleShapeSketch
{
    static class Program
    {

        public static State _state;
        public static System.Drawing.Color _color;
        public static List<GraphicalObject> _objects;
        public static GraphicalObject _selected;
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
                    _objects.Add(new Square(point.X, point.Y, point.X, point.Y, _form.getCanvas(), _color));
                    _selected = _objects.ElementAt(_objects.Count - 1);
                    break;
            }

            // Repaint
            repaint();
        }
        public static void mouseDrag(System.Drawing.Point point)
        {
            switch (_state)
            {
                case State.Square:
                    if (_selected == null)
                        break;

                    // Find the true points
                    int topLeft_x = _selected.TopLeft.X < point.X ? _selected.TopLeft.X : point.X;
                    int topLeft_y = _selected.TopLeft.Y < point.Y ? _selected.TopLeft.Y : point.Y;
                    int bottomRight_x = _selected.BottomRight.X > point.X ? _selected.BottomRight.X : point.X;
                    int bottomRight_y = _selected.BottomRight.Y > point.Y ? _selected.BottomRight.Y : point.Y;

                    // Resize
                    _selected.resize(topLeft_x, topLeft_y, bottomRight_x, bottomRight_y);
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
