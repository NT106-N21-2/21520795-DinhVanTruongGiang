using HtmlAgilityPack;
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
    public partial class Ex4_DowloadFiles : Form
    {
        static string URL;
        static List<string> files;
        public Ex4_DowloadFiles(string url)
        {
            InitializeComponent();
            URL = url;
        }

        private void UpdateFileList()
        {
            richTextBox1.Clear();
            foreach (string file in files)
            {
                richTextBox1.AppendText(file + Environment.NewLine);
            }
        }
        private void btnDowload_Click(object sender, EventArgs e)
        {
            //tạo đường dẫn thư mục lưu file
            string savePath = Path.Combine(Application.StartupPath, "DownloadedFiles");
            if (!Directory.Exists(savePath)) Directory.CreateDirectory(savePath);

            try
            {
                //tạo đối tượng webclient để tải file
                using (WebClient myClient = new WebClient())
                {
                    myClient.Encoding = System.Text.Encoding.UTF8;

                    //tạo và load nội dung html lên đối tượng HtmlDocument
                    HtmlAgilityPack.HtmlDocument htmlDoc = new HtmlAgilityPack.HtmlDocument();
                    string html = myClient.DownloadString(URL);
                    htmlDoc.LoadHtml(html);

                    files = new List<string>();

                    if (htmlDoc != null)
                    {
                        //tìm kiếm các node
                        HtmlAgilityPack.HtmlNodeCollection htmlNodes = htmlDoc.DocumentNode.SelectNodes(textBox1.Text);
                        if (htmlNodes != null && htmlNodes.Count > 0)
                        {
                            foreach (var node in htmlNodes)
                            {
                                string fileURL = node.GetAttributeValue("src", "");
                                if (string.IsNullOrEmpty(fileURL))
                                {
                                    //chỉ hiển thị nội dung node
                                    string innerText = node.InnerText;
                                    if (!string.IsNullOrEmpty(innerText)) files.Add(innerText);
                                }
                                else
                                {
                                    //kiểm tra đường dẫn tuyệt đối
                                    if (!Uri.IsWellFormedUriString(fileURL, UriKind.Absolute))
                                        fileURL = new Uri(new Uri(URL), fileURL).AbsoluteUri;

                                    //Tạo filename và filepath để lưu file
                                    string fileName = Path.GetFileName(fileURL);
                                    string filePath = Path.Combine(savePath, fileName);

                                    //tải file
                                    myClient.DownloadFile(fileURL, filePath);

                                    //đưa vào list view
                                    files.Add(fileName);
                                }
                            }
                            MessageBox.Show("Completed");
                        }
                        else
                        {
                            MessageBox.Show("Can't find any " + textBox1.Text + " items!");
                        }
                    }
                }
                UpdateFileList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
