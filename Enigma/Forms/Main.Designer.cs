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
            toolStripSeparator1 = new ToolStripSeparator();
            TsBtn_EncryptS = new ToolStripButton();
            TsBtn_DecryptS = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            TsBtn_EncryptA = new ToolStripButton();
            TsBtn_DecryptA = new ToolStripButton();
            Pnl_Main = new Panel();
            Ts_MenuTop.SuspendLayout();
            SuspendLayout();
            // 
            // Ts_MenuTop
            // 
            Ts_MenuTop.AutoSize = false;
            Ts_MenuTop.GripStyle = ToolStripGripStyle.Hidden;
            Ts_MenuTop.Items.AddRange(new ToolStripItem[] { TsBtn_Hash, toolStripSeparator1, TsBtn_EncryptS, TsBtn_DecryptS, toolStripSeparator2, TsBtn_EncryptA, TsBtn_DecryptA });
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
            TsBtn_Hash.Click += TsBtnS_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 35);
            // 
            // TsBtn_EncryptS
            // 
            TsBtn_EncryptS.Image = (Image)resources.GetObject("TsBtn_EncryptS.Image");
            TsBtn_EncryptS.ImageTransparentColor = Color.Magenta;
            TsBtn_EncryptS.Name = "TsBtn_EncryptS";
            TsBtn_EncryptS.Size = new Size(135, 32);
            TsBtn_EncryptS.Text = "&Encrypt (Symmetric)";
            TsBtn_EncryptS.Click += TsBtnS_Click;
            // 
            // TsBtn_DecryptS
            // 
            TsBtn_DecryptS.Image = (Image)resources.GetObject("TsBtn_DecryptS.Image");
            TsBtn_DecryptS.ImageTransparentColor = Color.Magenta;
            TsBtn_DecryptS.Name = "TsBtn_DecryptS";
            TsBtn_DecryptS.Size = new Size(136, 32);
            TsBtn_DecryptS.Text = "&Decrypt (Symmetric)";
            TsBtn_DecryptS.Click += TsBtnS_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 35);
            // 
            // TsBtn_EncryptA
            // 
            TsBtn_EncryptA.Image = (Image)resources.GetObject("TsBtn_EncryptA.Image");
            TsBtn_EncryptA.ImageTransparentColor = Color.Magenta;
            TsBtn_EncryptA.Name = "TsBtn_EncryptA";
            TsBtn_EncryptA.Size = new Size(142, 32);
            TsBtn_EncryptA.Text = "E&ncrypt (Asymmetric)";
            TsBtn_EncryptA.Click += TsBtnS_Click;
            // 
            // TsBtn_DecryptA
            // 
            TsBtn_DecryptA.Image = (Image)resources.GetObject("TsBtn_DecryptA.Image");
            TsBtn_DecryptA.ImageTransparentColor = Color.Magenta;
            TsBtn_DecryptA.Name = "TsBtn_DecryptA";
            TsBtn_DecryptA.Size = new Size(143, 32);
            TsBtn_DecryptA.Text = "De&crypt (Asymmetric)";
            TsBtn_DecryptA.Click += TsBtnS_Click;
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
            MinimumSize = new Size(850, 500);
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
        private ToolStripButton TsBtn_EncryptS;
        private ToolStripButton TsBtn_DecryptS;
        private Panel Pnl_Main;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton TsBtn_EncryptA;
        private ToolStripButton TsBtn_DecryptA;
    }
}