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

        private void Cmb_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calc();
        }

        private async void Btn_ImportPublicKey_Click(object sender, EventArgs e)
        {
            try
            {
                using OpenFileDialog OFD = new();
                OFD.Title = "Import a public key";
                OFD.Filter = "PEM|*.pem";
                OFD.Multiselect = false;
                OFD.RestoreDirectory = true;
                OFD.CheckFileExists = true;

                if (OFD.ShowDialog() == DialogResult.OK)
                {
                    string Data = await Functions.ImportFile(OFD.FileName);
                    AsymmetricEncryption.For_Encrypt.ImportKeys(Data);
                }
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

                byte[] EncryptedMessage = AsymmetricEncryption.For_Encrypt.Encrypt(Txt_Text.Text);

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
