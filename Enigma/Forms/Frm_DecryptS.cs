﻿using System.Text;

namespace Enigma
{
    public partial class Frm_DecryptS : Form
    {
        public Frm_DecryptS()
        {
            InitializeComponent();
        }


        private void Frm_Decrypt_Load(object sender, EventArgs e)
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

                string DecryptedMessage = SymmetricEncryption.Decrypt(ChipBytes, Txt_Password.Text, Txt_IV.Text);
                Txt_Result.Text = DecryptedMessage;
            }
            catch (Exception ex) { Txt_Result.Text = $"/// ERROR ///{Environment.NewLine}{Environment.NewLine}{ex.Message}"; }
        }

    }
}
