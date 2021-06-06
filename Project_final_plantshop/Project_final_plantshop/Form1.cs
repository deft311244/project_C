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

namespace Project_final_plantshop
{
    public partial class Form1 : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=project_plantshop;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void login_button_Click(object sender, EventArgs e)
        {
            if (UserText.Text != "")
            {
                if (PasswordText.Text != "")
                {
                    MySqlConnection conn = databaseConnection();
                    conn.Open();

                    MySqlCommand cmd;

                    cmd = conn.CreateCommand();
                    cmd.CommandText = $"SELECT * FROM user WHERE user=\"{UserText.Text}\"AND password=\"{PasswordText.Text}\"";

                    MySqlDataReader row = cmd.ExecuteReader();
                    if (row.HasRows)
                    {
                        UserText.Clear();
                        PasswordText.Clear();
                        Form2 F2 = new Form2();
                        this.Hide();
                        F2.Show();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect", "Message");
                        conn.Close();
                    }
                }
                else
                {
                    MessageBox.Show("กรุณากรอกรหัสผ่าน", "Message");
                }

            }
            else
            {
                MessageBox.Show("กรุณากรอกชื่อผู้ใช้งาน", "Message");
            }


        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
