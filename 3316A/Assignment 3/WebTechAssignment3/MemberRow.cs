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
    public partial class MemberRow : UserControl
    {
        private Member _model;
        private Controller _controller;
        private Form _parent;

        public MemberRow(Member m, Controller c, Form parent, bool canEdit)
        {
            InitializeComponent();
            this.member.Text = m.getName();
            this.instrument.Text = m.getInstrument();
            this.join.Text = m.getJoinDate();
            this._controller = c;
            this._model = m;
            this._parent = parent;
            if(canEdit)
                this.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void click(object sender, EventArgs e)
        {
            _controller.highlightMember(this, _model,_parent);
        }
        public void setGreen()
        {
            this.member.ForeColor = System.Drawing.Color.Green;
            this.instrument.ForeColor = System.Drawing.Color.Green;
            this.join.ForeColor = System.Drawing.Color.Green;
        }
        public void setNormal()
        {
            this.member.ForeColor = new System.Drawing.Color();
            this.instrument.ForeColor = new System.Drawing.Color();
            this.join.ForeColor = new System.Drawing.Color();
        }
    }
}
