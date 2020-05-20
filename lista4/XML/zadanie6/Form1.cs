using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadanie6
{
    public partial class Form1 : Form
    {
        private List<PhotoForm> photoList = new List<PhotoForm>();
        private int currentIndex = 0;
        private bool isLoaded = false;
        public Form1()
        {
            InitializeComponent();

        }

        private void ChangePicture(int offset = 0)
        {
            currentIndex += offset;
            if (currentIndex > photoList.Count - 1) currentIndex = 0;
            if (currentIndex < 0) currentIndex = photoList.Count - 1;
            foreach (var item in photoList) item.Hide();
            photoList[currentIndex].Show();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isLoaded) return;
            isLoaded = true;
            string[] filePhotos = Directory.GetFiles("../../photos");
            foreach (var item in filePhotos)
            {
                photoList.Add(new PhotoForm(this, item));
            }
            ChangePicture();
        }

        private void nextToolStripMenuItem_Click(object sender, EventArgs e) => ChangePicture(1);

        private void previousToolStripMenuItem_Click(object sender, EventArgs e) => ChangePicture(-1);
    }
}
