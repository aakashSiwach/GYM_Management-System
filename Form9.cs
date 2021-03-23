using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GYM
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username = textBox1.Text;
            String userpassword = textBox2.Text;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = AAKASH\\SKY; database = gym; integrated security =True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "insert into Admin (Username,UPassword) values ('" + username + "', '" + userpassword + "')";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            MessageBox.Show("Login Successfully");

 

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form10().Show();
        }
    }
}
