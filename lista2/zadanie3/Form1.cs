using System;
using System.Windows.Forms;

namespace zadanie3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("no buttons, just text", "title");
            label1.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Buttons with icon","title",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Error);
            label1.Text = result.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("                       Is this text right-aligned?","is it?",MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button1,MessageBoxOptions.RightAlign);
            label1.Text = result.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
