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
        private static char VigenereCipher(char c, char key)
        {
            if (!char.IsLetter(c))
                return c;

            bool isUpperCase = char.IsUpper(c);
            char offset = isUpperCase ? 'A' : 'a';
            int keyIndex = char.ToUpper(key) - 'A';
            int rowIndex = (char.ToUpper(c) - 'A') % 26;

            int columnIndex = (rowIndex + keyIndex) % 26;

            // Xác định ký tự trả về dựa trên trạng thái chữ hoa/chữ thường ban đầu
            char result = isUpperCase ? char.ToUpper(Alphabet[columnIndex]) : char.ToLower(Alphabet[columnIndex]);

            return result;
        }

        string encodedText;
        private void btn_Encode_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_Key.Text) || string.IsNullOrEmpty(rtb_inputData.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            encodedText = VigenereEncode(rtb_inputData.Text, tb_Key.Text.ToUpper());
            rtb_Encode.Text = encodedText.ToUpper();
        }

        private void btn_Decode_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(rtb_Encode.Text))
            {
                MessageBox.Show("Chưa có dữ liệu để giải mã!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            rtb_Decode.Text = VigenereDecode(encodedText, tb_Key.Text.ToUpper());
        }
        private string VigenereEncode(string input, string key)
        {
            string output = string.Empty;
            int keyLength = key.Length;
            int keyIndex = 0;

            foreach (char c in input)
            {
                char encryptedChar = VigenereCipher(c, key[keyIndex]);
                output += encryptedChar;

                keyIndex = (keyIndex + 1) % keyLength;
            }

            return output;
        }
        private string VigenereDecode(string input, string key)
        {
            string output = string.Empty;
            int keyLength = key.Length;
            int keyIndex = 0;

            foreach (char c in input)
            {
                bool isUpperCase = char.IsUpper(c);
                char decryptedChar = VigenereCipher(c, Alphabet[Mod(26 - (key[keyIndex] - 'A'), 26)]);

                // Xác định ký tự giải mã dựa trên trạng thái chữ hoa/chữ thường ban đầu
                char result = isUpperCase ? char.ToUpper(decryptedChar) : char.ToLower(decryptedChar);

                output += result;

                keyIndex = (keyIndex + 1) % keyLength;
            }

            return output;
        }
        private int Mod(int a, int b)
        {
            int result = a % b;
            return result >= 0 ? result : result + b;
        }

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
