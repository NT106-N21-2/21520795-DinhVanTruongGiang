using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Ex2 : Form
    {
        public Ex2()
        {
            InitializeComponent();
        }
        private static readonly char[] Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
       
        //Thực hiện mã hoá một ký tự 
        private static char VigenereCipher(char c, char key)
        {
            //Kiểm tra dữ liệu đầu vào đảm bảo dữ liệu đầu vào là 1 chữ cái thì sẽ thực hiện mã hoá
            if (!char.IsLetter(c))
                return c;
            
            //dùng xác định ký tự là chữ hoa
            bool isUpperCase = char.IsUpper(c);
            //dùng để tính toán chỉ số của ký tự trong quá trình mã hoá và giải mã
            char offset = isUpperCase ? 'A' : 'a'; //tính độ lệch giữa ký tự chữ hoa và chữ thường
            //tìm ra chỉ số của ký tự cần trong bảng 
            int keyIndex = char.ToUpper(key) - 'A';
            //tìm chỉ số hàng của ký tự trong bảng (sử dụng phép chia dư cho 26 để đảm bảo chỉ số nằm trong khoảng từ 0 đến 25)
            int rowIndex = (char.ToUpper(c) - 'A') % 26;
            //tìm chỉ số cột của ký tự
            int columnIndex = (rowIndex + keyIndex) % 26;

            // Xác định ký tự trả về dựa trên trạng thái chữ hoa/chữ thường ban đầu
            char result = isUpperCase ? char.ToUpper(Alphabet[columnIndex]) : char.ToLower(Alphabet[columnIndex]);

            return result;
        }

        string encodedText; 
        private void btn_Encode_Click(object sender, EventArgs e)
        {
            //Cài đặt ràng buộc đầu vào
            if (string.IsNullOrEmpty(tb_Key.Text) || string.IsNullOrEmpty(rtb_inputData.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Gọi hàm thực hiện mã hoá dữ liệu và sau đó hiển thị kết quả
            encodedText = VigenereEncode(rtb_inputData.Text, tb_Key.Text.ToUpper());
            rtb_Encode.Text = encodedText.ToUpper();
        }

        private void btn_Decode_Click(object sender, EventArgs e)
        {
            //Cài đặt ràng buộc đầu vào
            if (string.IsNullOrEmpty(rtb_Encode.Text))
            {
                MessageBox.Show("Chưa có dữ liệu để giải mã!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Gọi hàm thực hiện giải mã và sau đó hiển thị kết quả 
            rtb_Decode.Text = VigenereDecode(encodedText, tb_Key.Text.ToUpper());
        }

        //Thực hiện mã hoá chuỗi dữ liệu đầu vào
        private string VigenereEncode(string input, string key)
        {
            string output = string.Empty;
            //lấy độ dài của chuỗi Key
            int keyLength = key.Length;
            int keyIndex = 0;

            //bđ duyệt qua từng ký tự trong chuỗi
            foreach (char c in input)
            {
                //gọi hàm thực hiện mã hoá từng ký tự để thực hiện mã hoá
                char encryptedChar = VigenereCipher(c, key[keyIndex]);
                //Thêm ký tự đã mã hoá vô chuỗi sẽ hiển thị ra
                output += encryptedChar;

                keyIndex = (keyIndex + 1) % keyLength;
            }
            return output;
        }
        //Thực hiện giải mã chuỗi đã được mã hoá
        private string VigenereDecode(string input, string key)
        {
            string output = string.Empty;
            int keyLength = key.Length;
            int keyIndex = 0;
            foreach (char c in input)
            {
                bool isUpperCase = char.IsUpper(c);
                //tính toán ký tự giải mã thực hiện các phép tính tương tự như trong mã hoá nhưng sử dụng key ngược lại
                char decryptedChar = VigenereCipher(c, Alphabet[Mod(26 - (key[keyIndex] - 'A'), 26)]);
                // Xác định ký tự giải mã dựa trên trạng thái chữ hoa/chữ thường ban đầu
                char result = isUpperCase ? char.ToUpper(decryptedChar) : char.ToLower(decryptedChar);
                output += result;
                keyIndex = (keyIndex + 1) % keyLength;
            }
            return output;
        }
        //hỗ trợ tính toán phép chia lấy dư để sử dụng trong quá trình mã hoá và giải mã
        private int Mod(int a, int b)
        {
            int result = a % b;
            return result >= 0 ? result : result + b;
        }

        //Sử dụng để đảm bảo các ràng buộc cho dữ liệu đầu vào
        private void tb_Key_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Lấy mã phím của ký tự được nhấn
            int keyCode = e.KeyChar;

            // Kiểm tra nếu không phải là chữ cái (không nằm trong khoảng [A-Z] hoặc [a-z]) và không phải là nút backspace (mã phím 8)
            if (!char.IsLetter(e.KeyChar) && keyCode != 8)
            {
                // Hủy sự kiện, ngăn người dùng nhập ký tự không hợp lệ vào tb_Key
                e.Handled = true;
            }
        }
    }
}
