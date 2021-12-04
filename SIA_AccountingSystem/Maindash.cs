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
    public partial class Maindash : UserControl
    {
        private void Connection()
        {
            string conn = "datasource=localhost;port=3306;username=root;password=;SslMode=none;database=qcu_acc";
            MySqlConnection DBConnect = new MySqlConnection(conn);

            DBConnect.Open();

            string query = "SELECT ROUND(COUNT(stud_id_units) * 100 / (SELECT COUNT(student_id) FROM students_list),2) AS number_students FROM students";
            MySqlCommand command1 = new MySqlCommand(query, DBConnect);
            MySqlDataReader read1 = command1.ExecuteReader();
            read1.Read();

            double percentage = double.Parse(read1.GetString(0));

            guna2CircleProgressBar1.Value = (int)percentage;

            DBConnect.Close();

            //Units Miscs

            MySqlConnection DBConnectunit = new MySqlConnection(conn);

            DBConnectunit.Open();

            string queryunit = "SELECT ROUND(COUNT(status) * 100 / (SELECT COUNT(status) FROM misc_assigned),2) AS status_percentage FROM misc_assigned WHERE status = 'Unpaid'";
            MySqlCommand command1unit = new MySqlCommand(queryunit, DBConnectunit);
            MySqlDataReader read1unit = command1unit.ExecuteReader();
            read1unit.Read();

            double percentageunit = double.Parse(read1unit.GetString(0));

            guna2ProgressBar1.Value = (int)percentageunit;

            DBConnectunit.Close();


            //cont


            MySqlConnection DBConnectmisc = new MySqlConnection(conn);

            DBConnectmisc.Open();

            string querymisc = "SELECT ROUND(COUNT(status) * 100 / (SELECT COUNT(status) FROM units_assigned),2) AS status_percentage FROM units_assigned WHERE status = 'Unpaid'";
            MySqlCommand command1misc = new MySqlCommand(querymisc, DBConnectmisc);
            MySqlDataReader read1misc = command1misc.ExecuteReader();
            read1misc.Read();

            double percentagemisc = double.Parse(read1misc.GetString(0));

            guna2ProgressBar2.Value = (int)percentagemisc;

            DBConnectmisc.Close();
        }

        private void Grid_Data()
        {
            string conn = "datasource=localhost;port=3306;username=root;password=;SslMode=none;database=qcu_acc";
            MySqlConnection DBConnect = new MySqlConnection(conn);

            DBConnect.Open();

            string query = "SELECT * FROM transac_hist";
            MySqlCommand command1 = new MySqlCommand(query, DBConnect);
            MySqlDataReader read1 = command1.ExecuteReader();

            while (read1.Read())
            {
                dataGridView1.Rows.Add(read1.GetString(0), read1.GetString(1), read1.GetString(2), read1.GetString(3), read1.GetString(4));
            }

            DBConnect.Close();
        }

        public Maindash()
        {
            InitializeComponent();
            Connection();
            Grid_Data();
        }

        private void guna2CircleProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleProgressBar1_ValueChanged_1(object sender, EventArgs e)
        {

        }
    }
}
