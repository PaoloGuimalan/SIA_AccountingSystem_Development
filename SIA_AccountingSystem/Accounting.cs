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
    public partial class Accounting : UserControl
    {
        public Accounting()
        {
            InitializeComponent();
            ac_feetypes1.Hide();
            ac_overdue1.Hide();
            ac_invoice1.Show();
        }

        private void invoice_btn_Click(object sender, EventArgs e)
        {
            ac_feetypes1.Hide();
            ac_overdue1.Hide();
            ac_invoice1.Show();
        }

        private void overdue_btn_Click(object sender, EventArgs e)
        {
            ac_feetypes1.Hide();
            ac_invoice1.Hide();
            ac_overdue1.Show();
        }

        private void feetypes_btn_Click(object sender, EventArgs e)
        {
            ac_overdue1.Hide();
            ac_invoice1.Hide();
            ac_feetypes1.Show();
        }
    }
}
