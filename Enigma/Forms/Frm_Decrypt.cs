using System.Text;

namespace Enigma.Forms
{
    public partial class Frm_Decrypt : Form
    {
        public Frm_Decrypt()
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
                string DecryptedMessage = SE.Decrypt(Convert.FromHexString( Txt_Text.Text), Txt_Password.Text, "1234567890123456");
                Txt_Result.Text = DecryptedMessage;
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
