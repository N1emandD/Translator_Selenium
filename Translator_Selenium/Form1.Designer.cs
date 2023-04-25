namespace Translator_Selenium
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.input_text = new System.Windows.Forms.RichTextBox();
            this.output_text = new System.Windows.Forms.RichTextBox();
            this.trans_button = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.submit_butt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ocr_detect = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.image_status = new System.Windows.Forms.Label();
            this.ocr_set_lang = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // input_text
            // 
            this.input_text.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.input_text.Location = new System.Drawing.Point(70, 165);
            this.input_text.Name = "input_text";
            this.input_text.Size = new System.Drawing.Size(209, 96);
            this.input_text.TabIndex = 0;
            this.input_text.Text = "";
            // 
            // output_text
            // 
            this.output_text.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.output_text.Location = new System.Drawing.Point(392, 165);
            this.output_text.Name = "output_text";
            this.output_text.Size = new System.Drawing.Size(209, 96);
            this.output_text.TabIndex = 1;
            this.output_text.Text = "";
            // 
            // trans_button
            // 
            this.trans_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.trans_button.Location = new System.Drawing.Point(285, 192);
            this.trans_button.Name = "trans_button";
            this.trans_button.Size = new System.Drawing.Size(101, 40);
            this.trans_button.TabIndex = 2;
            this.trans_button.Text = "Translate";
            this.trans_button.UseVisualStyleBackColor = true;
            this.trans_button.Click += new System.EventHandler(this.trans_button_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(392, 126);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(209, 29);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.TextUpdate += new System.EventHandler(this.comboBox2_TextUpdate);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(70, 126);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(209, 29);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.TextUpdate += new System.EventHandler(this.comboBox1_TextUpdate);
            // 
            // submit_butt
            // 
            this.submit_butt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.submit_butt.Location = new System.Drawing.Point(285, 126);
            this.submit_butt.Name = "submit_butt";
            this.submit_butt.Size = new System.Drawing.Size(101, 29);
            this.submit_butt.TabIndex = 5;
            this.submit_butt.Text = "Submit";
            this.submit_butt.UseVisualStyleBackColor = true;
            this.submit_butt.Click += new System.EventHandler(this.submit_butt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(67, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Russian";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(388, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "English";
            // 
            // ocr_detect
            // 
            this.ocr_detect.Location = new System.Drawing.Point(70, 66);
            this.ocr_detect.Name = "ocr_detect";
            this.ocr_detect.Size = new System.Drawing.Size(209, 34);
            this.ocr_detect.TabIndex = 8;
            this.ocr_detect.Text = "OCR";
            this.ocr_detect.UseVisualStyleBackColor = true;
            this.ocr_detect.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // image_status
            // 
            this.image_status.AutoSize = true;
            this.image_status.Location = new System.Drawing.Point(68, 103);
            this.image_status.Name = "image_status";
            this.image_status.Size = new System.Drawing.Size(0, 13);
            this.image_status.TabIndex = 9;
            // 
            // ocr_set_lang
            // 
            this.ocr_set_lang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ocr_set_lang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ocr_set_lang.FormattingEnabled = true;
            this.ocr_set_lang.Location = new System.Drawing.Point(70, 31);
            this.ocr_set_lang.Name = "ocr_set_lang";
            this.ocr_set_lang.Size = new System.Drawing.Size(209, 29);
            this.ocr_set_lang.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 353);
            this.Controls.Add(this.ocr_set_lang);
            this.Controls.Add(this.image_status);
            this.Controls.Add(this.ocr_detect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.submit_butt);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.trans_button);
            this.Controls.Add(this.output_text);
            this.Controls.Add(this.input_text);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Online Translator v0.9";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox input_text;
        private System.Windows.Forms.RichTextBox output_text;
        private System.Windows.Forms.Button trans_button;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button submit_butt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ocr_detect;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label image_status;
        private System.Windows.Forms.ComboBox ocr_set_lang;
    }
}

