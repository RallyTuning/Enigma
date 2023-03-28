using System.Security.Cryptography;

namespace Enigma
{
    public partial class Frm_EncryptA : Form
    {
        public Frm_EncryptA()
        {
            InitializeComponent();
        }


        private void Frm_EncryptA_Load(object sender, EventArgs e)
        {
            try
            {
                Cmb_Type.SelectedIndex = 0;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void Txt_Text_TextChanged(object sender, EventArgs e)
        {
            Calc();
        }

        private void Txt_Password_TextChanged(object sender, EventArgs e)
        {
            Calc();
        }

        private void Txt_IV_TextChanged(object sender, EventArgs e)
        {
            Calc();
        }

        private void Cmb_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calc();
        }


        private void Calc()
        {
            try
            {
                if (string.IsNullOrEmpty(Txt_Text.Text)) { Txt_Result.Text = ""; return; }

                RSAParameters PrivateAndPublicKeys, PublicKeyOnly;
                using RSA RsaAlg = RSA.Create();

                PrivateAndPublicKeys = RsaAlg.ExportParameters(true);
                PublicKeyOnly = RsaAlg.ExportParameters(false);

                byte[] EncryptedMessage = AsymmetricEncryption.Encrypt(Txt_Text.Text, PublicKeyOnly);

                Txt_Result.Text = Cmb_Type.SelectedIndex switch
                {
                    0 => EncryptedMessage.ToHex(),
                    1 => EncryptedMessage.ToBase64(),
                    2 => EncryptedMessage.ToBinary(),
                    3 => EncryptedMessage.ToRString(),
                    _ => "???",
                };
            }
            catch (Exception ex) { Txt_Result.Text = $"/// ERROR ///{Environment.NewLine}{Environment.NewLine}{ex.Message}"; }
        }
    }
}
