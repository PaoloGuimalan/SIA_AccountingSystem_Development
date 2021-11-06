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
    public partial class ac_invoice : UserControl
    {
        private void Connection()
        {
            string conn = "datasource=localhost;port=3306;username=root;password=;SslMode=none;database=qcu_acc";
            MySqlConnection DBConnect = new MySqlConnection(conn);
            dataGridView1.Rows.Clear();

            DBConnect.Open();
            string query = "SELECT * FROM students_list";
            MySqlCommand command1 = new MySqlCommand(query, DBConnect);
            MySqlDataReader read1 = command1.ExecuteReader();
            while (read1.Read())
            {
                dataGridView1.Rows.Add(read1.GetString(0), read1.GetString(1)+", "+read1.GetString(2)+", "+read1.GetString(3), read1.GetString(4), read1.GetString(5));
            }
            DBConnect.Close();
        }

        public ac_invoice()
        {
            InitializeComponent();
            Connection();
        }

        private void Search_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
