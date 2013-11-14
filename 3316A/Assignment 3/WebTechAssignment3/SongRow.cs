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
    public partial class SongRow : UserControl
    {
        Controller _controller;
        Song _model;
        Album _parent;
        AlbumRow _parent_row;

        public SongRow(Controller c, Song s, Album a, AlbumRow row)
        {
            _controller = c;
            _model = s;
            _parent = a;
            _parent_row = row;

            InitializeComponent();

            this.songName.Text = _model.getName();
            this.lengthLabel.Text = parseTime(_model.getlength());
        }
        private string parseTime(string length)
        {
            string minutes = "";
            string seconds = "";

            length = length.Substring(2);

            minutes = length.Substring(0, length.IndexOf("M"));
            length = length.Substring(length.IndexOf("M") + 1);

            seconds = length.Substring(0, length.IndexOf("S"));

            return minutes + ":" + seconds;
        }
        internal void initialize()
        {
            foreach (Control c in this.Controls)
                c.Width = this.Parent.Width;
        }

        private void songName_Click(object sender, EventArgs e)
        {
            _controller.songClick(this, _parent, _parent_row);
        }

        private void lengthTitleLabel_Click(object sender, EventArgs e)
        {
            _controller.songClick(this, _parent, _parent_row);
        }

        private void lengthLabel_Click(object sender, EventArgs e)
        {
            _controller.songClick(this, _parent, _parent_row);
        }
        public void setGreen()
        {
            this.songName.ForeColor = System.Drawing.Color.Green;
            this.lengthTitleLabel.ForeColor = System.Drawing.Color.Green;
            this.lengthLabel.ForeColor = System.Drawing.Color.Green;
        }
        public void setNormal()
        {
            this.songName.ForeColor = new System.Drawing.Color();
            this.lengthLabel.ForeColor = new System.Drawing.Color();
            this.lengthTitleLabel.ForeColor = new System.Drawing.Color();
        }
    }
}
