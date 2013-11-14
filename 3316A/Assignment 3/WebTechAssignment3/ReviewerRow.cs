using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WebTechAssignment3
{
    class ReviewerRow : UserControl
    {
        private Reviewer _model;
        private Controller _controller;
        private Form _parent;
        private bool _isEdit;

        public ReviewerRow(Reviewer r, Controller controller, Form parent, bool canEditMembers)
        {
            _model = r;
            _controller = controller;
            _parent = parent;
            _isEdit = canEditMembers;
        }
        public ReviewerRow(Reviewer r, Controller controller, Form parent) : this(r, controller, parent, false){}

        public void initialize()
        {
            foreach (Control c in this.Controls)
                c.Width = this.Parent.Width;
        }
    }
}
