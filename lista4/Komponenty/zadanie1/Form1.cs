using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrafficComponent;

namespace zadanie1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void CheckedChanged(object sender, EventArgs e)
        {
            var state = (checkBox1.Checked ? TrafficState.Stop : TrafficState.None)
                | (checkBox2.Checked ? TrafficState.Warn : TrafficState.None)
                | (checkBox3.Checked ? TrafficState.Go : TrafficState.None);
            trafficControl1.ChangeState(state);
        }
    }
}
