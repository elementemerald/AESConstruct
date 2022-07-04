using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace AESConstruct
{
    public partial class MainForm : Form
    {
        private string selectedInputFile = "";
        private string selectedOutputFile = "";
        private readonly string saltKey = "asdfasdfasdfasdf";
        private readonly string saltIV = "fdsafdsafdsafdsa";

        public MainForm()
        {
            InitializeComponent();
        }

        private static string RandomString(int len)
        {
            Random random = new Random();
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var result = new string(
               Enumerable.Repeat(chars, len)
               .Select(s => s[random.Next(s.Length)])
               .ToArray());
            return result;
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.ShowDialog(this);
        }

        private void FileSelectButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "All Files (*.*)|*.*";
            ofd.RestoreDirectory = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileNameLabel.Text = ofd.FileName;
                selectedInputFile = ofd.FileName;
            }
        }

        private void OutputFileSelectButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "All Files (*.*)|*.*";
            sfd.RestoreDirectory = true;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                OutputFileNameLabel.Text = sfd.FileName;
                selectedOutputFile = sfd.FileName;
            }
        }

        private void SecretKeyBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SecretKeyShown_CheckedChanged(object sender, EventArgs e)
        {
            SecretKeyBox.PasswordChar = SecretKeyShown.Checked ? '\0' : '*';
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(selectedInputFile, FileMode.Open, FileAccess.Read);
            FileStream encFs = new FileStream(selectedOutputFile, FileMode.Create);

            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(SecretKeyBox.Text);
                aes.Mode = CipherMode.ECB;
                aes.Padding = PaddingMode.PKCS7;

                ICryptoTransform enc = aes.CreateEncryptor(Encoding.UTF8.GetBytes(saltKey), Encoding.UTF8.GetBytes(saltIV));
                CryptoStream crypto = new CryptoStream(encFs, enc, CryptoStreamMode.Write);

                byte[] buff = new byte[1024];
                int read;

                try
                {
                    while ((read = fs.Read(buff, 0, buff.Length)) > 0)
                    {
                        crypto.Write(buff, 0, read);
                    }

                    crypto.FlushFinalBlock();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Exception occurred while encrypting: {ex.Message}", "Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    fs.Close();
                    encFs.Close();
                    MessageBox.Show("Successfully encrypted file!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            FileStream encFs = new FileStream(selectedInputFile, FileMode.Open, FileAccess.Read);
            FileStream fs = new FileStream(selectedOutputFile, FileMode.Create);

            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(SecretKeyBox.Text);
                aes.Mode = CipherMode.ECB;
                aes.Padding = PaddingMode.PKCS7;

                ICryptoTransform dec = aes.CreateDecryptor(Encoding.UTF8.GetBytes(saltKey), Encoding.UTF8.GetBytes(saltIV));
                CryptoStream crypto = new CryptoStream(encFs, dec, CryptoStreamMode.Read);

                try
                {
                    byte[] buff = new byte[1024];
                    int read;
                    while ((read = crypto.Read(buff, 0, buff.Length)) > 0)
                    {
                        fs.Write(buff, 0, read);
                    }

                    fs.Flush();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Exception occurred while decrypting: {ex.Message}", "Result", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    encFs.Close();
                    fs.Close();
                    MessageBox.Show("Successfully decrypted file!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void SKGenerateButton_Click(object sender, EventArgs e)
        {
            SecretKeyBox.Text = RandomString(32);
        }
    }
}