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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 438);
            this.Controls.Add(this.trans_button);
            this.Controls.Add(this.output_text);
            this.Controls.Add(this.input_text);
            this.Name = "Form1";
            this.Text = "Online Translator v0.1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox input_text;
        private System.Windows.Forms.RichTextBox output_text;
        private System.Windows.Forms.Button trans_button;
    }
}

