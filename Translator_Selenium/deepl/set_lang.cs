using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translator_Selenium
{
    internal class set_lang
    {
        public async static void from(String a, String b, IWebDriver driver)
        {
            //pressing button to switching language

            for (int i = 0; i < 50; i++)
            {
                try
                {
                    driver.FindElement(By.XPath("//*[@id=\"panelTranslateText\"]/div[1]/div[2]/section[1]/div[1]/div[2]/button")).Click();
                    break;
                }
                catch
                {
                    await Task.Delay(100);
                }
            }

            //trying set claimed language
            for (int i = 0; i < 50; i++)
            {
                try
                {
                    driver.FindElement(By.XPath($"//*[@id=\"panelTranslateText\"]/div[1]/div[2]/section[1]/div[6]/div[2]/div[{a}]/button[{b}]")).Click();
                    break;
                }
                catch
                {
                    await Task.Delay(100);
                }
            }
        }

        public async static void to(String a, String b, IWebDriver driver)
        {
            //pressing button to switching language

            for (int i = 0; i < 50; i++)
            {
                try
                {
                    driver.FindElement(By.XPath("//*[@id=\"panelTranslateText\"]/div[1]/div[2]/section[2]/div[1]/div[1]/div[2]/button")).Click();
                    break;
                }
                catch
                {
                    await Task.Delay(100);
                }
            }

            //trying set claimed language
            for (int i = 0; i < 50; i++)
            {
                try
                {
                    driver.FindElement(By.XPath($"//*[@id=\"panelTranslateText\"]/div[1]/div[2]/section[2]/div[9]/div[2]/div[{a}]/button[{b}]")).Click();
                    break;
                }
                catch
                {
                    await Task.Delay(100);
                }
            }
        }
    }
}
