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
                LoadAllForms();
                ParseForm("Frm_Hash", Action.Open);
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void TsBtnS_Click(object sender, EventArgs e)
        {
            try
            {
                ToolStripButton TsBtn = (ToolStripButton)sender;
                ParseForm($"Frm_{TsBtn.Name.Split("_").Last()}", Action.Open);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }


        #region Open forms

        internal enum LoadFormType { Loaded, Exist, None }
        internal enum Action { Open, Close }


        internal void LoadAllForms()
        {
            List<Form> FormList = new() { new Frm_Hash(), new Frm_EncryptS(), new Frm_DecryptS(), new Frm_EncryptA(), new Frm_DecryptA() };

            foreach (Form F in FormList)
            {
                LoadOneForms(F);
            }
        }

        internal LoadFormType LoadOneForms(Form F)
        {
            if (Pnl_Main.Controls.ContainsKey(F.Name))
            {
                ParseForm(F.Name, Action.Open);
                return LoadFormType.Exist;
            }

            F.TopLevel = false;         // First
            Pnl_Main.Controls.Add(F);  // Then
            F.Dock = DockStyle.Fill;  // Finally

            return LoadFormType.Loaded;
        }

        internal void ParseForm(string Name, Action Act)
        {
            Pnl_Main.SuspendLayout();
            foreach (Form F in Pnl_Main.Controls.OfType<Form>())
            {
                if (Act == Action.Close)
                {
                    if (F.Name == Name)
                    {
                        F.Dispose();
                        Pnl_Main.Controls.Remove(F);
                        break;
                    }
                }
                else
                {
                    if (F.Name == Name)
                    { F.Show(); break; }
                    else
                    { F.Hide(); }
                }
            }
            Pnl_Main.ResumeLayout();
        }

        #endregion

    }
}