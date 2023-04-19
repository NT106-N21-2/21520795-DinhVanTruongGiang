namespace Lab2
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }
        private void Bai1_Load(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FileStream inputfs = new FileStream("input1.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(inputfs);
            string s = sr.ReadToEnd();
            textBox1.AppendText(s);
            sr.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            using (FileStream outputfs = new FileStream("output2.txt", FileMode.Truncate))
            {
                StreamWriter sw = new StreamWriter(outputfs);
                sw.WriteLine(textBox1.Text);
                sw.Close();
                MessageBox.Show("Ghi thành công!");
            }
        }
    }
}