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
    public partial class AddReview : Form
    {
        private Controller _controller;
        private Reviewer[] _reviewers;
        private bool _isEdit;
        
        public AddReview(Controller c, Reviewer[] reviewers, bool isEdit)
        {
            _controller = c;
            _isEdit = isEdit;
            InitializeComponent();

            this.reviewerIdComboBox.Items.AddRange(reviewers);
        }
        public AddReview(Controller c, Reviewer[] reviewers, bool isEdit, Review r)
            : this(c, reviewers, isEdit)
        {
            foreach(Reviewer rev in reviewers)
                if(rev.getId().Equals(r.getReviewerId()))
                    this.reviewerIdComboBox.SelectedItem = rev;

            this.reviewBox.Text = r.getReview();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            _controller.close(this);
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (_controller.saveReviewer((Reviewer)this.reviewerIdComboBox.SelectedItem, this.reviewBox.Text, _isEdit))
                _controller.close(this);
        }
    }
}
