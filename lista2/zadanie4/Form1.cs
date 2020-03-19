using System;
using System.Windows.Forms;

namespace zadanie4
{
    public partial class Form1 : Form
    {
        private Calculator calculator;

        public Form1()
        {
            InitializeComponent();
            calculator = Calculator.GetCalculator();
        }

        private void number_Click(object sender, EventArgs e) => this.inputBox.Text += sender.ToString()[sender.ToString().Length-1];

        private void button16_Click(object sender, EventArgs e) => this.inputBox.Text = calculator.Calculate(this.inputBox.Text).ToString();
    }
}
