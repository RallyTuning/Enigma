namespace Enigma.Forms
{
    partial class Frm_Hash
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
            Txt_Text = new TextBox();
            Txt_Result = new TextBox();
            Txt_Password = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.MediumPurple;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(834, 30);
            label1.TabIndex = 0;
            label1.Text = "Hash";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Txt_Text
            // 
            Txt_Text.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Txt_Text.Location = new Point(12, 38);
            Txt_Text.Multiline = true;
            Txt_Text.Name = "Txt_Text";
            Txt_Text.PlaceholderText = "Text to hash...";
            Txt_Text.Size = new Size(381, 83);
            Txt_Text.TabIndex = 1;
            Txt_Text.TextChanged += Txt_Text_TextChanged;
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
            Txt_Result.TabIndex = 1;
            Txt_Result.WordWrap = false;
            // 
            // Txt_Password
            // 
            Txt_Password.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Txt_Password.Location = new Point(440, 38);
            Txt_Password.Multiline = true;
            Txt_Password.Name = "Txt_Password";
            Txt_Password.PlaceholderText = "Optional password...";
            Txt_Password.Size = new Size(382, 83);
            Txt_Password.TabIndex = 1;
            Txt_Password.TextChanged += Txt_Password_TextChanged;
            // 
            // Frm_Hash
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 426);
            Controls.Add(Txt_Result);
            Controls.Add(Txt_Password);
            Controls.Add(Txt_Text);
            Controls.Add(label1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_Hash";
            Text = "Hash";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox Txt_Text;
        private TextBox Txt_Result;
        private TextBox Txt_Password;
    }
}