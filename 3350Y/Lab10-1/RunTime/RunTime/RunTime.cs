using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RunTime
{
    public partial class RunTime : Form
    {
        public RunTime()
        {
            InitializeComponent();
        }

 
        private void Runtime_Load(object sender, System.EventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Label temp = new Label();
            
            temp.Text = tbxText.Text;
            if (temp.Text.Length == 0)
                return;

            tbxText.Text = "";
            
            temp.Location = new Point((int)nudX.Value, (int)nudY.Value);
            nudX.Value = 0;
            nudY.Value = 0;

            pnlControls.Controls.Add(temp);

            temp.Visible = true;

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            while (pnlControls.Controls.Count > 0)
                pnlControls.Controls.RemoveAt(0);
        }



    }
}