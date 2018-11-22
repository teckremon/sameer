using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        string ch = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = ch = ch + "1";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = ch = ch + "2";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = ch = ch + "3";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = ch = ch + "4";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = ch = ch + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = ch = ch + "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = ch = ch + "7";
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = ch = ch + "8";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = ch = ch + "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = ch = ch + "+";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = ch = ch + "-";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = ch = ch + "*";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = ch = ch + "/";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(ch.Substring(0, 1));
            char c = Convert.ToChar(ch.Substring(1, 1));
            int b = Convert.ToInt32(ch.Substring(2, 1));
            switch (c)
            {
                case '+':
                    {
                        textBox1.Clear();
                        textBox1.Text = Convert.ToString(a + b);
                        break;
                    }
                case '-':
                    {
                        textBox1.Clear();
                        textBox1.Text = Convert.ToString(a - b);
                        break;
                    }
                case '*':
                    {
                        textBox1.Clear();
                        textBox1.Text = Convert.ToString(a * b);
                        break;
                    }
                case '/':
                    {
                        textBox1.Clear();
                        textBox1.Text = Convert.ToString(a / b);
                        break;
                    }
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            ch = "";
            textBox1.Clear();
        }
    }
}
