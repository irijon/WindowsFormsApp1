using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using AngleSharp;
using AngleSharp.Dom;
using AngleSharp.Html.Dom;
using AngleSharp.Html.Parser;
using Parser.Core;
using Parser.Core.Habra;

namespace WindowsFormsApp1
{
    public partial class ParserForm : Form
    {
        ParserWorker<string[]> par;
        public ParserForm()
        {
            InitializeComponent();
            par = new ParserWorker<string[]>(
                   new HabraParser()
               );
            par.OnCompleted += Parser_OnCompleted;
        }

        private void Parser_OnCompleted(IHtmlDocument document, string html)
        {
            var links = document.QuerySelectorAll("a").OfType<IHtmlAnchorElement>();
            var tables = document.QuerySelectorAll("table").OfType<IHtmlTableElement>();
            var images = document.QuerySelectorAll("img").OfType<IHtmlImageElement>();

            var list = new List<string>();

            list.Add($"Ссылок : " + links.ToArray().Length);
            list.Add($"Таблиц : " + tables.ToArray().Length);
            list.Add($"Картинок : " + images.ToArray().Length);

            Validator.AppendText(html);

            highlightHTMLText();

            ListTitles.Items.AddRange(list.ToArray());
            

            var linksList= new List<string>();
            var imgList = new List<string>();

            foreach (var item in links)
            {
                linksList.Add(item.Href);
            }

            foreach (var item in images.Select(x => x.Attributes["src"]?.Value))
            {
                imgList.Add(item);
            }

            /*foreach (var item in images)
            {
                if (String.IsNullOrEmpty(item.GetAttribute("alt")) || String.IsNullOrWhiteSpace(item.GetAttribute("alt")))
                {
                    int index = Validator.Text.IndexOf("alt");
                    Validator.Select(index, item.OuterHtml.Length);
                    Validator.SelectionColor = Color.Red;
                }
            }*/

            listLinks.Items.AddRange(linksList.ToArray());
            listImg.Items.AddRange(imgList.ToArray());
        }

        private void highlightHTMLText()
        {
            findAndHighlight("<a", Color.Coral);
            findAndHighlight("</a>", Color.Coral);
            findAndHighlight("<img", Color.Yellow);
            findAndHighlight("</img>", Color.Yellow);
            findAndHighlight("<table", Color.Chocolate);
            findAndHighlight("</table>", Color.Chocolate);
            validateImages();
        }

        private void findAndHighlight(string sSearchStr, Color oColor)
        {
            int index = Validator.Text.IndexOf(sSearchStr);
            while (index != -1)
            {
                Validator.Select(index, sSearchStr.Length);
                Validator.SelectionColor = oColor;

                index = Validator.Text.IndexOf(sSearchStr, index + sSearchStr.Length);
            }
        }

        private void validateImages()
        {
            Regex regex = new Regex("(<img(?!.*?alt=(['\"]).*?2)[^>]*)(>)");
            MatchCollection matches = regex.Matches(Validator.Text);
            foreach(var m in matches)
            {
                int index = Validator.Text.IndexOf(m.ToString());
                Validator.Select(index, m.ToString().Length);
                Validator.SelectionColor = Color.Red;
            }
        }

        private async void button1_ClickAsync(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(UrlText.Text))
            {
                Browser.Navigate(new Uri((string)UrlText.Text));
                ListTitles.Items.Clear();
                par.Settings = new HabraSettings((string)UrlText.Text);
                par.Start();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Browser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
