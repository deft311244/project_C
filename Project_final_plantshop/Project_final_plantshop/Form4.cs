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
    public partial class Form4 : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=project_plantshop;";
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

        public Form4()
        {
            InitializeComponent();
        }

        private void dataEquiment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataEquiment.CurrentRow.Selected = true;
            NameText.Text = dataEquiment.Rows[e.RowIndex].Cells["plant_name"].FormattedValue.ToString();
            NumText.Text = dataEquiment.Rows[e.RowIndex].Cells["plant_number"].FormattedValue.ToString();
            PriceText.Text = dataEquiment.Rows[e.RowIndex].Cells["plant_price"].FormattedValue.ToString();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            showEquipment();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            string sql = "INSERT INTO stock (plant_name,plant_number,plant_price) VALUES('" + NameText.Text + "','" + NumText.Text + "','" + PriceText.Text + "')";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            int rows = cmd.ExecuteNonQuery();
            conn.Close();
            if (rows > 0)
            {
                MessageBox.Show("เพิ่มข้อมูลสำเร็จ");
                showEquipment();
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            int selectedRow = dataEquiment.CurrentCell.RowIndex;
            int editId = Convert.ToInt32(dataEquiment.Rows[selectedRow].Cells["id"].Value);

            MySqlConnection conn = databaseConnection();

            string sql = "UPDATE stock set plant_name= '" + NameText.Text + "',plant_number='" + NumText.Text + "',plant_price='" + PriceText.Text + "' Where id = '" + editId + "'";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            conn.Open();

            int rows = cmd.ExecuteNonQuery();

            conn.Close();

            if (rows > 0)
            {
                MessageBox.Show("แก้ไขข้อมูลสำเร็จ");
                showEquipment();
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int selectedRow = dataEquiment.CurrentCell.RowIndex;
            int deleteId = Convert.ToInt32(dataEquiment.Rows[selectedRow].Cells["id"].Value);

            MySqlConnection conn = databaseConnection();

            string sql = "DELETE FROM stock WHERE id '" + deleteId + "'";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            conn.Open();

            int rows = cmd.ExecuteNonQuery();

            conn.Close();

            if (rows > 0)
            {
                MessageBox.Show("ลบข้อมูลสำเร็จ");
                showEquipment();
            }
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
