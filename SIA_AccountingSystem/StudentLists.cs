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

            DBConnect.Open();
                string query = "SELECT * FROM students_list";
                MySqlCommand command1 = new MySqlCommand(query, DBConnect);
                //MySqlDataReader read1 = command1.ExecuteReader();
                MySqlDataAdapter adapt;
                adapt = new MySqlDataAdapter(query, DBConnect);
                //MessageBox.Show(read1.GetString(0));
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                DBConnect.Close();

            for(int i = 0; i < 5; i++)
            {
                dataGridView1.Columns[i].Width = 200;
            }
        }
        public StudentLists()
        {
            InitializeComponent();
            Connection();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            
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
    }
}
