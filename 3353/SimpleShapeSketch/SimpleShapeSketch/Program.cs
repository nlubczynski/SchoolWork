﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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
        //previous point
        public static Point previousPoint;
        // Cut/copy memory
        public static GraphicalObject _cutCopyMemory;
        // Caretaker
        public static Caretaker _caretaker;

        public enum State
        {
            Pointer, FreeDraw, StraighLine, Square, Rectangle, Circle, Ellipse, Polygon, ClosedPolygon, Move, Group,
            UnGroup
        }
        public static State CurrentState
        {
            get { return _state; }
            set
            {
                // Reset cursor
                _form.Cursor = Cursors.Arrow;
                // Store value
                _state = value;
            }
        }
        public static System.Drawing.Color Color
        {
            get { return _color; }
            set { _color = value; }
        }
        public static GraphicalObject Selected
        {
            get { return _selected; }
            set
            {
                // Clear the selected alpha
                clearSelected();
                // Set selected, and set it's alpha
                _selected = value;
                if (_selected != null)
                {
                    // Set selected alpha
                    _selected.Color = Color.FromArgb(150, _selected.Color.R, _selected.Color.G, _selected.Color.B);
                    // Enable move button
                    _form.setMove(true);
                    // Enable copy / cut
                    _form.setCutCopy(true);
                }
                else
                {
                    // Disable move
                    _form.setMove(false);
                    // Disable copy / cut
                    _form.setCutCopy(false);
                }
            }
        }
        public static GraphicalObject CutCopyMemory
        {
            get { return _cutCopyMemory; }
            set
            {
                // Store value
                _cutCopyMemory = value;

                //Enable paste
                if (value != null)
                    _form.setPaste(true);
                else
                    _form.setPaste(false);
            }
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
            _caretaker = new Caretaker();
            //_caretaker.add(new Memento(_objects));
            // Create the main window
            Application.Run(_form);
        }

        public static void addAction()
        {
            // Backup
            Memento memento = new Memento(_objects);
            _caretaker.add(memento);
            redoUndoCheck();
        }
        public static void mouseDown(System.Drawing.Point point)
        {

            // Back up prev state
            switch (_state)
            {
                case State.Pointer:
                case State.Polygon:
                    break;

                default:
                    addAction();
                    break;
            }

            // Handle create
            switch (_state)
            {
                case State.Square:
                    _anchorPoint = point;
                    _objects.Add(new Square(point.X, point.Y, point.X, point.Y, _form.getCanvas(), _color));
                    Program.Selected = _objects.Last();
                    break;

                case State.Ellipse:
                    _anchorPoint = point;
                    _objects.Add(new Ellipse(point.X, point.Y, point.X, point.Y, _form.getCanvas(), _color));
                    Program.Selected = _objects.Last();
                    break;

                case State.StraighLine:
                    _anchorPoint = point;
                    _objects.Add(new Line(point.X, point.Y, point.X, point.Y, _form.getCanvas(), _color));
                    Program.Selected = _objects.Last();
                    break;

                case State.Polygon:
                    {
                        _anchorPoint = point;
                        if (_selected == null)
                        {
                            //backup
                            addAction();

                            UnClosedPolygon polygon = new UnClosedPolygon(point.X, point.Y, point.X, point.Y, _form.getCanvas(), _color);

                            polygon.addLine(new Line(point.X, point.Y, point.X, point.Y, _form.getCanvas(), _color));
                            _objects.Add(polygon);

                            Program.Selected = _objects.Last();
                            previousPoint = point;
                            break;
                        }
                        else
                        {
                            ((UnClosedPolygon)_objects.Last()).addLine(new Line(previousPoint.X, previousPoint.Y, point.X, point.Y, _form.getCanvas(), _color));
                            Program.Selected = _objects.Last();
                            previousPoint = point;
                            break;

                        }
                    }
                case State.FreeDraw:
                    _anchorPoint = point;
                    _objects.Add(new FreeFormLine(point.X, point.Y, point.X, point.Y, _form.getCanvas(), _color));
                    Program.Selected = _objects.Last();
                    previousPoint = point;
                    break;

                case State.ClosedPolygon:
                    {
                        _anchorPoint = point;
                        if (_selected == null)
                        {
                            _objects.Add(new Polygon(point.X, point.Y, point.X, point.Y, _form.getCanvas(), _color));
                            Program.Selected = _objects.Last();
                            break;
                        }
                        else
                        {
                            ((Polygon)Program.Selected).addPoint(point);
                            break;
                        }
                    }
                case State.Rectangle:
                    _anchorPoint = point;
                    _objects.Add(new Rectangle(point.X, point.Y, point.X, point.Y, _form.getCanvas(), _color));
                    Program.Selected = _objects.Last();
                    break;

                case State.Circle:
                    _anchorPoint = point;
                    _objects.Add(new Circle(point.X, point.Y, point.X, point.Y, _form.getCanvas(), _color));
                    Program.Selected = _objects.Last();
                    break;

                case State.Pointer:
                    _anchorPoint = point;
                    foreach(GraphicalObject go in _objects)
                        if(go.contains(point))
                            Program.Selected = go;

                    // show the user what they selected
                    if (_selected != null)
                    {
                        Program.Selected.Color = Color.FromArgb(150, _selected.Color.R, _selected.Color.G, _selected.Color.B);
                    }

                    break;

                case State.Group:
                     _anchorPoint = point;
  
                    foreach(GraphicalObject go in _objects)
                    {
                        if (go.contains(point))
                        {
                            if (_selected == null)
                            {
                                _objects.Add(new GroupedObject(point.X, point.Y, point.X, point.Y, _form.getCanvas(), _color));
                                Program.Selected = _objects.Last();
                            }

                            GroupedObject groupedObject = ((GroupedObject)_objects.Last());
                            groupedObject.addObject(go);
                            Program.Selected = groupedObject;

                            _objects.Remove(go);

                            break;
                        }
                    }

                    // show the user what they selected
                    if (_selected != null)
                    {
                        Program.Selected.Color = Color.FromArgb(150, _selected.Color.R, _selected.Color.G, _selected.Color.B);
                    }

                    break;

                case State.UnGroup:
                    _anchorPoint = point;

                    foreach (GraphicalObject go in _objects)
                    {
                        if (go.contains(point))
                        {
                            if (!(go.GetType().Name == "GroupedObject"))
                                break;

                            GraphicalObject rmved = ((GroupedObject)go).removeObject(point);
                            _objects.Add(rmved);

                            Program.Selected = _objects.Last();

                            // if grouped object doesn't exist anymore with objects
                            if (((GroupedObject)go).getGroupedObjectList().Count == 0)
                            {
                                _objects.Remove(go);
                            }

                            break;
                        }
                    }

                    // show the user what they selected
                    if (_selected != null)
                    {
                        Program.Selected.Color = Color.FromArgb(150, _selected.Color.R, _selected.Color.G, _selected.Color.B);
                    }

                    break;

                case State.Move:
                    // Reset the cursor
                    _form.Cursor = Cursors.Arrow;
                    CurrentState = State.Pointer;
                    _form.setPointerButtonSelected();
                    break;

            }

            //Check for undo / redo
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
                    _selected.resize(topLeft.X, topLeft.Y, bottomRight.X, bottomRight.Y, quadrant);
                    break;

                case State.FreeDraw:
                    if (Program.Selected == null)
                        break;
                    //Resize
                    ((FreeFormLine)Program.Selected).addLine(new Line(previousPoint.X, previousPoint.Y, point.X, point.Y, _form.getCanvas(), _color));
                    previousPoint = point;
                    break;

                case State.Circle:
                    if (_selected == null)
                        break;
                    // Resize
                    Selected.resize(topLeft.X, topLeft.Y, bottomRight.X, bottomRight.Y, quadrant);
                    break;

                case State.Move:
                    Selected.move(point.X - Selected.TopLeft.X, point.Y - Selected.TopLeft.Y);
                    break;
            }

            // Repaint
            repaint();
        }
        public static void repaint()
        {
            // Refresh
            _form.refreshCanvas();

            // Draw last change
            foreach (GraphicalObject go in _objects)
                go.paint();
        }

        internal static void undo()
        {
            // Undo
            _objects = _caretaker.undo(new Memento(_objects)).restore();

            // Change selected
            if(_objects.Count() > 0)
                Selected = _objects.Last();

            //Check for redo undo
            redoUndoCheck();

            // Repaint
            repaint();
        }

        internal static void redo()
        {
            // Redo
            _objects = _caretaker.redo(new Memento(_objects)).restore();

            // Change selected
            Selected = _objects.Last();

            //Check for redo undo
            redoUndoCheck();

            // Repaint
            repaint();
        }
        static internal void redoUndoCheck()
        {
            bool undo = _caretaker.canUndo();
            bool redo = _caretaker.canRedo();
            _form.setRedo(redo);
            _form.setUndo(undo);
        }
        static private void clearSelected()
        {
            // Undo prev tranparency
            if (_selected != null)
            {
                _selected.Color = Color.FromArgb(255, _selected.Color.R, _selected.Color.G, _selected.Color.B);
            }
        }

        internal static void copy()
        {
            // Store to memory
            CutCopyMemory = Selected;
        }

        internal static void cut()
        {
            // Store
            addAction();

            // Store to memory
            CutCopyMemory = Selected;

            // Remove from screen
            _objects.Remove(Selected);
            _objects.TrimExcess();
            repaint();
        }

        internal static void paste()
        {
            // Backup
            addAction();

            // Add a copy
            _objects.Add(CutCopyMemory.Clone());
            // Set it as selected
            Selected = _objects.Last();
            //Repaint
            repaint();
        }
        public static System.Drawing.Graphics getCanvas()
        {
            return _form.getCanvas();
        }

        internal static void mouseUp(MouseEventArgs e)
        {
        }
        internal static void save()
        {
            //Make none selected
            Selected = null;

            //Save as string
            string saveData = _objects.ToXmlString();

            //Create save dialog
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Sketcher Format | *.PAINT";
            saveDialog.AddExtension = true;
            saveDialog.DefaultExt = "PAINT";

            // Get user saved location
            string file;

            // Run the save
            if (DialogResult.OK == saveDialog.ShowDialog())
            {
                file = saveDialog.FileName;
                File.WriteAllText(file, saveData);
            }
            else
            {
                MessageBox.Show("Error", "File was not saved", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
        internal static void load()
        {
            // Create dialog
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Sketcher Format | *.PAINT";
            openDialog.DefaultExt = "PAINT";

            // Show it
            if (DialogResult.OK == openDialog.ShowDialog()) 
            {
                string file = openDialog.FileName;

                string saveData = File.ReadAllText(file);

                //Load objects and reinject graphics
                List<GraphicalObject> savedObjects = XmlTools.FromXmlString<List<GraphicalObject>>(saveData);
                foreach (GraphicalObject go in savedObjects)
                    go.Graphics = getCanvas();

                //Display
                _objects = savedObjects;

                //Selected
                Selected = null;

                //repaint
                repaint();
            }
            else
            {
                MessageBox.Show("Error", "File was not opened", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        internal static void reset()
        {
            _objects = new List<GraphicalObject>();
            _caretaker = new Caretaker();
            redoUndoCheck();
            repaint();
        }
    }
}
