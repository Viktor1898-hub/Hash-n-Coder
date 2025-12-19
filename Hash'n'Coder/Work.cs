
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
        public static string Encode64(string text)
        {
            if (Settings.encode)
            {
                var plainTextBytes = Encoding.UTF8.GetBytes(text);
                return Convert.ToBase64String(plainTextBytes);
            }
            else
            {
                var base64EncodedBytes = Convert.FromBase64String(text);
                return Encoding.UTF8.GetString(base64EncodedBytes);
            }
        }
        public static string UrlEncode(string text)
        {
            if (Settings.encode)
            {
                return System.Net.WebUtility.UrlEncode(text);
            }
            else
            {
                return System.Net.WebUtility.UrlDecode(text);
            }
        }
        public static string HtmlEncode(string text)
        {
            if (Settings.encode)
            {
                var sb = new StringBuilder(text.Length * 6);
                for (int i = 0; i < text.Length; i++)
                {
                    sb.Append("&#");
                    sb.Append(((int)text[i]).ToString());
                    sb.Append(";");
                }
                return sb.ToString();
            }
            else
            {
                return Regex.Replace(text, "&#(\\d+);", match =>
                {
                    int charCode = int.Parse(match.Groups[1].Value);
                    return ((char)charCode).ToString();
                });
            }
        }
        public static string EscapeEncode(string text)
        {
            if (Settings.encode)
            {
                return System.Uri.EscapeDataString(text);
            }
            else
            {
                return System.Uri.UnescapeDataString(text);
            }
        }
        public static string KeyGenerator()
        {
            using (Aes aes = Aes.Create())
            {
                aes.KeySize = Settings.KeySize;
                aes.GenerateKey();
                return Convert.ToString(BitConverter.ToString(aes.Key).Replace("-", ""));
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
        public static string EbcEncode(string text)
        {
            byte[] key = HexStringToBytes(Settings.keytext);
            using (Aes aes = Aes.Create())
            {
                aes.KeySize = Settings.KeySize;
                aes.Key = key;
                aes.Mode = CipherMode.ECB;
                aes.Padding = PaddingMode.PKCS7;
                if (Settings.encode)
                {
                    byte[] plainText = Encoding.UTF8.GetBytes(text);
                    using (ICryptoTransform encryptor = aes.CreateEncryptor())
                    {
                        byte[] cipherText = encryptor.TransformFinalBlock(plainText, 0, plainText.Length);
                        return BitConverter.ToString(cipherText).Replace("-", "");
                    }
                }
                else
                {
                    byte[] cipherText = HexStringToBytes(text);
                    using (ICryptoTransform decryptor = aes.CreateDecryptor())
                    {
                        byte[] plainText = decryptor.TransformFinalBlock(cipherText, 0, cipherText.Length);
                        return Encoding.UTF8.GetString(plainText);
                    }
                }
            }
        }
        public static string CbcEncode(string text)
        {
            byte[] key = HexStringToBytes(Settings.keytext);
            using (Aes aes = Aes.Create())
            {
                aes.KeySize = Settings.KeySize;
                aes.Key = key;
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;
                if (Settings.encode)
                {
                    aes.GenerateIV();
                    using (ICryptoTransform encryptor = aes.CreateEncryptor())
                    {
                        byte[] plainText = Encoding.UTF8.GetBytes(text);
                        byte[] cipherText = encryptor.TransformFinalBlock(plainText, 0, plainText.Length);
                        byte[] result = new byte[aes.IV.Length + cipherText.Length];
                        Buffer.BlockCopy(aes.IV, 0, result, 0, aes.IV.Length);
                        Buffer.BlockCopy(cipherText, 0, result, aes.IV.Length, cipherText.Length);
                        return BitConverter.ToString(result).Replace("-", "");
                    }
                }
                else
                {
                    byte[] cipherTextWithIv = HexStringToBytes(text);
                    byte[] iv = new byte[aes.BlockSize / 8];
                    byte[] cipherText = new byte[cipherTextWithIv.Length - iv.Length];
                    Buffer.BlockCopy(cipherTextWithIv, 0, iv, 0, iv.Length);
                    Buffer.BlockCopy(cipherTextWithIv, iv.Length, cipherText, 0, cipherText.Length);
                    aes.IV = iv;
                    using (ICryptoTransform decryptor = aes.CreateDecryptor())
                    {
                        byte[] plainText = decryptor.TransformFinalBlock(cipherText, 0, cipherText.Length);
                        return Encoding.UTF8.GetString(plainText);
                    }

                }
            }
        }
        public static string Hash(string input, HashAlgorithm hashAlg)
        {
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            byte[] hashBytes = hashAlg.ComputeHash(inputBytes);
            return BitConverter.ToString(hashBytes).Replace("-", "");
        }
        public static string Hashing()
        {
            return 
                $"MD5: {Hash(Settings.inputText, MD5.Create())}" +
                $"\r\nSHA1: {Hash(Settings.inputText, SHA1.Create())}" +
                $"\r\nSHA256: {Hash(Settings.inputText, SHA256.Create())}" +
                $"\r\nSHA384: {Hash(Settings.inputText, SHA384.Create())}" +
                $"\r\nSHA512: {Hash(Settings.inputText, SHA512.Create())}";
        }
    }
}
