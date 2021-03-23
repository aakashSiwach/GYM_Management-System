using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GYM
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String fname = textBox1.Text;
            String lname = textBox4.Text;

            String gender = "";

            bool isChecked = checkBox1.Checked;
            if(isChecked)
            {
                gender = checkBox1.Text;
            }
            else
            {
                gender = checkBox2.Text;
            }
            String dob = dateTimePicker1.Text;
            Int64 mobile = Int64.Parse(textBox3.Text);
            String email = textBox2.Text;
            String joindate = dateTimePicker2.Text;
            String gymtime = comboBox1.Text;
            String address = richTextBox1.Text;
            String membership = comboBox2.Text;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = AAKASH\\SKY; database = gym; integrated security =True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "insert into NewMember (Fname,Lname,Gender,Dob,Mobile,Email,JoinDate,GymTime,Maddress,MembershipTime) values ('" + fname + "', '" + lname + "','" + gender + "','" + dob + "','" + mobile + "','" + email + "','" + joindate + "','" + gymtime + "','" + address + "','" + membership + "')";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            MessageBox.Show("Data Saved Successfully");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

            checkBox1.Checked = false;
            checkBox2.Checked = false;

            comboBox1.ResetText();
            comboBox2.ResetText();

            richTextBox1.Clear();

            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;

        }
    }
}
