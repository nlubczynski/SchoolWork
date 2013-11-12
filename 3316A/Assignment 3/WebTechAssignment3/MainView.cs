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
    public partial class MainView : Form
    {
        private Controller _controller;
        private Band[] _b;
        private List<BandRow> rows;

        public MainView(Controller c)
        {
            InitializeComponent();
            this._controller = c;
            this.UseWaitCursor = false;
            this.tabs.Cursor = this.Cursor;
            this.rows = new List<BandRow>();
           
        }
        public void initialize(Band[] bandsSource)
        {
            int i = 0;
            Control lastControl = null;
            foreach (Band band in bandsSource)
            {
                BandRow row = new BandRow(band, _controller, this, false);
                //match parent's width
                row.Width = tabPage1.Width;
                //add the row
                this.tabPage1.Controls.Add(row);
                //adjust the height
                row.initialize();
                //move it down
                if (lastControl != null)
                    row.Top = lastControl.Top + lastControl.Height;
                else
                    row.Top = 0;
                //Store the "last control"
                lastControl = row;
                //Add it to the row list
                rows.Add((BandRow)lastControl);
                //increment placement
                i++;
            }           
        }

        private void MainView_Load(object sender, EventArgs e)
        {

        }
        public void addBandElement(Panel p)
        {
            this.Controls.Add(p);
        }
        private void closed(object sender, EventArgs e)
        {
            _controller.close();
        }

        private void addBand_Click(object sender, EventArgs e)
        {
            _controller.addBand();
        }

        private void editBand_Click(object sender, EventArgs e)
        {
            _controller.editBand();
        }

        private void removeBand_Click(object sender, EventArgs e)
        {
            _controller.removeBand();
        }
        public BandRow[] getRows()
        {
            return this.rows.ToArray();
        }

        internal void enableEdit()
        {
            this.editBand.Enabled = true;
        }

        internal void enableDelete()
        {
            this.removeBand.Enabled = true;
        }
        public void disableEdit()
        {
            this.editBand.Enabled = false;
        }
        public void disableDelete()
        {
            this.removeBand.Enabled = false;
        }
        public void removeAllRowsTab1()
        {
            foreach (BandRow row in rows)
                this.tabPage1.Controls.Remove(row);
        }
    }
}
