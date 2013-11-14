namespace WebTechAssignment3
{
    partial class MainView
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
            this.tabs = new System.Windows.Forms.TabControl();
            this.bandsTab = new System.Windows.Forms.TabPage();
            this.removeBand = new System.Windows.Forms.Button();
            this.editBand = new System.Windows.Forms.Button();
            this.addBand = new System.Windows.Forms.Button();
            this.reviewersTab = new System.Windows.Forms.TabPage();
            this.removeReviewer = new System.Windows.Forms.Button();
            this.editReviewer = new System.Windows.Forms.Button();
            this.addReviewer = new System.Windows.Forms.Button();
            this.bandTab = new System.Windows.Forms.TabPage();
            this.tabs.SuspendLayout();
            this.bandsTab.SuspendLayout();
            this.reviewersTab.SuspendLayout();
            this.SuspendLayout();
            this.tabs.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.bandsTab);
            this.tabs.Controls.Add(this.reviewersTab);
            this.tabs.Controls.Add(this.bandTab);
            this.tabs.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.tabs.ItemSize = new System.Drawing.Size(58, 18);
            this.tabs.Location = new System.Drawing.Point(12, 12);
            this.tabs.Multiline = true;
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(807, 445);
            this.tabs.TabIndex = 2;
            // 
            // bandsTab
            // 
            this.bandsTab.Controls.Add(this.removeBand);
            this.bandsTab.Controls.Add(this.editBand);
            this.bandsTab.Controls.Add(this.addBand);
            this.bandsTab.Location = new System.Drawing.Point(4, 22);
            this.bandsTab.Name = "bandsTab";
            this.bandsTab.Padding = new System.Windows.Forms.Padding(3);
            this.bandsTab.Size = new System.Drawing.Size(799, 419);
            this.bandsTab.TabIndex = 0;
            this.bandsTab.Text = "Bands";
            this.bandsTab.UseVisualStyleBackColor = true;
            // 
            // removeBand
            // 
            this.removeBand.Enabled = false;
            this.removeBand.Location = new System.Drawing.Point(671, 94);
            this.removeBand.Name = "removeBand";
            this.removeBand.Size = new System.Drawing.Size(122, 38);
            this.removeBand.TabIndex = 2;
            this.removeBand.Text = "Remove Band";
            this.removeBand.UseVisualStyleBackColor = true;
            this.removeBand.Click += new System.EventHandler(this.removeBand_Click);
            // 
            // editBand
            // 
            this.editBand.Enabled = false;
            this.editBand.Location = new System.Drawing.Point(671, 50);
            this.editBand.Name = "editBand";
            this.editBand.Size = new System.Drawing.Size(122, 38);
            this.editBand.TabIndex = 1;
            this.editBand.Text = "Edit Band";
            this.editBand.UseVisualStyleBackColor = true;
            this.editBand.Click += new System.EventHandler(this.editBand_Click);
            // 
            // addBand
            // 
            this.addBand.Location = new System.Drawing.Point(671, 6);
            this.addBand.Name = "addBand";
            this.addBand.Size = new System.Drawing.Size(122, 38);
            this.addBand.TabIndex = 0;
            this.addBand.Text = "Add Band";
            this.addBand.UseVisualStyleBackColor = true;
            this.addBand.Click += new System.EventHandler(this.addBand_Click);
            // 
            // reviewersTab
            // 
            this.reviewersTab.Controls.Add(this.removeReviewer);
            this.reviewersTab.Controls.Add(this.editReviewer);
            this.reviewersTab.Controls.Add(this.addReviewer);
            this.reviewersTab.Location = new System.Drawing.Point(4, 22);
            this.reviewersTab.Name = "reviewersTab";
            this.reviewersTab.Padding = new System.Windows.Forms.Padding(3);
            this.reviewersTab.Size = new System.Drawing.Size(799, 419);
            this.reviewersTab.TabIndex = 1;
            this.reviewersTab.Text = "Reviewers";
            this.reviewersTab.UseVisualStyleBackColor = true;
            // 
            // removeReviewer
            // 
            this.removeReviewer.Enabled = false;
            this.removeReviewer.Location = new System.Drawing.Point(671, 94);
            this.removeReviewer.Name = "removeReviewer";
            this.removeReviewer.Size = new System.Drawing.Size(122, 38);
            this.removeReviewer.TabIndex = 5;
            this.removeReviewer.Text = "Remove Reviewer";
            this.removeReviewer.UseVisualStyleBackColor = true;
            this.removeReviewer.Click += new System.EventHandler(this.removeReviewer_Click);
            // 
            // editReviewer
            // 
            this.editReviewer.Enabled = false;
            this.editReviewer.Location = new System.Drawing.Point(671, 50);
            this.editReviewer.Name = "editReviewer";
            this.editReviewer.Size = new System.Drawing.Size(122, 38);
            this.editReviewer.TabIndex = 4;
            this.editReviewer.Text = "Edit Reviewer";
            this.editReviewer.UseVisualStyleBackColor = true;
            this.editReviewer.Click += new System.EventHandler(this.editReviewer_Click);
            // 
            // addReviewer
            // 
            this.addReviewer.Location = new System.Drawing.Point(671, 6);
            this.addReviewer.Name = "addReviewer";
            this.addReviewer.Size = new System.Drawing.Size(122, 38);
            this.addReviewer.TabIndex = 3;
            this.addReviewer.Text = "Add Reviewer";
            this.addReviewer.UseVisualStyleBackColor = true;
            this.addReviewer.Click += new System.EventHandler(this.addReviewer_Click);
            // 
            // bandTab
            // 
            this.bandTab.Location = new System.Drawing.Point(4, 22);
            this.bandTab.Name = "bandTab";
            this.bandTab.Padding = new System.Windows.Forms.Padding(3);
            this.bandTab.Size = new System.Drawing.Size(799, 419);
            this.bandTab.TabIndex = 2;
            this.bandTab.Text = "Select a band";
            this.bandTab.UseVisualStyleBackColor = true;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 469);
            this.Controls.Add(this.tabs);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainView";
            this.Text = "XML Band Editor";
            this.UseWaitCursor = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.closed);
            this.Load += new System.EventHandler(this.MainView_Load);
            this.tabs.ResumeLayout(false);
            this.bandsTab.ResumeLayout(false);
            this.reviewersTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage bandsTab;
        private System.Windows.Forms.TabPage reviewersTab;
        private System.Windows.Forms.Button removeBand;
        private System.Windows.Forms.Button editBand;
        private System.Windows.Forms.Button addBand;
        private System.Windows.Forms.Button removeReviewer;
        private System.Windows.Forms.Button editReviewer;
        private System.Windows.Forms.Button addReviewer;
        private System.Windows.Forms.TabPage bandTab;

    }
}