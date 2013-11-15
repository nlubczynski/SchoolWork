namespace WebTechAssignment3
{
    partial class ShowRow
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
            this.venueLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // venueLabel
            // 
            this.venueLabel.AutoSize = true;
            this.venueLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.venueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.venueLabel.Location = new System.Drawing.Point(3, 0);
            this.venueLabel.Name = "venueLabel";
            this.venueLabel.Size = new System.Drawing.Size(52, 20);
            this.venueLabel.TabIndex = 0;
            this.venueLabel.Text = "venue";
            this.venueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.venueLabel.Click += new System.EventHandler(this.venueLabel_Click);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateLabel.Location = new System.Drawing.Point(220, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(41, 20);
            this.dateLabel.TabIndex = 1;
            this.dateLabel.Text = "date";
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dateLabel.Click += new System.EventHandler(this.dateLabel_Click);
            // 
            // ShowRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.venueLabel);
            this.Name = "ShowRow";
            this.Size = new System.Drawing.Size(326, 23);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label venueLabel;
        private System.Windows.Forms.Label dateLabel;
    }
}
