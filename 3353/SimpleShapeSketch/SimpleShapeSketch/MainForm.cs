using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleShapeSketch
{
    public partial class MainForm : Form
    {
        private bool _mouseDown;

        public MainForm(System.Drawing.Color color)
        {
            InitializeComponent();
            //Default colour
            colorButton.BackColor = color;
            // Default mouse state
            _mouseDown = false;
        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            Program._selected = null;
            // Create and show dialog
            if (colorDialog == null)
                colorDialog = new System.Windows.Forms.ColorDialog();

            colorDialog.Color = Program.Color;
            colorDialog.ShowDialog();

            // Get the color
            System.Drawing.Color color = colorDialog.Color;

            // Change button and inform main program
            colorButton.BackColor = color;
            Program._color = color;
        }

        public System.Drawing.Graphics getCanvas()
        {
            return Canvas.CreateGraphics();
        }
        public void refreshCanvas()
        {
            Canvas.Refresh();
        }
        private void selectButton_Click(object sender, EventArgs e)
        {
            Program.Selected = null;
            Program.CurrentState = Program.State.Pointer;
        }

        private void freeDrawButton_Click(object sender, EventArgs e)
        {
            Program.Selected = null;
            Program.CurrentState = Program.State.FreeDraw;
        }

        private void straightLineButton_Click(object sender, EventArgs e)
        {
            Program.Selected = null;
            Program.CurrentState = Program.State.StraighLine;
        }

        private void squareButton_Click(object sender, EventArgs e)
        {
            Program.Selected = null;
            Program.CurrentState = Program.State.Square;
        }

        private void rectangleButton_Click(object sender, EventArgs e)
        {
            Program.Selected = null;
            Program.CurrentState = Program.State.Rectangle;
        }

        private void circleButton_Click(object sender, EventArgs e)
        {
            Program.Selected = null;
            Program.CurrentState = Program.State.Circle;
        }

        private void ellipseButton_Click(object sender, EventArgs e)
        {
            Program.Selected = null; 
            Program.CurrentState = Program.State.Ellipse;
        }

        private void polygonButton_Click(object sender, EventArgs e)
        {
            Program.Selected = null;
            Program.CurrentState = Program.State.Polygon;
        }

        private void closedPolygonButton_Click(object sender, EventArgs e)
        {
            Program.Selected = null;
            Program.CurrentState = Program.State.ClosedPolygon;
        }

        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseDown = true;
            Program.mouseDown(e.Location);
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (_mouseDown)
                Program.mouseDrag(e.Location);
        }

        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            _mouseDown = false;
            Program.mouseUp(e);
        }


        internal void setUndo(bool p)
        {
            undoButton.Enabled = p;
            undoToolStripMenuItem.Enabled = p;
        }

        internal void setRedo(bool p)
        {
            redoButton.Enabled = p;
            redoToolStripMenuItem.Enabled = p;
        }

        private void undoButton_Click(object sender, EventArgs e)
        {
            Program.undo();
        }

        private void redoButton_Click(object sender, EventArgs e)
        {
            Program.redo();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.redo();
        }

        private void moveButton_Click(object sender, EventArgs e)
        {
            Program.CurrentState = Program.State.Move;
            Cursor = Cursors.SizeAll;
            Cursor.Position = Canvas.PointToScreen(Program.Selected.TopLeft);
            _mouseDown = true;
        }

        internal void setMove(bool p)
        {
            moveButton.Enabled = p;
        }

        internal void setCutCopy(bool p)
        {
            copyToolStripMenuItem.Enabled = p;
            cutToolStripMenuItem.Enabled = p;
        }
        internal void setPaste(bool p)
        {
            pasteToolStripMenuItem.Enabled = p;
        }
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.copy();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.cut();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.paste();
        }
    }
}
