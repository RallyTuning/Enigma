using System.Text;

namespace Enigma
{
    public partial class Frm_Hash : Form
    {
        public Frm_Hash()
        {
            InitializeComponent();
        }

        private void Txt_Text_TextChanged(object sender, EventArgs e)
        {
            Txt_FilePath.Text = "";
            GetCalc();
        }

        private void Txt_Password_TextChanged(object sender, EventArgs e)
        {
            GetCalc();
        }

        private void Btn_OpeFile_Click(object sender, EventArgs e)
        {
            try
            {
                using OpenFileDialog OFD = new();
                OFD.Multiselect = false;
                OFD.Title = "Select a file to generate hash";
                OFD.RestoreDirectory = true;

                if (OFD.ShowDialog() == DialogResult.OK)
                {
                    Txt_FilePath.Text = OFD.FileName;
                    Txt_Text.Text = "";

                    GetCalc();
                }
            }
            catch (Exception ex) { Txt_Result.Text = $"/// ERROR ///{Environment.NewLine}{Environment.NewLine}{ex.Message}"; }
        }

        private void GetCalc()
        {
            try
            {
                if (string.IsNullOrEmpty(Txt_Text.Text) && !string.IsNullOrEmpty(Txt_FilePath.Text))
                {
                    using FileStream FS = new(Txt_FilePath.Text, FileMode.Open, FileAccess.Read, FileShare.Read);
                    using MemoryStream MS = new();
                    FS.CopyTo(MS);

                    byte[] S = Encoding.UTF8.GetBytes(Txt_Password.Text);
                    byte[] F = MS.ToArray();
                    byte[] M = new byte[S.Length + F.Length];

                    Buffer.BlockCopy(S, 0, M, 0, S.Length);
                    Buffer.BlockCopy(F, 0, M, S.Length, F.Length);

                    Hashy HF = new(M, Txt_Password.Text);
                    Txt_Result.Text = HF.Calc();
                }
                else
                {
                    if (string.IsNullOrEmpty(Txt_Text.Text)) { Txt_Result.Text = ""; return; }

                    Hashy HS = new(Txt_Text.Text, Txt_Password.Text);
                    Txt_Result.Text = HS.Calc();
                }
            }
            catch (Exception ex) { Txt_Result.Text = $"/// ERROR ///{Environment.NewLine}{Environment.NewLine}{ex.Message}"; }
        }

    }
}
