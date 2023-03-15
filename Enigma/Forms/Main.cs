using Enigma.Forms;

namespace Enigma
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex) { MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void TsBtn_Hash_Click(object sender, EventArgs e)
        {
            try
            {
                Pnl_Main.OpenForm(new Frm_Hash());
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void TsBtn_Encrypt_Click(object sender, EventArgs e)
        {
            try
            {
                Pnl_Main.OpenForm(new Frm_Encrypt());
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void TsBtn_Decrypt_Click(object sender, EventArgs e)
        {
            try
            {
                Pnl_Main.OpenForm(new Frm_Decrypt());
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}