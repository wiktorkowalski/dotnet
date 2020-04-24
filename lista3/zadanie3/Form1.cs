using System.IO;
using System.Numerics;
using System.Windows.Forms;

namespace zadanie3
{
    public partial class Form1 : Form
    {
        //var intEncrypted = rsa.EncryptMessage(123456789);
        //var intDecrypted = rsa.DecryptMessage(intEncrypted);
        //var stringEncrypted = rsa.EncryptMessage("123test");
        //var stringDecrypted = rsa.DecryptMessage(stringEncrypted);
        //var fileEncrypted = rsa.EncryptFile(@"C:\Users\Wiktor\Desktop\encrypt.txt");
        //var fileDecrypted = rsa.DecryptFile(@"C:\Users\Wiktor\Desktop\decrypt.txt");
        private RSA rsa;
        private string fileLoadPath = string.Empty;
        private string fileSavePath = string.Empty;
        public Form1()
        {
            InitializeComponent();
            rsa = new RSA();
        }

        private void buttonGenerateKeys_Click(object sender, System.EventArgs e)
        {
            rsa.GenerateEncryptionKeys();
        }

        private void buttonEncrypt_Click(object sender, System.EventArgs e)
        {
            var encrypted = rsa.EncryptMessage(textBoxEncrypt.Text);
            this.textBoxEncrypted.Text = encrypted;
        }

        private void buttonDecrypt_Click(object sender, System.EventArgs e)
        {
            var decrypted = rsa.DecryptMessage(this.textBoxEncrypted.Text);
            this.textBoxDecrypted.Text = decrypted;
        }

        private void buttonClear_Click(object sender, System.EventArgs e)
        {
            Clear();
        }

        private void buttonShowKeys_Click(object sender, System.EventArgs e)
        {
            var showKeysForm = new ShowKeys(rsa);
            showKeysForm.Show();
        }

        private void buttonOpenFile_Click(object sender, System.EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    fileLoadPath = openFileDialog.FileName;
                }
            }
        }

        private void buttonSaveFile_Click(object sender, System.EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.InitialDirectory = "c:\\";
                saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 2;
                saveFileDialog.RestoreDirectory = true;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    fileSavePath = saveFileDialog.FileName;
                }
            }
        }

        private void Clear()
        {
            this.textBoxEncrypt.Clear();
            this.textBoxEncrypted.Clear();
            this.textBoxDecrypted.Clear();
            fileLoadPath = string.Empty;
            fileSavePath = string.Empty;
        }

        private void buttonEncryptFile_Click(object sender, System.EventArgs e)
        {
            var encrypted = rsa.EncryptFile(fileLoadPath);
            this.textBoxEncrypted.Text = encrypted;
        }
    }
}
