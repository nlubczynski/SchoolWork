namespace RunTime
{
    partial class RunTime
    {
        /// <summary>
        /// Required designer variable.
        /// 
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbControl;
        private System.Windows.Forms.TextBox tbxText;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblX;


        private System.Windows.Forms.NumericUpDown nudY;
        private System.Windows.Forms.NumericUpDown nudX;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblCaption;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Panel pnlProperties;
        private System.Windows.Forms.Button btnClear;

        /// 
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RunTime));
            this.pnlControls = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.tbxText = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbControl = new System.Windows.Forms.ComboBox();
            this.lblCaption = new System.Windows.Forms.Label();
            this.pnlProperties = new System.Windows.Forms.Panel();
            this.nudY = new System.Windows.Forms.NumericUpDown();
            this.nudX = new System.Windows.Forms.NumericUpDown();
            this.pnlProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlControls
            // 
            this.pnlControls.AutoScroll = true;
            this.pnlControls.BackColor = System.Drawing.SystemColors.Control;
            this.pnlControls.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlControls.BackgroundImage")));
            this.pnlControls.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlControls.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlControls.Location = new System.Drawing.Point(184, 0);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(408, 326);
            this.pnlControls.TabIndex = 1;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnClear.Location = new System.Drawing.Point(96, 176);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "&Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(0, 40);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(48, 13);
            this.lblLocation.TabIndex = 2;
            this.lblLocation.Text = "Location";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(22, 58);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(17, 13);
            this.lblX.TabIndex = 3;
            this.lblX.Text = "X:";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(22, 82);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(17, 13);
            this.lblY.TabIndex = 5;
            this.lblY.Text = "Y:";
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(8, 130);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(31, 13);
            this.lblText.TabIndex = 7;
            this.lblText.Text = "Text:";
            // 
            // tbxText
            // 
            this.tbxText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxText.Location = new System.Drawing.Point(51, 128);
            this.tbxText.Name = "tbxText";
            this.tbxText.Size = new System.Drawing.Size(120, 20);
            this.tbxText.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAdd.Location = new System.Drawing.Point(16, 176);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "&Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbControl
            // 
            this.cbControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbControl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbControl.Items.AddRange(new object[] {
            "Label"});
            this.cbControl.Location = new System.Drawing.Point(0, 16);
            this.cbControl.Name = "cbControl";
            this.cbControl.Size = new System.Drawing.Size(180, 21);
            this.cbControl.TabIndex = 1;
            // 
            // lblCaption
            // 
            this.lblCaption.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCaption.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCaption.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaption.ForeColor = System.Drawing.SystemColors.Window;
            this.lblCaption.Location = new System.Drawing.Point(0, 0);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(180, 16);
            this.lblCaption.TabIndex = 0;
            this.lblCaption.Text = "Create a new control";
            // 
            // pnlProperties
            // 
            this.pnlProperties.BackColor = System.Drawing.SystemColors.Control;
            this.pnlProperties.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlProperties.Controls.Add(this.nudY);
            this.pnlProperties.Controls.Add(this.nudX);
            this.pnlProperties.Controls.Add(this.btnClear);
            this.pnlProperties.Controls.Add(this.lblLocation);
            this.pnlProperties.Controls.Add(this.lblX);
            this.pnlProperties.Controls.Add(this.lblY);
            this.pnlProperties.Controls.Add(this.lblText);
            this.pnlProperties.Controls.Add(this.tbxText);
            this.pnlProperties.Controls.Add(this.btnAdd);
            this.pnlProperties.Controls.Add(this.cbControl);
            this.pnlProperties.Controls.Add(this.lblCaption);
            this.pnlProperties.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlProperties.Location = new System.Drawing.Point(0, 0);
            this.pnlProperties.Name = "pnlProperties";
            this.pnlProperties.Size = new System.Drawing.Size(184, 326);
            this.pnlProperties.TabIndex = 4;
            // 
            // nudY
            // 
            this.nudY.Location = new System.Drawing.Point(51, 84);
            this.nudY.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudY.Name = "nudY";
            this.nudY.Size = new System.Drawing.Size(120, 20);
            this.nudY.TabIndex = 11;
            // 
            // nudX
            // 
            this.nudX.Location = new System.Drawing.Point(51, 58);
            this.nudX.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudX.Name = "nudX";
            this.nudX.Size = new System.Drawing.Size(120, 20);
            this.nudX.TabIndex = 5;
            // 
            // RunTime
            // 
            this.ClientSize = new System.Drawing.Size(592, 326);
            this.Controls.Add(this.pnlControls);
            this.Controls.Add(this.pnlProperties);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RunTime";
            this.Text = "Runtime Controls";
            this.Load += new System.EventHandler(this.Runtime_Load);
            this.pnlProperties.ResumeLayout(false);
            this.pnlProperties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).EndInit();
            this.ResumeLayout(false);

		}

        #endregion
    }
}

