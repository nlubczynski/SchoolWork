using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebTechAssignment3
{
    public partial class ShowRow : UserControl
    {
        private Controller _controller;
        private Show _model;

        public ShowRow(Controller c, Show s, string venue, string date)
        {
            _controller = c;
            _model = s;
            InitializeComponent();

            this.venueLabel.Text = venue;
            this.dateLabel.Text = date;
        }
        internal void initialize()
        {
            foreach (Control c in this.Controls)
                c.Width = this.Parent.Width;
        }

        private void venueLabel_Click(object sender, EventArgs e)
        {
            _controller.showClick(this, _model);
        }

        private void dateLabel_Click(object sender, EventArgs e)
        {
            _controller.showClick(this, _model);
        }
        public void setGreen()
        {
            this.venueLabel.ForeColor = System.Drawing.Color.Green;
            this.dateLabel.ForeColor = System.Drawing.Color.Green;
        }
        public void setNormal()
        {
            this.venueLabel.ForeColor = new System.Drawing.Color();
            this.dateLabel.ForeColor = new System.Drawing.Color();
        }
    }
}
