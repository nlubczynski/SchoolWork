namespace WebTechAssignment3
{
    partial class AddAlbum
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
            this.albumNameLabel = new System.Windows.Forms.Label();
            this.songLabel = new System.Windows.Forms.Label();
            this.editSong = new System.Windows.Forms.Button();
            this.addSong = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.Location = new System.Drawing.Point(139, 6);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(268, 30);
            this.nameBox.TabIndex = 1;
            // 
            // albumNameLabel
            // 
            this.albumNameLabel.AutoSize = true;
            this.albumNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.albumNameLabel.Location = new System.Drawing.Point(12, 9);
            this.albumNameLabel.Name = "albumNameLabel";
            this.albumNameLabel.Size = new System.Drawing.Size(131, 25);
            this.albumNameLabel.TabIndex = 2;
            this.albumNameLabel.Text = "Album Name:";
            // 
            // songLabel
            // 
            this.songLabel.AutoSize = true;
            this.songLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songLabel.Location = new System.Drawing.Point(12, 57);
            this.songLabel.Name = "songLabel";
            this.songLabel.Size = new System.Drawing.Size(75, 25);
            this.songLabel.TabIndex = 5;
            this.songLabel.Text = "Songs:";
            // 
            // editSong
            // 
            this.editSong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.editSong.Enabled = false;
            this.editSong.Location = new System.Drawing.Point(110, 111);
            this.editSong.Name = "editSong";
            this.editSong.Size = new System.Drawing.Size(95, 26);
            this.editSong.TabIndex = 3;
            this.editSong.Text = "Edit Song";
            this.editSong.UseVisualStyleBackColor = true;
            this.editSong.Click += new System.EventHandler(this.editSong_Click);
            // 
            // addSong
            // 
            this.addSong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addSong.Location = new System.Drawing.Point(9, 111);
            this.addSong.Name = "addSong";
            this.addSong.Size = new System.Drawing.Size(95, 26);
            this.addSong.TabIndex = 2;
            this.addSong.Text = "Add Song";
            this.addSong.UseVisualStyleBackColor = true;
            this.addSong.Click += new System.EventHandler(this.addSong_Click);
            // 
            // cancel
            // 
            this.cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancel.Location = new System.Drawing.Point(312, 111);
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
            this.save.Location = new System.Drawing.Point(211, 111);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(95, 26);
            this.save.TabIndex = 4;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // AddAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 149);
            this.Controls.Add(this.editSong);
            this.Controls.Add(this.addSong);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.save);
            this.Controls.Add(this.songLabel);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.albumNameLabel);
            this.Name = "AddAlbum";
            this.Text = "Add Album";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label albumNameLabel;
        private System.Windows.Forms.Label songLabel;
        private System.Windows.Forms.Button editSong;
        private System.Windows.Forms.Button addSong;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button save;
    }
}