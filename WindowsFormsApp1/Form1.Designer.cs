
using Parser.Core;

namespace WindowsFormsApp1
{
    partial class ParserForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        ParserWorker<string[]> parser;

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
            this.ParseButton = new System.Windows.Forms.Button();
            this.UrlText = new System.Windows.Forms.TextBox();
            this.Browser = new System.Windows.Forms.WebBrowser();
            this.ListTitles = new System.Windows.Forms.ListBox();
            this.Validator = new System.Windows.Forms.RichTextBox();
            this.listLinks = new System.Windows.Forms.ListBox();
            this.listImg = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ParseButton
            // 
            this.ParseButton.Location = new System.Drawing.Point(590, 9);
            this.ParseButton.Name = "ParseButton";
            this.ParseButton.Size = new System.Drawing.Size(75, 23);
            this.ParseButton.TabIndex = 0;
            this.ParseButton.Text = "Parse";
            this.ParseButton.UseVisualStyleBackColor = true;
            this.ParseButton.Click += new System.EventHandler(this.button1_ClickAsync);
            // 
            // UrlText
            // 
            this.UrlText.Location = new System.Drawing.Point(344, 12);
            this.UrlText.Name = "UrlText";
            this.UrlText.Size = new System.Drawing.Size(240, 20);
            this.UrlText.TabIndex = 2;
            this.UrlText.Text = "https://habrahabr.ru";
            // 
            // Browser
            // 
            this.Browser.Location = new System.Drawing.Point(1, 44);
            this.Browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.Browser.Name = "Browser";
            this.Browser.ScriptErrorsSuppressed = true;
            this.Browser.Size = new System.Drawing.Size(499, 603);
            this.Browser.TabIndex = 1;
            this.Browser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.Browser_DocumentCompleted);
            // 
            // ListTitles
            // 
            this.ListTitles.FormattingEnabled = true;
            this.ListTitles.Location = new System.Drawing.Point(608, 690);
            this.ListTitles.Name = "ListTitles";
            this.ListTitles.Size = new System.Drawing.Size(311, 147);
            this.ListTitles.TabIndex = 4;
            // 
            // Validator
            // 
            this.Validator.Location = new System.Drawing.Point(506, 44);
            this.Validator.Name = "Validator";
            this.Validator.ReadOnly = true;
            this.Validator.Size = new System.Drawing.Size(413, 603);
            this.Validator.TabIndex = 5;
            this.Validator.Text = "";
            // 
            // listLinks
            // 
            this.listLinks.FormattingEnabled = true;
            this.listLinks.Location = new System.Drawing.Point(12, 690);
            this.listLinks.Name = "listLinks";
            this.listLinks.Size = new System.Drawing.Size(259, 147);
            this.listLinks.TabIndex = 6;
            // 
            // listImg
            // 
            this.listImg.FormattingEnabled = true;
            this.listImg.Location = new System.Drawing.Point(317, 690);
            this.listImg.Name = "listImg";
            this.listImg.Size = new System.Drawing.Size(245, 147);
            this.listImg.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(724, 665);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Статистика";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 665);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ссылки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(393, 665);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Картинки";
            // 
            // ParserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 849);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listImg);
            this.Controls.Add(this.listLinks);
            this.Controls.Add(this.Validator);
            this.Controls.Add(this.ListTitles);
            this.Controls.Add(this.Browser);
            this.Controls.Add(this.UrlText);
            this.Controls.Add(this.ParseButton);
            this.Name = "ParserForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ParseButton;
        private System.Windows.Forms.TextBox UrlText;
        private System.Windows.Forms.WebBrowser Browser;
        private System.Windows.Forms.ListBox ListTitles;
        private System.Windows.Forms.RichTextBox Validator;
        private System.Windows.Forms.ListBox listLinks;
        private System.Windows.Forms.ListBox listImg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

