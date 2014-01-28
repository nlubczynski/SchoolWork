using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace practice_2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SE3350button_MouseMove(object sender, MouseEventArgs e)
        {
            if (Control.ModifierKeys != Keys.Shift)
            {
                SE3350button.Text = "SE3350";

                SE3350button.Top -= e.Y;
                SE3350button.Left += e.X;

                if (SE3350button.Top < 0 || SE3350button.Top > 244)
                    SE3350button.Top = 187;

                if (SE3350button.Left < 0 || SE3350button.Left > 217)
                    SE3350button.Left = 106;
            }
        }

        private void SE3350button_Click(object sender, EventArgs e)
        {
            SE3350button.Text = "You Win!";
        }
    }
}