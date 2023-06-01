using MimeKit;
//using MailKit.Net.Smtp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Ex4_SendEmail : Form
    {
        private MailMessage mailMessage;
        private string smtpAddress;
        private int smtpPort;
        private string passwd = "";
        public Ex4_SendEmail(string from, string smtpAdd, string pass, int port)
        {
            InitializeComponent();
            tb_From.Text = from;
            smtpPort = port;
            passwd = pass;
            smtpAddress = smtpAdd;
        }

        private void bt_Clear_Click(object sender, EventArgs e)
        {
            rtb_Body.Clear();
        }

        private void bt_Send_Click(object sender, EventArgs e)
        {
            try
            {
                SmtpClient smtpClient = new SmtpClient(smtpAddress, smtpPort);
                smtpClient.UseDefaultCredentials = false;
                smtpClient.EnableSsl = true;
                smtpClient.Credentials = new System.Net.NetworkCredential(tb_From.Text, passwd);


                //Kiểm tra Các thành phần
                if (string.IsNullOrEmpty(tb_To.Text) || string.IsNullOrEmpty(rtb_Body.Text) || string.IsNullOrEmpty(tb_Sub.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                }
                //tạo mail mess
                mailMessage = new MailMessage();
                mailMessage.From = new MailAddress(tb_From.Text);
                mailMessage.To.Add(new MailAddress(tb_To.Text));
                mailMessage.Subject = tb_Sub.Text;
                mailMessage.Body = rtb_Body.Text;

                //kiểm tra HTML?
                if (cb_HTML.Checked)
                {
                    mailMessage.IsBodyHtml = true;
                }
                else
                {
                    mailMessage.IsBodyHtml = false;                    
                }

                //đính kèm file
                if (attachmentListBox.Items.Count > 0)
                {
                    foreach (string filePath in attachmentListBox.Items)
                    {
                        Attachment attachment = new Attachment(filePath);
                        mailMessage.Attachments.Add(attachment);
                    }
                }

                smtpClient.Send(mailMessage);
                MessageBox.Show("Gửi thành công!");
                mailMessage.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //Clearform
            tb_To.Clear();
            tb_Sub.Clear();
            rtb_Body.Clear();
            attachmentListBox.Items.Clear();
        }

        private void bt_ClearAttachment_Click(object sender, EventArgs e)
        {
            attachmentListBox.Items.Clear();
        }

        private void bt_Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                attachmentListBox.Items.Add(filePath);
            }
        }

        private void bt_ClearAttch_Click(object sender, EventArgs e)
        {
            if (attachmentListBox.SelectedIndex >= 0)
            {
                attachmentListBox.Items.RemoveAt(attachmentListBox.SelectedIndex);
            }
        }
    }
}
