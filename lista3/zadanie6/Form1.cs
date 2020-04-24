using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace zadanie6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chooseFileButton_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                var fileName = openFileDialog1.FileName;
                textBoxAttachmentPath.Text = fileName;
            }
        }

        private async void sendButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxLogin.Text) || string.IsNullOrEmpty(textBoxPassword.Text))
            {
                MessageBox.Show("Pola login oraz hasło nie mogą być puste.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            progressBar1.Style = ProgressBarStyle.Marquee;
            try
            {
                var mail = new MailMessage
                {
                    From = new MailAddress(textBoxFrom.Text),
                    Subject = textBoxSubject.Text,
                    Body = textBoxBody.Text
                };
                mail.To.Add(textBoxTo.Text);

                if (!string.IsNullOrEmpty(textBoxAttachmentPath.Text))
                {
                    var attachemnt = new Attachment(textBoxAttachmentPath.Text);
                    mail.Attachments.Add(attachemnt);
                }

                var smtpClient = new SmtpClient()
                {
                    Host = "poczta.stud.uz.zgora.pl",
                    Port = 587,
                    Credentials = new NetworkCredential(textBoxLogin.Text, textBoxPassword.Text),
                    EnableSsl = true
                };

                await smtpClient.SendMailAsync(mail);

                MessageBox.Show("Wiadomość została wysłana!", "Sukces", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Coś poszło nie tak!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                progressBar1.Style = ProgressBarStyle.Continuous;
            }
        }
    }
}
