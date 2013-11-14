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
            this.removeShowButton = new System.Windows.Forms.Button();
            this.editShowButton = new System.Windows.Forms.Button();
            this.addShowButton = new System.Windows.Forms.Button();
            this.removeReviewButton = new System.Windows.Forms.Button();
            this.editReviewButton = new System.Windows.Forms.Button();
            this.addReviewButton = new System.Windows.Forms.Button();
            this.removeAlbumButton = new System.Windows.Forms.Button();
            this.editAlbumButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tabs.SuspendLayout();
            this.bandsTab.SuspendLayout();
            this.reviewersTab.SuspendLayout();
            this.bandTab.SuspendLayout();
            this.SuspendLayout();
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
            this.tabs.UseWaitCursor = true;
            this.tabs.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
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
            this.bandsTab.UseWaitCursor = true;
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
            this.removeBand.UseWaitCursor = true;
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
            this.editBand.UseWaitCursor = true;
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
            this.addBand.UseWaitCursor = true;
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
            this.reviewersTab.UseWaitCursor = true;
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
            this.removeReviewer.UseWaitCursor = true;
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
            this.editReviewer.UseWaitCursor = true;
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
            this.addReviewer.UseWaitCursor = true;
            this.addReviewer.Click += new System.EventHandler(this.addReviewer_Click);
            // 
            // bandTab
            // 
            this.bandTab.Controls.Add(this.removeShowButton);
            this.bandTab.Controls.Add(this.editShowButton);
            this.bandTab.Controls.Add(this.addShowButton);
            this.bandTab.Controls.Add(this.removeReviewButton);
            this.bandTab.Controls.Add(this.editReviewButton);
            this.bandTab.Controls.Add(this.addReviewButton);
            this.bandTab.Controls.Add(this.removeAlbumButton);
            this.bandTab.Controls.Add(this.editAlbumButton);
            this.bandTab.Controls.Add(this.button3);
            this.bandTab.Location = new System.Drawing.Point(4, 22);
            this.bandTab.Name = "bandTab";
            this.bandTab.Padding = new System.Windows.Forms.Padding(3);
            this.bandTab.Size = new System.Drawing.Size(799, 419);
            this.bandTab.TabIndex = 2;
            this.bandTab.Text = "Select a band";
            this.bandTab.UseVisualStyleBackColor = true;
            this.bandTab.UseWaitCursor = true;
            // 
            // removeShowButton
            // 
            this.removeShowButton.Enabled = false;
            this.removeShowButton.Location = new System.Drawing.Point(671, 358);
            this.removeShowButton.Name = "removeShowButton";
            this.removeShowButton.Size = new System.Drawing.Size(122, 38);
            this.removeShowButton.TabIndex = 11;
            this.removeShowButton.Text = "Remove Show";
            this.removeShowButton.UseVisualStyleBackColor = true;
            this.removeShowButton.UseWaitCursor = true;
            // 
            // editShowButton
            // 
            this.editShowButton.AllowDrop = true;
            this.editShowButton.Enabled = false;
            this.editShowButton.Location = new System.Drawing.Point(671, 314);
            this.editShowButton.Name = "editShowButton";
            this.editShowButton.Size = new System.Drawing.Size(122, 38);
            this.editShowButton.TabIndex = 10;
            this.editShowButton.Text = "Edit Show";
            this.editShowButton.UseVisualStyleBackColor = true;
            this.editShowButton.UseWaitCursor = true;
            // 
            // addShowButton
            // 
            this.addShowButton.Location = new System.Drawing.Point(671, 270);
            this.addShowButton.Name = "addShowButton";
            this.addShowButton.Size = new System.Drawing.Size(122, 38);
            this.addShowButton.TabIndex = 9;
            this.addShowButton.Text = "Add Show";
            this.addShowButton.UseVisualStyleBackColor = true;
            this.addShowButton.UseWaitCursor = true;
            // 
            // removeReviewButton
            // 
            this.removeReviewButton.Enabled = false;
            this.removeReviewButton.Location = new System.Drawing.Point(671, 226);
            this.removeReviewButton.Name = "removeReviewButton";
            this.removeReviewButton.Size = new System.Drawing.Size(122, 38);
            this.removeReviewButton.TabIndex = 8;
            this.removeReviewButton.Text = "Remove Review";
            this.removeReviewButton.UseVisualStyleBackColor = true;
            this.removeReviewButton.UseWaitCursor = true;
            // 
            // editReviewButton
            // 
            this.editReviewButton.AllowDrop = true;
            this.editReviewButton.Enabled = false;
            this.editReviewButton.Location = new System.Drawing.Point(671, 182);
            this.editReviewButton.Name = "editReviewButton";
            this.editReviewButton.Size = new System.Drawing.Size(122, 38);
            this.editReviewButton.TabIndex = 7;
            this.editReviewButton.Text = "Edit Review";
            this.editReviewButton.UseVisualStyleBackColor = true;
            this.editReviewButton.UseWaitCursor = true;
            // 
            // addReviewButton
            // 
            this.addReviewButton.Location = new System.Drawing.Point(671, 138);
            this.addReviewButton.Name = "addReviewButton";
            this.addReviewButton.Size = new System.Drawing.Size(122, 38);
            this.addReviewButton.TabIndex = 6;
            this.addReviewButton.Text = "Add Review";
            this.addReviewButton.UseVisualStyleBackColor = true;
            this.addReviewButton.UseWaitCursor = true;
            // 
            // removeAlbumButton
            // 
            this.removeAlbumButton.Enabled = false;
            this.removeAlbumButton.Location = new System.Drawing.Point(671, 94);
            this.removeAlbumButton.Name = "removeAlbumButton";
            this.removeAlbumButton.Size = new System.Drawing.Size(122, 38);
            this.removeAlbumButton.TabIndex = 5;
            this.removeAlbumButton.Text = "Remove Album";
            this.removeAlbumButton.UseVisualStyleBackColor = true;
            this.removeAlbumButton.UseWaitCursor = true;
            // 
            // editAlbumButton
            // 
            this.editAlbumButton.AllowDrop = true;
            this.editAlbumButton.Enabled = false;
            this.editAlbumButton.Location = new System.Drawing.Point(671, 50);
            this.editAlbumButton.Name = "editAlbumButton";
            this.editAlbumButton.Size = new System.Drawing.Size(122, 38);
            this.editAlbumButton.TabIndex = 4;
            this.editAlbumButton.Text = "Edit Album";
            this.editAlbumButton.UseVisualStyleBackColor = true;
            this.editAlbumButton.UseWaitCursor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(671, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 38);
            this.button3.TabIndex = 3;
            this.button3.Text = "Add Album";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.UseWaitCursor = true;
            // 
            // addAlbumButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 469);
            this.Controls.Add(this.tabs);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "addAlbumButton";
            this.Text = "XML Band Editor";
            this.UseWaitCursor = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.closed);
            this.Load += new System.EventHandler(this.MainView_Load);
            this.tabs.ResumeLayout(false);
            this.bandsTab.ResumeLayout(false);
            this.reviewersTab.ResumeLayout(false);
            this.bandTab.ResumeLayout(false);
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
        private System.Windows.Forms.Button removeAlbumButton;
        private System.Windows.Forms.Button editAlbumButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button removeReviewButton;
        private System.Windows.Forms.Button editReviewButton;
        private System.Windows.Forms.Button addReviewButton;
        private System.Windows.Forms.Button removeShowButton;
        private System.Windows.Forms.Button editShowButton;
        private System.Windows.Forms.Button addShowButton;

    }
}