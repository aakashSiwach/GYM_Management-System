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
    public partial class Form11 : Form
    {
        private int iProgressBarValue = 0;
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 1000;
            progressBar1.Value = 0;

            timer1.Enabled  = true;
            timer1.Interval = 300;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            iProgressBarValue++;

            switch(iProgressBarValue)
            {
                case 1:case 3:case 5:case 7:case 9:
                    progressBar1.Value = (iProgressBarValue * 100);
                        break;
                case 2:case 4:case 6:case 10:
                    progressBar1.Value = (iProgressBarValue * 100);
                    break;
                case 13:
                    timer1.Stop();
                    timer1.Enabled = false;
                    Form8 nw = new Form8();
                    nw.Show();

                    this.Hide();
                    break;
                default:
                    break;

            }
        }
    }
}
