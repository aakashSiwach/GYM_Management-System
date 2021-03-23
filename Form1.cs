using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GYM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 nm = new Form2();
            nm.Show();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void newStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 ns = new Form3();
            ns.Show();
        }

        private void equipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Equipment eq = new Equipment();
            eq.Show();
        }

        private void searchMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 srch = new Form6();
            srch.Show();
        }

        private void deleteMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 del = new Form7();
            del.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("This will close your Application. Confirm?","CLOSE",MessageBoxButtons.YesNo, MessageBoxIcon.Warning)== DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Welcome Back", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Logout, Confirm?","Logout",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.OK)
            {
                this.Close();
                Form8 lg = new Form8();
                lg.Show();
            }
        }

        private void addAdminUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 usr = new Form9();
            usr.Show();

        }
    }
}
