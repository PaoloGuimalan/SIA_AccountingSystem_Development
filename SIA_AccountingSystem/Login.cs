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
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register Reg = new Register();
            this.Hide();
            Reg.Show();
            Reg.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var f11 = new Form1();
            Main m1 = new Main();
            //f11.Visible = false;
            m1.Show();
            ((Form)this.TopLevelControl).Hide();
        }
    }
}
