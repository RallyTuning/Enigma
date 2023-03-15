namespace Enigma
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            Ts_MenuTop = new ToolStrip();
            TsBtn_Hash = new ToolStripButton();
            TsBtn_Encrypt = new ToolStripButton();
            TsBtn_Decrypt = new ToolStripButton();
            Pnl_Main = new Panel();
            Ts_MenuTop.SuspendLayout();
            SuspendLayout();
            // 
            // Ts_MenuTop
            // 
            Ts_MenuTop.AutoSize = false;
            Ts_MenuTop.GripStyle = ToolStripGripStyle.Hidden;
            Ts_MenuTop.Items.AddRange(new ToolStripItem[] { TsBtn_Hash, TsBtn_Encrypt, TsBtn_Decrypt });
            Ts_MenuTop.Location = new Point(0, 0);
            Ts_MenuTop.Name = "Ts_MenuTop";
            Ts_MenuTop.Size = new Size(834, 35);
            Ts_MenuTop.TabIndex = 0;
            Ts_MenuTop.Text = "Top menu";
            // 
            // TsBtn_Hash
            // 
            TsBtn_Hash.Image = (Image)resources.GetObject("TsBtn_Hash.Image");
            TsBtn_Hash.ImageTransparentColor = Color.Magenta;
            TsBtn_Hash.Margin = new Padding(3, 1, 0, 2);
            TsBtn_Hash.Name = "TsBtn_Hash";
            TsBtn_Hash.Size = new Size(54, 32);
            TsBtn_Hash.Text = "&Hash";
            TsBtn_Hash.Click += TsBtn_Hash_Click;
            // 
            // TsBtn_Encrypt
            // 
            TsBtn_Encrypt.Image = (Image)resources.GetObject("TsBtn_Encrypt.Image");
            TsBtn_Encrypt.ImageTransparentColor = Color.Magenta;
            TsBtn_Encrypt.Name = "TsBtn_Encrypt";
            TsBtn_Encrypt.Size = new Size(67, 32);
            TsBtn_Encrypt.Text = "&Encrypt";
            TsBtn_Encrypt.Click += TsBtn_Encrypt_Click;
            // 
            // TsBtn_Decrypt
            // 
            TsBtn_Decrypt.Image = (Image)resources.GetObject("TsBtn_Decrypt.Image");
            TsBtn_Decrypt.ImageTransparentColor = Color.Magenta;
            TsBtn_Decrypt.Name = "TsBtn_Decrypt";
            TsBtn_Decrypt.Size = new Size(68, 32);
            TsBtn_Decrypt.Text = "&Decrypt";
            TsBtn_Decrypt.Click += TsBtn_Decrypt_Click;
            // 
            // Pnl_Main
            // 
            Pnl_Main.Dock = DockStyle.Fill;
            Pnl_Main.Location = new Point(0, 35);
            Pnl_Main.Name = "Pnl_Main";
            Pnl_Main.Size = new Size(834, 426);
            Pnl_Main.TabIndex = 1;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 461);
            Controls.Add(Pnl_Main);
            Controls.Add(Ts_MenuTop);
            DoubleBuffered = true;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Enigma";
            Load += Main_Load;
            Ts_MenuTop.ResumeLayout(false);
            Ts_MenuTop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ToolStrip Ts_MenuTop;
        private ToolStripButton TsBtn_Hash;
        private ToolStripButton TsBtn_Encrypt;
        private ToolStripButton TsBtn_Decrypt;
        private Panel Pnl_Main;
    }
}