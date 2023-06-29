namespace Lab6
{
    public partial class Ex1 : Form
    {
        public Ex1()
        {
            InitializeComponent();
        }
        private static char Cipher(char c, int shift)
        {
            if (!char.IsLetter(c))
                return c;
            char offset = char.IsUpper(c) ? 'A' : 'a';
            return (char)((((c + shift) - offset) % 26) + offset);
        }
        public static string Encryption(string input, int shift)
        {
            string output = string.Empty;
            foreach (char c in input)
                output += Cipher(c, shift);
            return output;
        }
        public static string Decryption(string input, int shift)
        {
            return Encryption(input, 26 - shift);
        }

        private void btn_Encryption_Click(object sender, EventArgs e)
        {
            tb_Encryption.Text = Encryption(tb_Input.Text, int.Parse(tb_Shift.Text));
        }

        private void btn_Decription_Click(object sender, EventArgs e)
        {
            tb_Decryption.Text = Decryption(tb_Encryption.Text, int.Parse(tb_Shift.Text));
        }
    }
}