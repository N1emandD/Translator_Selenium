using OpenQA.Selenium;
using System;
using System.Threading;

namespace Translator_Selenium.govnocode
{
    internal class get_translate
    {

        public static string otpt;

        public static string output(IWebDriver driver, String inpt)
        {
            //trying to connect to site (limit is 5 seconds)
            for (int i = 0; i < 100; i++)
            {
                try
                {
                    driver.FindElement(By.XPath("//*[@id=\"panelTranslateText\"]/div[1]/div[2]/section[1]/div[3]/div[2]/d-textarea/div/p/br")).SendKeys(inpt);
                    break;
                }
                catch
                {
                    Thread.Sleep(50);
                }
            }

            //trying to get text from site
            for (int i = 0; i < 100; i++)
            {
                otpt = driver.FindElement(By.XPath("//*[@id=\"target-dummydiv\"]")).GetAttribute("textContent");

                if (char.IsLetter(otpt[0]) && char.IsLetter(otpt[1]))
                {
                    otpt = encod.transform(otpt);
                    break;
                }
                else
                {
                    Thread.Sleep(50);
                }

            }

            return otpt;
        }

    }
}
