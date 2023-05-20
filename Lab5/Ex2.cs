using System.Net.Mail;
using MailKit.Net.Imap;
using MailKit;

namespace Lab5
{
    public partial class Ex2 : Form
    {
        public Ex2()
        {
            InitializeComponent();

            lv_yourMail.View = View.Details;
            lv_yourMail.Columns.Add("Email", 300);
            lv_yourMail.Columns.Add("From", 250);
            lv_yourMail.Columns.Add("Time", 300);
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            var client = new ImapClient();
            client.Connect("imap.gmail.com", 993, true);
            try
            {
                client.Authenticate(tb_Email.Text, tb_Password.Text);
                var inbox = client.Inbox;
                inbox.Open(FolderAccess.ReadOnly);
                lb_totalEmail.Text = inbox.Count.ToString();
                lb_recentEmail.Text = inbox.Recent.ToString();
                for (int i = inbox.Count - 1; i >= 0; i--)
                {
                    var message = inbox.GetMessage(i);

                    // Tạo một ListViewItem với Subject của email
                    var item = new ListViewItem(message.Subject);
                    // Thêm dữ liệu vào cột From
                    item.SubItems.Add(message.From.ToString());
                    // Thêm dữ liệu vào cột thời gian
                    item.SubItems.Add(message.Date.ToString());

                    lv_yourMail.Items.Add(item);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid email or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_Email.Clear();
                tb_Password.Clear();
            }
        }

        private void Ex2_Load(object sender, EventArgs e)
        {

        }
    }
}