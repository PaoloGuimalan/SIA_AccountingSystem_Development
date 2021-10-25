﻿using System;
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
        private void Connection(string receive_ID2)
        {
            string conn = "datasource=localhost;port=3306;username=root;password=;SslMode=none;database=qcu_acc";
            MySqlConnection DBConnect = new MySqlConnection(conn);

            DBConnect.Open();
            string query = $"SELECT * FROM units_assigned WHERE stud_id_units = '{receive_ID2}' AND status = '{due_selection.Text}'";
            MySqlCommand command1 = new MySqlCommand(query, DBConnect);
            MySqlDataReader read1 = command1.ExecuteReader();

            while (read1.Read())
            {
                MySqlConnection DBConnect2 = new MySqlConnection(conn);
                DBConnect2.Open();
                string query2 = $"SELECT * FROM av_units WHERE unit_id = '{read1.GetString(2)}'";
                MySqlCommand command2 = new MySqlCommand(query2, DBConnect2);
                MySqlDataReader read2 = command2.ExecuteReader();
                read2.Read();
                //MessageBox.Show(read2.GetString(1));
                dataGridView1.Rows.Add(read2.GetString(1), read2.GetString(2), read2.GetString(3), read2.GetString(7));

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
                dataGridView2.Rows.Add(read2_misc.GetString(1), read2_misc.GetString(3));

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
    }
}
