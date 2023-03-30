namespace Enigma
{
    partial class Frm_EncryptA
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
            Cmb_Type = new ComboBox();
            label2 = new Label();
            Txt_Result = new TextBox();
            Txt_Text = new TextBox();
            Btn_ImportPrivateKey = new Button();
            Nud_KeyBit = new NumericUpDown();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)Nud_KeyBit).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.DarkTurquoise;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(834, 30);
            label1.TabIndex = 2;
            label1.Text = "Encrypt  (Asymmetric)";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Cmb_Type
            // 
            Cmb_Type.DropDownStyle = ComboBoxStyle.DropDownList;
            Cmb_Type.FormattingEnabled = true;
            Cmb_Type.Items.AddRange(new object[] { "HEX", "Base64", "Binary", "String" });
            Cmb_Type.Location = new Point(92, 38);
            Cmb_Type.Name = "Cmb_Type";
            Cmb_Type.Size = new Size(144, 23);
            Cmb_Type.TabIndex = 14;
            Cmb_Type.SelectedIndexChanged += Cmb_Type_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 46);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 16;
            label2.Text = "Output type:";
            // 
            // Txt_Result
            // 
            Txt_Result.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Txt_Result.BackColor = SystemColors.Window;
            Txt_Result.Font = new Font("Courier New", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Txt_Result.Location = new Point(12, 196);
            Txt_Result.Multiline = true;
            Txt_Result.Name = "Txt_Result";
            Txt_Result.ReadOnly = true;
            Txt_Result.ScrollBars = ScrollBars.Both;
            Txt_Result.Size = new Size(810, 218);
            Txt_Result.TabIndex = 15;
            // 
            // Txt_Text
            // 
            Txt_Text.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Txt_Text.Location = new Point(12, 67);
            Txt_Text.Multiline = true;
            Txt_Text.Name = "Txt_Text";
            Txt_Text.PlaceholderText = "Text to encrypt...";
            Txt_Text.Size = new Size(810, 110);
            Txt_Text.TabIndex = 11;
            Txt_Text.TextChanged += Txt_Text_TextChanged;
            // 
            // Btn_ImportPrivateKey
            // 
            Btn_ImportPrivateKey.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Btn_ImportPrivateKey.ForeColor = Color.ForestGreen;
            Btn_ImportPrivateKey.Location = new Point(242, 38);
            Btn_ImportPrivateKey.Name = "Btn_ImportPrivateKey";
            Btn_ImportPrivateKey.Size = new Size(124, 23);
            Btn_ImportPrivateKey.TabIndex = 17;
            Btn_ImportPrivateKey.Text = "Import public key";
            Btn_ImportPrivateKey.UseVisualStyleBackColor = true;
            Btn_ImportPrivateKey.Click += Btn_ImportPublicKey_Click;
            // 
            // Nud_KeyBit
            // 
            Nud_KeyBit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Nud_KeyBit.Location = new Point(765, 38);
            Nud_KeyBit.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            Nud_KeyBit.Name = "Nud_KeyBit";
            Nud_KeyBit.Size = new Size(57, 23);
            Nud_KeyBit.TabIndex = 29;
            Nud_KeyBit.Value = new decimal(new int[] { 2048, 0, 0, 0 });
            Nud_KeyBit.ValueChanged += Nud_KeyBit_ValueChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(713, 42);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 28;
            label3.Text = "Key bit:";
            // 
            // Frm_EncryptA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 426);
            Controls.Add(Nud_KeyBit);
            Controls.Add(label3);
            Controls.Add(Btn_ImportPrivateKey);
            Controls.Add(Cmb_Type);
            Controls.Add(label2);
            Controls.Add(Txt_Result);
            Controls.Add(Txt_Text);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_EncryptA";
            Text = "Encrypt Asymmetric";
            Load += Frm_EncryptA_Load;
            ((System.ComponentModel.ISupportInitialize)Nud_KeyBit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox Cmb_Type;
        private Label label2;
        private TextBox Txt_Result;
        private TextBox Txt_Text;
        private Button Btn_ImportPrivateKey;
        private NumericUpDown Nud_KeyBit;
        private Label label3;
    }
}