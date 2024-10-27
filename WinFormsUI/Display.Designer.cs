namespace WinFormsUI
{
    partial class Display
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
            MenuStrip = new MenuStrip();
            DeriverToolStripMenuItem = new ToolStripMenuItem();
            GeneratorToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            DeriverPanel_PasswordLabel = new Label();
            DeriverPanel_PasswordTextBox = new TextBox();
            DeriverPanel_LengthTrackBar = new TrackBar();
            DeriverPanel_Pbkdf2Label = new Label();
            DeriverPanel_SaltCheckBox = new CheckBox();
            DeriverPanel_KeyLengthTextBox = new TextBox();
            DeriverPanel_KeyLengthLabel = new Label();
            DeriverPanel_EyeballLabel = new Label();
            DeriverPanel_Pbkdf2ClipboardLabel = new Label();
            DeriverPanel_Pbkdf2ValueTextBox = new TextBox();
            DeriverPanel_SaltValueTextBox = new TextBox();
            DeriverPanel_SaltClipboardLabel = new Label();
            DeriverPanel_SaltLabel = new Label();
            MenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DeriverPanel_LengthTrackBar).BeginInit();
            SuspendLayout();
            // 
            // MenuStrip
            // 
            MenuStrip.BackColor = Color.FromArgb(32, 32, 32);
            MenuStrip.Items.AddRange(new ToolStripItem[] { DeriverToolStripMenuItem, GeneratorToolStripMenuItem, toolStripMenuItem1 });
            MenuStrip.Location = new Point(0, 0);
            MenuStrip.Name = "MenuStrip";
            MenuStrip.Padding = new Padding(5, 2, 0, 2);
            MenuStrip.Size = new Size(297, 27);
            MenuStrip.TabIndex = 0;
            MenuStrip.Text = "menuStrip1";
            // 
            // DeriverToolStripMenuItem
            // 
            DeriverToolStripMenuItem.Font = new Font("Segoe UI Emoji", 10F);
            DeriverToolStripMenuItem.ForeColor = SystemColors.ButtonFace;
            DeriverToolStripMenuItem.Name = "DeriverToolStripMenuItem";
            DeriverToolStripMenuItem.Size = new Size(65, 23);
            DeriverToolStripMenuItem.Text = "Deriver";
            // 
            // GeneratorToolStripMenuItem
            // 
            GeneratorToolStripMenuItem.Font = new Font("Segoe UI Emoji", 10F);
            GeneratorToolStripMenuItem.ForeColor = SystemColors.ButtonFace;
            GeneratorToolStripMenuItem.Name = "GeneratorToolStripMenuItem";
            GeneratorToolStripMenuItem.Size = new Size(83, 23);
            GeneratorToolStripMenuItem.Text = "Generator";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Alignment = ToolStripItemAlignment.Right;
            toolStripMenuItem1.Font = new Font("Segoe UI Emoji", 10F);
            toolStripMenuItem1.ForeColor = SystemColors.ButtonFace;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(34, 23);
            toolStripMenuItem1.Text = "❔";
            // 
            // DeriverPanel_PasswordLabel
            // 
            DeriverPanel_PasswordLabel.AutoSize = true;
            DeriverPanel_PasswordLabel.ForeColor = SystemColors.ButtonFace;
            DeriverPanel_PasswordLabel.Location = new Point(16, 48);
            DeriverPanel_PasswordLabel.Name = "DeriverPanel_PasswordLabel";
            DeriverPanel_PasswordLabel.Size = new Size(67, 19);
            DeriverPanel_PasswordLabel.TabIndex = 1;
            DeriverPanel_PasswordLabel.Text = "Password";
            // 
            // DeriverPanel_PasswordTextBox
            // 
            DeriverPanel_PasswordTextBox.BackColor = Color.FromArgb(32, 32, 32);
            DeriverPanel_PasswordTextBox.BorderStyle = BorderStyle.FixedSingle;
            DeriverPanel_PasswordTextBox.ForeColor = SystemColors.ButtonFace;
            DeriverPanel_PasswordTextBox.Location = new Point(20, 70);
            DeriverPanel_PasswordTextBox.Name = "DeriverPanel_PasswordTextBox";
            DeriverPanel_PasswordTextBox.Size = new Size(263, 25);
            DeriverPanel_PasswordTextBox.TabIndex = 2;
            DeriverPanel_PasswordTextBox.UseSystemPasswordChar = true;
            DeriverPanel_PasswordTextBox.TextChanged += DeriverPanel_PasswordTextBox_TextChanged;
            // 
            // DeriverPanel_LengthTrackBar
            // 
            DeriverPanel_LengthTrackBar.Location = new Point(12, 172);
            DeriverPanel_LengthTrackBar.Maximum = 512;
            DeriverPanel_LengthTrackBar.Minimum = 1;
            DeriverPanel_LengthTrackBar.Name = "DeriverPanel_LengthTrackBar";
            DeriverPanel_LengthTrackBar.Size = new Size(273, 45);
            DeriverPanel_LengthTrackBar.TabIndex = 3;
            DeriverPanel_LengthTrackBar.TickFrequency = 32;
            DeriverPanel_LengthTrackBar.TickStyle = TickStyle.None;
            DeriverPanel_LengthTrackBar.Value = 256;
            DeriverPanel_LengthTrackBar.Scroll += DeriverPanel_LengthTrackBar_Scroll;
            // 
            // DeriverPanel_Pbkdf2Label
            // 
            DeriverPanel_Pbkdf2Label.AutoSize = true;
            DeriverPanel_Pbkdf2Label.ForeColor = SystemColors.ButtonFace;
            DeriverPanel_Pbkdf2Label.Location = new Point(46, 306);
            DeriverPanel_Pbkdf2Label.Name = "DeriverPanel_Pbkdf2Label";
            DeriverPanel_Pbkdf2Label.Size = new Size(61, 19);
            DeriverPanel_Pbkdf2Label.TabIndex = 4;
            DeriverPanel_Pbkdf2Label.Text = "PBKDF2:";
            // 
            // DeriverPanel_SaltCheckBox
            // 
            DeriverPanel_SaltCheckBox.AutoSize = true;
            DeriverPanel_SaltCheckBox.ForeColor = SystemColors.ButtonFace;
            DeriverPanel_SaltCheckBox.Location = new Point(233, 223);
            DeriverPanel_SaltCheckBox.Name = "DeriverPanel_SaltCheckBox";
            DeriverPanel_SaltCheckBox.Size = new Size(50, 23);
            DeriverPanel_SaltCheckBox.TabIndex = 5;
            DeriverPanel_SaltCheckBox.Text = "Salt";
            DeriverPanel_SaltCheckBox.UseVisualStyleBackColor = true;
            DeriverPanel_SaltCheckBox.CheckedChanged += DeriverPanel_SaltCheckBox_CheckedChanged;
            // 
            // DeriverPanel_KeyLengthTextBox
            // 
            DeriverPanel_KeyLengthTextBox.BackColor = Color.FromArgb(32, 32, 32);
            DeriverPanel_KeyLengthTextBox.BorderStyle = BorderStyle.FixedSingle;
            DeriverPanel_KeyLengthTextBox.ForeColor = SystemColors.ButtonFace;
            DeriverPanel_KeyLengthTextBox.Location = new Point(243, 143);
            DeriverPanel_KeyLengthTextBox.Name = "DeriverPanel_KeyLengthTextBox";
            DeriverPanel_KeyLengthTextBox.Size = new Size(40, 25);
            DeriverPanel_KeyLengthTextBox.TabIndex = 7;
            DeriverPanel_KeyLengthTextBox.Text = "256";
            DeriverPanel_KeyLengthTextBox.TextAlign = HorizontalAlignment.Right;
            DeriverPanel_KeyLengthTextBox.TextChanged += DeriverPanel_KeyLengthTextBox_TextChanged;
            // 
            // DeriverPanel_KeyLengthLabel
            // 
            DeriverPanel_KeyLengthLabel.AutoSize = true;
            DeriverPanel_KeyLengthLabel.ForeColor = SystemColors.ButtonFace;
            DeriverPanel_KeyLengthLabel.Location = new Point(16, 146);
            DeriverPanel_KeyLengthLabel.Name = "DeriverPanel_KeyLengthLabel";
            DeriverPanel_KeyLengthLabel.Size = new Size(138, 19);
            DeriverPanel_KeyLengthLabel.TabIndex = 6;
            DeriverPanel_KeyLengthLabel.Text = "Key Length (in bytes)";
            // 
            // DeriverPanel_EyeballLabel
            // 
            DeriverPanel_EyeballLabel.AutoSize = true;
            DeriverPanel_EyeballLabel.ForeColor = SystemColors.ButtonFace;
            DeriverPanel_EyeballLabel.Location = new Point(253, 72);
            DeriverPanel_EyeballLabel.Name = "DeriverPanel_EyeballLabel";
            DeriverPanel_EyeballLabel.Size = new Size(28, 19);
            DeriverPanel_EyeballLabel.TabIndex = 8;
            DeriverPanel_EyeballLabel.Text = "👁";
            DeriverPanel_EyeballLabel.Click += DeriverPanel_EyeballLabel_Click;
            // 
            // DeriverPanel_Pbkdf2ClipboardLabel
            // 
            DeriverPanel_Pbkdf2ClipboardLabel.AutoSize = true;
            DeriverPanel_Pbkdf2ClipboardLabel.ForeColor = SystemColors.ButtonFace;
            DeriverPanel_Pbkdf2ClipboardLabel.Location = new Point(20, 306);
            DeriverPanel_Pbkdf2ClipboardLabel.Name = "DeriverPanel_Pbkdf2ClipboardLabel";
            DeriverPanel_Pbkdf2ClipboardLabel.Size = new Size(25, 19);
            DeriverPanel_Pbkdf2ClipboardLabel.TabIndex = 9;
            DeriverPanel_Pbkdf2ClipboardLabel.Text = "📋";
            DeriverPanel_Pbkdf2ClipboardLabel.Click += DeriverPanel_Pbkdf2ClipboardLabel_Click;
            DeriverPanel_Pbkdf2ClipboardLabel.MouseEnter += Label_MouseEnter;
            DeriverPanel_Pbkdf2ClipboardLabel.MouseLeave += Label_MouseLeave;
            // 
            // DeriverPanel_Pbkdf2ValueTextBox
            // 
            DeriverPanel_Pbkdf2ValueTextBox.BackColor = Color.FromArgb(32, 32, 32);
            DeriverPanel_Pbkdf2ValueTextBox.BorderStyle = BorderStyle.FixedSingle;
            DeriverPanel_Pbkdf2ValueTextBox.ForeColor = SystemColors.ButtonFace;
            DeriverPanel_Pbkdf2ValueTextBox.Location = new Point(116, 303);
            DeriverPanel_Pbkdf2ValueTextBox.Multiline = true;
            DeriverPanel_Pbkdf2ValueTextBox.Name = "DeriverPanel_Pbkdf2ValueTextBox";
            DeriverPanel_Pbkdf2ValueTextBox.ScrollBars = ScrollBars.Horizontal;
            DeriverPanel_Pbkdf2ValueTextBox.Size = new Size(165, 41);
            DeriverPanel_Pbkdf2ValueTextBox.TabIndex = 10;
            DeriverPanel_Pbkdf2ValueTextBox.WordWrap = false;
            // 
            // DeriverPanel_SaltValueTextBox
            // 
            DeriverPanel_SaltValueTextBox.BackColor = Color.FromArgb(32, 32, 32);
            DeriverPanel_SaltValueTextBox.BorderStyle = BorderStyle.FixedSingle;
            DeriverPanel_SaltValueTextBox.ForeColor = SystemColors.ButtonFace;
            DeriverPanel_SaltValueTextBox.Location = new Point(116, 355);
            DeriverPanel_SaltValueTextBox.Multiline = true;
            DeriverPanel_SaltValueTextBox.Name = "DeriverPanel_SaltValueTextBox";
            DeriverPanel_SaltValueTextBox.ScrollBars = ScrollBars.Horizontal;
            DeriverPanel_SaltValueTextBox.Size = new Size(165, 41);
            DeriverPanel_SaltValueTextBox.TabIndex = 13;
            DeriverPanel_SaltValueTextBox.Visible = false;
            DeriverPanel_SaltValueTextBox.WordWrap = false;
            // 
            // DeriverPanel_SaltClipboardLabel
            // 
            DeriverPanel_SaltClipboardLabel.AutoSize = true;
            DeriverPanel_SaltClipboardLabel.ForeColor = SystemColors.ButtonFace;
            DeriverPanel_SaltClipboardLabel.Location = new Point(20, 358);
            DeriverPanel_SaltClipboardLabel.Name = "DeriverPanel_SaltClipboardLabel";
            DeriverPanel_SaltClipboardLabel.Size = new Size(25, 19);
            DeriverPanel_SaltClipboardLabel.TabIndex = 12;
            DeriverPanel_SaltClipboardLabel.Text = "📋";
            DeriverPanel_SaltClipboardLabel.Visible = false;
            DeriverPanel_SaltClipboardLabel.Click += DeriverPanel_SaltClipboardLabel_Click;
            DeriverPanel_SaltClipboardLabel.MouseEnter += Label_MouseEnter;
            DeriverPanel_SaltClipboardLabel.MouseLeave += Label_MouseLeave;
            // 
            // DeriverPanel_SaltLabel
            // 
            DeriverPanel_SaltLabel.AutoSize = true;
            DeriverPanel_SaltLabel.ForeColor = SystemColors.ButtonFace;
            DeriverPanel_SaltLabel.Location = new Point(46, 358);
            DeriverPanel_SaltLabel.Name = "DeriverPanel_SaltLabel";
            DeriverPanel_SaltLabel.Size = new Size(34, 19);
            DeriverPanel_SaltLabel.TabIndex = 11;
            DeriverPanel_SaltLabel.Text = "Salt:";
            DeriverPanel_SaltLabel.Visible = false;
            // 
            // Display
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(297, 414);
            Controls.Add(DeriverPanel_SaltValueTextBox);
            Controls.Add(DeriverPanel_SaltClipboardLabel);
            Controls.Add(DeriverPanel_SaltLabel);
            Controls.Add(DeriverPanel_Pbkdf2ValueTextBox);
            Controls.Add(DeriverPanel_Pbkdf2ClipboardLabel);
            Controls.Add(DeriverPanel_EyeballLabel);
            Controls.Add(DeriverPanel_KeyLengthTextBox);
            Controls.Add(DeriverPanel_KeyLengthLabel);
            Controls.Add(DeriverPanel_SaltCheckBox);
            Controls.Add(DeriverPanel_Pbkdf2Label);
            Controls.Add(DeriverPanel_LengthTrackBar);
            Controls.Add(DeriverPanel_PasswordTextBox);
            Controls.Add(DeriverPanel_PasswordLabel);
            Controls.Add(MenuStrip);
            Font = new Font("Segoe UI Emoji", 10F);
            MainMenuStrip = MenuStrip;
            Name = "Display";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Passkey";
            MenuStrip.ResumeLayout(false);
            MenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DeriverPanel_LengthTrackBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MenuStrip;
        private ToolStripMenuItem DeriverToolStripMenuItem;
        private ToolStripMenuItem GeneratorToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private Label DeriverPanel_PasswordLabel;
        private TextBox DeriverPanel_PasswordTextBox;
        private TrackBar DeriverPanel_LengthTrackBar;
        private Label DeriverPanel_Pbkdf2Label;
        private CheckBox DeriverPanel_SaltCheckBox;
        private TextBox DeriverPanel_KeyLengthTextBox;
        private Label DeriverPanel_KeyLengthLabel;
        private Label DeriverPanel_EyeballLabel;
        private Label DeriverPanel_Pbkdf2ClipboardLabel;
        private TextBox DeriverPanel_Pbkdf2ValueTextBox;
        private TextBox DeriverPanel_SaltValueTextBox;
        private Label DeriverPanel_SaltClipboardLabel;
        private Label DeriverPanel_SaltLabel;
    }
}
