﻿namespace Enigma
{
    partial class Frm_DecryptA
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
            Btn_ShowKeys = new Button();
            Btn_GenerateKeys = new Button();
            Cmb_Type = new ComboBox();
            label2 = new Label();
            Txt_Result = new TextBox();
            Txt_Text = new TextBox();
            Btn_ExportPublic = new Button();
            Btn_ExportPrivate = new Button();
            label3 = new Label();
            Nud_KeyBit = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)Nud_KeyBit).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Orchid;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(834, 30);
            label1.TabIndex = 2;
            label1.Text = "Decrypt  (Asymmetric)";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Btn_ShowKeys
            // 
            Btn_ShowKeys.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Btn_ShowKeys.Location = new Point(632, 38);
            Btn_ShowKeys.Name = "Btn_ShowKeys";
            Btn_ShowKeys.Size = new Size(75, 23);
            Btn_ShowKeys.TabIndex = 24;
            Btn_ShowKeys.Text = "Show keys";
            Btn_ShowKeys.UseVisualStyleBackColor = true;
            Btn_ShowKeys.Click += Btn_ShowKeys_Click;
            // 
            // Btn_GenerateKeys
            // 
            Btn_GenerateKeys.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Btn_GenerateKeys.Location = new Point(502, 38);
            Btn_GenerateKeys.Name = "Btn_GenerateKeys";
            Btn_GenerateKeys.Size = new Size(124, 23);
            Btn_GenerateKeys.TabIndex = 23;
            Btn_GenerateKeys.Text = "Generate new keys";
            Btn_GenerateKeys.UseVisualStyleBackColor = true;
            Btn_GenerateKeys.Click += Btn_GenerateKeys_Click;
            // 
            // Cmb_Type
            // 
            Cmb_Type.DropDownStyle = ComboBoxStyle.DropDownList;
            Cmb_Type.FormattingEnabled = true;
            Cmb_Type.Items.AddRange(new object[] { "HEX", "Base64" });
            Cmb_Type.Location = new Point(92, 38);
            Cmb_Type.Name = "Cmb_Type";
            Cmb_Type.Size = new Size(144, 23);
            Cmb_Type.TabIndex = 20;
            Cmb_Type.SelectedIndexChanged += Cmb_Type_SelectedIndexChanged_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 46);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 22;
            label2.Text = "Intput type:";
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
            Txt_Result.TabIndex = 21;
            // 
            // Txt_Text
            // 
            Txt_Text.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Txt_Text.Location = new Point(12, 67);
            Txt_Text.Multiline = true;
            Txt_Text.Name = "Txt_Text";
            Txt_Text.PlaceholderText = "Text to encrypt...";
            Txt_Text.Size = new Size(810, 110);
            Txt_Text.TabIndex = 19;
            Txt_Text.TextChanged += Txt_Text_TextChanged_1;
            // 
            // Btn_ExportPublic
            // 
            Btn_ExportPublic.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Btn_ExportPublic.ForeColor = Color.ForestGreen;
            Btn_ExportPublic.Location = new Point(242, 38);
            Btn_ExportPublic.Name = "Btn_ExportPublic";
            Btn_ExportPublic.Size = new Size(124, 23);
            Btn_ExportPublic.TabIndex = 25;
            Btn_ExportPublic.Text = "Export public key";
            Btn_ExportPublic.UseVisualStyleBackColor = true;
            Btn_ExportPublic.Click += Btn_ExportPublic_Click;
            // 
            // Btn_ExportPrivate
            // 
            Btn_ExportPrivate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Btn_ExportPrivate.ForeColor = Color.IndianRed;
            Btn_ExportPrivate.Location = new Point(372, 38);
            Btn_ExportPrivate.Name = "Btn_ExportPrivate";
            Btn_ExportPrivate.Size = new Size(124, 23);
            Btn_ExportPrivate.TabIndex = 26;
            Btn_ExportPrivate.Text = "Export private key";
            Btn_ExportPrivate.UseVisualStyleBackColor = true;
            Btn_ExportPrivate.Click += Btn_ExportPrivate_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(713, 42);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 22;
            label3.Text = "Key bit:";
            // 
            // Nud_KeyBit
            // 
            Nud_KeyBit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Nud_KeyBit.Location = new Point(765, 38);
            Nud_KeyBit.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            Nud_KeyBit.Name = "Nud_KeyBit";
            Nud_KeyBit.Size = new Size(57, 23);
            Nud_KeyBit.TabIndex = 27;
            Nud_KeyBit.Value = new decimal(new int[] { 2048, 0, 0, 0 });
            Nud_KeyBit.ValueChanged += Nud_KeyBit_ValueChanged;
            // 
            // Frm_DecryptA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 426);
            Controls.Add(Nud_KeyBit);
            Controls.Add(Btn_ExportPrivate);
            Controls.Add(Btn_ExportPublic);
            Controls.Add(Btn_ShowKeys);
            Controls.Add(Btn_GenerateKeys);
            Controls.Add(Cmb_Type);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Txt_Result);
            Controls.Add(Txt_Text);
            Controls.Add(label1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_DecryptA";
            Text = "Decrypt Asymmetric";
            Load += Frm_DecryptA_Load;
            ((System.ComponentModel.ISupportInitialize)Nud_KeyBit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button Btn_ShowKeys;
        private Button Btn_GenerateKeys;
        private ComboBox Cmb_Type;
        private Label label2;
        private TextBox Txt_Result;
        private TextBox Txt_Text;
        private Button Btn_ExportPublic;
        private Button Btn_ExportPrivate;
        private Label label3;
        private NumericUpDown Nud_KeyBit;
    }
}