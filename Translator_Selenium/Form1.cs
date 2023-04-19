using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Translator_Selenium
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            foreach (var proc in Process.GetProcessesByName("chromedriver"))
            {
                proc.Kill();
            }

            this.Icon = new Icon("languages_pq5_icon.ico");
            
        }

        private async void trans_button_Click(object sender, EventArgs e)
        {

            //setting arguments for chomedriver (hidding command prompt and browser itself)
            var service = ChromeDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true;

            var options = new ChromeOptions();
            options.AddArguments("headless");

            IWebDriver driver = new ChromeDriver(service, options);

            //trying to connect to site (limit is 5 seconds)
            driver.Url = "https://www.deepl.com/ru/translator#ru/en/";

            for(int i = 0; i < 10; i++)
            {
                try
                {
                    driver.FindElement(By.XPath("//*[@id=\"panelTranslateText\"]/div[1]/div[2]/section[1]/div[3]/div[2]/d-textarea/div/p/br"));
                    break;
                }
                catch
                {
                    await Task.Delay(500);
                }
            }

            //putting word in search bar and trying find word

            try
            {
                driver.FindElement(By.XPath("//*[@id=\"panelTranslateText\"]/div[1]/div[2]/section[1]/div[3]/div[2]/d-textarea/div/p/br")).SendKeys(input_text.Text);
            }
            catch
            {
                MessageBox.Show("Request time out", "Connection error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            await Task.Delay(1000);

            try
            {
                String otpt = driver.FindElement(By.XPath("//*[@id=\"target-dummydiv\"]")).GetAttribute("textContent");

                output_text.Text = otpt;
            }

            catch
            {
                MessageBox.Show("Не найдено слово, попробуйте еще раз", "Ошибка ввода", MessageBoxButtons.OK);
            }

            driver.Close();

            foreach (var proc in Process.GetProcessesByName("chromedriver"))
            {
                proc.Kill();
            }

        }
    }
}
