using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Translator_Selenium.govnocode;
using Translator_Selenium.ocr;

namespace Translator_Selenium
{
    public partial class Form1 : Form
    {

        IWebDriver driver;
        Image image;
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
                ocr_set_lang.Items.Add(lan);
            }

            launch();

            openFileDialog1.Filter = "Imaje files (*BMP; *JPG; *JPEG; *PNG;)|*BMP; *JPG; *JPEG; *PNG;|All files(*.*)|*.*";

        }

        public async void launch()
        {

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

            output_text.Text = get_translate.output(driver, input_text.Text);

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

            label2.Text = "Wait...";
            label1.Text = "Wait...";

            if (comboBox1.Text == "" || comboBox2.Text == "")
            {
                MessageBox.Show("Please choose on or both languages", "Langs error", MessageBoxButtons.OK);
                return;
            }

            String[] KeysData = new string[2];

            //seting input language keys
            String lang_from = language.GetKeys(comboBox1.Text);

            KeysData = lang_from.Split(',');
            set_lang.from(KeysData[0], KeysData[1], driver);
            
            label1.Text = comboBox1.Text;

            //seting output language keys
            String lang_to = language.GetKeys(comboBox2.Text);

            KeysData = lang_to.Split(',');

            if (comboBox2.Text == "Russian" || comboBox2.Text == "Japanese") {

                int buf = Int32.Parse(KeysData[1]);
                buf += 1;
                KeysData[1] = buf.ToString();

            }

            set_lang.to(KeysData[0], KeysData[1], driver);

            label2.Text = comboBox2.Text;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            input_text.Text = "";
            input_text.Text = loading_image.load_picure(openFileDialog1, image_status, ocr_set_lang);
        }
    }
}