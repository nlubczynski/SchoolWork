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
        AddAlbum _view;

        public SongRow(Controller c, Song s, Album a, AddAlbum view)
        {
            _controller = c;
            _model = s;
            _parent = a;
            _view = view;

            InitializeComponent();

            this.songName.Text = _model.getName();
            this.lengthLabel.Text = parseTime(_model.getlength());
        }
        public static string parseTime(string length)
        {
            try
            {
                string minutes = "";
                string seconds = "";

                length = length.Substring(2);

                minutes = length.Substring(0, length.IndexOf("M"));
                length = length.Substring(length.IndexOf("M") + 1);

                seconds = length.Substring(0, length.IndexOf("S"));

                return minutes + ":" + seconds;
            }
            catch
            {
                return "ERROR";
            }
        }
        internal void initialize()
        {
            foreach (Control c in this.Controls)
                c.Width = this.Parent.Width;
        }

        private void songName_Click(object sender, EventArgs e)
        {
            _controller.songClick(this, _model, _parent, _view);
        }

        private void lengthTitleLabel_Click(object sender, EventArgs e)
        {
            _controller.songClick(this, _model, _parent, _view);
        }

        private void lengthLabel_Click(object sender, EventArgs e)
        {
            _controller.songClick(this, _model, _parent, _view);
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

        private void songName_Click_1(object sender, EventArgs e)
        {
            if(_view != null)
                _controller.songClick(this, _model, _parent, _view);
        }

        private void lengthTitleLabel_Click_1(object sender, EventArgs e)
        {
            if (_view != null)
                _controller.songClick(this, _model, _parent, _view);
        }

        private void lengthLabel_Click_1(object sender, EventArgs e)
        {
            if (_view != null)
                _controller.songClick(this, _model, _parent, _view);
        }
    }
}
