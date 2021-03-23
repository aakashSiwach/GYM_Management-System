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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = AAKASH\\SKY; database = gym; integrated security =True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from NewMember";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            DataTable dataTable = DS.Tables[0];
            dataGridView1.DataSource = dataTable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (MessageBox.Show("This will Delete your data. Confirm?","Delete Data",MessageBoxButtons.YesNo)== DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "data source = AAKASH\\SKY; database = gym; integrated security =True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;

                    cmd.CommandText = "delete from NewMember where MID =" + textBox1.Text + "";

                    SqlDataAdapter DA = new SqlDataAdapter(cmd);
                    DataSet DS = new DataSet();
                    DA.Fill(DS);

                   // dataGridView1.DataSource = DS.Tables[0];
                }
                else
                {
                    this.Activate();
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "data source = AAKASH\\SKY; database = gym; integrated security =True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;

                    cmd.CommandText = "select * from NewMember";
                    SqlDataAdapter DA = new SqlDataAdapter(cmd);
                    DataSet DS = new DataSet();
                    DA.Fill(DS);
                    DataTable dataTable = DS.Tables[0];
                    dataGridView1.DataSource = dataTable;
                }
            }
            else
            {
                MessageBox.Show("Please Enter Member ID", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
