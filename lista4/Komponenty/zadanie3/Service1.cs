using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadanie3
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            //var temp = MessageBox.Show("AWS","Amazing Windows Service ON");
        }

        protected override void OnStop()
        {
            //var temp = MessageBox.Show("AWS", "Amazing Windows Service OFF");
        }
    }
}
