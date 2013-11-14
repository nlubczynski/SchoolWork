namespace WebTechAssignment3
{
    partial class ReviewRow
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.reviewerNameLabel = new System.Windows.Forms.Label();
            this.reviewLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // reviewerNameLabel
            // 
            this.reviewerNameLabel.AutoSize = true;
            this.reviewerNameLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reviewerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.reviewerNameLabel.Location = new System.Drawing.Point(4, 4);
            this.reviewerNameLabel.Name = "reviewerNameLabel";
            this.reviewerNameLabel.Size = new System.Drawing.Size(107, 20);
            this.reviewerNameLabel.TabIndex = 0;
            this.reviewerNameLabel.Text = "reviewername";
            this.reviewerNameLabel.Click += new System.EventHandler(this.reviewerNameLabel_Click);
            // 
            // reviewLabel
            // 
            this.reviewLabel.AutoSize = true;
            this.reviewLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reviewLabel.Location = new System.Drawing.Point(161, 9);
            this.reviewLabel.Name = "reviewLabel";
            this.reviewLabel.Size = new System.Drawing.Size(38, 13);
            this.reviewLabel.TabIndex = 1;
            this.reviewLabel.Text = "review";
            this.reviewLabel.Click += new System.EventHandler(this.reviewLabel_Click);
            // 
            // ReviewRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.reviewLabel);
            this.Controls.Add(this.reviewerNameLabel);
            this.Name = "ReviewRow";
            this.Size = new System.Drawing.Size(411, 31);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label reviewerNameLabel;
        private System.Windows.Forms.Label reviewLabel;
    }
}
