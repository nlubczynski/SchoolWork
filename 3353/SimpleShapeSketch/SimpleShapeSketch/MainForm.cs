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
            colorButton.BackColor = color;
            _mouseDown = false;
        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            // Create and show dialog
            if (colorDialog == null)
            {
                colorDialog = new System.Windows.Forms.ColorDialog();
                colorDialog.Color = Program._color;
            }
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
            Program.CurrentState = Program.State.Pointer;
        }

        private void freeDrawButton_Click(object sender, EventArgs e)
        {
            Program.CurrentState = Program.State.FreeDraw;
        }

        private void straightLineButton_Click(object sender, EventArgs e)
        {
            Program.CurrentState = Program.State.StraighLine;
        }

        private void squareButton_Click(object sender, EventArgs e)
        {
            Program.CurrentState = Program.State.Square;
        }

        private void rectangleButton_Click(object sender, EventArgs e)
        {
            Program.CurrentState = Program.State.Rectangle;
        }

        private void circleButton_Click(object sender, EventArgs e)
        {
            Program.CurrentState = Program.State.Circle;
        }

        private void ellipseButton_Click(object sender, EventArgs e)
        {
            Program.CurrentState = Program.State.Ellipse;
        }

        private void polygonButton_Click(object sender, EventArgs e)
        {
            Program.CurrentState = Program.State.Polygon;
        }

        private void moveButton_Click(object sender, EventArgs e)
        {
            Program.CurrentState = Program.State.Move;
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
        }

    }
}
