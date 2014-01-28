using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Validation
{
    public partial class Validation : Form
    {
        public Validation()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            Close();
        }


        private void Validation_Load(object sender, System.EventArgs e)
        {

        }


    }
}