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
    public partial class StudentLists : UserControl
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
                dataGridView1.Rows.Add(read1.GetString(0), read1.GetString(1), read1.GetString(2), read1.GetString(3), read1.GetString(4), read1.GetString(5), read1.GetString(6));
            }
                //MySqlDataAdapter adapt;
                //adapt = new MySqlDataAdapter(query, DBConnect);
                //MessageBox.Show(read1.GetString(0));
                //DataTable dt = new DataTable();
                //adapt.Fill(dt);
                //dataGridView1.DataSource = dt;
            DBConnect.Close();

            for(int i = 0; i < 5; i++)
            {
                dataGridView1.Columns[i].Width = 200;
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

        public StudentLists()
        {
            InitializeComponent();
            Connection();
            comboBox1.SelectedText = "--select a program--";
            comboBox2.SelectedText = "--select a year--";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            if(search_box.Text == "")
            {
                MessageBox.Show("Please type a Student ID");
            }
            else
            {
                //dataGridView1.Columns.Clear();
                Connection_search(search_box.Text);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                //MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells["student_id"].FormattedValue.ToString());
                StudentProfile stud = new StudentProfile(dataGridView1.Rows[e.RowIndex].Cells["student_id"].FormattedValue.ToString());
                stud.Show();
            }
        }

        private void load_list_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || comboBox2.Text == "")
            {
                MessageBox.Show("Please Select a Year and Course");
            }
            else
            {
                string year = comboBox2.Text;
                string course = comboBox1.Text;

                string conn = "datasource=localhost;port=3306;username=root;password=;SslMode=none;database=qcu_acc";
                MySqlConnection DBConnect = new MySqlConnection(conn);
                dataGridView1.Rows.Clear();

                DBConnect.Open();
                string query = $"SELECT * FROM students_list WHERE course = '{course}' AND year = '{year}'";
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

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
