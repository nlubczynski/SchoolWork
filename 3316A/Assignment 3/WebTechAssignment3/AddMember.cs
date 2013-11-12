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
    public partial class AddMember : Form
    {
        private Controller _controller;
        private Form _parent;
        private bool _isEdit;

        public AddMember(Controller c, Form parent)
        {
            InitializeComponent();
            this._controller = c;
            this._parent = parent;
            this._isEdit = false;
        }
        public AddMember(string name, string instrument, string joinDate, Controller c, Form parent)
        {
            InitializeComponent();
            this._controller = c;
            this._parent = parent;
            this.nameBox.Text = name;
            this.instrumentBox.Text = instrument;
            this.joinBox.Text = joinDate;
            this._isEdit = true;
            this.removeButton.Visible = true;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            _controller.close(this);
        }

        private void save_Click(object sender, EventArgs e)
        {
            _controller.saveMemeber(this.nameBox.Text, this.instrumentBox.Text, this.joinBox.Text, this, _parent, _isEdit);
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            _controller.removeMember((AddBand)_parent, this);
        }

    }
}
