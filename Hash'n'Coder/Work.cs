
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hash_n_Coder
{
    internal class Work
    {
        public static void Encode64()
        {
            var plainTextBytes = Encoding.UTF8.GetBytes(Settings.inputText);
            Settings.resulttext = Convert.ToBase64String(plainTextBytes);
        }
        public static void Decode64()
        {
            var base64EncodedBytes = Convert.FromBase64String(Settings.inputText);
            Settings.resulttext = Encoding.UTF8.GetString(base64EncodedBytes);
        }
        public static void UrlEncode()
        {
            Settings.resulttext = System.Net.WebUtility.UrlEncode(Settings.inputText);
        }
        public static void UrlDecode()
        {
            Settings.resulttext = System.Net.WebUtility.UrlDecode(Settings.inputText);
        }
        public static void HtmlEncode()
        {
            Settings.resulttext = System.Net.WebUtility.HtmlEncode(Settings.inputText);
        }
        public static void HtmlDecode()
        {
            Settings.resulttext = System.Net.WebUtility.HtmlDecode(Settings.inputText);
        }
        public static void EscapeEncode()
        { 
            Settings.resulttext = System.Uri.EscapeDataString(Settings.inputText);
        }
        public static void EscapeDecode()
        {
            Settings.resulttext = System.Uri.UnescapeDataString(Settings.inputText);
        }
        public static void KeyGenerator()
        {
            using (Aes aes = Aes.Create())
            {
                aes.KeySize = Settings.KeySize;
                aes.GenerateKey();
                Settings.keytext = Convert.ToString(BitConverter.ToString(aes.Key).Replace("-", ""));
            }
        }
        public static byte[] HexStringToBytes(string hex)
        {
            int length = hex.Length;
            byte[] bytes = new byte[length / 2];
            for (int i = 0; i < length; i += 2)
            {
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            }
            return bytes;
        }

        public static void EbcEncode()
        {

            byte[] key = HexStringToBytes(Settings.keytext);
            byte[] plainText = Encoding.UTF8.GetBytes(Settings.inputText);
            using (Aes aes = Aes.Create())
            {
                aes.KeySize = Settings.KeySize;
                aes.Key = key;
                aes.Mode = CipherMode.ECB;
                aes.Padding = PaddingMode.PKCS7;
                using (ICryptoTransform encryptor = aes.CreateEncryptor())
                {
                    byte[] cipherText = encryptor.TransformFinalBlock(plainText, 0, plainText.Length);
                    Settings.resulttext = BitConverter.ToString(cipherText).Replace("-", "");
                }
            }
        }
    }
}
