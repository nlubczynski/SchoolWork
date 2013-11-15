using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebTechAssignment3
{
    public partial class AddSong : Form
    {
        Controller _controller;
        bool _isEdit;
        AddAlbum _parent;

        public AddSong(Controller c, AddAlbum parent)
        {
            _controller = c;
            _isEdit = false;
            _parent = parent;
            InitializeComponent();
            this.removeSong.Visible = false;
        }
        public AddSong(Controller c, AddAlbum parent, string name, string length) : this(c, parent)
        {
            _isEdit = true;
            this.Text = "Edit Song";
            this.removeSong.Visible = true;
            this.lengthBox.Text = length;
            this.nameBox.Text = name;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            _controller.close(this);
        }

        private void save_Click(object sender, EventArgs e)
        {
            if(_controller.saveSong(this, this.nameBox.Text, this.lengthBox.Text, _isEdit, _parent))
                _controller.close(this);
        }

        private void removeSong_Click(object sender, EventArgs e)
        {
            _controller.removeSong(_parent);
            _controller.close(this);
        }
    }
}
