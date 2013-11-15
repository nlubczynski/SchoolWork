namespace WebTechAssignment3
{
    partial class AddShow
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
            this.venueBox = new System.Windows.Forms.TextBox();
            this.venueLabel = new System.Windows.Forms.Label();
            this.dateBox = new System.Windows.Forms.TextBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // venueBox
            // 
            this.venueBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.venueBox.Location = new System.Drawing.Point(149, 42);
            this.venueBox.Name = "venueBox";
            this.venueBox.Size = new System.Drawing.Size(275, 30);
            this.venueBox.TabIndex = 2;
            // 
            // venueLabel
            // 
            this.venueLabel.AutoSize = true;
            this.venueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.venueLabel.Location = new System.Drawing.Point(12, 45);
            this.venueLabel.Name = "venueLabel";
            this.venueLabel.Size = new System.Drawing.Size(131, 25);
            this.venueLabel.TabIndex = 10;
            this.venueLabel.Text = "Show Venue:";
            // 
            // dateBox
            // 
            this.dateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateBox.Location = new System.Drawing.Point(149, 6);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(275, 30);
            this.dateBox.TabIndex = 1;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(12, 9);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(114, 25);
            this.dateLabel.TabIndex = 8;
            this.dateLabel.Text = "Show Date:";
            // 
            // cancel
            // 
            this.cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancel.Location = new System.Drawing.Point(329, 86);
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
            this.save.Location = new System.Drawing.Point(228, 86);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(95, 26);
            this.save.TabIndex = 4;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // AddShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 124);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.save);
            this.Controls.Add(this.venueBox);
            this.Controls.Add(this.venueLabel);
            this.Controls.Add(this.dateBox);
            this.Controls.Add(this.dateLabel);
            this.Name = "AddShow";
            this.Text = "AddShow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox venueBox;
        private System.Windows.Forms.Label venueLabel;
        private System.Windows.Forms.TextBox dateBox;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button save;
    }
}