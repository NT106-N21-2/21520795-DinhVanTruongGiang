namespace Lab1
{
    public partial class Lab1 : Form
    {
        public Lab1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormBai01 nf = new FormBai01();
            nf.ShowDialog();
            //Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormBai02 nf = new FormBai02();
            nf.ShowDialog();
            //Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}