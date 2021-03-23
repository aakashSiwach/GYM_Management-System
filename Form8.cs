using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GYM
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = AAKASH\\SKY; database = gym; integrated security =True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select COUNT(*) from Admin where username='"+textBox1.Text+"' AND upassword='"+textBox2.Text+"'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);

                if(dt.Rows[0][0].ToString() == "1")
                {
                    this.Close();
                    new Form1().Show();
                }
                else
                {
                    MessageBox.Show("Invalid Username and Password", "Invalid Insertion", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Please enter Username and Password!", "TextField left blank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
