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
    public partial class Ex3 : Form
    {
        public Ex3()
        {
            InitializeComponent();
        }

        private void Ex5_Load(object sender, EventArgs e)
        {

        }

        //private static HttpClient myClient = new()
        //{
        //    BaseAddress = new Uri("https://jsonplaceholder.typicode.com"),
        //};
        private void btnDownload_Click(object sender, EventArgs e)
        {
            WebClient myClient = new WebClient();
            try
            {
                Stream response = myClient.OpenRead(tbxURL.Text);
                myClient.DownloadFile(tbxURL.Text, tbxFileURL.Text);
                StreamReader streamReader = new StreamReader(response);
                string Webcontent = streamReader.ReadToEnd();
                textBox3.Text = Webcontent;
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
