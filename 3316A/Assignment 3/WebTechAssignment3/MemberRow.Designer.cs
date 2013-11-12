namespace WebTechAssignment3
{
    partial class MemberRow
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
            this.member = new System.Windows.Forms.Label();
            this.instrument = new System.Windows.Forms.Label();
            this.join = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // member
            // 
            this.member.AutoSize = true;
            this.member.Location = new System.Drawing.Point(4, 4);
            this.member.Name = "member";
            this.member.Size = new System.Drawing.Size(44, 13);
            this.member.TabIndex = 0;
            this.member.Text = "member";
            this.member.Click += new System.EventHandler(this.click);
            // 
            // instrument
            // 
            this.instrument.AutoSize = true;
            this.instrument.Location = new System.Drawing.Point(160, 4);
            this.instrument.Name = "instrument";
            this.instrument.Size = new System.Drawing.Size(55, 13);
            this.instrument.TabIndex = 1;
            this.instrument.Text = "instrument";
            this.instrument.Click += new System.EventHandler(this.click);
            // 
            // join
            // 
            this.join.AutoSize = true;
            this.join.Location = new System.Drawing.Point(323, 4);
            this.join.Name = "join";
            this.join.Size = new System.Drawing.Size(47, 13);
            this.join.TabIndex = 2;
            this.join.Text = "join date";
            this.join.Click += new System.EventHandler(this.click);
            // 
            // MemberRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.join);
            this.Controls.Add(this.instrument);
            this.Controls.Add(this.member);
            this.Name = "MemberRow";
            this.Size = new System.Drawing.Size(444, 25);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label member;
        private System.Windows.Forms.Label instrument;
        private System.Windows.Forms.Label join;
    }
}
