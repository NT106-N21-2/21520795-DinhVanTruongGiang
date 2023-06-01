using MailKit;
using MailKit.Net.Imap;
//using MailKit.Net.Smtp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace Lab5
{
    public partial class Ex4 : Form
    {
        public SmtpClient smtpClient;
        public ImapClient imapClient;
        int index = 1;
        IMailFolder inbox;
        public Ex4()
        {
            InitializeComponent();
            listView1.View = View.Details;
            listView1.Columns.Add("#", 60);
            listView1.Columns.Add("Gửi từ", 360);
            listView1.Columns.Add("Tiêu đề", 300);
            listView1.Columns.Add("Thời gian", 360);
            bt_Refresh.Visible = false;
            bt_Send.Visible = false;
        }

        private void Ex4_Load(object sender, EventArgs e)
        {

        }
        private void bt_Log_Click(object sender, EventArgs e)
        {
            if (bt_Log.Text == "Đăng nhập")
            {
                //Kiểm tra username, mật khẩu
                if (string.IsNullOrEmpty(tb_Username.Text)) MessageBox.Show("Vui lòng nhập Email!");
                if (string.IsNullOrEmpty(tb_Passwd.Text)) MessageBox.Show("Vui lòng nhập mật khẩu!");

                //Kiểm tra cài đặt SMTP
                if (string.IsNullOrEmpty(tb_SmtpAddress.Text)) MessageBox.Show("Vui lòng nhập địa chỉ SMTP!");

                try
                {
                    smtpClient = new SmtpClient(tb_SmtpAddress.Text, (int)SMTP_port.Value);
                    smtpClient.EnableSsl = true;
                    smtpClient.Credentials = new NetworkCredential(tb_Username.Text, tb_Passwd.Text);

                    imapClient = new ImapClient();
                    imapClient.Connect(tb_Imap_Address.Text, (int)IMAP_port.Value, true);
                    imapClient.Authenticate(tb_Username.Text, tb_Passwd.Text);

                    inbox = imapClient.Inbox;
                    inbox.Open(FolderAccess.ReadOnly);

                    travelser();

                    bt_Log.Text = "Đăng xuất";
                    bt_Refresh.Visible = true;
                    bt_Send.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    tb_Username.Clear();
                    tb_Passwd.Clear();
                }
            }
            else
            {
                // Clear the stored credentials
                smtpClient.Credentials = null;
                imapClient = null;

                // Optional: Close any open connections or sessions with the server
                smtpClient.Dispose();

                if (imapClient != null) imapClient.Dispose();
                imapClient = null;

                // Show a message to indicate successful logout
                MessageBox.Show("Đã đăng xuất!");
                listView1.Items.Clear();
                //listView1.Clear();
                index = 1;
                bt_Log.Text = "Đăng nhập";
                bt_Refresh.Visible = false;
                bt_Send.Visible = false;
            }
        }

        private void bt_Back_Click(object sender, EventArgs e)
        {
            index -= 1;
            travelser();

            page.Text = (index * 30 - 30 + 1).ToString() + " - " + (index * 30).ToString();

            if (index <= 1) bt_Back.Enabled = false;
            if (index * 30 < inbox.Count) bt_Next.Enabled = true;
        }

        private void bt_Next_Click(object sender, EventArgs e)
        {
            index += 1;
            travelser();
            page.Text = (index * 30 - 30 + 1).ToString() + " - " + (index * 30).ToString();

            if (index * 30 >= inbox.Count) bt_Next.Enabled = false;
            if (index > 1) bt_Back.Enabled = true;
        }
        private void travelser()
        {
            listView1.Items.Clear();

            for (int i = inbox.Count - index * 30 + 29; (i >= 0) && (i >= inbox.Count - index * 30); i--)
            {
                var message = inbox.GetMessage(i);

                // Tạo một ListViewItem với Subject của email
                var item = new ListViewItem((inbox.Count - i).ToString());
                //thêm vào cột Gửi từ
                item.SubItems.Add(message.From.ToString());
                // Thêm dữ liệu vào cột Tiêu đề
                item.SubItems.Add(message.Subject.ToString());
                // Thêm dữ liệu vào cột thời gian
                item.SubItems.Add(message.Date.ToString());

                listView1.Items.Add(item);
            }
        }

        private void bt_Refresh_Click(object sender, EventArgs e)
        {
            index = 1;
            travelser();
        }

        private void bt_Send_Click(object sender, EventArgs e)
        {
            Ex4_SendEmail sendMailForm = new Ex4_SendEmail(tb_Username.Text, "", tb_SmtpAddress.Text, tb_Passwd.Text, (int)SMTP_port.Value);
            //bt_Log_Click(sender,e);
            sendMailForm.ShowDialog();
        }

        //private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (listView1.SelectedItems.Count > 0)
        //    {
        //        ListViewItem message = listView1.SelectedItems[0];
        //        int messageID = int.Parse(message.SubItems[0].Text);
        //        var mailMessage = inbox.GetMessage(inbox.Count - messageID);
        //        Ex4_MailView ex4_MailView = new Ex4_MailView(mailMessage);
        //        ex4_MailView.ShowDialog();
        //    }
        //}

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem message = listView1.SelectedItems[0];
            int messageID = int.Parse(message.SubItems[0].Text);
            var mailMessage = inbox.GetMessage(inbox.Count - messageID);
            Ex4_MailView ex4_MailView = new Ex4_MailView(mailMessage);
            ex4_MailView.ShowDialog();
        }
    }
}
