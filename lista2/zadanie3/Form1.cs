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

        private void Form1_Load(object sender, EventArgs e)
        {
            this.comboBox1.DataSource = Enum.GetValues(typeof(MessageBoxButtons));
            this.comboBox2.DataSource = Enum.GetValues(typeof(MessageBoxIcon));
            this.comboBox3.DataSource = Enum.GetValues(typeof(MessageBoxDefaultButton));
            this.comboBox4.DataSource = Enum.GetValues(typeof(MessageBoxOptions));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.labelResult.Text = MessageBox.Show("content", "title", (MessageBoxButtons)this.comboBox1.SelectedItem, (MessageBoxIcon)this.comboBox2.SelectedItem, (MessageBoxDefaultButton)this.comboBox3.SelectedItem, (MessageBoxOptions)this.comboBox4.SelectedItem).ToString();
        }
    }
}
