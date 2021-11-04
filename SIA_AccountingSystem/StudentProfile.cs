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
    public partial class StudentProfile : Form
    {
        string ID_reciever;
        public string ID
        {
            get { return ID_reciever; }
        }

        public void Connection_price(string val_id)
        {
            string conn = "datasource=localhost;port=3306;username=root;password=;SslMode=none;database=qcu_acc";

            MySqlConnection DBPrice = new MySqlConnection(conn);

            DBPrice.Open();
            string queryprice = $"SELECT  SUM(total) total_price FROM (SELECT SUM(unit_price) total FROM av_units WHERE unit_id IN(SELECT unit_id FROM units_assigned WHERE stud_id_units = '{val_id}' AND status = 'Unpaid') UNION ALL SELECT SUM(m_fee) total FROM av_miscellaneous WHERE m_id IN(SELECT misc_id FROM misc_assigned WHERE stud_id_misc = '{val_id}' AND status = 'Unpaid')) s";
            MySqlCommand commandprice = new MySqlCommand(queryprice, DBPrice);
            MySqlDataReader readprice = commandprice.ExecuteReader();
            readprice.Read();
            try
            {
                price_box.Text = "Unpaid Invoice: P" + readprice.GetString(0);
            }
            catch(Exception ez)
            {
                price_box.Text = "Unpaid Invoice: P 0.00";
            }
            DBPrice.Close();

            MySqlConnection DBConnect = new MySqlConnection(conn);

            DBConnect.Open();
            string query = $"SELECT * FROM students_list WHERE student_id = '{val_id}'";
            MySqlCommand command1 = new MySqlCommand(query, DBConnect);
            MySqlDataReader read1 = command1.ExecuteReader();
            //MessageBox.Show(read1.GetString(0));
            if(read1.Read())
            {
                stud_id.Text = "Student ID: " + read1.GetString(0);
                //ID_main = read1.GetString(0);
                stud_name.Text = read1.GetString(1) + ", " + read1.GetString(2) + ", " + read1.GetString(3);
                DBConnect.Close();
            }
        }
        public StudentProfile(string stud_id_im)
        {
            InitializeComponent();
            Connection_price(stud_id_im);
            ID_reciever = stud_id_im;
            profileview1.ID = stud_id_im;
            invoiceview1.ID = stud_id_im;
            //profileview1.ID = stud_id_im;
        }

        private void Profile_btn_Click(object sender, EventArgs e)
        {
            invoiceview1.Hide();
            profileview1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            profileview1.Hide();
            invoiceview1.Show();
        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void profileview1_Load(object sender, EventArgs e)
        {

        }

        private void StudentProfile_Load(object sender, EventArgs e)
        {

        }
    }
}
