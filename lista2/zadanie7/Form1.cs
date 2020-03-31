using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadanie7
{
    public partial class Form1 : Form
    {
        List<Codec> codecsList;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            codecsList = new List<Codec>();
            List<ImageCodecInfo> temp = new List<ImageCodecInfo>(ImageCodecInfo.GetImageEncoders());
            temp.AddRange(ImageCodecInfo.GetImageDecoders());
            foreach (var item in temp) codecsList.Add(new Codec(item));
            this.codecList.BeginUpdate();
            foreach (var item in temp)
            {
                this.codecList.Items.Add(new Codec(item)); 
            }
            this.codecList.EndUpdate();
        }

        private void codecList_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.richTextBox1.Text = codecsList[this.codecList.SelectedIndex].GetCodecInfo();
        }
    }
}
