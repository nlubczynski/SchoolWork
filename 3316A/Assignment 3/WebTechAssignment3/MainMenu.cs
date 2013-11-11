using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebTechAssignment3
{
    public partial class MainMenu : Form
    {
        private Controller controller;

        public MainMenu(Controller c)
        {
            InitializeComponent();
            this.controller = c;
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void select_click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "XML files (*.xml)|*.xml";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.fileTextBox.Text = openFileDialog.FileName;
            }
        }
        private void validate_click(object sender, EventArgs e)
        {
            string filePath = this.fileTextBox.Text;
            controller.validate(filePath, this);
        }
        private void open_click(object sender, EventArgs e)
        {
            string filePath = this.fileTextBox.Text;
            controller.openClick(filePath, this);
        }

        private void create_click(object sender, EventArgs e)
        {
            controller.openFile("", this, true);
        }
        public bool get_open_state()
        {
            return this.open.Enabled;
        }
        public void set_open_state(bool state)
        {
            this.open.Enabled = state;
        }
        private void text_change(object sender, EventArgs e)
        {
            controller.mainMenuTextChange(this);
        }
    }
}
