using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Color
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void redButton_Click(object sender, EventArgs e)
        {
            if(this.ActiveControl.GetType() == typeof(TextBox))
            {
                this.ActiveControl.BackColor = System.Drawing.Color.Red;
            }
        }

        private void greenButton_Click(object sender, EventArgs e)
        {
            if (this.ActiveControl.GetType() == typeof(TextBox))
            {
                this.ActiveControl.BackColor = System.Drawing.Color.Green;
            }
        }

        private void blueButton_Click(object sender, EventArgs e)
        {
            if (this.ActiveControl.GetType() == typeof(TextBox))
            {
                this.ActiveControl.BackColor = System.Drawing.Color.Blue;
            }
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ActiveControl.BackColor = new System.Drawing.Color();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if( MessageBox.Show("Do you really want to exit?", "Confirm Exit", MessageBoxButtons.YesNo) == DialogResult.Yes )            
                Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //do nothing
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string submittedString = "Submitted: \n";
            submittedString += "Name: " + textBox1.Text;
            submittedString += "\n";
            submittedString += "Age: " + textBox2.Text;
            MessageBox.Show(submittedString, "Submit Confirmation");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox1.BackColor = new System.Drawing.Color();
            textBox2.BackColor = new System.Drawing.Color();
        }

    }
}