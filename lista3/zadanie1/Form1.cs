using System;
using System.Windows.Forms;

namespace zadanie1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            var date1 = this.dateTimePicker1.Value;
            var date2 = this.dateTimePicker2.Value;
            TimeSpan dateDiffrence;
            if (date1.CompareTo(date2) >= 0) dateDiffrence = date1.Subtract(date2);
            else dateDiffrence = date2.Subtract(date1);
            this.label1.Text = "Diffrence is " +
            $"{dateDiffrence.Days} day" + (dateDiffrence.Days == 1 ? ", " : "s, ") +
            $"{dateDiffrence.Hours} hour" + (dateDiffrence.Hours == 1 ? ", " : "s, ") +
            $"{dateDiffrence.Seconds} second" + (dateDiffrence.Seconds == 1 ? "" : "s");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.dateTimePicker1.Format = DateTimePickerFormat.Long;
        }
    }
}
