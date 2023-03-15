using Enigma;

namespace Enigma.Forms
{
    public partial class Frm_Hash : Form
    {
        public Frm_Hash()
        {
            InitializeComponent();
        }

        private void Txt_Text_TextChanged(object sender, EventArgs e)
        {
            GetCalc();
        }

        private void Txt_Password_TextChanged(object sender, EventArgs e)
        {
            GetCalc();
        }

        private void GetCalc()
        {
            try
            {
                Hashy H = new(Txt_Text.Text, Txt_Password.Text);
                Txt_Result.Text = H.Calc();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
