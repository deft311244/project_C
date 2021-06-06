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
    public partial class Form6 : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=project_plantshop;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        public Form6()
        {
            InitializeComponent();
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            string x = "";
            string y = "";
            error_username.Text = x;
            error_confirm.Text = y;
            MySqlConnection con = databaseConnection();
            con.Open();

            MySqlCommand cmd;

            cmd = con.CreateCommand();
            cmd.CommandText = $"SELECT * FROM user WHERE user=\"{UsernameText.Text}\"";

            MySqlDataReader row = cmd.ExecuteReader();
            if (row.HasRows)
            {
                x = "มี username นี้แล้ว";
                error_username.Text = x;
            }
            else
            {
                con.Close();
                if (PasswordText.Text != "")
                {
                    if (ConfirmText.Text != "")
                    {
                        if (PasswordText.Text == ConfirmText.Text)
                        {
                            con.Open();
                            string sql = "INSERT INTO user (user,password) VALUES('" + UsernameText.Text + "','" + PasswordText.Text + "')";
                            MySqlCommand cmd2 = new MySqlCommand(sql, con);

                            int rows = cmd2.ExecuteNonQuery();
                            if (rows > 0)
                            {
                                MessageBox.Show("เพิ่มสมาชิกเรียบร้อย", "เสร็จสิ้น");
                                UsernameText.Clear();
                                PasswordText.Clear();
                                ConfirmText.Clear();

                            }
                            else 
                            {
                                MessageBox.Show("เพิ่มสมาชิกไม่สำเร็จ");
                                con.Close();
                            }

                        }
                        else
                        {
                            y = "รหัสผ่านไม่ตรงกัน";
                            error_confirm.Text = y;
                        }
                    }
                }
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            Check();
        }

        private void UsernameText_TextChanged(object sender, EventArgs e)
        {
            Check();
        }

        private void PasswordText_TextChanged(object sender, EventArgs e)
        {
            Check();
        }

        private void ConfirmText_TextChanged(object sender, EventArgs e)
        {
            Check();
        }
        private void Check()
        {
            string x = "";
            string y = "";
            error_username.Text = x;
            error_confirm.Text = y;
            MySqlConnection con = databaseConnection();
            con.Open();

            MySqlCommand cmd;

            cmd = con.CreateCommand();
            cmd.CommandText = $"SELECT * FROM user WHERE user=\"{UsernameText.Text}\"";

            MySqlDataReader row = cmd.ExecuteReader();
            if (row.HasRows)
            {
                x = "มี username นี้แล้ว";
                error_username.Text = x;
            }
            else
            {
                if (PasswordText.Text != "")
                {
                    if (ConfirmText.Text != "")
                    {
                        if (PasswordText.Text == ConfirmText.Text)
                        {

                        }
                        else
                        {
                            y = "รหัสผ่านไม่ตรงกัน";
                            error_confirm.Text = y;
                        }
                    }
                }
            }
        }
    }
}
