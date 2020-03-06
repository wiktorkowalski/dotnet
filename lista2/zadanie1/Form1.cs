using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DateTime = System.DateTime;

namespace zadanie1
{
    public partial class Form1 : Form
    {
        private DateTime alarm;
        private bool isAlarmActive = false;

        public Form1()
        {
            InitializeComponent();
            this.alarmPicker.Format = DateTimePickerFormat.Time;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.clockLabel.Text = DateTime.Now.ToString("HH:mm:ss");
            this.dateLabel.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            if (DateTime.Compare(DateTime.Now, alarm) > 0 && isAlarmActive)
            {
                isAlarmActive = false;
                this.alarmLabel.Text = String.Empty;
                MessageBox.Show("Alarm!!!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.clockLabel.Text = DateTime.Now.ToString("HH:mm:ss");
            this.dateLabel.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            this.alarmPicker.Value = DateTime.Now.AddSeconds(5);
            this.timer.Enabled = true;
        }

        private void alarmButton_Click(object sender, EventArgs e)
        {
            alarm = this.alarmPicker.Value;
            this.alarmLabel.Text = $"Alarm set to {alarm}";
            isAlarmActive = true;
        }
    }
}
