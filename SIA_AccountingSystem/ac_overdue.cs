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
    public partial class ac_overdue : UserControl
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
                dataGridView1.Rows.Add(read1.GetString(0), read1.GetString(1) + ", " + read1.GetString(2) + ", " + read1.GetString(3), read1.GetString(4), read1.GetString(5));
            }
            DBConnect.Close();
        }

        public ac_overdue()
        {
            InitializeComponent();
            Connection();
        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            if (search_box.Text == "")
            {
                MessageBox.Show("Please type a Student ID");
            }
            else
            {
                //dataGridView1.Columns.Clear();
                Connection_search(search_box.Text);
            }
        }

        private void Connection_search(string id_search)
        {
            string conn = "datasource=localhost;port=3306;username=root;password=;SslMode=none;database=qcu_acc";
            MySqlConnection DBConnect = new MySqlConnection(conn);
            dataGridView1.Rows.Clear();

            DBConnect.Open();
            string query = $"SELECT * FROM students_list WHERE student_id = '{id_search}'";
            MySqlCommand command1 = new MySqlCommand(query, DBConnect);
            MySqlDataReader read1 = command1.ExecuteReader();
            while (read1.Read())
            {
                dataGridView1.Rows.Add(read1.GetString(0), read1.GetString(1), read1.GetString(2), read1.GetString(3), read1.GetString(4), read1.GetString(5), read1.GetString(6));
            }
            //MySqlDataAdapter adapt;
            //adapt = new MySqlDataAdapter(query, DBConnect);
            //MessageBox.Show(read1.GetString(0));
            //DataTable dt = new DataTable();
            //adapt.Fill(dt);
            //dataGridView1.DataSource = dt;
            DBConnect.Close();

            for (int i = 0; i < 5; i++)
            {
                dataGridView1.Columns[i].Width = 200;
            }
        }
    }
}
