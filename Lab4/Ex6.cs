using HtmlAgilityPack;
using Microsoft.Web.WebView2.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Ex6 : Form
    {
        public Ex6()
        {
            InitializeComponent();
            webNews.EnsureCoreWebView2Async();
            webNews.NavigationCompleted += WebNews_NavigationCompleted;
        }

        private async Task<string> getHTML(string szURL)
        {
            // Create a request for the URL.
            WebRequest request = WebRequest.Create(szURL);
            // Get the response.
            WebResponse response = await request.GetResponseAsync();
            // Get the stream containing content returned by the server.
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = await reader.ReadToEndAsync();
            // Close the response.
            response.Close();
            return responseFromServer;
        }
        public class ArticlePanel : FlowLayoutPanel
        {
            public string url { get; set; }
        }

        private async void btnGet_Click(object sender, EventArgs e)
        {
            // Gọi hàm GetHTML
            string htmlContent = await getHTML(textURL.Text);

            // Trong lúc tải web thì bntGet sẽ không khả dụng
            btnGet.Enabled = false;

            while (flowLayoutPanel.Controls.Count > 0)
            {
                var control = flowLayoutPanel.Controls[0];
                flowLayoutPanel.Controls.Remove(control);
                control.Dispose();
            }
            webNews.CoreWebView2.ExecuteScriptAsync("document.body.innerHTML = '';");
            webNews.CoreWebView2.Navigate("about:blank");

            // Hiển thị progress bar khi đang tải dữ liệu trang web
            prgBar.Visible = true;
            prgBar.Value = 0;

            // Bắt đầu tải và phân tích website
            string url = textURL.Text;
            var web = new HtmlWeb();
            var doc = web.Load(url);

            // Trích xuất các bài báo
            var articles = doc.DocumentNode.Descendants("article")
                .Where(d => d.Attributes.Contains("class") && d.Attributes["class"].Value.Contains("item-news-common"));

            foreach (var article in articles)
            {
                string title = article.Descendants("h2").FirstOrDefault()?.InnerText;
                string description = article.Descendants("p").FirstOrDefault()?.InnerText;
                /*string imageUrl = article.Descendants("img")
                    .Where(d => d.Attributes.Contains("itemprop") && d.Attributes["itemprop"].Value == "contentUrl")
                    .Select(d => d.Attributes["src"].Value)
                    .FirstOrDefault();*/

                var panel = new ArticlePanel();
                //lấy url của từng news
                panel.url = article.Descendants("h2").FirstOrDefault()?.Descendants("a").FirstOrDefault()?.GetAttributeValue("href", "");

                panel.FlowDirection = FlowDirection.TopDown;
                panel.AutoSize = true;
                panel.BackColor = Color.LightGray;
                /*if (!string.IsNullOrEmpty(imageUrl))
                {
                    var pictureBox = new PictureBox();
                    pictureBox.Load(imageUrl);
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox.Width = 100;
                    pictureBox.Height = 100;
                    panel.Controls.Add(pictureBox);
                }*/

                if (!string.IsNullOrEmpty(title))
                {
                    var titleLabel = new Label();
                    titleLabel.Text = title;
                    titleLabel.AutoSize = true;
                    titleLabel.Font = new Font(titleLabel.Font.FontFamily, titleLabel.Font.Size, FontStyle.Bold);
                    panel.Controls.Add(titleLabel);
                }

                if (!string.IsNullOrEmpty(description))
                {
                    var descriptionLabel = new Label();
                    descriptionLabel.Text = description;
                    descriptionLabel.AutoSize = true;
                    panel.Controls.Add(descriptionLabel);
                }


                flowLayoutPanel.Controls.Add(panel);

                panel.Click += Panel_Click;
                foreach (Control childControl in panel.Controls)
                {
                    childControl.Click += Panel_Click;
                }
            }

            // Ẩn progress bar
            prgBar.Visible = false;

            // Cho phép bntGet khả dụng
            btnGet.Enabled = true;
        }
        private void Panel_Click(object sender, EventArgs e)
        {
            if (sender is ArticlePanel panel)
            {
                webNews.CoreWebView2.Navigate(panel.url);
            }
        }
        private async void WebNews_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            // Clear the content of the current webpage in WebView2
            await webNews.CoreWebView2.ExecuteScriptAsync("document.body.innerHTML = '';");

            // Update the label with the title of the web page
            //lblTitle.Text = await webNews.CoreWebView2.ExecuteScriptAsync("document.title");
        }

    }

}

