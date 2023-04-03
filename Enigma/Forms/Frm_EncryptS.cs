namespace Enigma
{
    public partial class Frm_EncryptS : Form
    {
        public Frm_EncryptS()
        {
            InitializeComponent();
        }


        private void Frm_Encrypt_Load(object sender, EventArgs e)
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

                byte[] EncryptedMessage = SymmetricEncryption.Encrypt(Txt_Text.Text, Txt_Password.Text, Txt_IV.Text);


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
