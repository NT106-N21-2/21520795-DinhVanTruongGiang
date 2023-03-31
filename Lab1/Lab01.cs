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
            FormBai03 nf = new FormBai03();
            nf.ShowDialog();
            //Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormBai04 nf = new FormBai04();
            nf.ShowDialog();
            //Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormBai05 nf = new FormBai05();
            nf.ShowDialog();
            //Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormBai06 nf = new FormBai06();
            nf.ShowDialog();
            //Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormBai07 nf = new FormBai07();
            nf.ShowDialog();
            //Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //FormBai08 nf = new FormBai08();
            //nf.ShowDialog();
            ////Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}