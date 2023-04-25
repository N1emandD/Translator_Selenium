using IronOcr;
using IronSoftware.Drawing;
using System.Windows.Forms;
using static SixLabors.ImageSharp.Image;

namespace Translator_Selenium.ocr
{
    internal class loading_image
    {
        public static IronTesseract ocr = new IronTesseract();
        public static OcrInput ocrInput = new OcrInput();
        public static SixLabors.ImageSharp.Image image;
        public static string load_picure(OpenFileDialog openFileDialog1, Label image_status, ComboBox combo)
        {
            //ocr.Language = OcrLanguage.Russian;
            choose_lang(ocr, combo);
            //loading image
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                image = new AnyBitmap(openFileDialog1.FileName);
            }

            image_status.Text = "Image is loaded";

            //using ocr
            ocrInput.AddImage(image);
            OcrResult result = ocr.Read(ocrInput);

            return result.Text;
        }

        public static void choose_lang(IronTesseract ocr, ComboBox combo)
        {
            if (combo.Text == "")
            {
                MessageBox.Show("Please, choose language", "Language error", MessageBoxButtons.OK);
            }

            if (combo.Text == "Russian")
            {
                ocr.Language = OcrLanguage.Russian;
            }

            if (combo.Text == "English")
            {
                ocr.Language = OcrLanguage.English;
            }

            if (combo.Text == "Spanish")
            {
                ocr.Language = OcrLanguage.Spanish;
            }

            if (combo.Text == "German")
            {
                ocr.Language = OcrLanguage.German;
            }

            if (combo.Text == "Chinese")
            {
                ocr.Language = OcrLanguage.ChineseSimplified;
            }

            if (combo.Text == "Japanese")
            {
                ocr.Language = OcrLanguage.Japanese;
            }

        }
    }
}
