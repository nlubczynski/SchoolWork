﻿namespace WebTechAssignment3
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
            this.reviewersTab = new System.Windows.Forms.TabPage();
            this.addBand = new System.Windows.Forms.Button();
            this.editBand = new System.Windows.Forms.Button();
            this.removeBand = new System.Windows.Forms.Button();
            this.tabs.SuspendLayout();
            this.bandsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.bandsTab);
            this.tabs.Controls.Add(this.reviewersTab);
            this.tabs.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.tabs.ItemSize = new System.Drawing.Size(58, 18);
            this.tabs.Location = new System.Drawing.Point(12, 12);
            this.tabs.Multiline = true;
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(807, 445);
            this.tabs.TabIndex = 2;
            this.tabs.UseWaitCursor = true;
            // 
            // tabPage1
            // 
            this.bandsTab.Controls.Add(this.removeBand);
            this.bandsTab.Controls.Add(this.editBand);
            this.bandsTab.Controls.Add(this.addBand);
            this.bandsTab.Location = new System.Drawing.Point(4, 22);
            this.bandsTab.Name = "tabPage1";
            this.bandsTab.Padding = new System.Windows.Forms.Padding(3);
            this.bandsTab.Size = new System.Drawing.Size(799, 419);
            this.bandsTab.TabIndex = 0;
            this.bandsTab.Text = "Bands";
            this.bandsTab.UseVisualStyleBackColor = true;
            this.bandsTab.UseWaitCursor = true;
            // 
            // tabPage2
            // 
            this.reviewersTab.Location = new System.Drawing.Point(4, 22);
            this.reviewersTab.Name = "tabPage2";
            this.reviewersTab.Padding = new System.Windows.Forms.Padding(3);
            this.reviewersTab.Size = new System.Drawing.Size(799, 419);
            this.reviewersTab.TabIndex = 1;
            this.reviewersTab.Text = "Reviewers";
            this.reviewersTab.UseVisualStyleBackColor = true;
            this.reviewersTab.UseWaitCursor = true;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage bandsTab;
        private System.Windows.Forms.TabPage reviewersTab;
        private System.Windows.Forms.Button removeBand;
        private System.Windows.Forms.Button editBand;
        private System.Windows.Forms.Button addBand;

    }
}