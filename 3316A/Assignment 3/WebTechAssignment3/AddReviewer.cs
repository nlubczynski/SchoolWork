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
    public partial class AddReviewer : Form
    {
        private Controller _controller;
        private bool _isEdit;

        public AddReviewer(Controller c)
        {
            _controller = c;
            InitializeComponent();
            _isEdit = false;
        }
        public AddReviewer(Controller c, string name, string company, string id) : this(c)
        {
            this.nameBox.Text = name;
            this.companyBox.Text = company;
            this.idBox.Text = id;
            _isEdit = true;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if(_controller.saveReviewer(this.nameBox.Text, this.companyBox.Text, this.idBox.Text, _isEdit))
                _controller.close(this);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            _controller.close(this);
        }
    }
}
