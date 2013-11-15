namespace WebTechAssignment3
{
    partial class SongRow
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
            this.songName = new System.Windows.Forms.Label();
            this.lengthTitleLabel = new System.Windows.Forms.Label();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // songName
            // 
            this.songName.AutoSize = true;
            this.songName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.songName.Location = new System.Drawing.Point(3, 0);
            this.songName.Name = "songName";
            this.songName.Size = new System.Drawing.Size(86, 20);
            this.songName.TabIndex = 0;
            this.songName.Text = "songName";
            this.songName.Click += new System.EventHandler(this.songName_Click_1);
            // 
            // lengthTitleLabel
            // 
            this.lengthTitleLabel.AutoEllipsis = true;
            this.lengthTitleLabel.AutoSize = true;
            this.lengthTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lengthTitleLabel.Location = new System.Drawing.Point(158, 0);
            this.lengthTitleLabel.Name = "lengthTitleLabel";
            this.lengthTitleLabel.Size = new System.Drawing.Size(63, 20);
            this.lengthTitleLabel.TabIndex = 1;
            this.lengthTitleLabel.Text = "Length:";
            this.lengthTitleLabel.Click += new System.EventHandler(this.lengthTitleLabel_Click_1);
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lengthLabel.Location = new System.Drawing.Point(227, 0);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(53, 20);
            this.lengthLabel.TabIndex = 2;
            this.lengthLabel.Text = "length";
            this.lengthLabel.Click += new System.EventHandler(this.lengthLabel_Click_1);
            // 
            // SongRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lengthLabel);
            this.Controls.Add(this.lengthTitleLabel);
            this.Controls.Add(this.songName);
            this.Name = "SongRow";
            this.Size = new System.Drawing.Size(309, 23);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label songName;
        private System.Windows.Forms.Label lengthTitleLabel;
        private System.Windows.Forms.Label lengthLabel;
    }
}
