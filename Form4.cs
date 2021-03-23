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

namespace GYM
{
    public partial class Equipment : Form
    {
        public Equipment()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            richTextBox1.Clear();
            dateTimePicker1.Value = DateTime.Now;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            String ename = textBox1.Text;
            String edesc = richTextBox1.Text;
            String mused = textBox2.Text;
            String dob = dateTimePicker1.Text;
            Int64 cost = Int64.Parse(textBox3.Text);
            

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = AAKASH\\SKY; database = gym; integrated security =True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "insert into Equipment (EName,EDescription,MUsed,DDate,Cost) values ('" + ename + "', '" + edesc + "','" + mused + "','" + dob + "','" + cost + "')";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            MessageBox.Show("Data Saved Successfully","Inserted",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 eq = new Form5();
            eq.Show();

        }
    }
}
