namespace WebTechAssignment3
{
    partial class AddMember
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
            this.bandNameLabel = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.instrumentBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.joinBox = new System.Windows.Forms.TextBox();
            this.joinLabel = new System.Windows.Forms.Label();
            this.removeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.Location = new System.Drawing.Point(158, 21);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(227, 30);
            this.nameBox.TabIndex = 3;
            // 
            // bandNameLabel
            // 
            this.bandNameLabel.AutoSize = true;
            this.bandNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bandNameLabel.Location = new System.Drawing.Point(5, 21);
            this.bandNameLabel.Name = "bandNameLabel";
            this.bandNameLabel.Size = new System.Drawing.Size(147, 25);
            this.bandNameLabel.TabIndex = 2;
            this.bandNameLabel.Text = "Member Name:";
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(289, 130);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(96, 26);
            this.cancel.TabIndex = 5;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(187, 130);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(96, 26);
            this.save.TabIndex = 4;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // instrumentBox
            // 
            this.instrumentBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instrumentBox.Location = new System.Drawing.Point(158, 58);
            this.instrumentBox.Name = "instrumentBox";
            this.instrumentBox.Size = new System.Drawing.Size(227, 30);
            this.instrumentBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Instrument:";
            // 
            // joinBox
            // 
            this.joinBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joinBox.Location = new System.Drawing.Point(158, 94);
            this.joinBox.Name = "joinBox";
            this.joinBox.Size = new System.Drawing.Size(227, 30);
            this.joinBox.TabIndex = 9;
            // 
            // joinLabel
            // 
            this.joinLabel.AutoSize = true;
            this.joinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joinLabel.Location = new System.Drawing.Point(5, 94);
            this.joinLabel.Name = "joinLabel";
            this.joinLabel.Size = new System.Drawing.Size(101, 25);
            this.joinLabel.TabIndex = 8;
            this.joinLabel.Text = "Join Date:";
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(85, 130);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(96, 26);
            this.removeButton.TabIndex = 10;
            this.removeButton.Text = "Remove Member";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Visible = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // AddMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 168);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.joinBox);
            this.Controls.Add(this.joinLabel);
            this.Controls.Add(this.instrumentBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.save);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.bandNameLabel);
            this.Name = "AddMember";
            this.Text = "Add Member";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label bandNameLabel;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox instrumentBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox joinBox;
        private System.Windows.Forms.Label joinLabel;
        private System.Windows.Forms.Button removeButton;
    }
}