using System.Security.Cryptography;

namespace Enigma
{
    public partial class Frm_DecryptA : Form
    {
        public Frm_DecryptA()
        {
            InitializeComponent();
        }

        private void Frm_DecryptA_Load(object sender, EventArgs e)
        {
            try
            {
                Cmb_Type.SelectedIndex = 0;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void Txt_Text_TextChanged_1(object sender, EventArgs e)
        {
            Calc();
        }

        private void Cmb_Type_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Calc();
        }


        private void Btn_ShowKeys_Click(object sender, EventArgs e)
        {

        }

        private void Btn_GenerateKeys_Click(object sender, EventArgs e)
        {
            try
            {
                AsymmetricEncryption.CreatAsymmetriceKeys();
            }
            catch (Exception ex) { Txt_Result.Text = $"/// ERROR ///{Environment.NewLine}{Environment.NewLine}{ex.Message}"; }
        }



        private void Calc()
        {
            try
            {
                if (string.IsNullOrEmpty(Txt_Text.Text)) { Txt_Result.Text = ""; return; }

                byte[] ChipBytes = Array.Empty<byte>();

                switch (Cmb_Type.SelectedIndex)
                {
                    case 0:
                        ChipBytes = Convert.FromHexString(Txt_Text.Text);
                        break;
                    case 1:
                        ChipBytes = Convert.FromBase64String(Txt_Text.Text);
                        break;
                    default:
                        return;
                }

                //RSAParameters PrivateAndPublicKeys, PublicKeyOnly;
                //using RSA RsaAlg = RSA.Create();
                //PrivateAndPublicKeys = RsaAlg.ImportRSAPrivateKey(true);
                //PublicKeyOnly = RsaAlg.ImportRSAPublicKey(true);

                string DecryptedMessage = AsymmetricEncryption.Decrypt(ChipBytes, AsymmetricEncryption.PrivateAndPublicKeys);
                Txt_Result.Text = DecryptedMessage;
            }
            catch (Exception ex) { Txt_Result.Text = $"/// ERROR ///{Environment.NewLine}{Environment.NewLine}{ex.Message}"; }
        }

    }
}
