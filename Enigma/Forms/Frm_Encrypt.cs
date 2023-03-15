using Enigma;

namespace Enigma.Forms
{
    public partial class Frm_Encrypt : Form
    {
        public Frm_Encrypt()
        {
            InitializeComponent();
        }

        private void Txt_Text_TextChanged(object sender, EventArgs e)
        {
            Calc();
        }

        private void Txt_Password_TextChanged(object sender, EventArgs e)
        {
            Calc();
        }

        private void Calc()
        {
            try
            {
                SymmetricEncryption SE = new();
                byte[] EncryptedMessage = SE.Encrypt(Txt_Text.Text, Txt_Password.Text, "1234567890123456");
                Txt_Result.Text = Convert.ToHexString(EncryptedMessage);
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] key2, iv2;
                using (System.Security.Cryptography.Aes aesAlg2 = System.Security.Cryptography.Aes.Create())
                {
                    key2 = aesAlg2.Key;
                    iv2 = aesAlg2.IV;
                }

                Txt_Result.AppendText(Convert.ToHexString(key2) + Environment.NewLine + Convert.ToHexString(iv2) + Environment.NewLine + Environment.NewLine);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
