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
    public partial class AddBand : Form
    {
        private Controller _controller;
        private List<MemberRow> _rows;
        private bool _isEdit;

        public AddBand(Controller controller)
        {
            InitializeComponent();
            this._controller = controller;
            this.Text = "Add band";
            this._rows = new List<MemberRow>();
            this._isEdit = false;
        }

        public AddBand(string bandName, Controller controller)
        {
            InitializeComponent();
            this._controller = controller;
            this.nameBox.Text = bandName;
            this.Text = "Edit Band";
            this._rows = new List<MemberRow>();
            this._isEdit = true;
        }

        private void AddBand_Load(object sender, EventArgs e)
        {

        }

        private void addMember_Click(object sender, EventArgs e)
        {
            _controller.addMember(this);
        }

        private void save_Click(object sender, EventArgs e)
        {
             
            _controller.saveBand(this.nameBox.Text, _controller.getMembers(), this, _isEdit);
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            _controller.close(this);
        }

        public int getInsertHeight()
        {
                    //The location      + height                  + buffer
            return this.memberLabel.Top + this.memberLabel.Height + 5;
        }

        public int getNumberOfMembers()
        {
            return _rows.Count;
        }

        public void incrementMembers(MemberRow r)
        {
            this._rows.Add(r);
            this.Controls.Add(r);
        }

        private void editMember_Click(object sender, EventArgs e)
        {
            _controller.editMember(this);
        }

        public MemberRow[] getRows()
        {
            return _rows.ToArray();
        }

        public void enableEdit()
        {
            this.editMember.Enabled = true;
        }

        public void disalbeEdit()
        {
            this.editMember.Enabled = false;
        }

        internal void removeAllRows()
        {
            foreach(MemberRow r in _rows)
                this.Controls.Remove(r);
            _rows = new List<MemberRow>();
        }
    }
}
