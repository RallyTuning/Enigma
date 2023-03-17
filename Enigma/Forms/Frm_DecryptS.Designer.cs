namespace Enigma
{
    partial class Frm_DecryptS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            Txt_Result = new TextBox();
            Txt_Password = new TextBox();
            Txt_Text = new TextBox();
            Txt_IV = new TextBox();
            label2 = new Label();
            Cmb_Type = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Coral;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(834, 30);
            label1.TabIndex = 1;
            label1.Text = "Decrypt  (Symmetric)";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Txt_Result
            // 
            Txt_Result.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Txt_Result.BackColor = SystemColors.Window;
            Txt_Result.Font = new Font("Courier New", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Txt_Result.Location = new Point(12, 163);
            Txt_Result.Multiline = true;
            Txt_Result.Name = "Txt_Result";
            Txt_Result.ReadOnly = true;
            Txt_Result.ScrollBars = ScrollBars.Both;
            Txt_Result.Size = new Size(810, 251);
            Txt_Result.TabIndex = 4;
            // 
            // Txt_Password
            // 
            Txt_Password.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Txt_Password.Location = new Point(440, 38);
            Txt_Password.MaxLength = 32;
            Txt_Password.Name = "Txt_Password";
            Txt_Password.PlaceholderText = "Optional salt (password)...";
            Txt_Password.Size = new Size(382, 23);
            Txt_Password.TabIndex = 1;
            Txt_Password.TextChanged += Txt_Password_TextChanged;
            // 
            // Txt_Text
            // 
            Txt_Text.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Txt_Text.Location = new Point(12, 38);
            Txt_Text.Multiline = true;
            Txt_Text.Name = "Txt_Text";
            Txt_Text.PlaceholderText = "Text to decrypt...";
            Txt_Text.Size = new Size(381, 104);
            Txt_Text.TabIndex = 0;
            Txt_Text.TextChanged += Txt_Text_TextChanged;
            // 
            // Txt_IV
            // 
            Txt_IV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Txt_IV.Location = new Point(440, 67);
            Txt_IV.MaxLength = 16;
            Txt_IV.Name = "Txt_IV";
            Txt_IV.PlaceholderText = "Optional IV (Initialization Vector)...";
            Txt_IV.Size = new Size(382, 23);
            Txt_IV.TabIndex = 2;
            Txt_IV.TextChanged += Txt_IV_TextChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(440, 99);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 8;
            label2.Text = "Input type:";
            // 
            // Cmb_Type
            // 
            Cmb_Type.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Cmb_Type.DropDownStyle = ComboBoxStyle.DropDownList;
            Cmb_Type.FormattingEnabled = true;
            Cmb_Type.Items.AddRange(new object[] { "HEX", "Base64" });
            Cmb_Type.Location = new Point(520, 96);
            Cmb_Type.Name = "Cmb_Type";
            Cmb_Type.Size = new Size(144, 23);
            Cmb_Type.TabIndex = 3;
            Cmb_Type.SelectedIndexChanged += Cmb_Type_SelectedIndexChanged;
            // 
            // Frm_Decrypt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 426);
            Controls.Add(Cmb_Type);
            Controls.Add(label2);
            Controls.Add(Txt_IV);
            Controls.Add(Txt_Result);
            Controls.Add(Txt_Password);
            Controls.Add(Txt_Text);
            Controls.Add(label1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_DecryptS";
            Text = "Decrypt Symmetric";
            Load += Frm_Decrypt_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox Txt_Result;
        private TextBox Txt_Password;
        private TextBox Txt_Text;
        private TextBox Txt_IV;
        private Label label2;
        private ComboBox Cmb_Type;
    }
}