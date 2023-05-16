using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace Lab4
{
    public partial class Ex6_WebNews : Form
    {
        static string URL;
        public Ex6_WebNews(string url)
        {
            InitializeComponent();
            InitializeAsync();
            URL = url;
        }
        private async void InitializeAsync()
        {
            await webNews.EnsureCoreWebView2Async(null);
            webNews.CoreWebView2.Navigate(URL);
        }
        private void Ex6_WebNews_Load(object sender, EventArgs e)
        {

        }
    }
}
