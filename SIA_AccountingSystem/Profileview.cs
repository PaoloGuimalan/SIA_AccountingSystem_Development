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
    public partial class Profileview : UserControl
    {

        private void Connection2(string val_id2)
        {
            string conn = "datasource=localhost;port=3306;username=root;password=;SslMode=none;database=qcu_acc";
            MySqlConnection DBConnect = new MySqlConnection(conn);

            DBConnect.Open();
            string query = $"SELECT * FROM students_list WHERE student_id = '{val_id2}'";
            MySqlCommand command1 = new MySqlCommand(query, DBConnect);
            MySqlDataReader read1 = command1.ExecuteReader();
            //MessageBox.Show(read1.GetString(0));
            if (read1.Read())
            {
                view_stud_id_val.Text = read1.GetString(0);
                view_lastname_val.Text = read1.GetString(1);
                view_firstname_val.Text = read1.GetString(2);
                view_middlename_val.Text = read1.GetString(3);
                DBConnect.Close();
            }
        }

        public Profileview()
        {
            InitializeComponent();
            //Connection2();
            //view_stud_id_val.Text = ID_recieve;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
