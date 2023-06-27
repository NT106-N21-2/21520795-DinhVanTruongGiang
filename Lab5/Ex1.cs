using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using MailKit.Net.Smtp;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using SmtpClient = MailKit.Net.Smtp.SmtpClient;
using MailKit.Net.Imap;
using System.Net;

namespace Lab5
{
    public partial class Ex1 : Form
    {
        public Ex1()
        {
            InitializeComponent();
            btn_Send.Enabled = false;
            tb_Sender.Enabled = false;
            tb_Receiver.Enabled = false;
            tb_subjectContent.Enabled = false;
            rtb_bodyContent.Enabled = false;
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            try
            {
                // Sử dụng Smtp để gửi mail
                var client = new SmtpClient();
                client.Connect("smtp.gmail.com", 465, true);
                //Xác thực email
                client.Authenticate(tb_Email.Text, tb_Password.Text);

                //Thiết lập cho mail
                var message = new MimeMessage();

                var sender_Name = tb_Email.Text.Split('@')[0];
                message.From.Add(new MailboxAddress(sender_Name, tb_Email.Text));

                var receiver_Name = tb_Receiver.Text.Split('@')[0];
                message.To.Add(new MailboxAddress(receiver_Name, tb_Receiver.Text));

                message.Subject = tb_subjectContent.Text;
                message.Body = new TextPart("plain")
                {
                    Text = rtb_bodyContent.Text,
                };
                //Gửi mail
                client.Send(message);
                //Thiết lập các ràng buộc và xử lý ngoại lệ
                if (string.IsNullOrEmpty(tb_Receiver.Text) ||
                    string.IsNullOrEmpty(tb_subjectContent.Text) ||
                    string.IsNullOrEmpty(rtb_bodyContent.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "MAIL KHÔNG HỢP LỆ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                MessageBox.Show("Mail đã được gửi đi thành công!", "ĐÃ GỬI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "GỬI THẤT BẠI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_Receiver.Clear();
                tb_subjectContent.Clear();
                rtb_bodyContent.Clear();
            }
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_Email.Text) || string.IsNullOrEmpty(tb_Password.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "ĐĂNG NHẬP THẤT BẠI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_Email.Clear();
                tb_Password.Clear();
                return;
            }

            using (var client = new ImapClient())
            {
                try
                {
                    client.Connect("imap.gmail.com", 993, true);

                    //chứa thông tin xác thực người dùng
                    var networkCredential = new NetworkCredential(tb_Email.Text, tb_Password.Text);
                    //Xác thực người dùng
                    client.Authenticate(networkCredential);
                    MessageBox.Show("Đăng nhập thành công!", "THÀNH CÔNG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btn_Login.Enabled = false;
                    tb_Email.Enabled = false;
                    tb_Password.Enabled = false;

                    btn_Send.Enabled = true;
                    tb_Sender.Enabled = true;
                    tb_Receiver.Enabled = true;
                    tb_subjectContent.Enabled = true;
                    rtb_bodyContent.Enabled = true;
                    tb_Sender.Text = tb_Email.Text;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Email hoặc mật khẩu không hợp lệ!", "ĐĂNG NHẬP THẤT BẠI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_Email.Clear();
                    tb_Password.Clear();
                }
            }
        }
    }
}
