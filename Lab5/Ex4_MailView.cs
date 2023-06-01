using MimeKit;
using MailKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace Lab5
{
    public partial class Ex4_MailView : Form
    {
        MimeMessage Message;
        private string smtpAddress;
        private string passwd = "";
        public Ex4_MailView(MimeMessage message, string smtpAdd, string password)
        {
            InitializeComponent();
            Message = message;
            passwd = password;
            smtpAddress = smtpAdd;

            tb_From.Text = message.From.ToString();
            tb_To.Text = message.To.ToString();
            tb_Sub.Text = message.Subject.ToString();
            if (message.HtmlBody != null)
            {
                richTextBox1.Visible = false;
                string tempPath = Path.Combine(Path.GetTempPath(), "temp.html");
                File.WriteAllText(tempPath, message.HtmlBody.ToString());

                webView21.Source = new Uri(tempPath);
            }
            else
            if (message.TextBody != null)
            {
                webView21.Visible = false;
                richTextBox1.Text = (message.TextBody);
            }
            if (message.Attachments != null)
            {
                foreach (var attachment in message.Attachments)
                {
                    if (attachment is MimePart mimePart)
                        listBox1.Items.Add(mimePart.FileName);
                }
            }
        }
        private void bt_Rep_Click(object sender, EventArgs e)
        {
            Ex4_SendEmail ex4_SendEmail = new Ex4_SendEmail(Message.To.ToString(), Message.From.ToString(),smtpAddress,passwd);
            ex4_SendEmail.ShowDialog();
        }

        private void bt_Download_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0)
            {
                try
                {
                    foreach (var item in Message.Attachments)
                    {
                        if (item is MimePart mimePart)
                            if (mimePart.FileName == listBox1.SelectedItem.ToString())
                            {
                                var filePath = Path.Combine("C:\\Users\\admin\\Downloads", mimePart.FileName);
                                using (var stream = File.Create(filePath))
                                {
                                    mimePart.WriteTo(stream);
                                }
                            }
                    }
                    MessageBox.Show("Download successfully!");
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0)
            {
                try
                {
                    foreach (var item in Message.Attachments)
                    {
                        if (item is MimePart mimePart)
                        {
                            var filePath = Path.Combine("C:\\Users\\admin\\Downloads", mimePart.FileName);
                            using (var stream = File.Create(filePath))
                            {
                                mimePart.WriteTo(stream);
                            }
                        }
                    }
                    MessageBox.Show("Download successfully!");
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }
    }
}
