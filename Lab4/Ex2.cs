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
    public partial class Ex2 : Form
    {
        private HttpClient httpClient;
        public Ex2()
        {
            InitializeComponent();
            //Tạo HttpClient và đưa cái đường dẫn tới trang đề bài yêu cầu vô (thiết lập base address cho nó)
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://www.contoso.com/PostAccepter.aspx");

        }
        private async void btn_Post_Click(object sender, EventArgs e)
        {
            try
            {
                //Tạo yêu cầu post với nội dung là nội dung lấy từ tb_Data mà người dùng nhập vô
                HttpContent request = new StringContent(tb_Data.Text, Encoding.UTF8, "application/x-www-form-urlencoded");

                //Gửi yêu cầu post
                HttpResponseMessage response = await httpClient.PostAsync("", request);
                response.EnsureSuccessStatusCode();

                /* //check xem post thành công không
                 //Lấy mã trạng thái
                 HttpStatusCode statusCode = response.StatusCode;
                 //Hiển thị mã trạng thái
                 MessageBox.Show($"Status code: {(int)statusCode} - {statusCode}", "Status Code", MessageBoxButtons.OK, MessageBoxIcon.Information);
 */
                //Đọc nội dung của response
                string responseContent = await response.Content.ReadAsStringAsync();
                //Hiển thị nội dung của response ra RichTextBox
                rtb_Response.Text = responseContent;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Ex2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose(true);
        }
    }
}
