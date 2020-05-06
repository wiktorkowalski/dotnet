using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrafficComponent
{
    public partial class TrafficControl : UserControl
    {
        private const int alphaOff = 100, alphaOn = 255;
        public TrafficControl()
        {
            InitializeComponent();
            this.panelRed.BackColor = Color.FromArgb(alphaOff, Color.Red);
            this.panelYellow.BackColor = Color.FromArgb(alphaOff, Color.Yellow);
            this.panelGreen.BackColor = Color.FromArgb(alphaOff, Color.Green);
        }

        public void ChangeState(TrafficState state)
        {
            this.panelRed.BackColor = Color.FromArgb(state.HasFlag(TrafficState.Stop) ? alphaOn : alphaOff, Color.Red);
            this.panelYellow.BackColor = Color.FromArgb(state.HasFlag(TrafficState.Warn) ? alphaOn : alphaOff, Color.Yellow);
            this.panelGreen.BackColor = Color.FromArgb(state.HasFlag(TrafficState.Go) ? alphaOn : alphaOff, Color.Green);
        }
    }


    public enum TrafficState
    {
        None = 0,
        Stop = 1,
        Warn = 2,
        Go = 4
    }
}
