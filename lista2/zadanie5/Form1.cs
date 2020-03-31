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

        private void populateButton_Click(object sender, EventArgs e)
        {
            multiSelectListBox.SelectionMode = SelectionMode.MultiExtended;
            multiSelectListBox.MultiColumn = true;
            multiSelectListBox.BeginUpdate();
            singleSelectListBox.BeginUpdate();
            for (int x = 1; x <= 50; x++)
            {
                multiSelectListBox.Items.Add("Item " + x.ToString());
                singleSelectListBox.Items.Add("Item " + x.ToString());
            }

            multiSelectListBox.EndUpdate();
            singleSelectListBox.EndUpdate();

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            multiSelectListBox.Items.Clear();
            singleSelectListBox.Items.Clear();
            selectedItemsTextBox.Text = string.Empty;
            selectedItemLabel.Text = string.Empty;
        }

        private void multiSelectListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < multiSelectListBox.SelectedItems.Count; i++)
            {
                sb.AppendLine(multiSelectListBox.SelectedItems[i].ToString());
            }
            selectedItemsTextBox.Text = sb.ToString();
        }

        private void listBox2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (singleSelectListBox.SelectedItem == null)
                {
                    return;
                }
                selectedItemLabel.Text = singleSelectListBox.SelectedItem?.ToString() ?? string.Empty;
                singleSelectListBox.DoDragDrop(singleSelectListBox.SelectedItem, DragDropEffects.Move);
            }
            if (e.Button == MouseButtons.Right)
            {
                singleSelectListBox.SelectedIndex = singleSelectListBox.IndexFromPoint(e.Location);
            }
        }

        private void listBox2DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            singleSelectListBox.Items.RemoveAt(singleSelectListBox.SelectedIndex);
        }

        private void multiSelectListBoxDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            multiSelectListBox.BeginUpdate();
            for (int i = multiSelectListBox.SelectedItems.Count - 1; i >= 0; i--)
            {
                multiSelectListBox.Items.Remove(multiSelectListBox.SelectedItems[i]);
            }
            multiSelectListBox.EndUpdate();
        }

        private void singleSelectListBox_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void singleSelectListBox_DragDrop(object sender, DragEventArgs e)
        {
            Point point = singleSelectListBox.PointToClient(new Point(e.X, e.Y));
            int index = singleSelectListBox.IndexFromPoint(point);
            if (index < 0)
            {
                index = this.multiSelectListBox.Items.Count - 1;
            }
            object item = singleSelectListBox.SelectedItem;
            singleSelectListBox.Items.Remove(item);
            singleSelectListBox.Items.Insert(index, item);
        }

        private void addToListBoxButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(newItemTextBox.Text))
            {
                singleSelectListBox.Items.Add(newItemTextBox.Text);
                multiSelectListBox.Items.Add(newItemTextBox.Text);
                newItemTextBox.Text = string.Empty;
            }
        }
    }
}
