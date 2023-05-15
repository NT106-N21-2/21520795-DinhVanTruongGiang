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
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab4
{
    public partial class Ex4 : Form
    {
        public Ex4()
        {
            InitializeComponent();
        }
        private void Ex4_Load(object sender, EventArgs e)
        {
            InitBrowser();
        }
        private async Task initizated()
        {
            await webView21.EnsureCoreWebView2Async(null);
        }
        public async void InitBrowser()
        {
            await initizated();
        }
        private void btnViewWeb_Click(object sender, EventArgs e)
        {
            try
            {
                webView21.CoreWebView2.Navigate(tbxURL.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            webView21.GoBack();
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            webView21.GoForward();
        }

        private void btnViewSource_Click(object sender, EventArgs e)
        {
            WebClient myClient = new WebClient();
            Stream response = myClient.OpenRead(tbxURL.Text);

            StreamReader streamReader = new StreamReader(response);
            string Webcontent = streamReader.ReadToEnd();

            Ex4_ViewSourceForm nf = new Ex4_ViewSourceForm(Webcontent);
            nf.ShowDialog();
        }

        private async void btnDownLoad_Click(object sender, EventArgs e)
        {
            Ex4_DowloadFiles nf = new Ex4_DowloadFiles(tbxURL.Text);
            nf.ShowDialog();
        }
    }
}
