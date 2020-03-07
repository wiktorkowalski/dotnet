using System;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;

namespace zadanie2
{
    public partial class Form1 : Form
    {
        private char @operator;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(this.textArg1.Text);
            double b = Convert.ToDouble(this.textArg2.Text);
            double result = calculate(a, b);
        }

        private double calculate(double a, double b)
        {
            if (b == 0)
            {
                MessageBox.Show("Division error");
                return 0;
            }
            switch (@operator)
            {
                case '+':
                    return a + b;
                    break;
                case '-':
                    return a - b;
                    break;
                case '*':
                    return a * b;
                    break;
                case '/':
                    return a / b;
                    break;
                default:
                    MessageBox.Show("Unknown error");
                    return 0;
            }
        }

        private void radioAdd_CheckedChanged(object sender, EventArgs e) => @operator = radioAdd.Text.ToCharArray()[0];
        private void radioSub_CheckedChanged(object sender, EventArgs e) => @operator = radioSub.Text.ToCharArray()[0];
        private void radioMul_CheckedChanged(object sender, EventArgs e) => @operator = radioMul.Text.ToCharArray()[0];
        private void radioDiv_CheckedChanged(object sender, EventArgs e) => @operator = radioDiv.Text.ToCharArray()[0];

    }
}
