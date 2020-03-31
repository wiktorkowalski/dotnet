using System;
using System.Text;
using System.Windows.Forms;

namespace zadanie5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.SelectionMode = SelectionMode.MultiExtended;
            listBox1.MultiColumn = true;
            listBox1.BeginUpdate();
            listBox2.BeginUpdate();
            for (int x = 1; x <= 50; x++)
            {
                listBox1.Items.Add("Item " + x.ToString());
                listBox2.Items.Add("Item " + x.ToString());
            }

            listBox1.EndUpdate();
            listBox2.EndUpdate();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            richTextBox1.Text = string.Empty;
            label3.Text = string.Empty;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < listBox1.SelectedItems.Count; i++)
            {
                sb.AppendLine(listBox1.SelectedItems[i].ToString());
            }
            richTextBox1.Text = sb.ToString();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            label3.Text = listBox2.SelectedItem?.ToString() ?? string.Empty;
        }

        private void listBox2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                listBox2.SelectedIndex = listBox2.IndexFromPoint(e.Location);
            }
        }

        private void listBox2DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox2.Items.RemoveAt(listBox2.SelectedIndex);
        }

        private void listBox1DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.BeginUpdate();
            for (int i = listBox1.SelectedItems.Count - 1; i >= 0; i--)
            {
                listBox1.Items.Remove(listBox1.SelectedItems[i]);
            }
            listBox1.EndUpdate();
        }
    }
}
