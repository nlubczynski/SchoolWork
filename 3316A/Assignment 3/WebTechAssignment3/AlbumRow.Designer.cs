namespace WebTechAssignment3
{
    partial class AlbumRow
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
            this.albumName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // albumName
            // 
            this.albumName.AutoSize = true;
            this.albumName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.albumName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.albumName.Location = new System.Drawing.Point(3, 0);
            this.albumName.Name = "albumName";
            this.albumName.Size = new System.Drawing.Size(117, 25);
            this.albumName.TabIndex = 0;
            this.albumName.Text = "albumName";
            this.albumName.Click += new System.EventHandler(this.albumName_Click);
            // 
            // AlbumRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.albumName);
            this.Name = "AlbumRow";
            this.Size = new System.Drawing.Size(496, 31);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label albumName;
    }
}
