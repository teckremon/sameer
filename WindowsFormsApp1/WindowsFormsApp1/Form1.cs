using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox4.Text);
            int b = Convert.ToInt32(textBox5.Text);
            int c;
            if (comboBox1.Text == "add")
            {
                c = a + b;
                MessageBox.Show(Convert.ToString(c));
            }
            if (comboBox1.Text == "subtract")
            {
                c = a - b;
                MessageBox.Show(Convert.ToString(c));
            }
            else if (comboBox1.Text == "multiply")
            {
                c = a * b;
                MessageBox.Show(Convert.ToString(c));
            }
            else if (comboBox1.Text == "divide")
            {
                c = a / b;
                MessageBox.Show(Convert.ToString(c));
            }
            else
                MessageBox.Show(" please check any of the operations to the in the combobox above");
        }
    }
}
