
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
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
            var sb = new StringBuilder(Settings.inputText.Length * 6);
            for (int i = 0; i < Settings.inputText.Length; i++)
            {
                sb.Append("&#");
                sb.Append(((int)Settings.inputText[i]).ToString());
                sb.Append(";");
            }
            Settings.resulttext = sb.ToString();
        }
        public static void HtmlDecode()
        {
            Settings.resulttext = Regex.Replace(Settings.inputText, "&#(\\d+);", match =>
            {
                int charCode = int.Parse(match.Groups[1].Value);
                return ((char)charCode).ToString();
            });
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
        public static void EbcDecode()
        {
            byte[] key = HexStringToBytes(Settings.keytext);
            byte[] cipherText = HexStringToBytes(Settings.inputText);
            using (Aes aes = Aes.Create())
            {
                aes.KeySize = Settings.KeySize;
                aes.Key = key;
                aes.Mode = CipherMode.ECB;
                aes.Padding = PaddingMode.PKCS7;
                using (ICryptoTransform decryptor = aes.CreateDecryptor())
                {
                    byte[] plainText = decryptor.TransformFinalBlock(cipherText, 0, cipherText.Length);
                    Settings.resulttext = Encoding.UTF8.GetString(plainText);
                }
            }
        }
        public static void CbcEncode()
        {
            byte[] key = HexStringToBytes(Settings.keytext);
            byte[] plainText = Encoding.UTF8.GetBytes(Settings.inputText);
            using (Aes aes = Aes.Create())
            {
                aes.KeySize = Settings.KeySize;
                aes.Key = key;
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;
                aes.GenerateIV();
                using (ICryptoTransform encryptor = aes.CreateEncryptor())
                {
                    byte[] cipherText = encryptor.TransformFinalBlock(plainText, 0, plainText.Length);
                    byte[] result = new byte[aes.IV.Length + cipherText.Length];
                    Buffer.BlockCopy(aes.IV, 0, result, 0, aes.IV.Length);
                    Buffer.BlockCopy(cipherText, 0, result, aes.IV.Length, cipherText.Length);
                    Settings.resulttext = BitConverter.ToString(result).Replace("-", "");
                }
            }
        }
        public static void CbcDecode()
        {
            byte[] key = HexStringToBytes(Settings.keytext);
            byte[] cipherTextWithIv = HexStringToBytes(Settings.inputText);
            using (Aes aes = Aes.Create())
            {
                aes.KeySize = Settings.KeySize;
                aes.Key = key;
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;
                byte[] iv = new byte[aes.BlockSize / 8];
                byte[] cipherText = new byte[cipherTextWithIv.Length - iv.Length];
                Buffer.BlockCopy(cipherTextWithIv, 0, iv, 0, iv.Length);
                Buffer.BlockCopy(cipherTextWithIv, iv.Length, cipherText, 0, cipherText.Length);
                aes.IV = iv;
                using (ICryptoTransform decryptor = aes.CreateDecryptor())
                {
                    byte[] plainText = decryptor.TransformFinalBlock(cipherText, 0, cipherText.Length);
                    Settings.resulttext = Encoding.UTF8.GetString(plainText);
                }
            }
        }
        public static string Hash(string input, HashAlgorithm hashAlg)
        {
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            byte[] hashBytes = hashAlg.ComputeHash(inputBytes);
            return BitConverter.ToString(hashBytes).Replace("-", "");
        }
        public static void Hashing()
        {
            Settings.resulttext = 
                $"MD5: {Hash(Settings.inputText, MD5.Create())}" +
                $"\r\nSHA1: {Hash(Settings.inputText, SHA1.Create())}" +
                $"\r\nSHA256: {Hash(Settings.inputText, SHA256.Create())}" +
                $"\r\nSHA384: {Hash(Settings.inputText, SHA384.Create())}" +
                $"\r\nSHA512: {Hash(Settings.inputText, SHA512.Create())}";
        }
    }
}
