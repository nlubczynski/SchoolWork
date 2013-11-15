namespace WebTechAssignment3
{
    partial class AddReview
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.reviewerIdLabel = new System.Windows.Forms.Label();
            this.reviewBox = new System.Windows.Forms.TextBox();
            this.reviewLabel = new System.Windows.Forms.Label();
            this.reviewerIdComboBox = new System.Windows.Forms.ComboBox();
            this.cancel = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reviewerIdLabel
            // 
            this.reviewerIdLabel.AutoSize = true;
            this.reviewerIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reviewerIdLabel.Location = new System.Drawing.Point(12, 9);
            this.reviewerIdLabel.Name = "reviewerIdLabel";
            this.reviewerIdLabel.Size = new System.Drawing.Size(122, 25);
            this.reviewerIdLabel.TabIndex = 6;
            this.reviewerIdLabel.Text = "Reviewer ID:";
            // 
            // reviewBox
            // 
            this.reviewBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reviewBox.Location = new System.Drawing.Point(149, 42);
            this.reviewBox.Name = "reviewBox";
            this.reviewBox.Size = new System.Drawing.Size(268, 30);
            this.reviewBox.TabIndex = 2;
            // 
            // reviewLabel
            // 
            this.reviewLabel.AutoSize = true;
            this.reviewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reviewLabel.Location = new System.Drawing.Point(53, 45);
            this.reviewLabel.Name = "reviewLabel";
            this.reviewLabel.Size = new System.Drawing.Size(81, 25);
            this.reviewLabel.TabIndex = 8;
            this.reviewLabel.Text = "Review:";
            // 
            // reviewerIdComboBox
            // 
            this.reviewerIdComboBox.FormattingEnabled = true;
            this.reviewerIdComboBox.Location = new System.Drawing.Point(149, 12);
            this.reviewerIdComboBox.Name = "reviewerIdComboBox";
            this.reviewerIdComboBox.Size = new System.Drawing.Size(121, 21);
            this.reviewerIdComboBox.TabIndex = 1;
            // 
            // cancel
            // 
            this.cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancel.Location = new System.Drawing.Point(322, 83);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(95, 26);
            this.cancel.TabIndex = 5;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // save
            // 
            this.save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.save.Location = new System.Drawing.Point(221, 83);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(95, 26);
            this.save.TabIndex = 4;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // AddReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 121);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.save);
            this.Controls.Add(this.reviewerIdComboBox);
            this.Controls.Add(this.reviewBox);
            this.Controls.Add(this.reviewLabel);
            this.Controls.Add(this.reviewerIdLabel);
            this.Name = "AddReview";
            this.Text = "AddReview";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label reviewerIdLabel;
        private System.Windows.Forms.TextBox reviewBox;
        private System.Windows.Forms.Label reviewLabel;
        private System.Windows.Forms.ComboBox reviewerIdComboBox;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button save;
    }
}