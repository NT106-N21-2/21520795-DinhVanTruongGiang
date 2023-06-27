using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Ex5 : Form
    {
        private int currentPage = 1;
        private int totalPages = 1;
        public Ex5()
        {
            InitializeComponent();
        }
        private string getHTML(string url)
        {
            //Tạo một request đến url 
            WebRequest request = WebRequest.Create(url);
            //Nhận phản hồi (response) từ máy chủ
            WebResponse response = request.GetResponse();
            //Nhận luồng chứa nội dung được trả về từ máy chủ 
            Stream dataStream = response.GetResponseStream();
            //Mở luồng bằng StreamReader để dễ truy cập
            StreamReader reader = new StreamReader(dataStream);
            //Bđ đọc nội dung
            string responseFromServer = reader.ReadToEnd();
            //Đóng
            response.Close();
            return responseFromServer;
        }
        //Thông tin của mỗi một user
        class User
        {
            [JsonPropertyName("id")]
            public int Id { get; set; }
            [JsonPropertyName("email")]
            public string Email { get; set; }
            [JsonPropertyName("first_name")]
            public string FirstName { get; set; }
            [JsonPropertyName("last_name")]
            public string LastName { get; set; }
            [JsonPropertyName("avatar")]
            public string Avatar { get; set; }
        }
        //Dữ liệu của user phân theo trang
        class UserPagination
        {
            //Xác định trang hiện tại
            [JsonPropertyName("page")]
            //Xác định số lượng user trên mỗi trang
            public int Page { get; set; }
            [JsonPropertyName("per_page")]
            //Xác định tổng số user
            public int PerPage { get; set; }
            [JsonPropertyName("total")]
            //Xác định tổng số trang có thể được tạo ra dựa trên số user và số user trên mỗi trang
            public int Total { get; set; }
            [JsonPropertyName("total_pages")]
            //Danh sách các user đại diện cho thông tin của từng user
            public int TotalPages { get; set; }
            [JsonPropertyName("data")]
            public List<User> Data { get; set; }
        }
        private void DisplayUserData(UserPagination userData)
        {
            //Chỉnh nội dung của các label thành giá trị tương ứng
            lb_Page.Text = userData.Page.ToString();
            lb_totalPage.Text = userData.TotalPages.ToString();
            lb_UsersPerPage.Text = userData.PerPage.ToString();
            lb_totalUsers.Text = userData.Total.ToString();

            pn_userInterface.Controls.Clear();
            int gb_User_Height = 160; // Đặt chiều cao mặc định cho khung chứa user

            //Bđ lần lượt hiển thị thông tin của các user
            for (int i = 0; i < userData.Data.Count; i++)
            {
                //Lấy user cụ thể từ list 
                var user = userData.Data[i];

                //Mỗi một user sẽ được gói vô 1 cái groupbox và sau đó add vô cái panel chính
                GroupBox gb_User = new GroupBox();
                gb_User.Location = new Point(10, i * (gb_User_Height + 10));
                gb_User.Size = new Size(650, gb_User_Height);
                pn_userInterface.Controls.Add(gb_User);

                //các thuộc tính cho hình ảnh
                PictureBox img = new PictureBox();
                img.SizeMode = PictureBoxSizeMode.StretchImage;
                img.ImageLocation = user.Avatar;
                img.Location = new Point(gb_User.Width - img.Width - 65, 20);
                img.Size = new Size(150, gb_User_Height - 30);
                gb_User.Controls.Add(img);

                //các thuộc tính cho dòng hiển thị tên của user
                Label lb_Name = new Label();
                lb_Name.Text = user.FirstName + " " + user.LastName;
                lb_Name.Location = new Point(10, 20);
                lb_Name.AutoSize = true;
                lb_Name.Font = new Font(lb_Name.Font.FontFamily, lb_Name.Font.Size + 2, FontStyle.Bold);
                gb_User.Controls.Add(lb_Name);

                //các thuộc tính cho dòng hiển thị email của user
                Label lb_Email = new Label();
                lb_Email.Text = user.Email;
                lb_Email.Location = new Point(10, 60);
                lb_Email.AutoSize = true;
                gb_User.Controls.Add(lb_Email);
            }
        }
        private void btn_previousPage_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
                currentPage--;
            else
                currentPage = totalPages;
            LoadUserData();
        }

        private void btn_nextPage_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
                currentPage++;
            else
                currentPage = 1;
            LoadUserData();
        }

        private void Ex5_Load(object sender, EventArgs e)
        {
            LoadUserData();
        }
        private void LoadUserData()
        {
            try
            {
                //Tạo url với số trang hiện tại để tải dữ liệu của user từ API
                string URL = "https://reqres.in/api/users?page=" + currentPage;
                //BĐ thực hiện yêu cầu http và nhận response từ url vừa mới tạo
                string response = getHTML(URL);

                //Phân tích cú pháp dữ liệu JSON trong response thành UserPagination
                UserPagination userData = JsonSerializer.Deserialize<UserPagination>(response);

                //Xác định tổng số trang có sẵn trong dữ liệu của user
                totalPages = userData.TotalPages;
                //Hiển thị ra giao diện
                DisplayUserData(userData);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
