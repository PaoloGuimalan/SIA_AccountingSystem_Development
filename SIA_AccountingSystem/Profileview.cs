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
using System.Threading;

namespace SIA_AccountingSystem
{
    public partial class Profileview : UserControl
    {
        public string ID
        {
            set { 
                view_stud_id_val.Text = value;
                view_ID = value;
            }
        }

        string view_ID;

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
                //view_status_val.Text = read1.GetString(4);
                view_yearlevel_val.Text = read1.GetString(5);
                view_course_val.Text = read1.GetString(4);

                MySqlConnection DBConnect1 = new MySqlConnection(conn);
                DBConnect1.Open();
                string query1 = $"SELECT * FROM stud_contacts WHERE student_id_con = '{val_id2}'";
                MySqlCommand command11 = new MySqlCommand(query1, DBConnect1);
                MySqlDataReader read11 = command11.ExecuteReader();

                if(read11.Read())
                {
                    view_emailadd_val.Text = read11.GetString(1);
                    view_contact_val.Text = read11.GetString(2);
                    DBConnect1.Close();

                    MySqlConnection DBConnect2 = new MySqlConnection(conn);
                    DBConnect2.Open();
                    string query2 = $"SELECT * FROM stud_semester WHERE student_id_sem = '{val_id2}'";
                    MySqlCommand command2 = new MySqlCommand(query2, DBConnect2);
                    MySqlDataReader read2 = command2.ExecuteReader();

                    if (read2.Read())
                    {
                        view_semester_val.Text = read2.GetString(1);
                        DBConnect2.Close();

                        MySqlConnection DBConnect3 = new MySqlConnection(conn);
                        DBConnect3.Open();
                        string query3 = $"SELECT * FROM stud_bill_status WHERE student_id_status = '{val_id2}'";
                        MySqlCommand command3 = new MySqlCommand(query3, DBConnect3);
                        MySqlDataReader read3 = command3.ExecuteReader();

                        if (read3.Read())
                        {
                            view_status_val.Text = read3.GetString(1);
                            DBConnect3.Close();
                        }

                    }

                }

                DBConnect.Close();
            }
        }

        public Profileview()
        {
            InitializeComponent();
            //Thread.Sleep(1000);
            //Connection2(view_ID);
            //view_stud_id_val.Text = view_ID;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void view_stud_id_val_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(view_ID);
            //Connection2(view_ID);
        }

        private void load_btn_Click(object sender, EventArgs e)
        {
            Connection2(view_ID);
        }
    }
}
