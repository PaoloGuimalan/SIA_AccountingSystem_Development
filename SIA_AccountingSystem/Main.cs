using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIA_AccountingSystem
{
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Restart();
        }

        private void dashboard1_Load(object sender, EventArgs e)
        {

        }

        private void dshbrd_Click(object sender, EventArgs e)
        {
            maindash1.Show();
            accounting1.Hide();
        }

        private void schcal_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            TableLayoutColumnStyleCollection tb1 = this.tableLayoutPanel1.ColumnStyles;

            foreach (ColumnStyle tbdel in tb1)
            {
                tbdel.SizeType = SizeType.Absolute;
                tbdel.Width = 0;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            TableLayoutColumnStyleCollection tb1 = this.tableLayoutPanel1.ColumnStyles;

            foreach (ColumnStyle tbdel in tb1)
            {
                tbdel.SizeType = SizeType.Absolute;
                tbdel.Width = 400;
            }
        }

        private void maindash1_Load(object sender, EventArgs e)
        {

        }

        private void accnt_Click(object sender, EventArgs e)
        {
            accounting1.Show();
            maindash1.Hide();
        }

        private void stdnt_Click(object sender, EventArgs e)
        {
            StudentProfile stp = new StudentProfile();
            stp.Show();
        }
    }
}
