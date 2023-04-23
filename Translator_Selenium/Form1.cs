using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Text;
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

            //comboVombox setup

            String[] langs = { "English", "Spanish", "Chinese", "German", "Russian", "Japanese" };

            foreach (String lan in langs)
            {
                comboBox1.Items.Add(lan);
                comboBox2.Items.Add(lan);
            }

            launch();
        }

        public async void launch()
        {
            /*
            //checking chrome version
            String vs = version.get();

            if (vs == null)
            {
                MessageBox.Show("Seems like Google Chrome is not installed on your PC or it have old version");
                return;
            }
            */

            //setting arguments for chomedriver (hidding command prompt and browser itself)
            await Task.Factory.StartNew(() =>
            {
                var service = ChromeDriverService.CreateDefaultService();
                service.HideCommandPromptWindow = true;

                var options = new ChromeOptions();
                options.AddArguments("--window-size=1920,1080");
                options.AddArguments("--disable-gpu");
                options.AddArguments("--disable-extensions");
                options.AddArguments("--proxy-server='direct://'");
                options.AddArguments("--proxy-bypass-list=*");
                options.AddArguments("--start-maximized");
                options.AddArguments("--headless");

                driver = new ChromeDriver(service, options);
                driver.Url = "https://www.deepl.com/ru/translator#ru/en/";
            });
            
        }

        private async void trans_button_Click(object sender, EventArgs e)
        {

            if (label1.Text == "Wait..." || label2.Text == "Wait...")
            {
                return;
            }

            output_text.Text = "";

            //trying to connect to site (limit is 5 seconds)
            for (int i = 0; i < 100; i++)
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
            for (int i = 0; i < 100; i++)
            {
                otpt = driver.FindElement(By.XPath("//*[@id=\"target-dummydiv\"]")).GetAttribute("textContent");

                if (char.IsLetter(otpt[0]) && char.IsLetter(otpt[1]))
                {
                    output_text.Text = encod.transform(otpt);
                    break;
                }
                else
                {
                    await Task.Delay(50);
                }

            }

            driver.FindElement(By.XPath("//*[@id=\"translator-source-clear-button\"]")).Click();

        }

        //closing all chromdriver processes with programm closing

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
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


        private void comboBox2_TextUpdate(object sender, EventArgs e)
        {
            comboBox2.Text = string.Empty;
        }

        private void comboBox1_TextUpdate(object sender, EventArgs e)
        {
            comboBox1.Text = string.Empty;
        }

        private async void submit_butt_Click(object sender, EventArgs e)
        {

            if (comboBox1.Text == "" || comboBox2.Text == "")
            {
                MessageBox.Show("Please choose on or both languages", "Langs error", MessageBoxButtons.OK);
                return;
            }

            String[] KeysData = new string[2];

            //seting input language keys
            String lang_from = language.GetKeys(comboBox1.Text);
            KeysData = lang_from.Split(',');
            set_lang_from(KeysData[0], KeysData[1]);
            
            label1.Text = comboBox1.Text;

            //seting output language keys
            String lang_to = language.GetKeys(comboBox2.Text);
            KeysData = lang_to.Split(',');

            if (comboBox2.Text == "Russian" || comboBox2.Text == "Japanese") {
                int buf = Int32.Parse(KeysData[1]);
                buf += 1;
                KeysData[1] = buf.ToString();
            }

            set_lang_to(KeysData[0], KeysData[1]);

            label2.Text = comboBox2.Text;

        }

        public async void set_lang_from (String a, String b)
        {

            label1.Text = "Wait...";

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

        public async void set_lang_to(String a, String b)
        {
            label2.Text = "Wait...";

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