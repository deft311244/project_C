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
    public partial class Form5 : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=project_plantshop;Allow User Variables = True";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }

        private void showReceipt()
        {
            MySqlConnection con = databaseConnection();
            con.Open();

            int no1 = 12;
            int no2 = 1;
            int all_total = 0;
            int a2;
            while (no2 <= no1)
            {
                string selectSql = "select * from price where id=" + no2;
                MySqlCommand cmd = new MySqlCommand(selectSql, con);

                using (MySqlDataReader read = cmd.ExecuteReader())
                {
                    while (read.Read())
                    {
                        id.Text = id.Text + "\n" + (read["id"].ToString());
                        nameP.Text = nameP.Text + "\n" + (read["plant_name"].ToString());
                        number.Text = number.Text + "\n" + (read["plant_number"].ToString());
                        price.Text = price.Text + "\n" + (read["plant_price"].ToString());
                    }
                }
                no2 = no2 + 1;
            }

            char[] delimiterChars = { '-','\n' };

            string[] aa = price.Text.Split(delimiterChars);
            foreach (var a1 in aa)
            {
                int.TryParse(a1, out a2);
                all_total = all_total + a2;
                total.Text = all_total.ToString();
            }
            MySqlConnection conn = databaseConnection();
            string sql = "INSERT INTO receipt (All_plant_name,All_plant_num,All_plant_price,total) VALUES('" + nameP.Text + "','" + number.Text + "','" + price.Text + "','" + total.Text + "')";
            MySqlCommand cmd2 = new MySqlCommand(sql, conn);
            conn.Open();
            int rows = cmd2.ExecuteNonQuery();
            conn.Close();
            if (rows > 0)
            {
                MessageBox.Show("บันทึกรายการสั่งซื้อเรียบร้อย");
            }
        }

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            showReceipt();
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
