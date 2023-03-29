using System.Security.Cryptography;
using System.Security.Cryptography.Pkcs;
using System.Text;

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

        private void Btn_ShowKeys_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder SB = new();

                SB.AppendLine("-----BEGIN PUBLIC KEY-----");
                SB.AppendLine("WIP");
                SB.AppendLine("-----END PUBLIC KEY-----");
                SB.AppendLine(Environment.NewLine + Environment.NewLine);
                SB.AppendLine("-----BEGIN RSA PRIVATE KEY-----");
                SB.AppendLine("WIP");
                SB.AppendLine("-----END RSA PRIVATE KEY-----");

                Txt_Result.Text = SB.ToString();
            }
            catch (Exception ex) { Txt_Result.Text = $"/// ERROR ///{Environment.NewLine}{Environment.NewLine}{ex.Message}"; }
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

                byte[] EncryptedMessage = AsymmetricEncryption.Encrypt(Txt_Text.Text, AsymmetricEncryption.PublicKeyOnly);

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
