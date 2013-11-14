using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WebTechAssignment3
{
    public class ReviewerRow : UserControl
    {
        private Reviewer _model;
        private Controller _controller;
        private Form _parent;
        private Label nameLabel;
        private Label companyLabel;
        private Label idTitle;
        private Label idLabel;

        public ReviewerRow(Reviewer r, Controller controller, Form parent)
        {
            _model = r;
            _controller = controller;
            _parent = parent;
            InitializeComponent();

            this.nameLabel.Text = r.getName();
            if (r.getCompany().Length > 0)
                this.companyLabel.Text = r.getCompany();
            else
                this.companyLabel.Text = "No Company";
            this.idLabel.Text = r.getId();
        }

        public void initialize()
        {
            foreach (Control c in this.Controls)
                c.Width = this.Parent.Width;
        }

        private void InitializeComponent()
        {
            this.nameLabel = new System.Windows.Forms.Label();
            this.companyLabel = new System.Windows.Forms.Label();
            this.idTitle = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(3, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(50, 20);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "name";
            this.nameLabel.Click += new System.EventHandler(this.nameLabel_Click);
            // 
            // companyLabel
            // 
            this.companyLabel.AutoSize = true;
            this.companyLabel.Location = new System.Drawing.Point(4, 24);
            this.companyLabel.Name = "companyLabel";
            this.companyLabel.Size = new System.Drawing.Size(50, 13);
            this.companyLabel.TabIndex = 1;
            this.companyLabel.Text = "company";
            this.companyLabel.Click += new System.EventHandler(this.companyLabel_Click);
            // 
            // idTitle
            // 
            this.idTitle.AutoSize = true;
            this.idTitle.Location = new System.Drawing.Point(132, 24);
            this.idTitle.Name = "idTitle";
            this.idTitle.Size = new System.Drawing.Size(24, 13);
            this.idTitle.TabIndex = 2;
            this.idTitle.Text = "ID: ";
            this.idTitle.Click += new System.EventHandler(this.idTitle_Click);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(163, 24);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(15, 13);
            this.idLabel.TabIndex = 3;
            this.idLabel.Text = "id";
            this.idLabel.Click += new System.EventHandler(this.idLabel_Click);
            // 
            // ReviewerRow
            // 
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.idTitle);
            this.Controls.Add(this.companyLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "ReviewerRow";
            this.Size = new System.Drawing.Size(331, 37);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void nameLabel_Click(object sender, EventArgs e)
        {
            _controller.selectReviewer(this, _model);
        }

        private void companyLabel_Click(object sender, EventArgs e)
        {
            _controller.selectReviewer(this, _model);
        }

        private void idTitle_Click(object sender, EventArgs e)
        {
            _controller.selectReviewer(this, _model);
        }

        private void idLabel_Click(object sender, EventArgs e)
        {
            _controller.selectReviewer(this, _model);
        }
        public void setGreen()
        {
            this.nameLabel.ForeColor = System.Drawing.Color.Green;
            this.companyLabel.ForeColor = System.Drawing.Color.Green;
            this.idLabel.ForeColor = System.Drawing.Color.Green;
            this.idTitle.ForeColor = System.Drawing.Color.Green;
        }
        public void setNormal()
        {
            this.nameLabel.ForeColor = new System.Drawing.Color();
            this.companyLabel.ForeColor = new System.Drawing.Color();
            this.idLabel.ForeColor = new System.Drawing.Color();
            this.idTitle.ForeColor = new System.Drawing.Color();
        }
        public Form getParent()
        {
            return _parent;
        }
    }
}
