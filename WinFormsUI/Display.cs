using PasskeyLibrary;
using System.Diagnostics;
using System.Security.Cryptography;

namespace WinFormsUI
{
    public partial class Display : Form
    {
        private bool isEyeballLabelClicked = false;
        private byte[] salt = null;

        public Display()
        {
            InitializeComponent();
            DeriverToolStripMenuItem_Click(null, null);
            InitializeAlgorithmComboBox();
        }

        private void InitializeAlgorithmComboBox()
        {
            DeriverPanel_AlgorithmComboBox.Items.Add("SHA1");
            DeriverPanel_AlgorithmComboBox.Items.Add("SHA256");
            DeriverPanel_AlgorithmComboBox.Items.Add("SHA384");
            DeriverPanel_AlgorithmComboBox.Items.Add("SHA512");

            // SHA256 default
            DeriverPanel_AlgorithmComboBox.SelectedIndex = 1;
        }

        private void DeriverPanel_EyeballLabel_Click(object sender, EventArgs e)
        {
            // toggle off
            if (isEyeballLabelClicked)
            {
                DeriverPanel_PasswordTextBox.UseSystemPasswordChar = true;
                DeriverPanel_EyeballLabel.ForeColor = SystemColors.ButtonFace;
                isEyeballLabelClicked = false;
            }
            // toggle on
            else
            {
                DeriverPanel_PasswordTextBox.UseSystemPasswordChar = false;
                DeriverPanel_EyeballLabel.ForeColor = SystemColors.Highlight;
                isEyeballLabelClicked = true;
            }
        }

        private void DeriverPanel_LengthTrackBar_Scroll(object sender, EventArgs e)
        {
            DeriverPanel_KeyLengthTextBox.Text = DeriverPanel_LengthTrackBar.Value.ToString();
            DeriverTryComputeKey();
        }

        private void DeriverPanel_KeyLengthTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!ValidateKeyLength(DeriverPanel_KeyLengthTextBox.Text, DeriverPanel_LengthTrackBar.Minimum, DeriverPanel_LengthTrackBar.Maximum))
            {
                DeriverPanel_KeyLengthTextBox.ForeColor = Color.Red;
                return;
            }

            int.TryParse(DeriverPanel_KeyLengthTextBox.Text, out int keyLength);
            DeriverPanel_LengthTrackBar.Value = keyLength;
            DeriverPanel_KeyLengthTextBox.ForeColor = SystemColors.ButtonFace;

            DeriverTryComputeKey();
        }

        private void DeriverTryComputeKey()
        {
            if (!ValidateKeyLength(DeriverPanel_KeyLengthTextBox.Text, DeriverPanel_LengthTrackBar.Minimum, DeriverPanel_LengthTrackBar.Maximum) ||
                string.IsNullOrWhiteSpace(DeriverPanel_PasswordTextBox.Text))
            {
                DeriverPanel_Pbkdf2ValueTextBox.Text = "";
                return;
            }

            // read options
            int.TryParse(DeriverPanel_KeyLengthTextBox.Text, out int keyLength);
            int iterations = (int)DeriverPanel_IterationsNumericUpDown.Value;
            HashAlgorithmName algorithm;
            switch (DeriverPanel_AlgorithmComboBox.SelectedIndex)
            {
                case 0:
                    algorithm = HashAlgorithmName.SHA1;
                    break;
                case 1:
                    algorithm = HashAlgorithmName.SHA256;
                    break;
                case 2:
                    algorithm = HashAlgorithmName.SHA384;
                    break;
                case 3:
                    algorithm = HashAlgorithmName.SHA512;
                    break;
                default:
                    algorithm = HashAlgorithmName.SHA256;
                    break;
            }

            string key = BitConverter.ToString(KeyDeriver.DeriveKey(password: DeriverPanel_PasswordTextBox.Text,
                                                                    salt: salt,
                                                                    length: keyLength,
                                                                    iterations: iterations,
                                                                    algorithm: algorithm)).Replace("-", "");
            DeriverPanel_Pbkdf2ValueTextBox.Text = key;
        }

        private bool ValidateKeyLength(string length, int min, int max)
        {
            bool parsed = int.TryParse(length, out int keyLength);
            bool inRange = keyLength >= min && keyLength <= max;

            return parsed && inRange;
        }

        private void DeriverPanel_PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            DeriverTryComputeKey();
        }

        private void DeriverPanel_SaltCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (DeriverPanel_SaltCheckBox.Checked)
            {
                salt = KeyDeriver.GenerateSalt();
                DeriverPanel_SaltValueTextBox.Text = BitConverter.ToString(salt).Replace("-", "");

                DeriverPanel_SaltClipboardLabel.Visible = true;
                DeriverPanel_SaltLabel.Visible = true;
                DeriverPanel_SaltValueTextBox.Visible = true;
                DeriverPanel_RefreshLabel.Visible = true;
            }
            else
            {
                salt = null;
                DeriverPanel_SaltValueTextBox.Text = "";

                DeriverPanel_SaltClipboardLabel.Visible = false;
                DeriverPanel_SaltLabel.Visible = false;
                DeriverPanel_SaltValueTextBox.Visible = false;
                DeriverPanel_RefreshLabel.Visible = false;
            }

            DeriverTryComputeKey();
        }

        private void DeriverPanel_AlgorithmComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DeriverTryComputeKey();
        }

        private void DeriverPanel_IterationsNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (DeriverPanel_IterationsNumericUpDown.Value < 1)
            {
                DeriverPanel_IterationsNumericUpDown.Value = 1;
            }
            else if (DeriverPanel_IterationsNumericUpDown.Value > 10000)
            {
                DeriverPanel_IterationsNumericUpDown.Value = 10000;
            }

            DeriverTryComputeKey();
        }

        private void DeriverPanel_RefreshLabel_Click(object sender, EventArgs e)
        {
            salt = KeyDeriver.GenerateSalt();
            DeriverPanel_SaltValueTextBox.Text = BitConverter.ToString(salt).Replace("-", "");
            DeriverTryComputeKey();
        }

        private void DeriverPanel_Pbkdf2ClipboardLabel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(DeriverPanel_Pbkdf2ValueTextBox.Text))
            {
                return;
            }

            Clipboard.SetText(DeriverPanel_Pbkdf2ValueTextBox.Text);
        }

        private void DeriverPanel_SaltClipboardLabel_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(DeriverPanel_SaltValueTextBox.Text);
        }

        private void Label_MouseEnter(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            label.ForeColor = SystemColors.Highlight;
        }

        private void Label_MouseLeave(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            label.ForeColor = SystemColors.ButtonFace;
        }

        private void QuestionMarkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo processStartInfo = new()
            {
                FileName = "https://github.com/EvanHei/Passkey/blob/main/README.md",
                UseShellExecute = true
            };

            Process.Start(processStartInfo);
        }

        private void DeriverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowDeriverPanel();
            DeriverToolStripMenuItem.Font = new(DeriverToolStripMenuItem.Font, FontStyle.Bold);
            GeneratorToolStripMenuItem.Font = new(GeneratorToolStripMenuItem.Font, FontStyle.Regular);
        }

        private void GeneratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowGeneratorPanel();
            DeriverToolStripMenuItem.Font = new(DeriverToolStripMenuItem.Font, FontStyle.Regular);
            GeneratorToolStripMenuItem.Font = new(GeneratorToolStripMenuItem.Font, FontStyle.Bold);
        }

        private void ShowDeriverPanel()
        {
            DeriverPanel.Visible = true;
            GeneratorPanel.Visible = false;
        }

        private void ShowGeneratorPanel()
        {
            DeriverPanel.Visible = false;
            GeneratorPanel.Visible = true;

            GeneratorPanel_RadioButton_CheckedChanged(null, null);
        }

        private void ShowSymmetricPanel()
        {
            SymmetricPanel.Visible = true;
            AsymmetricPanel.Visible = false;

            SymmetricTryComputeKey();
        }

        private void ShowAsymmetricPanel()
        {
            SymmetricPanel.Visible = false;
            AsymmetricPanel.Visible = true;

            AsymmetricTryComputeKey();
        }

        private void GeneratorPanel_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (GeneratePanel_SymmetricRadioButton.Checked)
            {
                ShowSymmetricPanel();
            }
            else if (GeneratePanel_AsymmetricRadioButton.Checked)
            {
                ShowAsymmetricPanel();
            }
        }

        private void SymmetricPanel_LengthTrackBar_Scroll(object sender, EventArgs e)
        {
            SymmetricPanel_KeyLengthTextBox.Text = SymmetricPanel_LengthTrackBar.Value.ToString();
            SymmetricTryComputeKey();
        }

        private void SymmetricPanel_KeyLengthTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!ValidateKeyLength(SymmetricPanel_KeyLengthTextBox.Text, SymmetricPanel_LengthTrackBar.Minimum, SymmetricPanel_LengthTrackBar.Maximum))
            {
                SymmetricPanel_KeyLengthTextBox.ForeColor = Color.Red;
                return;
            }

            int.TryParse(SymmetricPanel_KeyLengthTextBox.Text, out int keyLength);
            SymmetricPanel_LengthTrackBar.Value = keyLength;
            SymmetricPanel_KeyLengthTextBox.ForeColor = SystemColors.ButtonFace;

            SymmetricTryComputeKey();
        }

        private void SymmetricTryComputeKey()
        {
            if (!ValidateKeyLength(SymmetricPanel_KeyLengthTextBox.Text, SymmetricPanel_LengthTrackBar.Minimum, SymmetricPanel_LengthTrackBar.Maximum))
            {
                SymmetricPanel_KeyValueTextBox.Text = "";
                return;
            }

            int.TryParse(SymmetricPanel_KeyLengthTextBox.Text, out int keyLength);
            string key = BitConverter.ToString(SymmetricKeyGenerator.GenerateKey(keyLength)).Replace("-", "");
            SymmetricPanel_KeyValueTextBox.Text = key;
        }

        private void AsymmetricTryComputeKey()
        {
            (byte[] publicKeyBytes, byte[] privateKeyBytes) = (null, null);

            if (AsymmetricPanel_RsaRadioButton.Checked)
            {
                (publicKeyBytes, privateKeyBytes) = AsymmetricKeyGenerator.GenerateRsaKeyPair();
            }
            else if (AsymmetricPanel_EcdsaRadioButton.Checked)
            {
                (publicKeyBytes, privateKeyBytes) = AsymmetricKeyGenerator.GenerateEcdsaKeyPair();
            }

            string publicKey = BitConverter.ToString(publicKeyBytes).Replace("-", "");
            string privateKey = BitConverter.ToString(privateKeyBytes).Replace("-", "");

            AsymmetricPanel_PublicKeyValueTextBox.Text = publicKey;
            AsymmetricPanel_PrivateKeyValueTextBox.Text = privateKey;
        }

        private void SymmetricPanel_KeyClipboardLabel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SymmetricPanel_KeyValueTextBox.Text))
            {
                return;
            }

            Clipboard.SetText(SymmetricPanel_KeyValueTextBox.Text);
        }

        private void SymmetricPanel_RefreshLabel_Click(object sender, EventArgs e)
        {
            SymmetricTryComputeKey();
        }

        private void AsymmetricPanel_RsaRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (AsymmetricPanel_RsaRadioButton.Checked)
            {
                AsymmetricPanel_InfoLabel.Text = "*The public key will be exported in the X.509 \r\nSubjectPublicKeyInfo format, and the private \r\nkey will be exported in the PKCS #1 format.\r\n";
                AsymmetricTryComputeKey();
            }
            else if (AsymmetricPanel_EcdsaRadioButton.Checked)
            {
                AsymmetricPanel_InfoLabel.Text = "*The public key will be exported in the X.509 \r\nSubjectPublicKeyInfo format, and the private \r\nkey will be exported in the PKCS #8 format.\r\n";
                AsymmetricTryComputeKey();
            }
        }

        private void AsymmetricPanel_PublicKeyClipboardLabel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(AsymmetricPanel_PublicKeyValueTextBox.Text))
            {
                return;
            }

            Clipboard.SetText(AsymmetricPanel_PublicKeyValueTextBox.Text);
        }

        private void AsymmetricPanel_PrivateKeyClipboardLabel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(AsymmetricPanel_PrivateKeyValueTextBox.Text))
            {
                return;
            }

            Clipboard.SetText(AsymmetricPanel_PrivateKeyValueTextBox.Text);
        }

        private void AsymmetricPanel_RefreshLabel_Click(object sender, EventArgs e)
        {
            AsymmetricTryComputeKey();
        }
    }
}
