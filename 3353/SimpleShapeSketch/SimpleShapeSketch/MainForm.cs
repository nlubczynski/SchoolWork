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
        public MainForm(System.Drawing.Color color)
        {
            InitializeComponent();
            colorButton.BackColor = color;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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

    }
}
