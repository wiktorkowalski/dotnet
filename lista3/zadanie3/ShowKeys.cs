using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadanie3
{
    public partial class ShowKeys : Form
    {
        private RSA rsa;
        public ShowKeys(RSA rsa)
        {
            InitializeComponent();
            this.rsa = rsa;
        }

        private void ShowKeys_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void populate()
        {
            textBox1.Text = rsa.p.ToString();
            textBox2.Text = rsa.q.ToString();
            textBox3.Text = rsa.Ø.ToString();
            textBox4.Text = rsa.N.ToString();
            textBox5.Text = rsa.E.ToString();
            textBox6.Text = rsa.D.ToString();
        }
    }
}
