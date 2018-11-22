using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Student\Source\Repos\myroofonfire\sameer\WindowsFormsApp5\WindowsFormsApp5\Database1.mdf;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand c = con.CreateCommand();
            c.CommandType = CommandType.Text;
            c.CommandText = "Insert into Mytable values('" + id.Text + "','" + name.Text + "','"+dept.Text+"')";
            c.ExecuteNonQuery();
            con.Close();
        }

        private void update_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand c = con.CreateCommand();
            c.CommandType = CommandType.Text;
            c.CommandType = CommandType.Text;
            c.CommandText="UPDATE sample SET name"+tbid.text
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new
                SqlDataAdapter("select *from storeimage where id=" + textBox2.Text + "", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            byte[] mydata = new byte[0];
            mydata=()
        }
    }
}
