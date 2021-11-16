using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SIA_AccountingSystem
{
    public partial class ac_feetypes : UserControl
    {

        private void Connection_fee()
        {
            string conn = "datasource=localhost;port=3306;username=root;password=;SslMode=none;database=qcu_acc";
            MySqlConnection DBfee = new MySqlConnection(conn);
            MySqlConnection DBfee2 = new MySqlConnection(conn);

            DBfee.Open();

            string query = "SELECT * FROM av_units";
            MySqlCommand cmdfee = new MySqlCommand(query, DBfee);
            MySqlDataReader readerfee = cmdfee.ExecuteReader();

            while (readerfee.Read())
            {
                dataGridView1.Rows.Add(readerfee.GetString(1), readerfee.GetString(2), readerfee.GetString(3), readerfee.GetString(5), readerfee.GetString(6), readerfee.GetString(4), readerfee.GetString(7));
            }

            DBfee.Close();

            DBfee2.Open();

            string query2 = "SELECT * FROM av_miscellaneous";
            MySqlCommand cmdfee2 = new MySqlCommand(query2, DBfee2);
            MySqlDataReader readerfee2 = cmdfee2.ExecuteReader();

            while (readerfee2.Read())
            {
                dataGridView2.Rows.Add(readerfee2.GetString(1), readerfee2.GetString(2), readerfee2.GetString(3));
            }

            DBfee2.Close();

        }

        public ac_feetypes()
        {
            InitializeComponent();
            Connection_fee();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
