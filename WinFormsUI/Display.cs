using PasskeyLibrary;
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
            TryComputeKey();
        }

        private void DeriverPanel_KeyLengthTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!DeriverPanel_ValidateKeyLength())
            {
                DeriverPanel_KeyLengthTextBox.ForeColor = Color.Red;
                return;
            }

            int.TryParse(DeriverPanel_KeyLengthTextBox.Text, out int keyLength);
            DeriverPanel_LengthTrackBar.Value = keyLength;
            DeriverPanel_KeyLengthTextBox.ForeColor = SystemColors.ButtonFace;

            TryComputeKey();
        }

        private void TryComputeKey()
        {
            if (!DeriverPanel_ValidateKeyLength() || string.IsNullOrWhiteSpace(DeriverPanel_PasswordTextBox.Text))
            {
                DeriverPanel_Pbkdf2ValueTextBox.Text = "";
                return;
            }

            int.TryParse(DeriverPanel_KeyLengthTextBox.Text, out int keyLength);
            string key = BitConverter.ToString(KeyDeriver.DeriveKey(password: DeriverPanel_PasswordTextBox.Text,
                                                                    length: keyLength,
                                                                    salt: salt)).Replace("-", "");
            DeriverPanel_Pbkdf2ValueTextBox.Text = key;
        }

        private bool DeriverPanel_ValidateKeyLength()
        {
            bool parsed = int.TryParse(DeriverPanel_KeyLengthTextBox.Text, out int keyLength);
            bool inRange = keyLength >= DeriverPanel_LengthTrackBar.Minimum && keyLength <= DeriverPanel_LengthTrackBar.Maximum;

            return parsed && inRange;
        }

        private void DeriverPanel_PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            TryComputeKey();
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
            }
            else
            {
                salt = null;
                DeriverPanel_SaltValueTextBox.Text = "";

                DeriverPanel_SaltClipboardLabel.Visible = false;
                DeriverPanel_SaltLabel.Visible = false;
                DeriverPanel_SaltValueTextBox.Visible = false;
            }

            TryComputeKey();
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
    }
}
