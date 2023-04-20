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
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            FileStream inputfile = new FileStream("input3.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(inputfile);
            string s;
            while ((s = sr.ReadLine()) != null)
                textBox1.AppendText(s + "\r\n");
            sr.Close();
            MessageBox.Show("Read successfully!");
        }
        private static float Caculate(string s)
        {
            Stack<float> operands = new Stack<float>();
            Stack<char> operators = new Stack<char>();
            s = s.Replace(" ", "");
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (char.IsDigit(c))
                {
                    string GetNum = c.ToString();
                    while (i + 1 < s.Length && char.IsDigit(s[i + 1]))
                    {
                        GetNum += s[i + 1];
                        i++;
                    }
                    float num = float.Parse(GetNum);
                    if (operators.Count > 0 && (operators.Peek() == '–' || operators.Peek() == '-')) { num *= -1; operators.Pop(); operators.Push('+'); }
                    operands.Push(num);
                }
                else if (c == '(') operators.Push(c);
                else if (c == ')')
                {
                    while (operators.Count > 0 && operators.Peek() != '(')
                    {
                        float result = Caculate2Operands(operands.Pop(), operands.Pop(), operators.Pop());
                        operands.Push(result);
                    }
                    operators.Pop();
                }
                else if (c == '*' || c == '/')
                {
                    if (operators.Count > 0 && (operators.Peek() == '*' || operators.Peek() == '/'))
                    {
                        float result = Caculate2Operands(operands.Pop(), operands.Pop(), operators.Pop());
                        operands.Push(result);
                    }
                    operators.Push(c);
                }
                else if (c == '+' || c == '–' || c == '-')
                {
                    if (i == 0 || !char.IsDigit(s[i - 1]))
                        operands.Push(0);
                    if (operators.Count > 0 && (operators.Peek() == '*' || operators.Peek() == '/'))
                    {
                        float result = Caculate2Operands(operands.Pop(), operands.Pop(), operators.Pop());
                        operands.Push(result);
                    }
                    operators.Push(c);
                }
            }
            operands.Reverse();
            operators.Reverse();
            while (operators.Count > 0)
            {
                float result = Caculate2Operands(operands.Pop(), operands.Pop(), operators.Pop());
                operands.Push(result);
            }
            return operands.Pop();
        }
        private static float Caculate2Operands(float n1, float n2, char op)
        {
            switch (op)
            {
                case '+':
                    return n1 + n2;
                    break;
                case '–':
                    return n2 - n1;
                    break;
                case '*':
                    return n1 * n2;
                    break;
                case '/':
                    return n2 / n1;
                    break;
                default:
                    throw new Exception();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = string.Empty;
            FileStream inputfile = new FileStream("input3.txt", FileMode.Open, FileAccess.Read);
            FileStream outputfile = new FileStream("output3.txt", FileMode.Truncate);
            StreamReader sr = new StreamReader(inputfile);
            StreamWriter sw = new StreamWriter(outputfile);
            string s;
            while ((s = sr.ReadLine()) != null)
            {
                textBox2.AppendText(s + " = " + Caculate(s) + "\r\n");
                sw.WriteLine(s + " = " + Caculate(s));
            }
            sr.Close();
            sw.Close();
            MessageBox.Show("Write successfully!");
        }

        private void Bai3_Load(object sender, EventArgs e)
        {

        }
    }
}
