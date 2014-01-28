using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Alarm
{
    public partial class ClockForm : Form
    {

        // Form variable to hold the alarm time setting
        private DateTime alarmTime;

        public ClockForm()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }



        // Code that fires on each tick of the timer
        private void clockTimer_Tick(object sender, System.EventArgs e)
        {
            // Get the current time
            // Instantiate a new DateTime object
            DateTime time = DateTime.Now;
            // Set the label text to the time, passing the formatting
            // option as a parameter
            clockLabel.Text = time.ToString("h:mm:ss tt");

            // Check to see if alarm is set and if the alarmTime has passed
            if (alarmTime != DateTime.MinValue && time.CompareTo(alarmTime) > 0)
            {
                // Attach the AlarmToggle method to the clockTimer.Tick event
                // ADD YOUR CODE HERE
                this.clockTimer.Tick += new System.EventHandler(this.alarmToggle);
                // End of your code

                // Reset the alarmTime to the default value
                alarmTime = DateTime.MinValue;
            }
        }

        private void setButton_Click(object sender, System.EventArgs e)
        {
            // Convert the hours in hoursUpDown to a 24 hour clock
            int h = ((int)hourUpDown.Value == 12)
                        ? (ampmUpDown.Text == "AM") ? 0 : (int)hourUpDown.Value
                        : (ampmUpDown.Text == "AM") ? (int)hourUpDown.Value : (int)hourUpDown.Value + 12;

            // Set the alarmTime using the converted hours h and the
            // up/down control values for minutes and seconds
            alarmTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, h, (int)minuteUpDown.Value, (int)secondUpDown.Value);
        }
        private void alarmToggle(object sender, System.EventArgs e)
        {
            if (clockLabel.BackColor == Color.Red)
                clockLabel.BackColor = new Color();
            else
                clockLabel.BackColor = Color.Red;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            //Reset colour
            if (clockLabel.BackColor == Color.Red)
                clockLabel.BackColor = new Color();

            //unattach the flashing alarm thing
            this.clockTimer.Tick -= new System.EventHandler(this.alarmToggle);

            // Reset the alarmTime to the default value
            alarmTime = DateTime.MinValue;
            hourUpDown.Value = 1;
            minuteUpDown.Value = 0;
            secondUpDown.Value = 0;
            ampmUpDown.Text = "AM";
        }

    }
}