﻿namespace WinFormsUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Display));
            MenuStrip = new MenuStrip();
            DeriverToolStripMenuItem = new ToolStripMenuItem();
            GeneratorToolStripMenuItem = new ToolStripMenuItem();
            QuestionMarkToolStripMenuItem = new ToolStripMenuItem();
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
            DeriverPanel = new Panel();
            DeriverPanel_IterationsLabel = new Label();
            DeriverPanel_IterationsNumericUpDown = new NumericUpDown();
            DeriverPanel_AlgorithmComboBox = new ComboBox();
            DeriverPanel_RefreshLabel = new Label();
            GeneratorPanel = new Panel();
            GeneratePanel_AsymmetricRadioButton = new RadioButton();
            GeneratePanel_SymmetricRadioButton = new RadioButton();
            AsymmetricPanel = new Panel();
            AsymmetricPanel_DownloadButton = new Button();
            AsymmetricPanel_EcdsaRadioButton = new RadioButton();
            AsymmetricPanel_RsaRadioButton = new RadioButton();
            SymmetricPanel = new Panel();
            SymmetricPanel_RefreshLabel = new Label();
            SymmetricPanel_KeyValueTextBox = new TextBox();
            SymmetricPanel_KeyClipboardLabel = new Label();
            SymmetricPanel_KeyLabel = new Label();
            SymmetricPanel_KeyLengthLabel = new Label();
            SymmetricPanel_KeyLengthTextBox = new TextBox();
            SymmetricPanel_LengthTrackBar = new TrackBar();
            MenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DeriverPanel_LengthTrackBar).BeginInit();
            DeriverPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DeriverPanel_IterationsNumericUpDown).BeginInit();
            GeneratorPanel.SuspendLayout();
            AsymmetricPanel.SuspendLayout();
            SymmetricPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SymmetricPanel_LengthTrackBar).BeginInit();
            SuspendLayout();
            // 
            // MenuStrip
            // 
            MenuStrip.BackColor = Color.FromArgb(32, 32, 32);
            MenuStrip.Items.AddRange(new ToolStripItem[] { DeriverToolStripMenuItem, GeneratorToolStripMenuItem, QuestionMarkToolStripMenuItem });
            MenuStrip.Location = new Point(0, 0);
            MenuStrip.Name = "MenuStrip";
            MenuStrip.Padding = new Padding(5, 2, 0, 2);
            MenuStrip.Size = new Size(298, 27);
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
            DeriverToolStripMenuItem.Click += DeriverToolStripMenuItem_Click;
            // 
            // GeneratorToolStripMenuItem
            // 
            GeneratorToolStripMenuItem.Font = new Font("Segoe UI Emoji", 10F);
            GeneratorToolStripMenuItem.ForeColor = SystemColors.ButtonFace;
            GeneratorToolStripMenuItem.Name = "GeneratorToolStripMenuItem";
            GeneratorToolStripMenuItem.Size = new Size(83, 23);
            GeneratorToolStripMenuItem.Text = "Generator";
            GeneratorToolStripMenuItem.Click += GeneratorToolStripMenuItem_Click;
            // 
            // QuestionMarkToolStripMenuItem
            // 
            QuestionMarkToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            QuestionMarkToolStripMenuItem.Font = new Font("Segoe UI Emoji", 10F);
            QuestionMarkToolStripMenuItem.ForeColor = SystemColors.ButtonFace;
            QuestionMarkToolStripMenuItem.Name = "QuestionMarkToolStripMenuItem";
            QuestionMarkToolStripMenuItem.Size = new Size(34, 23);
            QuestionMarkToolStripMenuItem.Text = "❔";
            QuestionMarkToolStripMenuItem.Click += QuestionMarkToolStripMenuItem_Click;
            // 
            // DeriverPanel_PasswordLabel
            // 
            DeriverPanel_PasswordLabel.AutoSize = true;
            DeriverPanel_PasswordLabel.ForeColor = SystemColors.ButtonFace;
            DeriverPanel_PasswordLabel.Location = new Point(15, 12);
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
            DeriverPanel_PasswordTextBox.Location = new Point(19, 34);
            DeriverPanel_PasswordTextBox.Name = "DeriverPanel_PasswordTextBox";
            DeriverPanel_PasswordTextBox.Size = new Size(263, 25);
            DeriverPanel_PasswordTextBox.TabIndex = 2;
            DeriverPanel_PasswordTextBox.UseSystemPasswordChar = true;
            DeriverPanel_PasswordTextBox.TextChanged += DeriverPanel_PasswordTextBox_TextChanged;
            // 
            // DeriverPanel_LengthTrackBar
            // 
            DeriverPanel_LengthTrackBar.Location = new Point(11, 136);
            DeriverPanel_LengthTrackBar.Maximum = 512;
            DeriverPanel_LengthTrackBar.Minimum = 1;
            DeriverPanel_LengthTrackBar.Name = "DeriverPanel_LengthTrackBar";
            DeriverPanel_LengthTrackBar.Size = new Size(273, 45);
            DeriverPanel_LengthTrackBar.TabIndex = 3;
            DeriverPanel_LengthTrackBar.TickFrequency = 32;
            DeriverPanel_LengthTrackBar.TickStyle = TickStyle.None;
            DeriverPanel_LengthTrackBar.Value = 32;
            DeriverPanel_LengthTrackBar.Scroll += DeriverPanel_LengthTrackBar_Scroll;
            // 
            // DeriverPanel_Pbkdf2Label
            // 
            DeriverPanel_Pbkdf2Label.AutoSize = true;
            DeriverPanel_Pbkdf2Label.ForeColor = SystemColors.ButtonFace;
            DeriverPanel_Pbkdf2Label.Location = new Point(45, 270);
            DeriverPanel_Pbkdf2Label.Name = "DeriverPanel_Pbkdf2Label";
            DeriverPanel_Pbkdf2Label.Size = new Size(61, 19);
            DeriverPanel_Pbkdf2Label.TabIndex = 4;
            DeriverPanel_Pbkdf2Label.Text = "PBKDF2:";
            // 
            // DeriverPanel_SaltCheckBox
            // 
            DeriverPanel_SaltCheckBox.AutoSize = true;
            DeriverPanel_SaltCheckBox.ForeColor = SystemColors.ButtonFace;
            DeriverPanel_SaltCheckBox.Location = new Point(214, 195);
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
            DeriverPanel_KeyLengthTextBox.Location = new Point(242, 107);
            DeriverPanel_KeyLengthTextBox.Name = "DeriverPanel_KeyLengthTextBox";
            DeriverPanel_KeyLengthTextBox.Size = new Size(40, 25);
            DeriverPanel_KeyLengthTextBox.TabIndex = 7;
            DeriverPanel_KeyLengthTextBox.Text = "32";
            DeriverPanel_KeyLengthTextBox.TextAlign = HorizontalAlignment.Right;
            DeriverPanel_KeyLengthTextBox.TextChanged += DeriverPanel_KeyLengthTextBox_TextChanged;
            // 
            // DeriverPanel_KeyLengthLabel
            // 
            DeriverPanel_KeyLengthLabel.AutoSize = true;
            DeriverPanel_KeyLengthLabel.ForeColor = SystemColors.ButtonFace;
            DeriverPanel_KeyLengthLabel.Location = new Point(15, 110);
            DeriverPanel_KeyLengthLabel.Name = "DeriverPanel_KeyLengthLabel";
            DeriverPanel_KeyLengthLabel.Size = new Size(138, 19);
            DeriverPanel_KeyLengthLabel.TabIndex = 6;
            DeriverPanel_KeyLengthLabel.Text = "Key Length (in bytes)";
            // 
            // DeriverPanel_EyeballLabel
            // 
            DeriverPanel_EyeballLabel.AutoSize = true;
            DeriverPanel_EyeballLabel.ForeColor = SystemColors.ButtonFace;
            DeriverPanel_EyeballLabel.Location = new Point(252, 36);
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
            DeriverPanel_Pbkdf2ClipboardLabel.Location = new Point(19, 270);
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
            DeriverPanel_Pbkdf2ValueTextBox.Location = new Point(115, 267);
            DeriverPanel_Pbkdf2ValueTextBox.Multiline = true;
            DeriverPanel_Pbkdf2ValueTextBox.Name = "DeriverPanel_Pbkdf2ValueTextBox";
            DeriverPanel_Pbkdf2ValueTextBox.ReadOnly = true;
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
            DeriverPanel_SaltValueTextBox.Location = new Point(115, 319);
            DeriverPanel_SaltValueTextBox.Multiline = true;
            DeriverPanel_SaltValueTextBox.Name = "DeriverPanel_SaltValueTextBox";
            DeriverPanel_SaltValueTextBox.ReadOnly = true;
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
            DeriverPanel_SaltClipboardLabel.Location = new Point(19, 322);
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
            DeriverPanel_SaltLabel.Location = new Point(45, 322);
            DeriverPanel_SaltLabel.Name = "DeriverPanel_SaltLabel";
            DeriverPanel_SaltLabel.Size = new Size(34, 19);
            DeriverPanel_SaltLabel.TabIndex = 11;
            DeriverPanel_SaltLabel.Text = "Salt:";
            DeriverPanel_SaltLabel.Visible = false;
            // 
            // DeriverPanel
            // 
            DeriverPanel.Controls.Add(DeriverPanel_IterationsLabel);
            DeriverPanel.Controls.Add(DeriverPanel_IterationsNumericUpDown);
            DeriverPanel.Controls.Add(DeriverPanel_AlgorithmComboBox);
            DeriverPanel.Controls.Add(DeriverPanel_EyeballLabel);
            DeriverPanel.Controls.Add(DeriverPanel_RefreshLabel);
            DeriverPanel.Controls.Add(DeriverPanel_PasswordLabel);
            DeriverPanel.Controls.Add(DeriverPanel_SaltValueTextBox);
            DeriverPanel.Controls.Add(DeriverPanel_PasswordTextBox);
            DeriverPanel.Controls.Add(DeriverPanel_SaltClipboardLabel);
            DeriverPanel.Controls.Add(DeriverPanel_LengthTrackBar);
            DeriverPanel.Controls.Add(DeriverPanel_SaltLabel);
            DeriverPanel.Controls.Add(DeriverPanel_Pbkdf2Label);
            DeriverPanel.Controls.Add(DeriverPanel_Pbkdf2ValueTextBox);
            DeriverPanel.Controls.Add(DeriverPanel_SaltCheckBox);
            DeriverPanel.Controls.Add(DeriverPanel_Pbkdf2ClipboardLabel);
            DeriverPanel.Controls.Add(DeriverPanel_KeyLengthLabel);
            DeriverPanel.Controls.Add(DeriverPanel_KeyLengthTextBox);
            DeriverPanel.Location = new Point(0, 39);
            DeriverPanel.Name = "DeriverPanel";
            DeriverPanel.Size = new Size(297, 374);
            DeriverPanel.TabIndex = 14;
            // 
            // DeriverPanel_IterationsLabel
            // 
            DeriverPanel_IterationsLabel.AutoSize = true;
            DeriverPanel_IterationsLabel.ForeColor = SystemColors.ButtonFace;
            DeriverPanel_IterationsLabel.Location = new Point(15, 170);
            DeriverPanel_IterationsLabel.Name = "DeriverPanel_IterationsLabel";
            DeriverPanel_IterationsLabel.Size = new Size(67, 19);
            DeriverPanel_IterationsLabel.TabIndex = 24;
            DeriverPanel_IterationsLabel.Text = "Iterations";
            // 
            // DeriverPanel_IterationsNumericUpDown
            // 
            DeriverPanel_IterationsNumericUpDown.BackColor = Color.FromArgb(32, 32, 32);
            DeriverPanel_IterationsNumericUpDown.BorderStyle = BorderStyle.FixedSingle;
            DeriverPanel_IterationsNumericUpDown.ForeColor = SystemColors.ButtonFace;
            DeriverPanel_IterationsNumericUpDown.Location = new Point(19, 193);
            DeriverPanel_IterationsNumericUpDown.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            DeriverPanel_IterationsNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            DeriverPanel_IterationsNumericUpDown.Name = "DeriverPanel_IterationsNumericUpDown";
            DeriverPanel_IterationsNumericUpDown.Size = new Size(108, 25);
            DeriverPanel_IterationsNumericUpDown.TabIndex = 23;
            DeriverPanel_IterationsNumericUpDown.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            DeriverPanel_IterationsNumericUpDown.ValueChanged += DeriverPanel_IterationsNumericUpDown_ValueChanged;
            // 
            // DeriverPanel_AlgorithmComboBox
            // 
            DeriverPanel_AlgorithmComboBox.BackColor = Color.FromArgb(32, 32, 32);
            DeriverPanel_AlgorithmComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            DeriverPanel_AlgorithmComboBox.FlatStyle = FlatStyle.Flat;
            DeriverPanel_AlgorithmComboBox.ForeColor = SystemColors.ButtonFace;
            DeriverPanel_AlgorithmComboBox.FormattingEnabled = true;
            DeriverPanel_AlgorithmComboBox.Location = new Point(18, 227);
            DeriverPanel_AlgorithmComboBox.Name = "DeriverPanel_AlgorithmComboBox";
            DeriverPanel_AlgorithmComboBox.Size = new Size(109, 25);
            DeriverPanel_AlgorithmComboBox.TabIndex = 22;
            DeriverPanel_AlgorithmComboBox.SelectedIndexChanged += DeriverPanel_AlgorithmComboBox_SelectedIndexChanged;
            // 
            // DeriverPanel_RefreshLabel
            // 
            DeriverPanel_RefreshLabel.AutoSize = true;
            DeriverPanel_RefreshLabel.ForeColor = SystemColors.ButtonFace;
            DeriverPanel_RefreshLabel.Location = new Point(264, 196);
            DeriverPanel_RefreshLabel.Name = "DeriverPanel_RefreshLabel";
            DeriverPanel_RefreshLabel.Size = new Size(28, 19);
            DeriverPanel_RefreshLabel.TabIndex = 21;
            DeriverPanel_RefreshLabel.Text = "🔄";
            DeriverPanel_RefreshLabel.Visible = false;
            DeriverPanel_RefreshLabel.Click += DeriverPanel_RefreshLabel_Click;
            DeriverPanel_RefreshLabel.MouseEnter += Label_MouseEnter;
            DeriverPanel_RefreshLabel.MouseLeave += Label_MouseLeave;
            // 
            // GeneratorPanel
            // 
            GeneratorPanel.Controls.Add(GeneratePanel_AsymmetricRadioButton);
            GeneratorPanel.Controls.Add(GeneratePanel_SymmetricRadioButton);
            GeneratorPanel.Controls.Add(AsymmetricPanel);
            GeneratorPanel.Controls.Add(SymmetricPanel);
            GeneratorPanel.Location = new Point(0, 39);
            GeneratorPanel.Name = "GeneratorPanel";
            GeneratorPanel.Size = new Size(297, 374);
            GeneratorPanel.TabIndex = 15;
            // 
            // GeneratePanel_AsymmetricRadioButton
            // 
            GeneratePanel_AsymmetricRadioButton.AutoSize = true;
            GeneratePanel_AsymmetricRadioButton.ForeColor = SystemColors.ButtonFace;
            GeneratePanel_AsymmetricRadioButton.Location = new Point(14, 51);
            GeneratePanel_AsymmetricRadioButton.Name = "GeneratePanel_AsymmetricRadioButton";
            GeneratePanel_AsymmetricRadioButton.Size = new Size(99, 23);
            GeneratePanel_AsymmetricRadioButton.TabIndex = 1;
            GeneratePanel_AsymmetricRadioButton.TabStop = true;
            GeneratePanel_AsymmetricRadioButton.Text = "Asymmetric";
            GeneratePanel_AsymmetricRadioButton.UseVisualStyleBackColor = true;
            GeneratePanel_AsymmetricRadioButton.CheckedChanged += GeneratorPanel_RadioButton_CheckedChanged;
            // 
            // GeneratePanel_SymmetricRadioButton
            // 
            GeneratePanel_SymmetricRadioButton.AutoSize = true;
            GeneratePanel_SymmetricRadioButton.Checked = true;
            GeneratePanel_SymmetricRadioButton.ForeColor = SystemColors.ButtonFace;
            GeneratePanel_SymmetricRadioButton.Location = new Point(14, 22);
            GeneratePanel_SymmetricRadioButton.Name = "GeneratePanel_SymmetricRadioButton";
            GeneratePanel_SymmetricRadioButton.Size = new Size(91, 23);
            GeneratePanel_SymmetricRadioButton.TabIndex = 0;
            GeneratePanel_SymmetricRadioButton.TabStop = true;
            GeneratePanel_SymmetricRadioButton.Text = "Symmetric";
            GeneratePanel_SymmetricRadioButton.UseVisualStyleBackColor = true;
            GeneratePanel_SymmetricRadioButton.CheckedChanged += GeneratorPanel_RadioButton_CheckedChanged;
            // 
            // AsymmetricPanel
            // 
            AsymmetricPanel.Controls.Add(AsymmetricPanel_DownloadButton);
            AsymmetricPanel.Controls.Add(AsymmetricPanel_EcdsaRadioButton);
            AsymmetricPanel.Controls.Add(AsymmetricPanel_RsaRadioButton);
            AsymmetricPanel.Location = new Point(0, 82);
            AsymmetricPanel.Name = "AsymmetricPanel";
            AsymmetricPanel.Size = new Size(297, 292);
            AsymmetricPanel.TabIndex = 20;
            // 
            // AsymmetricPanel_DownloadButton
            // 
            AsymmetricPanel_DownloadButton.BackColor = SystemColors.Highlight;
            AsymmetricPanel_DownloadButton.FlatStyle = FlatStyle.Flat;
            AsymmetricPanel_DownloadButton.ForeColor = SystemColors.ButtonFace;
            AsymmetricPanel_DownloadButton.Location = new Point(178, 33);
            AsymmetricPanel_DownloadButton.Name = "AsymmetricPanel_DownloadButton";
            AsymmetricPanel_DownloadButton.Size = new Size(86, 34);
            AsymmetricPanel_DownloadButton.TabIndex = 24;
            AsymmetricPanel_DownloadButton.Text = "Save";
            AsymmetricPanel_DownloadButton.UseVisualStyleBackColor = false;
            AsymmetricPanel_DownloadButton.Click += AsymmetricPanel_DownloadButton_Click;
            // 
            // AsymmetricPanel_EcdsaRadioButton
            // 
            AsymmetricPanel_EcdsaRadioButton.AutoSize = true;
            AsymmetricPanel_EcdsaRadioButton.ForeColor = SystemColors.ButtonFace;
            AsymmetricPanel_EcdsaRadioButton.Location = new Point(14, 53);
            AsymmetricPanel_EcdsaRadioButton.Name = "AsymmetricPanel_EcdsaRadioButton";
            AsymmetricPanel_EcdsaRadioButton.Size = new Size(69, 23);
            AsymmetricPanel_EcdsaRadioButton.TabIndex = 23;
            AsymmetricPanel_EcdsaRadioButton.TabStop = true;
            AsymmetricPanel_EcdsaRadioButton.Text = "ECDSA";
            AsymmetricPanel_EcdsaRadioButton.UseVisualStyleBackColor = true;
            // 
            // AsymmetricPanel_RsaRadioButton
            // 
            AsymmetricPanel_RsaRadioButton.AutoSize = true;
            AsymmetricPanel_RsaRadioButton.Checked = true;
            AsymmetricPanel_RsaRadioButton.ForeColor = SystemColors.ButtonFace;
            AsymmetricPanel_RsaRadioButton.Location = new Point(14, 24);
            AsymmetricPanel_RsaRadioButton.Name = "AsymmetricPanel_RsaRadioButton";
            AsymmetricPanel_RsaRadioButton.Size = new Size(51, 23);
            AsymmetricPanel_RsaRadioButton.TabIndex = 22;
            AsymmetricPanel_RsaRadioButton.TabStop = true;
            AsymmetricPanel_RsaRadioButton.Text = "RSA";
            AsymmetricPanel_RsaRadioButton.UseVisualStyleBackColor = true;
            // 
            // SymmetricPanel
            // 
            SymmetricPanel.Controls.Add(SymmetricPanel_RefreshLabel);
            SymmetricPanel.Controls.Add(SymmetricPanel_KeyValueTextBox);
            SymmetricPanel.Controls.Add(SymmetricPanel_KeyClipboardLabel);
            SymmetricPanel.Controls.Add(SymmetricPanel_KeyLabel);
            SymmetricPanel.Controls.Add(SymmetricPanel_KeyLengthLabel);
            SymmetricPanel.Controls.Add(SymmetricPanel_KeyLengthTextBox);
            SymmetricPanel.Controls.Add(SymmetricPanel_LengthTrackBar);
            SymmetricPanel.Location = new Point(0, 82);
            SymmetricPanel.Name = "SymmetricPanel";
            SymmetricPanel.Size = new Size(297, 292);
            SymmetricPanel.TabIndex = 21;
            // 
            // SymmetricPanel_RefreshLabel
            // 
            SymmetricPanel_RefreshLabel.AutoSize = true;
            SymmetricPanel_RefreshLabel.ForeColor = SystemColors.ButtonFace;
            SymmetricPanel_RefreshLabel.Location = new Point(254, 80);
            SymmetricPanel_RefreshLabel.Name = "SymmetricPanel_RefreshLabel";
            SymmetricPanel_RefreshLabel.Size = new Size(28, 19);
            SymmetricPanel_RefreshLabel.TabIndex = 20;
            SymmetricPanel_RefreshLabel.Text = "🔄";
            SymmetricPanel_RefreshLabel.Click += SymmetricPanel_RefreshLabel_Click;
            SymmetricPanel_RefreshLabel.MouseEnter += Label_MouseEnter;
            SymmetricPanel_RefreshLabel.MouseLeave += Label_MouseLeave;
            // 
            // SymmetricPanel_KeyValueTextBox
            // 
            SymmetricPanel_KeyValueTextBox.BackColor = Color.FromArgb(32, 32, 32);
            SymmetricPanel_KeyValueTextBox.BorderStyle = BorderStyle.FixedSingle;
            SymmetricPanel_KeyValueTextBox.ForeColor = SystemColors.ButtonFace;
            SymmetricPanel_KeyValueTextBox.Location = new Point(115, 185);
            SymmetricPanel_KeyValueTextBox.Multiline = true;
            SymmetricPanel_KeyValueTextBox.Name = "SymmetricPanel_KeyValueTextBox";
            SymmetricPanel_KeyValueTextBox.ReadOnly = true;
            SymmetricPanel_KeyValueTextBox.ScrollBars = ScrollBars.Horizontal;
            SymmetricPanel_KeyValueTextBox.Size = new Size(165, 41);
            SymmetricPanel_KeyValueTextBox.TabIndex = 19;
            SymmetricPanel_KeyValueTextBox.WordWrap = false;
            // 
            // SymmetricPanel_KeyClipboardLabel
            // 
            SymmetricPanel_KeyClipboardLabel.AutoSize = true;
            SymmetricPanel_KeyClipboardLabel.ForeColor = SystemColors.ButtonFace;
            SymmetricPanel_KeyClipboardLabel.Location = new Point(19, 188);
            SymmetricPanel_KeyClipboardLabel.Name = "SymmetricPanel_KeyClipboardLabel";
            SymmetricPanel_KeyClipboardLabel.Size = new Size(25, 19);
            SymmetricPanel_KeyClipboardLabel.TabIndex = 18;
            SymmetricPanel_KeyClipboardLabel.Text = "📋";
            SymmetricPanel_KeyClipboardLabel.Click += SymmetricPanel_KeyClipboardLabel_Click;
            SymmetricPanel_KeyClipboardLabel.MouseEnter += Label_MouseEnter;
            SymmetricPanel_KeyClipboardLabel.MouseLeave += Label_MouseLeave;
            // 
            // SymmetricPanel_KeyLabel
            // 
            SymmetricPanel_KeyLabel.AutoSize = true;
            SymmetricPanel_KeyLabel.ForeColor = SystemColors.ButtonFace;
            SymmetricPanel_KeyLabel.Location = new Point(45, 188);
            SymmetricPanel_KeyLabel.Name = "SymmetricPanel_KeyLabel";
            SymmetricPanel_KeyLabel.Size = new Size(34, 19);
            SymmetricPanel_KeyLabel.TabIndex = 17;
            SymmetricPanel_KeyLabel.Text = "Key:";
            // 
            // SymmetricPanel_KeyLengthLabel
            // 
            SymmetricPanel_KeyLengthLabel.AutoSize = true;
            SymmetricPanel_KeyLengthLabel.ForeColor = SystemColors.ButtonFace;
            SymmetricPanel_KeyLengthLabel.Location = new Point(15, 28);
            SymmetricPanel_KeyLengthLabel.Name = "SymmetricPanel_KeyLengthLabel";
            SymmetricPanel_KeyLengthLabel.Size = new Size(138, 19);
            SymmetricPanel_KeyLengthLabel.TabIndex = 9;
            SymmetricPanel_KeyLengthLabel.Text = "Key Length (in bytes)";
            // 
            // SymmetricPanel_KeyLengthTextBox
            // 
            SymmetricPanel_KeyLengthTextBox.BackColor = Color.FromArgb(32, 32, 32);
            SymmetricPanel_KeyLengthTextBox.BorderStyle = BorderStyle.FixedSingle;
            SymmetricPanel_KeyLengthTextBox.ForeColor = SystemColors.ButtonFace;
            SymmetricPanel_KeyLengthTextBox.Location = new Point(242, 25);
            SymmetricPanel_KeyLengthTextBox.Name = "SymmetricPanel_KeyLengthTextBox";
            SymmetricPanel_KeyLengthTextBox.Size = new Size(40, 25);
            SymmetricPanel_KeyLengthTextBox.TabIndex = 10;
            SymmetricPanel_KeyLengthTextBox.Text = "32";
            SymmetricPanel_KeyLengthTextBox.TextAlign = HorizontalAlignment.Right;
            SymmetricPanel_KeyLengthTextBox.TextChanged += SymmetricPanel_KeyLengthTextBox_TextChanged;
            // 
            // SymmetricPanel_LengthTrackBar
            // 
            SymmetricPanel_LengthTrackBar.Location = new Point(11, 54);
            SymmetricPanel_LengthTrackBar.Maximum = 512;
            SymmetricPanel_LengthTrackBar.Minimum = 1;
            SymmetricPanel_LengthTrackBar.Name = "SymmetricPanel_LengthTrackBar";
            SymmetricPanel_LengthTrackBar.Size = new Size(273, 45);
            SymmetricPanel_LengthTrackBar.TabIndex = 8;
            SymmetricPanel_LengthTrackBar.TickFrequency = 32;
            SymmetricPanel_LengthTrackBar.TickStyle = TickStyle.None;
            SymmetricPanel_LengthTrackBar.Value = 32;
            SymmetricPanel_LengthTrackBar.Scroll += SymmetricPanel_LengthTrackBar_Scroll;
            // 
            // Display
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(298, 414);
            Controls.Add(MenuStrip);
            Controls.Add(DeriverPanel);
            Controls.Add(GeneratorPanel);
            Font = new Font("Segoe UI Emoji", 10F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = MenuStrip;
            Name = "Display";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Passkey";
            MenuStrip.ResumeLayout(false);
            MenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DeriverPanel_LengthTrackBar).EndInit();
            DeriverPanel.ResumeLayout(false);
            DeriverPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DeriverPanel_IterationsNumericUpDown).EndInit();
            GeneratorPanel.ResumeLayout(false);
            GeneratorPanel.PerformLayout();
            AsymmetricPanel.ResumeLayout(false);
            AsymmetricPanel.PerformLayout();
            SymmetricPanel.ResumeLayout(false);
            SymmetricPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SymmetricPanel_LengthTrackBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MenuStrip;
        private ToolStripMenuItem DeriverToolStripMenuItem;
        private ToolStripMenuItem GeneratorToolStripMenuItem;
        private ToolStripMenuItem QuestionMarkToolStripMenuItem;
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
        private Panel DeriverPanel;
        private Panel GeneratorPanel;
        private TrackBar SymmetricPanel_LengthTrackBar;
        private Label SymmetricPanel_KeyLengthLabel;
        private TextBox SymmetricPanel_KeyLengthTextBox;
        private RadioButton GeneratePanel_AsymmetricRadioButton;
        private RadioButton GeneratePanel_SymmetricRadioButton;
        private Panel AsymmetricPanel;
        private Panel SymmetricPanel;
        private TextBox SymmetricPanel_KeyValueTextBox;
        private Label SymmetricPanel_KeyClipboardLabel;
        private Label SymmetricPanel_KeyLabel;
        private Label SymmetricPanel_RefreshLabel;
        private Label DeriverPanel_RefreshLabel;
        private RadioButton AsymmetricPanel_EcdsaRadioButton;
        private RadioButton AsymmetricPanel_RsaRadioButton;
        private ComboBox DeriverPanel_AlgorithmComboBox;
        private NumericUpDown DeriverPanel_IterationsNumericUpDown;
        private Label DeriverPanel_IterationsLabel;
        private Button AsymmetricPanel_DownloadButton;
    }
}
