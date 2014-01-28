namespace Alarm
{
    partial class ClockForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClockForm));
            this.setButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.alarmGroupBox = new System.Windows.Forms.GroupBox();
            this.ampmUpDown = new System.Windows.Forms.DomainUpDown();
            this.hourUpDown = new System.Windows.Forms.NumericUpDown();
            this.minuteUpDown = new System.Windows.Forms.NumericUpDown();
            this.secondUpDown = new System.Windows.Forms.NumericUpDown();
            this.resetButton = new System.Windows.Forms.Button();
            this.clockLabel = new System.Windows.Forms.Label();
            this.clockTimer = new System.Windows.Forms.Timer(this.components);
            this.alarmGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hourUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minuteUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // setButton
            // 
            this.setButton.Location = new System.Drawing.Point(224, 16);
            this.setButton.Name = "setButton";
            this.setButton.Size = new System.Drawing.Size(64, 23);
            this.setButton.TabIndex = 13;
            this.setButton.Text = "Set";
            this.setButton.Click += new System.EventHandler(this.setButton_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Hr.";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(72, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Min.";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(120, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Sec.";
            // 
            // alarmGroupBox
            // 
            this.alarmGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.alarmGroupBox.Controls.Add(this.ampmUpDown);
            this.alarmGroupBox.Controls.Add(this.hourUpDown);
            this.alarmGroupBox.Controls.Add(this.minuteUpDown);
            this.alarmGroupBox.Controls.Add(this.secondUpDown);
            this.alarmGroupBox.Controls.Add(this.resetButton);
            this.alarmGroupBox.Controls.Add(this.label3);
            this.alarmGroupBox.Controls.Add(this.setButton);
            this.alarmGroupBox.Controls.Add(this.label1);
            this.alarmGroupBox.Controls.Add(this.label2);
            this.alarmGroupBox.Location = new System.Drawing.Point(16, 144);
            this.alarmGroupBox.Name = "alarmGroupBox";
            this.alarmGroupBox.Size = new System.Drawing.Size(304, 80);
            this.alarmGroupBox.TabIndex = 6;
            this.alarmGroupBox.TabStop = false;
            this.alarmGroupBox.Text = "Alarm";
            // 
            // ampmUpDown
            // 
            this.ampmUpDown.Items.Add("AM");
            this.ampmUpDown.Items.Add("PM");
            this.ampmUpDown.Location = new System.Drawing.Point(168, 40);
            this.ampmUpDown.Name = "ampmUpDown";
            this.ampmUpDown.Size = new System.Drawing.Size(40, 20);
            this.ampmUpDown.TabIndex = 9;
            this.ampmUpDown.Text = "AM";
            // 
            // hourUpDown
            // 
            this.hourUpDown.Location = new System.Drawing.Point(24, 40);
            this.hourUpDown.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.hourUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.hourUpDown.Name = "hourUpDown";
            this.hourUpDown.Size = new System.Drawing.Size(40, 20);
            this.hourUpDown.TabIndex = 7;
            this.hourUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // minuteUpDown
            // 
            this.minuteUpDown.Location = new System.Drawing.Point(72, 40);
            this.minuteUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minuteUpDown.Name = "minuteUpDown";
            this.minuteUpDown.Size = new System.Drawing.Size(40, 20);
            this.minuteUpDown.TabIndex = 7;
            // 
            // secondUpDown
            // 
            this.secondUpDown.Location = new System.Drawing.Point(120, 40);
            this.secondUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.secondUpDown.Name = "secondUpDown";
            this.secondUpDown.Size = new System.Drawing.Size(40, 20);
            this.secondUpDown.TabIndex = 8;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(224, 48);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(64, 23);
            this.resetButton.TabIndex = 5;
            this.resetButton.Text = "Reset";
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // clockLabel
            // 
            this.clockLabel.BackColor = System.Drawing.Color.Transparent;
            this.clockLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clockLabel.Location = new System.Drawing.Point(16, 24);
            this.clockLabel.Name = "clockLabel";
            this.clockLabel.Size = new System.Drawing.Size(304, 100);
            this.clockLabel.TabIndex = 0;
            this.clockLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clockTimer
            // 
            this.clockTimer.Enabled = true;
            this.clockTimer.Interval = 500;
            this.clockTimer.Tick += new System.EventHandler(this.clockTimer_Tick);
            // 
            // ClockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(353, 247);
            this.Controls.Add(this.clockLabel);
            this.Controls.Add(this.alarmGroupBox);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClockForm";
            this.Text = "SE3350-Alarm";
            this.alarmGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hourUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minuteUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button setButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox alarmGroupBox;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.NumericUpDown hourUpDown;
        private System.Windows.Forms.NumericUpDown minuteUpDown;
        private System.Windows.Forms.NumericUpDown secondUpDown;
        private System.Windows.Forms.DomainUpDown ampmUpDown;
        private System.Windows.Forms.Label clockLabel;
        private System.Windows.Forms.Timer clockTimer;


    }
}

