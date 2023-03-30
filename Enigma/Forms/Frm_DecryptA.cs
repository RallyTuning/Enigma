using System.Text;

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

                AsymmetricEncryption.For_Decrypt.CreatAsymmetriceKeys();
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


        private async void Btn_ExportPublic_Click(object sender, EventArgs e)
        {
            try
            {
                using SaveFileDialog SFD = new();
                SFD.Title = "Save public PEM file";
                SFD.Filter = "PEM|*.pem";
                SFD.OverwritePrompt = true;
                SFD.RestoreDirectory = true;
                SFD.SupportMultiDottedExtensions = false;

                if (SFD.ShowDialog() == DialogResult.OK)
                {
                    await Functions.SaveFile(SFD.FileName, AsymmetricEncryption.For_Decrypt.ExportPublicKey());
                }
            }
            catch (Exception ex) { Txt_Result.Text = $"/// ERROR ///{Environment.NewLine}{Environment.NewLine}{ex.Message}"; }
        }

        private async void Btn_ExportPrivate_Click(object sender, EventArgs e)
        {
            try
            {
                using SaveFileDialog SFD = new();
                SFD.Title = "Save private PEM file";
                SFD.Filter = "PEM|*.pem";
                SFD.OverwritePrompt = true;
                SFD.RestoreDirectory = true;
                SFD.SupportMultiDottedExtensions = false;

                if (SFD.ShowDialog() == DialogResult.OK)
                {
                    await Functions.SaveFile(SFD.FileName, AsymmetricEncryption.For_Decrypt.ExportPrivateKey());
                }
            }
            catch (Exception ex) { Txt_Result.Text = $"/// ERROR ///{Environment.NewLine}{Environment.NewLine}{ex.Message}"; }
        }

        private void Btn_ShowKeys_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder SB = new();

                SB.AppendLine(AsymmetricEncryption.For_Decrypt.ExportPublicKey());
                SB.AppendLine(Environment.NewLine + Environment.NewLine);
                SB.AppendLine(AsymmetricEncryption.For_Decrypt.ExportPrivateKey());

                Txt_Result.Text = SB.ToString();
            }
            catch (Exception ex) { Txt_Result.Text = $"/// ERROR ///{Environment.NewLine}{Environment.NewLine}{ex.Message}"; }
        }

        private void Btn_GenerateKeys_Click(object sender, EventArgs e)
        {
            try
            {
                AsymmetricEncryption.For_Decrypt.CreatAsymmetriceKeys();
            }
            catch (Exception ex) { Txt_Result.Text = $"/// ERROR ///{Environment.NewLine}{Environment.NewLine}{ex.Message}"; }
        }


        private void Nud_KeyBit_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                AsymmetricEncryption.KeyBitSize = int.Parse(Nud_KeyBit.Value.ToString());
            }
            catch (Exception ex) { Txt_Result.Text = $"/// ERROR ///{Environment.NewLine}{Environment.NewLine}{ex.Message}"; }
        }



        private void Calc()
        {
            try
            {
                if (string.IsNullOrEmpty(Txt_Text.Text)) { Txt_Result.Text = "First export the public key in the Decrypt window, then import it in the Encrypt window."; return; }

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

                string DecryptedMessage = AsymmetricEncryption.For_Decrypt.Decrypt(ChipBytes);

                Txt_Result.Text = DecryptedMessage;
            }
            catch (Exception ex) { Txt_Result.Text = $"/// ERROR ///{Environment.NewLine}{Environment.NewLine}{ex.Message}"; }
        }
    }
}
