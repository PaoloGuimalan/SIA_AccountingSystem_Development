﻿using System;
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
    public partial class Register : UserControl
    {

        public Register()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void confirm_btn_Click(object sender, EventArgs e)
        {

        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Login Lg1 = new Login();
            //this.Hide();
            //Lg1.Show();
            //Lg1.BringToFront();
            //MessageBox.Show("Hello");
            Application.Restart();
        }
    }
}
