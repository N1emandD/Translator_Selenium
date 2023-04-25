using System.Collections.Generic;

namespace Translator_Selenium
{
    internal class language
    {
        public static Dictionary<string, string> lang_code = new Dictionary<string, string>()
        {
            { "English", "1,2" },
            { "Spanish", "1,8" },
            { "Chinese", "1,10" },
            { "German", "2,3" },
            { "Russian", "2,9" },
            { "Japanese", "3,8" }
        };

        public static string GetKeys (string lang)
        {
            return lang_code[lang];
        }

    }
}
