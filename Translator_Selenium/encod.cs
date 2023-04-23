using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translator_Selenium
{
    internal class encod
    {
        public static Encoding utf8 = Encoding.UTF8;
        public static Encoding utf32 = Encoding.Unicode;
        public static string transform (string text)
        {
            byte[] bytes1 = utf8.GetBytes (text);
            byte[] bytes2 = Encoding.Convert(utf8, utf32, bytes1);

            return utf32.GetString (bytes2);
        }
    }
}
