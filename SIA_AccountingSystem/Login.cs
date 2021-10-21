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
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register Reg = new Register();
            this.Hide();
            Reg.Show();
            Reg.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var f11 = new Form1();
            //f11.Visible = false;

            string id = log_reg_id.Text;
            string pass = log_reg_pass.Text;

            string conn = "datasource=localhost;port=3306;username=root;password=;SslMode=none;database=qcu_acc";

            MySqlConnection DBConnect1 = new MySqlConnection(conn);

            if(id == string.Empty)
            {
                MessageBox.Show("Empty ID!");
            }
            else if(pass == string.Empty)
            {
                MessageBox.Show("Empty Password!");
            }
            else if(id != string.Empty && pass != string.Empty)
            {
                try
                {
                    DBConnect1.Open();
                    string query1 = $"SELECT * FROM registrar_acc WHERE registrar_id = '{id}' AND pass = '{pass}'";
                    MySqlCommand command1 = new MySqlCommand(query1, DBConnect1);
                    MySqlDataReader read1 = command1.ExecuteReader();

                    if(read1.Read())
                    {
                        string resultlog = read1.GetString(0);

                        if(resultlog == string.Empty)
                        {
                            MessageBox.Show("Log In Failed!");
                        }
                        else
                        {
                            //MessageBox.Show("Success Log In!");
                            Main m1 = new Main(resultlog.ToString());
                            m1.Show();
                            ((Form)this.TopLevelControl).Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Log In Failed!");
                    }
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message);
                }
                DBConnect1.Close();
            }

            //Main m1 = new Main();
            //m1.Show();
            //((Form)this.TopLevelControl).Hide();
        }
    }
}
