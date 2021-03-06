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
    public partial class Invoiceview : UserControl
    {
        public string ID
        {
            set
            {
                value_ID2 = value;
            }
        }

        string value_ID2;

        private void Misc_Con()
        {
            DateTime dateTime = DateTime.UtcNow.Date;
            string conn = "datasource=localhost;port=3306;username=root;password=;SslMode=none;database=qcu_acc";
            MySqlConnection DBConnect1 = new MySqlConnection(conn);
            DBConnect1.Open();
            string query1 = $"UPDATE misc_assigned SET status = 'Paid', date_payed = '{dateTime.ToString("d")}' WHERE stud_id_misc = '{value_ID2}'";
            MySqlCommand command1 = new MySqlCommand(query1, DBConnect1);
            command1.ExecuteNonQuery();
            DBConnect1.Close();
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            Connection(value_ID2);
        }

        private void Units_Con()
        {
            DateTime dateTime = DateTime.UtcNow.Date;
            string conn = "datasource=localhost;port=3306;username=root;password=;SslMode=none;database=qcu_acc";
            MySqlConnection DBConnect1 = new MySqlConnection(conn);
            DBConnect1.Open();
            string query1 = $"UPDATE units_assigned SET status = 'Paid', date_payed = '{dateTime.ToString("d")}' WHERE stud_id_units = '{value_ID2}'";
            MySqlCommand command1 = new MySqlCommand(query1, DBConnect1);
            command1.ExecuteNonQuery();
            DBConnect1.Close();
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            Connection(value_ID2);
        }

        private void Connection(string receive_ID2)
        {
            string conn = "datasource=localhost;port=3306;username=root;password=;SslMode=none;database=qcu_acc";
            MySqlConnection DBConnect = new MySqlConnection(conn);

            DBConnect.Open();
            string query = $"SELECT * FROM units_assigned WHERE stud_id_units = '{receive_ID2}' AND status = '{due_selection.Text}'";
            MySqlCommand command1 = new MySqlCommand(query, DBConnect);
            MySqlDataReader read1 = command1.ExecuteReader();

            dataGridView1.Columns["id"].Visible = false;
            dataGridView1.Columns["status"].Visible = false;

            while (read1.Read())
            {
                MySqlConnection DBConnect2 = new MySqlConnection(conn);
                DBConnect2.Open();
                string query2 = $"SELECT * FROM av_units WHERE unit_id = '{read1.GetString(2)}'";
                MySqlCommand command2 = new MySqlCommand(query2, DBConnect2);
                MySqlDataReader read2 = command2.ExecuteReader();
                read2.Read();
                //MessageBox.Show(read2.GetString(1));
                //dataGridView1.Rows.Add(read2.GetString(1), read2.GetString(2), read2.GetString(3), read2.GetString(7), read1.GetString(0), read1.GetString(3));

                if(due_selection.Text == "Unpaid")
                {
                    dataGridView1.Rows.Add(read2.GetString(1), read2.GetString(2), read2.GetString(3), read2.GetString(7), read1.GetString(5), read1.GetString(0), read1.GetString(3));
                }
                else if (due_selection.Text == "Paid")
                {
                    dataGridView1.Rows.Add(read2.GetString(1), read2.GetString(2), read2.GetString(3), read2.GetString(7), read1.GetString(4), read1.GetString(0), read1.GetString(3));
                }
                else if(due_selection.Text == "Overdue")
                {
                    dataGridView1.Rows.Add(read2.GetString(1), read2.GetString(2), read2.GetString(3), read2.GetString(7), read1.GetString(5), read1.GetString(0), read1.GetString(3));
                }

                DBConnect2.Close();
            }

            DBConnect.Close();

            MySqlConnection DBConnect_misc = new MySqlConnection(conn);

            DBConnect_misc.Open();
            string query_misc = $"SELECT * FROM misc_assigned WHERE stud_id_misc = '{receive_ID2}' AND status = '{due_selection.Text}'";
            MySqlCommand command_misc = new MySqlCommand(query_misc, DBConnect_misc);
            MySqlDataReader read_misc = command_misc.ExecuteReader();

            while (read_misc.Read())
            {
                MySqlConnection DBConnect2_misc = new MySqlConnection(conn);
                DBConnect2_misc.Open();
                string query2_misc = $"SELECT * FROM av_miscellaneous WHERE m_id = '{read_misc.GetString(2)}'";
                MySqlCommand command2_misc = new MySqlCommand(query2_misc, DBConnect2_misc);
                MySqlDataReader read2_misc = command2_misc.ExecuteReader();
                read2_misc.Read();
                //MessageBox.Show(read2.GetString(1));
                //dataGridView2.Rows.Add(read2_misc.GetString(1), read2_misc.GetString(3));

                if (due_selection.Text == "Unpaid")
                {
                    dataGridView2.Rows.Add(read2_misc.GetString(1), read2_misc.GetString(3), read_misc.GetString(5));
                }
                else if (due_selection.Text == "Paid")
                {
                    dataGridView2.Rows.Add(read2_misc.GetString(1), read2_misc.GetString(3), read_misc.GetString(4));
                }
                else if (due_selection.Text == "Overdue")
                {
                    dataGridView2.Rows.Add(read2_misc.GetString(1), read2_misc.GetString(3), read_misc.GetString(4));
                }

                dataGridView1.Columns["id"].Visible = false;
                dataGridView1.Columns["status"].Visible = false;
                DBConnect2_misc.Close();
            }

            DBConnect_misc.Close();
        }
        public Invoiceview()
        {
            InitializeComponent();
            Connection(value_ID2);
            due_selection.SelectedText = "Unpaid";
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void load_btn_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            Connection(value_ID2);
            //MessageBox.Show(value_ID2);
        }

        private void load_invoice_drop(object sender, EventArgs e)
        {
            //Connection(value_ID2);
        }

        private void pay_miscellanous_Click(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.UtcNow.Date;
            //MessageBox.Show(dateTime.ToString("d"));
            if(value_ID2 == null)
            {
                MessageBox.Show("No Value");
            }
            else
            {
                //MessageBox.Show("With Value");
                DialogResult dialogResult = MessageBox.Show("Confirm All Miscellaneous Payment?", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Misc_Con();
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            }
        }

        private void pay_units_Click(object sender, EventArgs e)
        {
            if (value_ID2 == null)
            {
                MessageBox.Show("No Value");
            }
            else
            {
                //MessageBox.Show("With Value");
                DialogResult dialogResult = MessageBox.Show("Confirm All Units Payment?", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Units_Con();
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            }
        }

        private void pay_overall_Click(object sender, EventArgs e)
        {
            if (value_ID2 == null)
            {
                MessageBox.Show("No Value");
            }
            else
            {
                //MessageBox.Show("With Value");
                DialogResult dialogResult = MessageBox.Show("Confirm Full Payment?", "Some Title", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Misc_Con();
                    Units_Con();
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            }
        }

        private void Unit_Con_Single(string unit_id)
        {
            DateTime dateTime = DateTime.UtcNow.Date;
            string conn = "datasource=localhost;port=3306;username=root;password=;SslMode=none;database=qcu_acc";
            MySqlConnection DBConnect1 = new MySqlConnection(conn);
            DBConnect1.Open();
            string query1 = $"UPDATE units_assigned SET status = 'Paid', date_payed = '{dateTime.ToString("d")}' WHERE id = '{unit_id}'";
            MySqlCommand command1 = new MySqlCommand(query1, DBConnect1);
            command1.ExecuteNonQuery();
            DBConnect1.Close();
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            Connection(value_ID2);
        }

        private static Random random = new Random();

        public static string RandomString()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789abcdefghijklmnopqrstuvwxyz";
            return new string(Enumerable.Repeat(chars, 11)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void Transaction_unit_single(string sub_code_rec)
        {
            DateTime dateTime = DateTime.UtcNow.Date;
            string conn = "datasource=localhost;port=3306;username=root;password=;SslMode=none;database=qcu_acc";
            MySqlConnection DBConnect1 = new MySqlConnection(conn);
            DBConnect1.Open();
            string query1 = $"INSERT INTO transac_hist (transaction_code, unit_misc, student, registrar, date) VALUES ('{RandomString()}','{sub_code_rec}','Juan','Solomon','{dateTime.ToString("d")}')";
            MySqlCommand command1 = new MySqlCommand(query1, DBConnect1);
            command1.ExecuteNonQuery();
            DBConnect1.Close();
        }

        private void click_unit(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                string data = dataGridView1.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString();
                string status_unit = dataGridView1.Rows[e.RowIndex].Cells["status"].FormattedValue.ToString();
                string sub_code = dataGridView1.Rows[e.RowIndex].Cells["subject_code"].FormattedValue.ToString();

                if (status_unit == "Unpaid")
                {
                    //MessageBox.Show(data + " " + status_unit);
                    DialogResult dialogResult = MessageBox.Show($"Confirm Payment of {sub_code}?", "Some Title", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Unit_Con_Single(data);
                        Transaction_unit_single(sub_code);
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //do something else
                    }
                }
            }
        }

        private void click_misc(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void combo_onchange(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            Connection(value_ID2);
        }
    }
}
