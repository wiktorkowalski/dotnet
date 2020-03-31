using System;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

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

        private void listBox2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (listBox2.SelectedItem == null)
                {
                    return;
                }
                label3.Text = listBox2.SelectedItem?.ToString() ?? string.Empty;
                listBox2.DoDragDrop(listBox2.SelectedItem, DragDropEffects.Move);
            }
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

        private void listBox2_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void listBox2_DragDrop(object sender, DragEventArgs e)
        {
            Point point = listBox2.PointToClient(new Point(e.X, e.Y));
            int index = listBox2.IndexFromPoint(point);
            if (index < 0)
            {
                index = this.listBox1.Items.Count - 1;
            }
            object item = listBox2.SelectedItem;
            listBox2.Items.Remove(item);
            listBox2.Items.Insert(index, item);
        }
    }
}
