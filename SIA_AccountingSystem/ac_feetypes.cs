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

        private void Connection_fee_con_single(string query_one, string query_two)
        {
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            string conn = "datasource=localhost;port=3306;username=root;password=;SslMode=none;database=qcu_acc";
            MySqlConnection DBfee = new MySqlConnection(conn);
            MySqlConnection DBfee2 = new MySqlConnection(conn);

            DBfee.Open();

            string query = query_one;
            MySqlCommand cmdfee = new MySqlCommand(query, DBfee);
            MySqlDataReader readerfee = cmdfee.ExecuteReader();

            while (readerfee.Read())
            {
                dataGridView1.Rows.Add(readerfee.GetString(1), readerfee.GetString(2), readerfee.GetString(3), readerfee.GetString(5), readerfee.GetString(6), readerfee.GetString(4), readerfee.GetString(7));
            }

            DBfee.Close();

            DBfee2.Open();

            string query2 = query_two;
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

        private void course_onchange(object sender, EventArgs e)
        {
            if(comboBox1.Text != "" && comboBox2.Text == "" && comboBox3.Text == "")
            {
                //MessageBox.Show("Okay 1");
                string query_uno = $"SELECT * FROM av_units WHERE unit_course = '{comboBox1.Text}'";
                string query_dos = $"SELECT * FROM av_miscellaneous WHERE m_course = '{comboBox1.Text}'";
                Connection_fee_con_single(query_uno, query_dos);
            }
            else if (comboBox1.Text != "" && comboBox2.Text != "" && comboBox3.Text == "")
            {
                //MessageBox.Show("Okay 1, 2");
                string query_uno = $"SELECT * FROM av_units WHERE unit_course = '{comboBox1.Text}' AND unit_year = '{comboBox2.Text}'";
                string query_dos = $"SELECT * FROM av_miscellaneous WHERE m_course = '{comboBox1.Text}'";
                Connection_fee_con_single(query_uno, query_dos);
            }
            else if (comboBox1.Text != "" && comboBox3.Text != "" && comboBox2.Text == "")
            {
                //MessageBox.Show("Okay 1, 3");
                string query_uno = $"SELECT * FROM av_units WHERE unit_course = '{comboBox1.Text}' AND unit_sem = '{comboBox3.Text}'";
                string query_dos = $"SELECT * FROM av_miscellaneous WHERE m_course = '{comboBox1.Text}'";
                Connection_fee_con_single(query_uno, query_dos);
            }
            else if (comboBox1.Text != "" && comboBox2.Text != "" && comboBox3.Text != "")
            {
                //MessageBox.Show("Okay 1, 2, 3");
                string query_uno = $"SELECT * FROM av_units WHERE unit_course = '{comboBox1.Text}' AND unit_year = '{comboBox2.Text}' AND unit_sem = '{comboBox3.Text}'";
                string query_dos = $"SELECT * FROM av_miscellaneous WHERE m_course = '{comboBox1.Text}'";
                Connection_fee_con_single(query_uno, query_dos);
            }
        }

        private void year_onchange(object sender, EventArgs e)
        {
            if (comboBox2.Text != "" && comboBox1.Text == "" && comboBox3.Text == "")
            {
                //MessageBox.Show("Okay 2");
                string query_uno = $"SELECT * FROM av_units WHERE unit_year = '{comboBox2.Text}'";
                string query_dos = $"SELECT * FROM av_miscellaneous";
                Connection_fee_con_single(query_uno, query_dos);
            }
            else if (comboBox2.Text != "" && comboBox1.Text != "" && comboBox3.Text == "")
            {
                //MessageBox.Show("Okay 2, 1");
                string query_uno = $"SELECT * FROM av_units WHERE unit_year = '{comboBox2.Text}' AND unit_course = '{comboBox1.Text}'";
                string query_dos = $"SELECT * FROM av_miscellaneous WHERE m_course = '{comboBox1.Text}'";
                Connection_fee_con_single(query_uno, query_dos);
            }
            else if (comboBox2.Text != "" && comboBox3.Text != "" && comboBox1.Text == "")
            {
                //MessageBox.Show("Okay 2, 3");
                string query_uno = $"SELECT * FROM av_units WHERE unit_year = '{comboBox2.Text}' AND unit_sem = '{comboBox3.Text}'";
                string query_dos = $"SELECT * FROM av_miscellaneous";
                Connection_fee_con_single(query_uno, query_dos);
            }
            else if (comboBox2.Text != "" && comboBox1.Text != "" && comboBox3.Text != "")
            {
                //MessageBox.Show("Okay 2, 1, 3");
                string query_uno = $"SELECT * FROM av_units WHERE unit_course = '{comboBox1.Text}' AND unit_year = '{comboBox2.Text}' AND unit_sem = '{comboBox3.Text}'";
                string query_dos = $"SELECT * FROM av_miscellaneous WHERE m_course = '{comboBox1.Text}'";
                Connection_fee_con_single(query_uno, query_dos);
            }
        }

        private void sem_onchange(object sender, EventArgs e)
        {
            if (comboBox3.Text != "" && comboBox2.Text == "" && comboBox1.Text == "")
            {
                //MessageBox.Show("Okay 3");
                string query_uno = $"SELECT * FROM av_units WHERE unit_sem = '{comboBox3.Text}'";
                string query_dos = $"SELECT * FROM av_miscellaneous";
                Connection_fee_con_single(query_uno, query_dos);
            }
            else if (comboBox3.Text != "" && comboBox2.Text != "" && comboBox1.Text == "")
            {
                //MessageBox.Show("Okay 3, 2");
                string query_uno = $"SELECT * FROM av_units WHERE unit_sem = '{comboBox3.Text}' AND unit_year = '{comboBox2.Text}'";
                string query_dos = $"SELECT * FROM av_miscellaneous WHERE m_course = '{comboBox1.Text}'";
                Connection_fee_con_single(query_uno, query_dos);
            }
            else if (comboBox3.Text != "" && comboBox1.Text != "" && comboBox2.Text == "")
            {
                //MessageBox.Show("Okay 3, 1");
                string query_uno = $"SELECT * FROM av_units WHERE unit_course = '{comboBox1.Text}' AND unit_sem = '{comboBox3.Text}'";
                string query_dos = $"SELECT * FROM av_miscellaneous WHERE m_course = '{comboBox1.Text}'";
                Connection_fee_con_single(query_uno, query_dos);
            }
            else if (comboBox3.Text != "" && comboBox2.Text != "" && comboBox1.Text != "")
            {
                //MessageBox.Show("Okay 3, 2, 1");
                string query_uno = $"SELECT * FROM av_units WHERE unit_course = '{comboBox1.Text}' AND unit_year = '{comboBox2.Text}' AND unit_sem = '{comboBox3.Text}'";
                string query_dos = $"SELECT * FROM av_miscellaneous WHERE m_course = '{comboBox1.Text}'";
                Connection_fee_con_single(query_uno, query_dos);
            }
        }
    }
}
