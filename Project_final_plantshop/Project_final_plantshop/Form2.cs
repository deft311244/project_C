using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Project_final_plantshop
{
    public partial class Form2 : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=project_plantshop;Allow User Variables = True";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        private void showEquipment()
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();
            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM stock";

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            conn.Close();

            dataEquiment.DataSource = ds.Tables[0].DefaultView;
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void plantDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 F3 = new Form3();
            F3.Show();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("คุณต้องการออกจากระบบหรือไม่?",
          "LOG OUT", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    Form1 F1 = new Form1();
                    F1.Show();
                    this.Close();
                    break;
                case DialogResult.No:
                    break;

            }
        }

        private void checkStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 F4 = new Form4();
            F4.Show();
        }

        private void dataEquiment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataEquiment.CurrentRow.Selected = true;
            NameText.Text = dataEquiment.Rows[e.RowIndex].Cells["plant_name"].FormattedValue.ToString();
            NumSText.Text = dataEquiment.Rows[e.RowIndex].Cells["plant_number"].FormattedValue.ToString();
            PriceText.Text = dataEquiment.Rows[e.RowIndex].Cells["plant_price"].FormattedValue.ToString();
            if (NameText.Text!="")
            {
                if (NameText.Text == "ลิ้นมังกร (Snake Plant)")
                {
                    this.pictureBox8.Image = global::Project_final_plantshop.Properties.Resources._01;
                }
                if (NameText.Text == "เดหลี (Peace Lily)")
                {
                    this.pictureBox8.Image = global::Project_final_plantshop.Properties.Resources._02;
                }
                if (NameText.Text == "เขียวหมื่นปี (Chinese Evergreen)")
                {
                    this.pictureBox8.Image = global::Project_final_plantshop.Properties.Resources._03;
                }
                if (NameText.Text == "ซานาดู (Xanadu)")
                {
                    this.pictureBox8.Image = global::Project_final_plantshop.Properties.Resources._04;
                }
                if (NameText.Text == "มอนสเตร่า (Monstera)")
                {
                    this.pictureBox8.Image = global::Project_final_plantshop.Properties.Resources._05;
                }
                if (NameText.Text == "เสน่ห์จันทร์แดง (Araceae)")
                {
                    this.pictureBox8.Image = global::Project_final_plantshop.Properties.Resources._06;
                }
                if (NameText.Text == "เฟิร์นบอสตัน (Boston Fern)")
                {
                    this.pictureBox8.Image = global::Project_final_plantshop.Properties.Resources._07;
                }
                if (NameText.Text == "จั๋ง (Lady Palm)")
                {
                    this.pictureBox8.Image = global::Project_final_plantshop.Properties.Resources._08;
                }
                if (NameText.Text == "หมากเหลือง (Butterfly Palm)")
                {
                    this.pictureBox8.Image = global::Project_final_plantshop.Properties.Resources._09;
                }
                if (NameText.Text == "ตีนตุ๊กแก (English Ivy)")
                {
                    this.pictureBox8.Image = global::Project_final_plantshop.Properties.Resources._10;
                }
                if (NameText.Text == "หางจระเข้ ( Aloe Vera)")
                {
                    this.pictureBox8.Image = global::Project_final_plantshop.Properties.Resources._11;
                }
                if (NameText.Text == "ยางอินเดีย (Rubber Plant)")
                {
                    this.pictureBox8.Image = global::Project_final_plantshop.Properties.Resources._12;
                }
            }
            else
            {
                this.pictureBox8.Image = global::Project_final_plantshop.Properties.Resources._00;
            }
            


        }

        private void Form2_Load(object sender, EventArgs e)
        {
            showEquipment();
            showPrice();

        }

        private void showPrice()
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();
            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM price";

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            conn.Close();

            dataPrice.DataSource = ds.Tables[0].DefaultView;
            MySqlConnection con = databaseConnection();
            con.Open();

            int no1 = 12;
            int no2 = 1;
            int all_total = 0;
            int a2;

            while (no2 <= no1)
            {
                string selectSql = "select * from price where id=" + no2;
                MySqlCommand cmd2 = new MySqlCommand(selectSql, con);
                int row = cmd2.ExecuteNonQuery();
                    using (MySqlDataReader read = cmd2.ExecuteReader())
                    {
                        while (read.Read())
                        {
                            string total = (read["plant_price"].ToString());
                            char[] delimiterChars = { '-', '\n' };

                            string[] aa = total.Split(delimiterChars);
                            foreach (var a1 in aa)
                            {
                                int.TryParse(a1, out a2);
                                all_total = all_total + a2;
                                TotalText.Text = all_total.ToString();
                            }
                        }

                    }
                no2 = no2 + 1;
            }

        }

        private void dataPrice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataPrice.CurrentRow.Selected = true;
            NamePText.Text = dataPrice.Rows[e.RowIndex].Cells["plant_name"].FormattedValue.ToString();
            NumPText.Text = dataPrice.Rows[e.RowIndex].Cells["plant_number"].FormattedValue.ToString();
            PricePText.Text = dataPrice.Rows[e.RowIndex].Cells["plant_price"].FormattedValue.ToString();
            OldNumPText.Text =  dataPrice.Rows[e.RowIndex].Cells["plant_number"].FormattedValue.ToString();
            if (NamePText.Text != "")
            {
                if (NamePText.Text == "ลิ้นมังกร (Snake Plant)")
                {
                    this.pictureBox9.Image = global::Project_final_plantshop.Properties.Resources._01;
                }
                if (NamePText.Text == "เดหลี (Peace Lily)")
                {
                    this.pictureBox9.Image = global::Project_final_plantshop.Properties.Resources._02;
                }
                if (NamePText.Text == "เขียวหมื่นปี (Chinese Evergreen)")
                {
                    this.pictureBox9.Image = global::Project_final_plantshop.Properties.Resources._03;
                }
                if (NamePText.Text == "ซานาดู (Xanadu)")
                {
                    this.pictureBox9.Image = global::Project_final_plantshop.Properties.Resources._04;
                }
                if (NamePText.Text == "มอนสเตร่า (Monstera)")
                {
                    this.pictureBox9.Image = global::Project_final_plantshop.Properties.Resources._05;
                }
                if (NamePText.Text == "เสน่ห์จันทร์แดง (Araceae)")
                {
                    this.pictureBox9.Image = global::Project_final_plantshop.Properties.Resources._06;
                }
                if (NamePText.Text == "เฟิร์นบอสตัน (Boston Fern)")
                {
                    this.pictureBox9.Image = global::Project_final_plantshop.Properties.Resources._07;
                }
                if (NamePText.Text == "จั๋ง (Lady Palm)")
                {
                    this.pictureBox9.Image = global::Project_final_plantshop.Properties.Resources._08;
                }
                if (NamePText.Text == "หมากเหลือง (Butterfly Palm)")
                {
                    this.pictureBox9.Image = global::Project_final_plantshop.Properties.Resources._09;
                }
                if (NamePText.Text == "ตีนตุ๊กแก (English Ivy)")
                {
                    this.pictureBox9.Image = global::Project_final_plantshop.Properties.Resources._10;
                }
                if (NamePText.Text == "หางจระเข้ ( Aloe Vera)")
                {
                    this.pictureBox9.Image = global::Project_final_plantshop.Properties.Resources._11;
                }
                if (NamePText.Text == "ยางอินเดีย (Rubber Plant)")
                {
                    this.pictureBox9.Image = global::Project_final_plantshop.Properties.Resources._12;
                }
            }
            else
            {
                this.pictureBox9.Image = global::Project_final_plantshop.Properties.Resources._000;
            }
        }

        private void insert_button_Click(object sender, EventArgs e)
        {

            if (NumText.Text != "")
            {
                string name_plant = NameText.Text;
                int num = int.Parse(NumSText.Text);
                int numtext = int.Parse(NumText.Text);
                if (numtext <= num)
                {
                    MySqlConnection con = databaseConnection();
                    MySqlConnection conn = databaseConnection();
                    con.Open();

                    MySqlCommand cmd;

                    cmd = con.CreateCommand();
                    cmd.CommandText = $"SELECT * FROM price WHERE plant_name=\"{name_plant}\"";

                    MySqlDataReader row = cmd.ExecuteReader();
                    if (row.HasRows)
                    {
                        con.Close();
                        string selectP = $"select * FROM price WHERE plant_name=\"{name_plant}\"";
                        MySqlCommand cmd3 = new MySqlCommand(selectP, con);
                        con.Open();

                        int P_number;
                        int P_price;

                        using (MySqlDataReader read = cmd3.ExecuteReader())
                        {
                            while (read.Read())
                            {
                                string plant_number_P = read["plant_number"].ToString();
                                int.TryParse(plant_number_P, out P_number);
                                string plant_price_P = read["plant_price"].ToString();
                                int.TryParse(plant_price_P, out P_price);

                                int selectedRow = dataEquiment.CurrentCell.RowIndex;


                                int p1 = int.Parse(PriceText.Text);
                                int up_number = int.Parse(NumText.Text);
                                int number_s = P_number + up_number;
                                int total = numtext * p1;
                                int total_s = total + P_price;

                                string sql = "UPDATE price set plant_price='" + total_s + "',plant_number='" + number_s + "'WHERE plant_name='" + name_plant + "'";
                                MySqlCommand cmd1 = new MySqlCommand(sql, conn);
                                int remain = num - numtext;
                                string sql2 = "UPDATE stock set plant_number ='" + remain + "'Where plant_name = '" + name_plant + "'";
                                MySqlCommand cmd2 = new MySqlCommand(sql2, conn);
                                conn.Open();
                                int rows = cmd1.ExecuteNonQuery();
                                cmd2.ExecuteNonQuery();
                                conn.Close();
                                if (rows > 0)
                                {
                                    MessageBox.Show("เพิ่มรายการสินค้าเรียบร้อย");
                                    showPrice();
                                    showEquipment();
                                    NumText.Clear();
                                    PriceText.Clear();
                                    NumSText.Clear();
                                    NameText.Clear();
                                }

                            }
                        }


                    }
                    else
                    {
                        int selectedRow = dataEquiment.CurrentCell.RowIndex;
                        int p1 = int.Parse(PriceText.Text);
                        int total = numtext * p1;
                        string sql = "INSERT INTO price (plant_name,plant_number,plant_price) VALUES('" + name_plant + "','" + NumText.Text + "','" + total + "')";
                        MySqlCommand cmd1 = new MySqlCommand(sql, conn);

                        int remain = num - numtext;
                        string sql2 = "UPDATE stock set plant_number ='" + remain + "'Where plant_name = '" + name_plant + "'";
                        MySqlCommand cmd2 = new MySqlCommand(sql2, conn);
                        conn.Open();
                        int rows = cmd1.ExecuteNonQuery();
                        cmd2.ExecuteNonQuery();
                        conn.Close();
                        if (rows > 0)
                        {
                            MessageBox.Show("เพิ่มรายการสินค้าเรียบร้อย");
                            showPrice();
                            showEquipment();
                            NumText.Clear();
                            PriceText.Clear();
                            NumSText.Clear();
                            NameText.Clear();
                        }
                    }

                }
                else
                {
                    MessageBox.Show("จำนวนสินค้าในคลัง ไม่เพียงพอ");
                }
            }
            else
            {
                MessageBox.Show("กรุณากรอกจำนวนที่ต้องการ");
            }


        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            int selectedRow = dataPrice.CurrentCell.RowIndex;
            int editId = Convert.ToInt32(dataPrice.Rows[selectedRow].Cells["id"].Value);
            int Oldnumber = int.Parse(OldNumPText.Text);
            int Oldprice = int.Parse(PricePText.Text);
            int newnum = int.Parse(NumPText.Text);
            int price_1 = Oldprice / Oldnumber;
            int New_price = price_1 * newnum;

            MySqlConnection conn = databaseConnection();
            conn.Open();
            string selectSql = "select * from stock where plant_name='" + NamePText.Text+"'";
            MySqlCommand cmd1 = new MySqlCommand(selectSql, conn);
            int old_stock_number;
            using (MySqlDataReader read = cmd1.ExecuteReader())
            {
                read.Read();
                string stock_number = (read["plant_number"].ToString());
                int.TryParse(stock_number, out old_stock_number);
                read.Close();
            }
            string sql = "UPDATE price set plant_price ='" + New_price + "',plant_number = '" + newnum + "'Where id = '" + editId + "'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            if (Oldnumber > newnum)
            {
                int pass_stock = Oldnumber - newnum;
                int newstock_number = old_stock_number + pass_stock;
                string sql2 = "UPDATE stock set plant_number ='" + newstock_number + "'Where plant_name = '" + NamePText.Text + "'";
                MySqlCommand cmd2 = new MySqlCommand(sql2, conn);

                int rows = cmd2.ExecuteNonQuery();

                conn.Close();

                if (rows > 0)
                {
                    MessageBox.Show("แก้ไขรายการเรียบร้อย");
                    showPrice();
                    showEquipment();
                    NamePText.Clear();
                    NumPText.Clear();
                    PricePText.Clear();
                    OldNumPText.Clear();
                }
            }
            if (Oldnumber < newnum)
            {
                int del_stock = newnum - Oldnumber;
                int newstock_number = old_stock_number - del_stock;
                string sql2 = "UPDATE stock set plant_number ='" + newstock_number + "'Where plant_name = '" + NamePText + "'";
                MySqlCommand cmd2 = new MySqlCommand(sql2, conn);

                int rows = cmd2.ExecuteNonQuery();

                conn.Close();

                if (rows > 0)
                {
                    MessageBox.Show("แก้ไขรายการเรียบร้อย");
                    showPrice();
                    showEquipment();
                    NamePText.Clear();
                    NumPText.Clear();
                    PricePText.Clear();
                    OldNumPText.Clear();
                }
            }
        }

        private void del_button_Click(object sender, EventArgs e)
        {

            int selectedRow = dataPrice.CurrentCell.RowIndex;
            int deleteId = Convert.ToInt32(dataPrice.Rows[selectedRow].Cells["id"].Value);
            MySqlConnection conn = databaseConnection();

            String sql = "DELETE FROM price WHERE id ='" + deleteId + "'";
            String sql2 = "UPDATE stock set plant_number ='" + "d" + "' WHERE plant_name ='" + NamePText.Text + "'";
            string sql1 = "set @autoid := 0;" +
            "\nUPDATE price set id = @autoid := (@autoid + 1);" +
            "\nalter table price Auto_increment = 1;";

            MySqlCommand cmd2 = new MySqlCommand(sql1, conn);
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();

            cmd.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            conn.Close();

            MySqlConnection con = databaseConnection();
            con.Open();

            string selectSql = "select plant_number from stock where plant_name='" + NamePText.Text + "'";
            MySqlCommand cmd3 = new MySqlCommand(selectSql, con);
            int old_stock_number;
            using (MySqlDataReader read = cmd3.ExecuteReader())
            {
                read.Read();
                string old_number = read["plant_number"].ToString();
                int.TryParse(old_number, out old_stock_number);
                read.Close();
            }

            int old_price_number = int.Parse(OldNumPText.Text);
            int newstock_number = old_stock_number + old_price_number;

            string sql4 = "UPDATE stock set plant_number ='" + newstock_number + "'Where plant_name = '" + NamePText.Text + "'";
            MySqlCommand cmd4 = new MySqlCommand(sql4, con);

            int rows = cmd4.ExecuteNonQuery();

            con.Close();

            if (rows > 0)
            {
                MessageBox.Show("ลบรายการเรียบร้อย");
                showPrice();
                showEquipment();

            }

        }

        private void confirm_button_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("ยืนยันการสั่งซื้อ","ยืนยัน", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:

                    Form5 F5 = new Form5();
                    F5.Show();

                    MySqlConnection conn = databaseConnection();
                    conn.Open();

                    string sql = "DELETE FROM price";

                    string sql1 = "UPDATE price set id = 1;" +
                    "\nalter table price Auto_increment = 1;";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    int rows = cmd.ExecuteNonQuery();
                    cmd.ExecuteNonQuery();
                    MySqlCommand cmd2 = new MySqlCommand(sql1, conn);
                    cmd2.ExecuteNonQuery();

                    conn.Close();

                    if (rows > 0)
                    {
                        showPrice();
                        showEquipment();
                    }
                    NamePText.Clear();
                    NumPText.Clear();
                    PricePText.Clear();
                    OldNumPText.Clear();
                    TotalText.Text = "0";

                    break;
                case DialogResult.No:
                    break;
            }

        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("คุณต้องการยกเลิกการสั่งซื้อสิ้นค้าหรือไม่?",
          "ยกเลิกการสั่งซื้อ", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:

                    int id_P = 1;
                    int id_S = 100;
                    int P_number;
                    int S_number;
                    while (id_P <= id_S)
                    {
                        MySqlConnection con = databaseConnection();
                        con.Open();
                        string selectP = "select * from price WHERE id =" + id_P;
                        MySqlCommand cmd3 = new MySqlCommand(selectP, con);

                        using (MySqlDataReader read = cmd3.ExecuteReader())
                        {
                            while (read.Read())
                            {
                                string plant_name_P = read["plant_name"].ToString();
                                string plant_number_P = read["plant_number"].ToString();
                                int.TryParse(plant_number_P, out P_number);

                                MySqlConnection con2 = databaseConnection();
                                con2.Open();
                                string selectS = "select plant_number from stock WHERE plant_name ='" + plant_name_P + "'";
                                MySqlCommand cmd4 = new MySqlCommand(selectS, con2);

                                using (MySqlDataReader read2 = cmd4.ExecuteReader())
                                {
                                    while (read2.Read())
                                    {
                                        string plant_number_S = read2["plant_number"].ToString();
                                        int.TryParse(plant_number_S, out S_number);
                                        int Update_number_stock = P_number + S_number;

                                        MySqlConnection con3 = databaseConnection();
                                        con3.Open();
                                        string sql4 = "UPDATE stock set plant_number ='" + Update_number_stock + "'Where plant_name = '" + plant_name_P + "'";
                                        MySqlCommand cmd5 = new MySqlCommand(sql4, con3);

                                        cmd5.ExecuteNonQuery();
                                        con3.Close();
                                    }
                                }
                                con2.Close();
                            }
                            con.Close();
                        }
                        id_P = id_P + 1;
                    }

                    MySqlConnection conn = databaseConnection();
                    conn.Open();

                    string sql = "DELETE FROM price";

                    string sql1 = "UPDATE price set id = 1;" +
                    "\nalter table price Auto_increment = 1;";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    int rows = cmd.ExecuteNonQuery();
                    cmd.ExecuteNonQuery();
                    MySqlCommand cmd2 = new MySqlCommand(sql1, conn);
                    cmd2.ExecuteNonQuery();

                    conn.Close();

                    if (rows > 0)
                    {
                        MessageBox.Show("ยกเลิกรายการสั่งซื้อเรียบร้อย");
                        showPrice();
                        showEquipment();
                        NamePText.Clear();
                        NumPText.Clear();
                        PricePText.Clear();
                        OldNumPText.Clear();
                        TotalText.Text = "0";
                    }

                    break;
                case DialogResult.No:
                    break;
            }

        }

        private void addMembersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 F6 = new Form6();
            F6.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            showEquipment();
            showPrice();
        }
    }
}
