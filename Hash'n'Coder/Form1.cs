using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hash_n_Coder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void EncodBtn_Click(object sender, EventArgs e)
        {
            BtnBase64.Checked = true;
            AlgorPanel.Visible = true;
            BtnBase64.Visible = true;
            BtnUrl.Visible = true;
            BtnHtml.Visible = true;
            BtnUnescape.Visible = true;
            CBCBtn.Visible = false;
            EBCBtn.Visible = false;
            AESComboBox.Visible = false;
            KeyPanel.Visible = false;
            EncodeBtn.Visible = true;
            DecodeBtn.Visible = true;
            EncodeBtn.Checked = true;
            ResultText.Text = "";
        }

        private void AESBtn_Click(object sender, EventArgs e)
        {
            EBCBtn.Checked = true;
            AlgorPanel.Visible = true;
            BtnBase64.Visible = false;
            BtnUrl.Visible = false;
            BtnHtml.Visible = false;
            BtnUnescape.Visible = false;
            CBCBtn.Visible = true;
            EBCBtn.Visible = true;
            AESComboBox.Visible = true;
            KeyPanel.Visible = true;
            EncodeBtn.Visible = true;
            DecodeBtn.Visible = true;
            EncodeBtn.Checked = true;
            ResultText.Text = "";
        }

        private void HashingBtn_Click(object sender, EventArgs e)
        {
            AlgorPanel.Visible = false;
            KeyPanel.Visible = false;
            EncodeBtn.Visible = false;
            DecodeBtn.Visible = false;
            EncodeBtn.Checked = false;
            DecodeBtn.Checked = false;
            ResultText.Text = "";
        }

        private void PasteBtn_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                InputText.Text = Clipboard.GetText();
            }
            else
            {
                MessageBox.Show("Clipboard does not contain any text.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CopyBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ResultText.Text))
            {
                Clipboard.SetText(ResultText.Text);
            }
            else
            {
                MessageBox.Show("There is no text to copy.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RunBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Settings.inputText = InputText.Text;
                if (BtnBase64.Checked)
                {
                    if (EncodeBtn.Checked)
                    {
                        Work.Encode64();
                    }
                    else if (DecodeBtn.Checked)
                    {
                        Work.Decode64();
                    }
                }
                if (BtnUrl.Checked)
                {
                    if (EncodeBtn.Checked)
                    {
                        Work.UrlEncode();
                    }
                    if (DecodeBtn.Checked)
                    {
                        Work.UrlDecode();
                    }
                }
                if (BtnHtml.Checked)
                {
                    if (EncodeBtn.Checked)
                    {
                        Work.HtmlEncode();
                    }
                    if (DecodeBtn.Checked)
                    {
                        Work.HtmlDecode();
                    }
                }
                if (BtnUnescape.Checked)
                {
                    if (EncodeBtn.Checked)
                    {
                        Work.EscapeEncode();
                    }
                    if (DecodeBtn.Checked)
                    {
                        Work.EscapeDecode();
                    }
                }

                if (EBCBtn.Checked)
                {
                    if (EncodeBtn.Checked)
                    {
                        if (string.IsNullOrEmpty(KeyText.Text))
                        {
                            KeyGenerateBtn_Click(sender, e);
                        }
                        Settings.keytext = KeyText.Text;
                        Work.EbcEncode();
                    }
                    if (DecodeBtn.Checked)
                    {
                        Settings.keytext = KeyText.Text;
                        Work.EbcDecode();
                    }   
                }
                if (CBCBtn.Checked)
                {
                    if (EncodeBtn.Checked)
                    {
                        if (string.IsNullOrEmpty(KeyText.Text))
                        {
                            KeyGenerateBtn_Click(sender, e);
                        }
                        Settings.keytext = KeyText.Text;
                        Work.CbcEncode();
                    }
                    if (DecodeBtn.Checked)
                    {
                        Settings.keytext = KeyText.Text;
                        Work.CbcDecode();
                    }
                }
                if (HashingBtn.Checked)
                {
                    Work.Hashing();
                }
                ResultText.ForeColor = Color.Green;
                ResultText.Text = Settings.resulttext;
            }
            catch (System.FormatException)
            {
                ResultText.ForeColor = Color.Red;
                ResultText.Text = "Format Exception.";
            }
            catch (System.Security.Cryptography.CryptographicException)
            {
                ResultText.ForeColor = Color.Red;
                ResultText.Text = "Cryptographic Exception. Please enter the correct decryption key.";
            }
            catch (System.ArgumentOutOfRangeException)
            {
                ResultText.ForeColor = Color.Red;
                ResultText.Text = "Argument Out Of Range Exception.";
            }
        }

        private void KeyGenerateBtn_Click(object sender, EventArgs e)
        {
            KeyText.Clear();
            Settings.KeySize = int.Parse(AESComboBox.SelectedItem.ToString());
            Work.KeyGenerator();
            KeyText.Text = Settings.keytext;
        }
    }
}


