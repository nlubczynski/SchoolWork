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
    public partial class AddShow : Form
    {
        private Controller _controller;
        private bool _isEdit;
        private int _index;

        public AddShow(Controller c,  bool isEdit, int index)
        {
            _controller = c;
            _isEdit = isEdit;
            _index = index;

            InitializeComponent();
        }
        public AddShow(Controller c, bool isEdit, int index, string date, string venue)
            : this(c, isEdit, index)
        {
            this.dateBox.Text = date;
            this.venueBox.Text = venue;
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (_controller.saveShow(dateBox.Text, venueBox.Text, _isEdit, _index))
                _controller.close(this);
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            _controller.close(this);
        }
    }
}
