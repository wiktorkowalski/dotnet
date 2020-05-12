using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadanie2
{
    public partial class Form2 : Form
    {

        public Person NewPerson { get; set; }

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            foreach (Control control in Controls)
            {
                if (control is TextBox)
                {
                    if (string.IsNullOrEmpty(control.Text))
                    {
                        isValid = false;
                    }
                }
            }

            if (!isValid)
            {
                MessageBox.Show($"Wszystkie pola muszą być uzupełnione!", "Uzupełnij pola!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.NewPerson = new Person(-1, name.Text, surname.Text, address.Text, phoneNumber.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
