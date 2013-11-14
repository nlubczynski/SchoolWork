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
    public partial class AlbumRow : UserControl
    {
        Controller _controller;
        Album _model;

        public AlbumRow(Controller c, Album a)
        {
            _controller = c;
            _model = a;
            InitializeComponent();

            this.albumName.Text = _model.getName();
        }

        internal void initialize()
        {
            foreach (Control c in this.Controls)
                c.Width = this.Parent.Width;
        }

        private void albumName_Click(object sender, EventArgs e)
        {
            _controller.albumClick(this, _model);
        }
        public void setGreen()
        {
            this.albumName.ForeColor = System.Drawing.Color.Green;
        }
        public void setNormal()
        {
            this.albumName.ForeColor = new System.Drawing.Color();
        }
    }
}
