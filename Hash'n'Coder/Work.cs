
using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
