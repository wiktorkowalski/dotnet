using System.Numerics;
using System.Windows.Forms;

namespace zadanie3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void SetEncryptionKeys(BigInteger privateKey, BigInteger publicKey)
        {

        }

        private void button1_Click(object sender, System.EventArgs e) => Controller.GenerateEncryptionKeys();


    }
}
