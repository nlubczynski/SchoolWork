namespace WebTechAssignment3
{
    partial class MainMenu
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
            this.select = new System.Windows.Forms.Button();
            this.fileTextBox = new System.Windows.Forms.TextBox();
            this.XMLLabel = new System.Windows.Forms.Label();
            this.validate = new System.Windows.Forms.Button();
            this.open = new System.Windows.Forms.Button();
            this.create = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // select
            // 
            this.select.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.select.Location = new System.Drawing.Point(404, 38);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(75, 22);
            this.select.TabIndex = 0;
            this.select.Text = "Select File";
            this.select.UseVisualStyleBackColor = true;
            this.select.Click += new System.EventHandler(this.select_click);
            // 
            // fileTextBox
            // 
            this.fileTextBox.Location = new System.Drawing.Point(12, 39);
            this.fileTextBox.Name = "fileTextBox";
            this.fileTextBox.Size = new System.Drawing.Size(386, 20);
            this.fileTextBox.TabIndex = 1;
            this.fileTextBox.TextChanged += new System.EventHandler(this.text_change);
            // 
            // XMLLabel
            // 
            this.XMLLabel.AutoSize = true;
            this.XMLLabel.Location = new System.Drawing.Point(9, 18);
            this.XMLLabel.Name = "XMLLabel";
            this.XMLLabel.Size = new System.Drawing.Size(51, 13);
            this.XMLLabel.TabIndex = 2;
            this.XMLLabel.Text = "XML File:";
            // 
            // validate
            // 
            this.validate.Location = new System.Drawing.Point(12, 79);
            this.validate.Name = "validate";
            this.validate.Size = new System.Drawing.Size(150, 22);
            this.validate.TabIndex = 3;
            this.validate.Text = "Validate";
            this.validate.UseVisualStyleBackColor = true;
            this.validate.Click += new System.EventHandler(this.validate_click);
            // 
            // open
            // 
            this.open.Enabled = false;
            this.open.Location = new System.Drawing.Point(168, 79);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(150, 22);
            this.open.TabIndex = 4;
            this.open.Text = "Open File";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.open_click);
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(329, 79);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(150, 22);
            this.create.TabIndex = 5;
            this.create.Text = "Create New";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(487, 113);
            this.Controls.Add(this.create);
            this.Controls.Add(this.open);
            this.Controls.Add(this.validate);
            this.Controls.Add(this.XMLLabel);
            this.Controls.Add(this.fileTextBox);
            this.Controls.Add(this.select);
            this.Name = "MainMenu";
            this.Text = "Select an XML File";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button select;
        private System.Windows.Forms.TextBox fileTextBox;
        private System.Windows.Forms.Label XMLLabel;
        private System.Windows.Forms.Button validate;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.Button create;
    }
}

