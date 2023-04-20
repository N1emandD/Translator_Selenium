using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Translator_Selenium
{
    public partial class Form1 : Form
    {

        IWebDriver driver;

        String otpt;
        public Form1()
        {
            InitializeComponent();

            this.Icon = new Icon("languages_pq5_icon.ico");

            launch();
        }

        public async void launch()
        {
            //setting arguments for chomedriver (hidding command prompt and browser itself)
            await Task.Factory.StartNew(() =>
            {
                var service = ChromeDriverService.CreateDefaultService();
                service.HideCommandPromptWindow = true;

                var options = new ChromeOptions();
                options.AddArguments("headless");

                driver = new ChromeDriver(service, options);
                driver.Url = "https://www.deepl.com/ru/translator#ru/en/";
            });
            
        }

        private async void trans_button_Click(object sender, EventArgs e)
        {
            output_text.Text = "";

            //trying to connect to site (limit is 5 seconds)
            for (int i = 0; i < 50; i++)
            {
                try
                {
                    driver.FindElement(By.XPath("//*[@id=\"panelTranslateText\"]/div[1]/div[2]/section[1]/div[3]/div[2]/d-textarea/div/p/br")).SendKeys(input_text.Text);
                    break;
                }
                catch
                {
                    await Task.Delay(100);
                }
            }

            //trying to get text from site
            for (int i = 0; i < 50; i++)
            {
                otpt = driver.FindElement(By.XPath("//*[@id=\"target-dummydiv\"]")).GetAttribute("textContent");

                if (char.IsLetter(otpt[0]) && char.IsLetter(otpt[1]))
                {
                    output_text.Text = otpt;
                    break;
                }
                else
                {
                    await Task.Delay(50);
                }

            }

            //close chromdriver
            driver.Close();

            foreach (var proc in Process.GetProcessesByName("chromedriver"))
            {
                proc.Kill();
            }

            launch();

        }

        //closing all chromdriver processes with programm closing
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                driver.Close();
            }
            catch
            {
                return;
            }

            foreach (var proc in Process.GetProcessesByName("chromedriver"))
            {
                proc.Kill();
            }
            
        }
    }
}