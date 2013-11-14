namespace WebTechAssignment3
{
    partial class AddBand
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
            this.bandNameLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.memberLabel = new System.Windows.Forms.Label();
            this.addMember = new System.Windows.Forms.Button();
            this.editMember = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bandNameLabel
            // 
            this.bandNameLabel.AutoSize = true;
            this.bandNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bandNameLabel.Location = new System.Drawing.Point(13, 13);
            this.bandNameLabel.Name = "bandNameLabel";
            this.bandNameLabel.Size = new System.Drawing.Size(121, 25);
            this.bandNameLabel.TabIndex = 0;
            this.bandNameLabel.Text = "Band Name:";
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.Location = new System.Drawing.Point(140, 13);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(253, 30);
            this.nameBox.TabIndex = 1;
            // 
            // save
            // 
            this.save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.save.Location = new System.Drawing.Point(207, 107);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(95, 26);
            this.save.TabIndex = 4;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // cancel
            // 
            this.cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancel.Location = new System.Drawing.Point(309, 107);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(95, 26);
            this.cancel.TabIndex = 5;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // memberLabel
            // 
            this.memberLabel.AutoSize = true;
            this.memberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberLabel.Location = new System.Drawing.Point(13, 60);
            this.memberLabel.Name = "memberLabel";
            this.memberLabel.Size = new System.Drawing.Size(100, 25);
            this.memberLabel.TabIndex = 4;
            this.memberLabel.Text = "Members:";
            // 
            // addMember
            // 
            this.addMember.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addMember.Location = new System.Drawing.Point(5, 107);
            this.addMember.Name = "addMember";
            this.addMember.Size = new System.Drawing.Size(95, 26);
            this.addMember.TabIndex = 2;
            this.addMember.Text = "Add Member";
            this.addMember.UseVisualStyleBackColor = true;
            this.addMember.Click += new System.EventHandler(this.addMember_Click);
            // 
            // editMember
            // 
            this.editMember.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.editMember.Enabled = false;
            this.editMember.Location = new System.Drawing.Point(106, 107);
            this.editMember.Name = "editMember";
            this.editMember.Size = new System.Drawing.Size(95, 26);
            this.editMember.TabIndex = 3;
            this.editMember.Text = "Edit Member";
            this.editMember.UseVisualStyleBackColor = true;
            this.editMember.Click += new System.EventHandler(this.editMember_Click);
            // 
            // AddBand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 149);
            this.Controls.Add(this.editMember);
            this.Controls.Add(this.addMember);
            this.Controls.Add(this.memberLabel);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.save);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.bandNameLabel);
            this.Name = "AddBand";
            this.Text = "Add Band";
            this.Load += new System.EventHandler(this.AddBand_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bandNameLabel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label memberLabel;
        private System.Windows.Forms.Button addMember;
        private System.Windows.Forms.Button editMember;
    }
}