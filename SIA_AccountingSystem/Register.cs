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
    public partial class Register : UserControl
    {

        public Register()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void confirm_btn_Click(object sender, EventArgs e)
        {
            if(registrar_pass.Text == string.Empty)
            {
                MessageBox.Show("Empty Password!");
            }
            else if (registrar_conpass.Text == string.Empty)
            {
                MessageBox.Show("Please Confirm Password!");
            }
            else if(registrar_pass.Text != string.Empty && registrar_conpass.Text != string.Empty)
            {
                if(registrar_pass.Text == registrar_conpass.Text)
                {
                    //MessageBox.Show("Success!");
                    string reg_id = registrar_id.Text;
                    string reg_fname = registrar_fname.Text;
                    string reg_lname = registrar_lname.Text;
                    string reg_mname = registrar_midname.Text;
                    string reg_email = registrar_email.Text;
                    string reg_pass = registrar_pass.Text;

                    string conn = "datasource=localhost;port=3306;username=root;password=;SslMode=none;database=qcu_acc";

                    MySqlConnection DBConnect1 = new MySqlConnection(conn);

                    try
                    {
                        DBConnect1.Open();
                        string query1 = $"INSERT INTO registrar_acc (registrar_id, fname, lname, midname, email, pass) VALUES ('{reg_id}', '{reg_fname}', '{reg_lname}', '{reg_mname}', '{reg_email}', '{reg_pass}')";
                        MySqlCommand command1 = new MySqlCommand(query1, DBConnect1);
                        command1.ExecuteNonQuery();
                        MessageBox.Show("Register Succesfull!");
                        Application.Restart();
                    }
                    catch(Exception x)
                    {
                        MessageBox.Show(x.Message);
                    }

                    DBConnect1.Close();
                }
                else
                {
                    MessageBox.Show("Password does not match!");
                }
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Login Lg1 = new Login();
            //this.Hide();
            //Lg1.Show();
            //Lg1.BringToFront();
            //MessageBox.Show("Hello");
            Application.Restart();
        }
    }
}
