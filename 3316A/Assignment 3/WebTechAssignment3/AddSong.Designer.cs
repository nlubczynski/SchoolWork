namespace WebTechAssignment3
{
    partial class AddSong
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
            this.nameBox = new System.Windows.Forms.TextBox();
            this.songNameLabel = new System.Windows.Forms.Label();
            this.lengthBox = new System.Windows.Forms.TextBox();
            this.songLengthLabel = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.removeSong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.Location = new System.Drawing.Point(149, 8);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(268, 30);
            this.nameBox.TabIndex = 3;
            // 
            // songNameLabel
            // 
            this.songNameLabel.AutoSize = true;
            this.songNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songNameLabel.Location = new System.Drawing.Point(12, 11);
            this.songNameLabel.Name = "songNameLabel";
            this.songNameLabel.Size = new System.Drawing.Size(122, 25);
            this.songNameLabel.TabIndex = 4;
            this.songNameLabel.Text = "Song Name:";
            // 
            // lengthBox
            // 
            this.lengthBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lengthBox.Location = new System.Drawing.Point(149, 44);
            this.lengthBox.Name = "lengthBox";
            this.lengthBox.Size = new System.Drawing.Size(268, 30);
            this.lengthBox.TabIndex = 5;
            // 
            // songLengthLabel
            // 
            this.songLengthLabel.AutoSize = true;
            this.songLengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songLengthLabel.Location = new System.Drawing.Point(12, 47);
            this.songLengthLabel.Name = "songLengthLabel";
            this.songLengthLabel.Size = new System.Drawing.Size(130, 25);
            this.songLengthLabel.TabIndex = 6;
            this.songLengthLabel.Text = "Song Length:";
            // 
            // cancel
            // 
            this.cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancel.Location = new System.Drawing.Point(322, 86);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(95, 26);
            this.cancel.TabIndex = 8;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // save
            // 
            this.save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.save.Location = new System.Drawing.Point(221, 86);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(95, 26);
            this.save.TabIndex = 7;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // removeSong
            // 
            this.removeSong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.removeSong.Location = new System.Drawing.Point(120, 86);
            this.removeSong.Name = "removeSong";
            this.removeSong.Size = new System.Drawing.Size(95, 26);
            this.removeSong.TabIndex = 9;
            this.removeSong.Text = "Remove Song";
            this.removeSong.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.removeSong.UseVisualStyleBackColor = true;
            this.removeSong.Click += new System.EventHandler(this.removeSong_Click);
            // 
            // AddSong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 124);
            this.Controls.Add(this.removeSong);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.save);
            this.Controls.Add(this.lengthBox);
            this.Controls.Add(this.songLengthLabel);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.songNameLabel);
            this.Name = "AddSong";
            this.Text = "Add Song";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label songNameLabel;
        private System.Windows.Forms.TextBox lengthBox;
        private System.Windows.Forms.Label songLengthLabel;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button removeSong;
    }
}