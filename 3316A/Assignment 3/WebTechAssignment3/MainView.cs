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
        public MainView(Controller c)
        {
            InitializeComponent();
            this._controller = c;
            this.UseWaitCursor = false;
            this.dataGridView1.Cursor = this.Cursor;
        }
        public void initialize(Band[] bandsSource)
        {
            List<Band> bands = new List<Band>();

            foreach(Band band in bandsSource)
                bands.Add(band);

            var bandsDataSource = bands.Select(b => new { 
                Band = b.getName(), 
                Size = b.getSize() 
            }).ToList();

            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = bandsDataSource;
            
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
