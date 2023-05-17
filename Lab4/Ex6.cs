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
using static Lab4.Ex6;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab4
{
    public partial class Ex6 : Form
    {
        private HtmlWeb htmlWeb;
        private List<Article> articles; //Lưu thông tin của từng bài báo
        public Ex6()
        {
            InitializeComponent();
            htmlWeb = new HtmlWeb();
            articles = new List<Article>();
        }
        public class Article
        {
            //Tạo các biến để lưu thông tin Title, Description, Link của từng bài báo
            public string Title { get; set; }
            public string Description { get; set; }
            public string Link { get; set; }

            public Article(string title, string description, string link)
            {
                Title = title;
                Description = description;
                Link = link;
            }
        }
        //Tạo hàm chạy Progress Bar
        private async Task RunProgress()
        {
            // Thực hiện công việc chạy từ đầu tới cuối
            for (int i = 0; i <= 100; i++)
            {
                // Thiết lập giá trị hiện tại của ProgressBar
                prgBar.Value = i;

                // Dừng một chút để thấy thanh progress chạy
                await Task.Delay(1); // Đợi 1 milliseconds (0.001 giây)
            }
        }
        private async void btnGet_Click(object sender, EventArgs e)
        {
            prgBar.Visible = true; //Khi bắt đầu phân tích HTML thì bật Progress Bar lên
            await RunProgress();
            string url = txtUrl.Text;
            if (!string.IsNullOrEmpty(url))
            {
                btnGet.Enabled = false; //Trong khi phân tích, không cho user sử dụng button Get
                await LoadWebsite(url);
                btnGet.Enabled = true; //Bật lại button Get sau khi thực hiện phân tích xong
            }
            prgBar.Visible = false; //Tắt Progress Bar
        }
        private async Task LoadWebsite(string url)
        {
            var htmlDoc = htmlWeb.Load(url);

            //  lấy tất cả các phần tử trong tài liệu HTML
            //có thuộc tính id="automation_TV0" và đường dẫn xpath là "div[2]/article"
            //  Đây là mã nguồn của từng bài báo
            var articleNodes = htmlDoc.DocumentNode.SelectNodes("//*[@id=\"automation_TV0\"]/div[2]/article");

            // Xóa các Control cũ trong Panel
            panelArticles.Controls.Clear();

            int groupBoxTop = 10; // Đặt vị trí top ban đầu cho GroupBox

            foreach (var articleNode in articleNodes)
            {
                var titleNode = articleNode.SelectSingleNode("./h2/a");
                var descriptionNode = articleNode.SelectSingleNode("./p");
                var imageNode = articleNode.SelectSingleNode(".//img");

                if (titleNode != null && descriptionNode != null && imageNode != null)
                {
                    var title = titleNode.InnerText;
                    var description = descriptionNode.InnerText;
                    var link = titleNode.GetAttributeValue("href", "");
                    var imageUrl = imageNode.GetAttributeValue("src", "");

                    GroupBox groupBox = new GroupBox();
                    groupBox.AutoSize = true;
                    groupBox.Text = null;
                    groupBox.Location = new Point(10, groupBoxTop); // Đặt vị trí cho GroupBox

                    panelArticles.Controls.Add(groupBox);

                    // Tạo PictureBox để hiển thị hình ảnh
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.ImageLocation = imageUrl;
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.Size = new Size(200, 150);
                    pictureBox.Location = new Point(10, 50); // Điều chỉnh vị trí PictureBox
                    groupBox.Controls.Add(pictureBox);

                    //Tạo Label để hiển thị Title
                    Label titleLabel = new Label();
                    titleLabel.Text = title;
                    titleLabel.Font = new Font(titleLabel.Font.FontFamily, 14, FontStyle.Bold); // Phóng to cỡ chữ
                    titleLabel.AutoSize = true;
                    titleLabel.MaximumSize = new Size(729 - 20, 0);
                    titleLabel.Location = new Point(220, 50); // Điều chỉnh vị trí tiêu đề
                    groupBox.Controls.Add(titleLabel);

                    //Tạo Label để hiển thị Description
                    Label descriptionLabel = new Label();
                    descriptionLabel.Text = description;
                    descriptionLabel.AutoSize = true;
                    descriptionLabel.Font = new Font(descriptionLabel.Font.FontFamily, 12);
                    descriptionLabel.MaximumSize = new Size(729 - 20, 0); // Giới hạn kích thước của Label
                    descriptionLabel.Location = new Point(220, titleLabel.Bottom + 10); // Điều chỉnh vị trí mô tả
                    groupBox.Controls.Add(descriptionLabel);

                    //Tạo Link Label để thêm phần "Read more"
                    LinkLabel readMoreLinkLabel = new LinkLabel();
                    readMoreLinkLabel.Text = "Read more";
                    readMoreLinkLabel.AutoSize = true;
                    readMoreLinkLabel.Location = new Point(10, descriptionLabel.Bottom + 10); // Điều chỉnh vị trí "Read more"
                    groupBox.Controls.Add(readMoreLinkLabel);

                    readMoreLinkLabel.LinkClicked += (sender, e) =>
                    {
                        // Xử lý sự kiện khi nhấp vào liên kết "Read more"
                        Ex6_WebNews webNews = new Ex6_WebNews(link, title);
                        webNews.ShowDialog();
                        //webNews.CoreWebView2.Navigate(link);
                    };

                    // Giới hạn độ rộng của GroupBox bằng độ rộng của Panel chính - 10
                    groupBox.Width = panelArticles.Width - 10;

                    groupBoxTop += groupBox.Height + 10; // Tăng vị trí top cho GroupBox tiếp theo
                }
            }
        }

    }

}

