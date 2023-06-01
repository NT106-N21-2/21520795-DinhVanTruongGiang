using MailKit.Net.Imap;
using MailKit.Net.Pop3;
using MailKit;
using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Ex3 : Form
    {
        private List<MimeMessage> allEmails; // Danh sách tất cả các email
        private int currentPage = 1; // Trang hiện tại
        private int emailsPerPage = 50; // Số lượng email trên mỗi trang
        public Ex3()
        {
            InitializeComponent();

            lv_yourMail.View = View.Details;
            lv_yourMail.Columns.Add("Email", 300);
            lv_yourMail.Columns.Add("From", 250);
            lv_yourMail.Columns.Add("Time", 300);

            allEmails = new List<MimeMessage>();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            btn_Login.Enabled = false;

            //Đọc mail bằng IMAP
            if (cmb_Protocol.SelectedIndex == 0)
            {
                var client = new ImapClient();
                client.Connect("imap.gmail.com", 993, true);
                try
                {
                    client.Authenticate(tb_Email.Text, tb_Password.Text);
                    var inbox = client.Inbox;
                    inbox.Open(FolderAccess.ReadOnly);
                    // Xóa danh sách email cũ và lấy danh sách email mới
                    allEmails.Clear();
                    for (int i = inbox.Count - 1; i >= 0; i--)
                    {
                        var message = inbox.GetMessage(i);
                        allEmails.Add(message);
                    }
                    // Hiển thị danh sách email trên trang đầu tiên
                    currentPage = 1;
                    ShowEmailsByPage(currentPage);
                    lb_Recent.Text = "Recent: ";
                    lb_recentEmail.Text = inbox.Recent.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid email or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_Email.Clear();
                    tb_Password.Clear();
                }
            }

            //Đọc mail bằng POP
            else if (cmb_Protocol.SelectedIndex == 1)
            {
                var client = new Pop3Client();
                client.Connect("pop.gmail.com", 995, true);
                try
                {
                    client.Authenticate(tb_Email.Text, tb_Password.Text);


                    // Xóa danh sách email cũ và lấy danh sách email mới
                    allEmails.Clear();
                    int messageCount = client.GetMessageCount();
                    for (int i = messageCount - 1; i >= 0; i--)
                    {
                        var message = client.GetMessage(i);
                        allEmails.Add(message);
                    }

                    // Hiển thị danh sách email trên trang đầu tiên
                    currentPage = 1;
                    ShowEmailsByPage(currentPage);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid email or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_Email.Clear();
                    tb_Password.Clear();
                }
            }
            btn_Login.Enabled = true;
        }
        private void ShowEmailsByPage(int page)
        {
            // Xóa tất cả các email đang hiển thị trong ListView
            lv_yourMail.Items.Clear();

            // Tính chỉ số bắt đầu và chỉ số kết thúc của danh sách email trên trang hiện tại
            int startIndex = (page - 1) * emailsPerPage;
            int endIndex = startIndex + emailsPerPage - 1;
            if (endIndex >= allEmails.Count)
            {
                endIndex = allEmails.Count - 1;
            }

            // Hiển thị các email trên trang hiện tại
            for (int i = startIndex; i <= endIndex; i++)
            {
                var message = allEmails[i];

                // Tạo một ListViewItem với Subject của email
                var item = new ListViewItem(message.Subject);
                // Thêm dữ liệu vào cột From
                item.SubItems.Add(message.From.ToString());
                // Thêm dữ liệu vào cột thời gian
                item.SubItems.Add(message.Date.ToString());

                lv_yourMail.Items.Add(item);
            }

            // Cập nhật thông tin về trang hiện tại và số lượng email đã hiển thị
            int totalEmails = allEmails.Count;
            int begin = page * 50 - 49;
            int end = page * 50;
            lb_Page.Text = begin.ToString() + "-" + end.ToString() + " of " + totalEmails;
            lb_totalEmail.Text = totalEmails.ToString();
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            int totalPages = (int)Math.Ceiling((double)allEmails.Count / emailsPerPage);
            if (currentPage < totalPages)
            {
                currentPage++;
                ShowEmailsByPage(currentPage);
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                ShowEmailsByPage(currentPage);
            }
        }

        private void cmb_Protocol_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Reset biến và xóa danh sách email
            allEmails = new List<MimeMessage>();
            currentPage = 1;
            lv_yourMail.Items.Clear();
            lb_Page.Text = "";
            lb_Recent.Text = "";
            lb_recentEmail.Text = "";
            lb_totalEmail.Text = "";
        }
    }

}
