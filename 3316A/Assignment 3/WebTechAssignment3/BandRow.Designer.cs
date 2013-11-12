namespace WebTechAssignment3
{
    partial class BandRow
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
            this.band = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // band
            // 
            this.band.AutoSize = true;
            this.band.Cursor = System.Windows.Forms.Cursors.Hand;
            this.band.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.band.Location = new System.Drawing.Point(3, 0);
            this.band.Name = "band";
            this.band.Size = new System.Drawing.Size(56, 25);
            this.band.TabIndex = 0;
            this.band.Text = "band";
            this.band.Click += new System.EventHandler(this.bandHighlight);
            // 
            // BandRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.band);
            this.Name = "BandRow";
            this.Size = new System.Drawing.Size(577, 27);
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.Label band;
    }
}