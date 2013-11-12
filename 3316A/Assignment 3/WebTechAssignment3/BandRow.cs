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
    public partial class BandRow : UserControl
    {
        private Controller _controller;
        private Band _model;
        private Form _parent;

        public BandRow(Band b, Controller controller, Form parent, bool canEditMembers)
        {
            InitializeComponent();
            this._controller = controller;
            this._model = b;
            this._parent = parent;

            this.band.Text = b.getName();
            int i = 0;
            foreach (Member member in b.getMembers())
            {
                MemberRow row = new MemberRow(member, _controller, _parent, canEditMembers);
                row.Top = row.Height * i + this.Height;                
                this.Controls.Add(row);
                i++;
            }

            //update the height
            MemberRow temp = new MemberRow(b.getMembers()[0], _controller, _parent, canEditMembers);
            this.Height += i * temp.Height;
        }
        public void initialize()
        {
            foreach(Control c in this.Controls)
                c.Width = this.Parent.Width;
        }

        public Label getBandLabel()
        {
            return this.band;
        }
        private void bandHighlight(object sender, System.EventArgs e)
        {
            _controller.highlightBand(this);
        }
        public void setGreen()
        {
            this.band.ForeColor = System.Drawing.Color.Green;
        }
        public void setNormal()
        {
            this.band.ForeColor = new System.Drawing.Color();
        }
        public Band getModel()
        {
            return _model;
        }
    }
}
