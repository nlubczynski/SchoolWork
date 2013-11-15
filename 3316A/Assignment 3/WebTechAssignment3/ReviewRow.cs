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
    public partial class ReviewRow : UserControl
    {
        Controller _controller;
        Review _model;
        Album _parent;
        AlbumRow _parent_row;

        public ReviewRow(Controller c, Review r, Album a, AlbumRow row)
        {
            _controller = c;
            _model = r;
            _parent = a;
            _parent_row = row;

            InitializeComponent();

            Reviewer reviewer = _controller.getReviewer(r.getReviewerId());
            if (reviewer != null)
                this.reviewerNameLabel.Text = reviewer.getName();

            this.reviewLabel.Text = r.getReview();
        }

        internal void initialize()
        {
            foreach (Control c in this.Controls)
                c.Width = this.Parent.Width;
        }

        private void reviewerNameLabel_Click(object sender, EventArgs e)
        {
            _controller.reviewClick(this, _model, _parent, _parent_row);
        }

        private void reviewLabel_Click(object sender, EventArgs e)
        {
            _controller.reviewClick(this, _model, _parent, _parent_row);
        }
        public void setGreen()
        {
            this.reviewLabel.ForeColor = System.Drawing.Color.Green;
            this.reviewerNameLabel.ForeColor = System.Drawing.Color.Green;
        }
        public void setNormal()
        {
            this.reviewLabel.ForeColor = new System.Drawing.Color();
            this.reviewerNameLabel.ForeColor = new System.Drawing.Color();
        }
    }
}
