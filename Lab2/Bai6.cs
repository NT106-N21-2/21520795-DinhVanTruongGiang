using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Bai6 : Form
    {
        public Bai6()
        {
            InitializeComponent();
            LoadTreeView();
        }
        public void TraverserDirectory(TreeNode root)
        {
            if (root == null) return;
            //lấy đường dẫn
            string Path = root.FullPath;
            //lấy tất cả các thư mục con
            var subDir = new DirectoryInfo(Path).GetDirectories();
            if (subDir.Count() > 0)
            {
                //Duyệt thư mục con
                foreach (DirectoryInfo dir in subDir)
                {
                    if (Directory.Exists(dir.FullName))
                    {
                        //Thêm node
                        TreeNode treeNode = new TreeNode() { Text = dir.Name };
                        root.Nodes.Add(treeNode);
                    }
                }
            }
            var Files = new DirectoryInfo(Path).GetFiles();
            if (Files.Count() > 0)
            {
                foreach (FileInfo file in Files)
                {
                    if (file.Exists)
                    {
                        TreeNode treeNode = new TreeNode() { Text = file.Name };
                        root.Nodes.Add(treeNode);
                    }
                }
            }
        }
        public void LoadTreeView()
        {
            TreeNode root1 = new TreeNode();
            root1.Text = @"C:\";
            TreeNode root2 = new TreeNode();
            root2.Text = @"D:\";
            treeView1.Nodes.Add(root1);
            treeView1.Nodes.Add(root2);
        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string Path = treeView1.SelectedNode.FullPath;
            if (Directory.Exists(Path))
                //Gọi hàm duyệt thư mục
                TraverserDirectory(treeView1.SelectedNode);

            if (File.Exists(Path))
            {
                try
                {
                    FileInfo fs = new FileInfo(Path);
                    //Nếu là file ảnh
                    if (fs.Extension == ".jpg" || fs.Extension == ".png" || fs.Extension == ".bmp" || fs.Extension == ".gif")
                    {
                        textBox1.Visible = false;
                        Image image = Image.FromFile(Path);
                        pictureBox1.Visible = true;
                        pictureBox1.Image = image;
                        return;
                    }
                    //nếu là file text
                    if (fs.Extension == ".txt")
                    {
                        pictureBox1.Visible = false;
                        using (StreamReader sr = new StreamReader(Path))
                        {
                            string s = sr.ReadToEnd();
                            textBox1.Visible = true;
                            textBox1.Text = s;
                        }
                        return;
                    }
                    //Nếu là các định dạng file khác
                    MessageBox.Show("Can't Open " + fs.Extension + " file!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Can't open this file!");
                    return;
                }
            }
        }

        private void Bai6_Load(object sender, EventArgs e)
        {

        }
    }
}
