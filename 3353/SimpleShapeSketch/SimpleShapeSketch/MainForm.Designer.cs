﻿namespace SimpleShapeSketch
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.colorButton = new System.Windows.Forms.Button();
            this.colourLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.freeDrawButton = new System.Windows.Forms.Button();
            this.straightLineButton = new System.Windows.Forms.Button();
            this.squareButton = new System.Windows.Forms.Button();
            this.rectangleButton = new System.Windows.Forms.Button();
            this.circleButton = new System.Windows.Forms.Button();
            this.ellipseButton = new System.Windows.Forms.Button();
            this.polygonButton = new System.Windows.Forms.Button();
            this.moveButton = new System.Windows.Forms.Button();
            this.groupButton = new System.Windows.Forms.Button();
            this.ungroupButton = new System.Windows.Forms.Button();
            this.undoButton = new System.Windows.Forms.Button();
            this.redoButton = new System.Windows.Forms.Button();
            this.selectButton = new System.Windows.Forms.Button();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Canvas = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.flowLayoutPanel1.Controls.Add(this.selectButton);
            this.flowLayoutPanel1.Controls.Add(this.freeDrawButton);
            this.flowLayoutPanel1.Controls.Add(this.straightLineButton);
            this.flowLayoutPanel1.Controls.Add(this.squareButton);
            this.flowLayoutPanel1.Controls.Add(this.rectangleButton);
            this.flowLayoutPanel1.Controls.Add(this.circleButton);
            this.flowLayoutPanel1.Controls.Add(this.ellipseButton);
            this.flowLayoutPanel1.Controls.Add(this.polygonButton);
            this.flowLayoutPanel1.Controls.Add(this.moveButton);
            this.flowLayoutPanel1.Controls.Add(this.groupButton);
            this.flowLayoutPanel1.Controls.Add(this.ungroupButton);
            this.flowLayoutPanel1.Controls.Add(this.undoButton);
            this.flowLayoutPanel1.Controls.Add(this.redoButton);
            this.flowLayoutPanel1.Controls.Add(this.colorButton);
            this.flowLayoutPanel1.Controls.Add(this.colourLabel);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 27);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(103, 442);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // colorButton
            // 
            this.colorButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.colorButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.colorButton.Location = new System.Drawing.Point(3, 360);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(45, 45);
            this.colorButton.TabIndex = 12;
            this.colorButton.UseVisualStyleBackColor = false;
            this.colorButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // colourLabel
            // 
            this.colourLabel.Location = new System.Drawing.Point(54, 357);
            this.colourLabel.Name = "colourLabel";
            this.colourLabel.Size = new System.Drawing.Size(45, 48);
            this.colourLabel.TabIndex = 13;
            this.colourLabel.Text = "Colour";
            this.colourLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(887, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // freeDrawButton
            // 
            this.freeDrawButton.Image = global::SimpleShapeSketch.Properties.Resources.freeDraw;
            this.freeDrawButton.Location = new System.Drawing.Point(3, 54);
            this.freeDrawButton.Name = "freeDrawButton";
            this.freeDrawButton.Size = new System.Drawing.Size(45, 45);
            this.freeDrawButton.TabIndex = 0;
            this.freeDrawButton.UseVisualStyleBackColor = true;
            // 
            // straightLineButton
            // 
            this.straightLineButton.Image = global::SimpleShapeSketch.Properties.Resources.straightLine;
            this.straightLineButton.Location = new System.Drawing.Point(54, 54);
            this.straightLineButton.Name = "straightLineButton";
            this.straightLineButton.Size = new System.Drawing.Size(45, 45);
            this.straightLineButton.TabIndex = 1;
            this.straightLineButton.UseVisualStyleBackColor = true;
            // 
            // squareButton
            // 
            this.squareButton.Image = global::SimpleShapeSketch.Properties.Resources.square;
            this.squareButton.Location = new System.Drawing.Point(3, 105);
            this.squareButton.Name = "squareButton";
            this.squareButton.Size = new System.Drawing.Size(45, 45);
            this.squareButton.TabIndex = 2;
            this.squareButton.UseVisualStyleBackColor = true;
            // 
            // rectangleButton
            // 
            this.rectangleButton.Image = global::SimpleShapeSketch.Properties.Resources.rectangle;
            this.rectangleButton.Location = new System.Drawing.Point(54, 105);
            this.rectangleButton.Name = "rectangleButton";
            this.rectangleButton.Size = new System.Drawing.Size(45, 45);
            this.rectangleButton.TabIndex = 3;
            this.rectangleButton.UseVisualStyleBackColor = true;
            // 
            // circleButton
            // 
            this.circleButton.Image = ((System.Drawing.Image)(resources.GetObject("circleButton.Image")));
            this.circleButton.Location = new System.Drawing.Point(3, 156);
            this.circleButton.Name = "circleButton";
            this.circleButton.Size = new System.Drawing.Size(45, 45);
            this.circleButton.TabIndex = 4;
            this.circleButton.UseVisualStyleBackColor = true;
            // 
            // ellipseButton
            // 
            this.ellipseButton.Image = global::SimpleShapeSketch.Properties.Resources.ellipse;
            this.ellipseButton.Location = new System.Drawing.Point(54, 156);
            this.ellipseButton.Name = "ellipseButton";
            this.ellipseButton.Size = new System.Drawing.Size(45, 45);
            this.ellipseButton.TabIndex = 5;
            this.ellipseButton.UseVisualStyleBackColor = true;
            // 
            // polygonButton
            // 
            this.polygonButton.Image = global::SimpleShapeSketch.Properties.Resources.polygon;
            this.polygonButton.Location = new System.Drawing.Point(3, 207);
            this.polygonButton.Name = "polygonButton";
            this.polygonButton.Size = new System.Drawing.Size(45, 45);
            this.polygonButton.TabIndex = 6;
            this.polygonButton.UseVisualStyleBackColor = true;
            // 
            // moveButton
            // 
            this.moveButton.Image = global::SimpleShapeSketch.Properties.Resources.move;
            this.moveButton.Location = new System.Drawing.Point(54, 207);
            this.moveButton.Name = "moveButton";
            this.moveButton.Size = new System.Drawing.Size(45, 45);
            this.moveButton.TabIndex = 7;
            this.moveButton.UseVisualStyleBackColor = true;
            // 
            // groupButton
            // 
            this.groupButton.Image = global::SimpleShapeSketch.Properties.Resources.group;
            this.groupButton.Location = new System.Drawing.Point(3, 258);
            this.groupButton.Name = "groupButton";
            this.groupButton.Size = new System.Drawing.Size(45, 45);
            this.groupButton.TabIndex = 8;
            this.groupButton.UseVisualStyleBackColor = true;
            // 
            // ungroupButton
            // 
            this.ungroupButton.Image = global::SimpleShapeSketch.Properties.Resources.ungroup;
            this.ungroupButton.Location = new System.Drawing.Point(54, 258);
            this.ungroupButton.Name = "ungroupButton";
            this.ungroupButton.Size = new System.Drawing.Size(45, 45);
            this.ungroupButton.TabIndex = 9;
            this.ungroupButton.UseVisualStyleBackColor = true;
            // 
            // undoButton
            // 
            this.undoButton.Image = global::SimpleShapeSketch.Properties.Resources.undo;
            this.undoButton.Location = new System.Drawing.Point(3, 309);
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(45, 45);
            this.undoButton.TabIndex = 10;
            this.undoButton.UseVisualStyleBackColor = true;
            // 
            // redoButton
            // 
            this.redoButton.Image = global::SimpleShapeSketch.Properties.Resources.redo;
            this.redoButton.Location = new System.Drawing.Point(54, 309);
            this.redoButton.Name = "redoButton";
            this.redoButton.Size = new System.Drawing.Size(45, 45);
            this.redoButton.TabIndex = 11;
            this.redoButton.UseVisualStyleBackColor = true;
            // 
            // selectButton
            // 
            this.selectButton.Image = global::SimpleShapeSketch.Properties.Resources.select;
            this.selectButton.Location = new System.Drawing.Point(3, 3);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(96, 45);
            this.selectButton.TabIndex = 14;
            this.selectButton.UseVisualStyleBackColor = true;
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // Canvas
            // 
            this.Canvas.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Canvas.Location = new System.Drawing.Point(121, 27);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(754, 442);
            this.Canvas.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(887, 481);
            this.Controls.Add(this.Canvas);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Sketcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Button freeDrawButton;
        private System.Windows.Forms.Button straightLineButton;
        private System.Windows.Forms.Button squareButton;
        private System.Windows.Forms.Button rectangleButton;
        private System.Windows.Forms.Button circleButton;
        private System.Windows.Forms.Button ellipseButton;
        private System.Windows.Forms.Button polygonButton;
        private System.Windows.Forms.Button moveButton;
        private System.Windows.Forms.Button groupButton;
        private System.Windows.Forms.Button ungroupButton;
        private System.Windows.Forms.Button undoButton;
        private System.Windows.Forms.Button redoButton;
        private System.Windows.Forms.Button colorButton;
        private System.Windows.Forms.Label colourLabel;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel Canvas;
    }
}

