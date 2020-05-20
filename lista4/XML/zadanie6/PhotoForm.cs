using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadanie6
{
    public partial class PhotoForm : Form
    {
        public PhotoForm(Form mdiParent, string path)
        {
            InitializeComponent();
            this.MdiParent = mdiParent;
            this.pictureBox1.Image = (Image)new Bitmap(path);
        }
    }
}
